// public class Program
// {

//   private static List<string> allSubsets = new List<string>();

//   public static void Main(string[] args)
//   {
//     string s = "atgcxrzattgcxtz";
//     //string s = "abcabcbb";
//     var result = LengthOfLongestSubstring(s);
//     Console.WriteLine(result);
//   }

//   public static int LengthOfLongestSubstring(string s)
//   {
//     return MergeSplit(s);
//   }

//   public static int MergeSplit(string s)
//   {
//     return MergeSplit(s, 0, s.Length - 1);
//   }

//   public static int MergeSplit(string s, int startIndex, int endIndex)
//   {
//     // first step: split the string into 2 subsets
//     int midIndex = (startIndex + endIndex) / 2;
//     var length = s.Length - midIndex - 1;
//     string midValue = s.Substring(midIndex, 1);
//     string leftValue = s.Substring(midIndex-1, 1);
//     // Tuple<string, string> leftSide = new Tuple<string, string>(string.Empty, string.Empty);
//     // Tuple<string, string> rightSubset = new Tuple<string, string>(string.Empty, string.Empty);
//     string leftSide = string.Empty;
//     string rightSide = string.Empty;

//     // first split
//     Tuple<string, string> subsets = new Tuple<string, string>(s.Substring(0, midIndex+1),
//       s.Substring(midIndex+1, length));
//     leftSide = subsets.Item1;
//     rightSide = subsets.Item2;

//     // get the left half separately and recursively call the split method
//     subsets = Split(leftSide, 0, subsets.Item1.Length - 1);
//     allSubsets.Add(Split(subsets.Item1, "left"));
//     allSubsets.Add(Split(subsets.Item2, "right"));

//     // get the right half separately and recursively call the split method
//     subsets = Split(rightSide, 0, subsets.Item2.Length - 1);
//     allSubsets.Add(Split(subsets.Item1, "left"));
//     allSubsets.Add(Split(subsets.Item2, "right"));

//     // // repetedly split the left and right halves until there are no more duplicate characters in either half
//     // while (HasRemainingDuplicateCharacters(subsets.Item1) || HasRemainingDuplicateCharacters(subsets.Item2))
//     // {
//     // }

//     // // repetedly split the left and right halves until there are no more duplicate characters in either half
//     // while (HasRemainingDuplicateCharacters(subsets.Item1) || HasRemainingDuplicateCharacters(subsets.Item2))
//     // {
//     // }

//     // if (!string.IsNullOrEmpty(subsets.Item1))
//     //   leftSubset = Split(subsets.Item1, 0, subsets.Item1.Length - 1);
//     // // if(string.IsNullOrEmpty(subsets.Item1))
//     // if (!string.IsNullOrEmpty(subsets.Item2))
//     // {
//     //   rightSubset = Split(subsets.Item2, 0, subsets.Item2.Length - 1);
//     // }
//     // return (side.Equals("left") ? leftSubset : rightSubset);

//     return allSubsets.Where(x => !string.IsNullOrEmpty(x)).Select(x => x.Length).DefaultIfEmpty(0).Max();
//   }

//   private static bool HasRemainingDuplicateCharacters(string item1)
//   {
//     return item1.GroupBy(x => x).Any(g => g.Count() > 1);
//   }

//   private static string Split(string s, string side)
//   {
//     var leftFirstRun = false;
//     var rightFirstRun = false;
//     Tuple<string, string> leftSubset = new Tuple<string, string>(string.Empty, string.Empty);
//     Tuple<string, string> rightSubset = new Tuple<string, string>(string.Empty, string.Empty);

//     if (side.Equals("left"))
//       return Split(s, 0, s.Length - 1).Item1;

//     if (side.Equals("right"))
//       return Split(s, 0, s.Length - 1).Item2;

//     // // split subsets
//     // while (!string.IsNullOrEmpty(leftSubset.Item2) || !leftFirstRun)
//     // {
//     //   if (!leftFirstRun)
//     //   {
//     //     leftSubset = Split(leftSubset, "left");
//     //     leftFirstRun = true;
//     //   }
//     //   if (leftFirstRun)
//     //     leftSubset = Split(leftSubset, "left");
//     // }
//     // while (!string.IsNullOrEmpty(rightSubset.Item2) || !leftFirstRun)
//     // {
//     //   if (!rightFirstRun)
//     //   {
//     //     rightSubset = Split(rightSubset, "right");
//     //     rightFirstRun = true;
//     //   }
//     //   if (rightFirstRun)
//     //     rightSubset = Split(rightSubset, "right");
//     // }

//     return "Invalid side";
//   }

//   public static Tuple<string, string> Split(string s, int startIndex, int endIndex)
//   {
//     if (s.Length > 1)
//     {
//       var found = false;
//       string leftSubset = string.Empty;
//       string rightSubset = string.Empty;
//       var counter = 0;
//       List<string> subsets = new List<string>();
//       int midIndex = (startIndex + endIndex) / 2;
//       string target = s.Substring(s.Length-1, 1);
//       string leftValue = s.Substring(midIndex-1, 1);
//       var length = s.Length - midIndex;
//       if (leftValue.Equals(target))
//       {
//           found = true;
//           leftSubset = s.Substring(0, midIndex-counter);
//           rightSubset = s.Substring(midIndex-counter, length);
//       }
//       while (!found && s.Length > 1 && !target.Equals(leftValue) && midIndex-counter >= 0)
//       {
//         counter++;
//         leftValue = SearchLeft(s, midIndex-counter);
//         found = target.Equals(leftValue) ? true : false;
//         if (found)
//         {
//           length = (s.Length % 2 == 0) ? midIndex : midIndex+1;
//           leftSubset = s.Substring(0, midIndex-counter);
//           rightSubset = s.Substring(midIndex-counter, counter+1);
//           //rightSubset = s.Substring(midIndex+1, length+1);
//           subsets.Add(leftSubset);
//           subsets.Add(rightSubset);
//           allSubsets.Add(leftSubset);
//           allSubsets.Add(rightSubset);
//           break;
//         }
//       }
//       if (!found)
//       {
//         leftSubset = string.Empty;
//         rightSubset = s;
//       }
//       return new Tuple<string, string>(leftSubset, rightSubset);
//     }
//     if (s.Length == 1)
//     {
//       return new Tuple<string, string>(string.Empty, string.Empty);
//     }
//     return new Tuple<string, string>(string.Empty, string.Empty);
//   }

//   private static string SearchLeft(string s, int index)
//   {
//     if (index >= 0)
//       return s.Substring(index, 1);
//     return string.Empty;
//   }

// }