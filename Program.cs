using System ;

class Program {
    static void Main(string[] atgs) {
        string halfDNASequence; //halfDNASequence คือครึ่งหนึ่งของสาย DNA ที่ระบุโดยเบสของนิวคลีโอไทด์
        InputhalfDNASequence("halfDNASequence"); 
    }
    static void InputhalfDNASequence(string halfDNASequence) { //InputhalfDNASequence() คือฟังก์ชันใส่ข้อความครึ่งหนึ่งของสาย DNA ที่ระบุโดยเบสของนิวคลีโอไทด์
        halfDNASequence = Console.ReadLine(); //halfDNASequence คือครึ่งหนึ่งของสาย DNA ที่ระบุโดยเบสของนิวคลีโอไทด์
        IsValidSequence(halfDNASequence); 
        if (IsValidSequence(halfDNASequence) == true) {
            Console.WriteLine("Current half DNA sequence : {0}",halfDNASequence);
            TrueIsValidSequence(halfDNASequence);
        } else {
            Console.WriteLine("That half DNA sequence is invalid.");
            FalseIsValidSequence(halfDNASequence);
        }
       
    }
    static bool IsValidSequence(string halfDNASequence) { //IsValidSequence() คือฟังก์ชันตรวจสอบครึ่งหนึ่งของสาย DNA ดังกล่าวว่าเบสของนิวคลีโอไทด์ที่ระบุนั้นถูกต้องหรือไม่
	    foreach(char nucleotide in halfDNASequence) {
    	    if(!"ATCG".Contains(nucleotide)) {
        	return false;
    	    }
	    }
	    return true;
    }
    static void TrueIsValidSequence(string halfDNASequence) { //TrueIsValidSequence() คือฟังก์ชันที่ได้รับการตรวจสอบแล้วว่า "True"
        while (true) {
            Console.Write("Do you want to replicate it ? (Y/N): ");
            string yesorno = Console.ReadLine();
            if (yesorno == "Y") {
                ReplicateSeqeunce(halfDNASequence);
                Console.WriteLine("Replicated half DNA sequence : {0}",ReplicateSeqeunce(halfDNASequence));
                FalseIsValidSequence(halfDNASequence);
                break;
            } else if (yesorno == "N") {
                break;
            } else {
                Console.WriteLine("Please input Y or N.");
                continue;
            }
    }
}
    static void FalseIsValidSequence(string halfDNASequence) { //FalseIsValidSequence() คือฟังก์ชันที่ได้รับการตรวจสอบแล้วว่า "False"
        while (true) {
            Console.Write("Do you want to process another sequence ? (Y/N) : ");
            string yesorno = Console.ReadLine();
            if (yesorno == "Y") {
                InputhalfDNASequence(halfDNASequence);
            } else if (yesorno == "N") {
                break;
            } else {
                Console.WriteLine("Please input Y or N.");
                continue;
            }
        }
    }
    static string ReplicateSeqeunce(string halfDNASequence) { //ReplicateSeqeunce() คือฟังก์ชันสังเคราะห์ DNA
	    string result = "";
	    foreach(char nucleotide in halfDNASequence) {
    	result += "TAGC"["ATCG".IndexOf(nucleotide)];
	    }
	    return result;
}
}