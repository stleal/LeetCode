using System.ComponentModel.DataAnnotations.Schema;

[Table("PancakeFlips")]
public class PancakeFlips
{

    // properties go here 
    public string? unsArr { get; set; } 
    public string? sortedArr { get; set; }
    public string? sequenceStr { get; set; }
    public int numberOfStepsInSequence { get; set; }
    public int maximumNumberOfStepsAllowed { get; set; }
    public int lengthOfUnsortedArray { get; set; }
    public int isValidSequence { get; set; }

}
