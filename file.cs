class FileProcessing
{
    public static void main(){

        string folder = "Files";

        if (!Directory.Exists(folder)){

            Directory.CreateDirectory(folder);
        }
    }
}