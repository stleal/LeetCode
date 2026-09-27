public class Solution {
    public int NumberOfMatches(int n) {
        int teams = n;
        int matches = 0;
        while (teams > 1)
        {
            matches += (teams%2==0) ? (teams/2) : (teams-1) / 2;
            teams = (teams%2==0) ? teams/2 : (teams - 1) / 2 + 1;
        }
        return matches;
    }
}