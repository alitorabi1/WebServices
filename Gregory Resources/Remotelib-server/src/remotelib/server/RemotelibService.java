package remotelib.server;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.Scanner;

public class RemotelibService implements LibraryInt {
    
    private static final String FILE_NAME = "data.txt";
    
    @Override
    public int addBook(String title, String author, int yop) throws IOException {
       System.out.println("called addBook()");
        try (PrintWriter pw = new PrintWriter(new BufferedWriter(new FileWriter(FILE_NAME, true)))) {            
            String book = String.format("%s;%s;%s", title,author, yop);
            pw.println(book);
        } catch (IOException e) {
            e.printStackTrace();
            throw e;
        }
        return 0; 
    }

    @Override
    public ArrayList<String> getAllBooks() throws IOException {
        System.out.println("called getAllBooks()");
        try(Scanner scanner = new Scanner(new File(FILE_NAME))) {
            ArrayList<String> bookList = new ArrayList<>();
            // trick scanner into returning content of the entire text file
            while (scanner.hasNextLine()) {
                bookList.add(scanner.nextLine());
            }
           // scanner.close();
            return bookList;
        } catch (IOException e) {
            e.printStackTrace();
            throw e;
            //return "";
        }
    }
    
}
