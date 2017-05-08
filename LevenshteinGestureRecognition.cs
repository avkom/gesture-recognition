// ----------------------------------------------------------------------------
// Levenshtein Gesture Recognition Utility Class
// Copyright 2012 Alexander Komendant
// Email: avkomq@gmail.ru
// Revision: 2012-11-11
// ----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Komendant
{
  public static class LevenshteinGestureRecognition
  {
    /// <summary>
    /// Compute segments directions string from list of points
    /// </summary>
    /// <param name="points"> List of points </param>
    /// <param name="maxSegmentCount"> Maximal segment count, restricts the minimal segment length </param>
    /// <returns> Gesture segments directions string </returns>
    public static string SegmentsDirections(List<Point> points, int maxSegmentCount) {
      // Compute segment lengths and total gesture length
      int segmentCount = points.Count - 1;
      double[] segmentLengths = new double[segmentCount];
      double gestureLength = 0;
      for (int segmentIndex = 0; segmentIndex < segmentCount; segmentIndex++) {
        double deltaX = points[segmentIndex + 1].X - points[segmentIndex].X;
        double deltaY = points[segmentIndex + 1].Y - points[segmentIndex].Y;
        segmentLengths[segmentIndex] = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        gestureLength += segmentLengths[segmentIndex];
      }
      double minSegmentLength = gestureLength / maxSegmentCount;

      // Union segments, which length is less than minSegmentLength and compute direction of each united segment
      StringBuilder gesture = new StringBuilder();
      double complexSegmentLength = 0;
      int firstPointIndex = 0;
      for (int segmentIndex = 0; segmentIndex < segmentCount; segmentIndex++) {
        complexSegmentLength += segmentLengths[segmentIndex];
        if (complexSegmentLength < minSegmentLength)
          continue;
        complexSegmentLength = 0;
        int secondPointIndex = segmentIndex + 1;
        int segmentDirection = SegmentDirection(points[firstPointIndex], points[secondPointIndex]);
        gesture.Append(segmentDirection);
        firstPointIndex = secondPointIndex;
      }

      // Union neighboring duplicate directions in segments directions string
      StringBuilder gestureWithoutDuplicates = new StringBuilder();
      gestureWithoutDuplicates.Append(gesture[0]);
      char previousChar = gesture[0];
      for (int index = 1; index < gesture.Length; index++) {
        if (gesture[index] == previousChar)
          continue;
        gestureWithoutDuplicates.Append(gesture[index]);
        previousChar = gesture[index];
      }

      return gestureWithoutDuplicates.ToString();
    }

    /// <summary>
    /// Compute Levenshtein distance between two gestures
    /// </summary>
    /// <param name="gesture1"> String which contains the first gesture segment directions </param>
    /// <param name="gesture2"> String which contains the second gesture segment directions </param>
    /// <returns> Levenshtein distance between two gestures </returns>
    public static int LevenshteinDistance(string gesture1, string gesture2) {
      int[] deleteCosts = DeleteSegmentCosts(gesture1);
      int[] insertCosts = DeleteSegmentCosts(gesture2);
      int m = gesture1.Length + 1;
      int n = gesture2.Length + 1;
      int[,] d = new int[m, n];

      d[0, 0] = 0;
      for (int i = 1; i < m; i++)
        d[i, 0] = d[i - 1, 0] + deleteCosts[i - 1];
      for (int j = 1; j < n; j++)
        d[0, j] = d[0, j - 1] + insertCosts[j - 1];

      for (int i = 1; i < m; i++)
        for (int j = 1; j < n; j++) {
          int replaceCost = ReplaceSegmentCost(gesture1[i - 1], gesture2[j - 1]);
          int pDelete = d[i - 1, j] + deleteCosts[i - 1];
          int pInsert = d[i, j - 1] + insertCosts[j - 1];
          int pReplace = d[i - 1, j - 1] + replaceCost;
          d[i, j] = Math.Min(Math.Min(pDelete, pInsert), pReplace);
        }

      return d[m - 1, n - 1];
    }

    /// <summary>
    /// Compute segment direction, which defined by two points
    /// </summary>
    /// <param name="point1"> First point coordinates </param>
    /// <param name="point2"> Second point coordinates </param>
    /// <returns> Segment direction </returns>
    private static int SegmentDirection(Point point1, Point point2) {
      double angle = Math.Atan2(point1.Y - point2.Y, point2.X - point1.X);
      double direction = angle * 4 / Math.PI;
      if (direction < -0.5)
        direction += 8;
      return (int)direction;
    }

    /// <summary>
    /// Compute cost of replacement of segment direction
    /// </summary>
    /// <param name="direction1"> Inital direction </param>
    /// <param name="direction2"> Final direction </param>
    /// <returns></returns>
    private static int ReplaceSegmentCost(int direction1, int direction2) {
      int difference = Math.Abs(direction1 - direction2);
      if (difference > 4)
        difference = 8 - difference;
      return difference;
    }

    /// <summary>
    /// Compute costs of deletion segments
    /// </summary>
    /// <param name="segments"> String represents gesture segments directions </param>
    /// <returns> Array represents costs of deletion segments, one element for each segment</returns>
    private static int[] DeleteSegmentCosts(string segments) {
      int segmentCount = segments.Length;
      int[] costs = new int[segmentCount];
      if (segmentCount == 1) {
        costs[0] = 2;
        return costs;
      }
      costs[0] = ReplaceSegmentCost(segments[0], segments[1]);
      costs[segmentCount - 1] = ReplaceSegmentCost(segments[segmentCount - 2], segments[segmentCount - 1]);
      for (int i = 1; i < segmentCount - 1; i++) {
        int costBeforeDeletion = ReplaceSegmentCost(segments[i - 1], segments[i]) + ReplaceSegmentCost(segments[i], segments[i + 1]);
        int costAfterDeletion = ReplaceSegmentCost(segments[i - 1], segments[i + 1]);
        if (costBeforeDeletion == costAfterDeletion)
          costs[i] = 1;
        else
          costs[i] = Math.Abs(costBeforeDeletion - costAfterDeletion);
      }
      return costs;
    }
  }
}
