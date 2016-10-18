package remotelibserver;

import java.io.IOException;

public interface LibraryInt {
    public int addBook(String title, String author, int yop) throws IOException;
    public String getAllBooks() throws IOException;
    public String getFilteredBooks(String keyword) throws IOException;
}
