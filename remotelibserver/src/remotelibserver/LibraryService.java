package remotelibserver;

import com.sun.org.apache.xml.internal.dtm.Axis;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.Scanner;

public class LibraryService implements LibraryInt {

    private static final String FILE_NAME = "data.txt";

    @Override
    public int addBook(String title, String author, int yop) throws IOException {
        try {
            PrintWriter pw = new PrintWriter(new BufferedWriter(new FileWriter(FILE_NAME, true)));
            pw.println(title + ";" + author + ";" + yop + ";");
            pw.close();
        } catch (IOException e) {
            e.printStackTrace();
            throw e;
        }
        return 0;
    }

    @Override
    public String getAllBooks() throws IOException {
        try {
            // 26 = end of file -hex> = \u001A actually : trick: scanner into returning content of the entire text file
            Scanner scanner = new Scanner(new File(FILE_NAME)).useDelimiter("\u001A");
            return scanner.next();
        } catch (IOException e) {
            e.printStackTrace();
            throw e;
        }
    }

    @Override
    public String getFilteredBooks(String keyword) throws IOException {
        try {
            Scanner scanner = new Scanner(new File(FILE_NAME));
            String line = scanner.useDelimiter("\u001A").next();
            if (keyword.equals("")) {
                return line;
            } else {
//            if (!keyword.equals("")) {
                while (scanner.hasNextLine()) {
                    final String lineFromFile = scanner.nextLine();
                    if (lineFromFile.contains(keyword)) {
                        // a match!
                        line = lineFromFile;
                    }
                }
            }
//            } else {
            return line;
//            }
        } catch (IOException e) {
            e.printStackTrace();
            throw e;
        }
    }

}
