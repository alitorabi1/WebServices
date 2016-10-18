package remotelibserver;

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
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }


}
