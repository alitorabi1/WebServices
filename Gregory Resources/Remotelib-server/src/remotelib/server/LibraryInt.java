package remotelib.server;

import java.io.IOException;
import java.util.ArrayList;

public interface LibraryInt {
    public int addBook(String title, String author, int yop) throws IOException;
    public ArrayList<String> getAllBooks() throws IOException;
}
