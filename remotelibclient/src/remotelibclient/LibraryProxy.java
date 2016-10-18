package remotelibclient;

import java.io.IOException;
import java.net.MalformedURLException;
import java.net.URL;
import org.apache.xmlrpc.XmlRpcException;
import org.apache.xmlrpc.client.XmlRpcClient;
import org.apache.xmlrpc.client.XmlRpcClientConfigImpl;
import remotelibserver.LibraryInt;

public class LibraryProxy implements LibraryInt {

    private XmlRpcClient rpc;
    public static final String SERVER_ENDPOINT = "http://127.0.0.1:8282/XmlRpcServlet";

    LibraryProxy() throws MalformedURLException {
        XmlRpcClientConfigImpl config = new XmlRpcClientConfigImpl();
        config.setServerURL(new URL(SERVER_ENDPOINT));
        // instantiate the client
        rpc = new XmlRpcClient();
        rpc.setConfig(config);
    }

    @Override
    public int addBook(String title, String author, int yop) throws IOException {
        try {
            Object[] params1 = new Object[]{title, author, yop};
            return (Integer) rpc.execute("Library.addBook", params1);
        } catch (XmlRpcException ex) {
            throw new IOException(ex);
        }
    }

    @Override
    public String getAllBooks() throws IOException {
        try {
            Object[] params2 = new Object[]{};
            return (String) rpc.execute("Library.getAllBooks", params2);
        } catch (XmlRpcException ex) {
            throw new IOException(ex);
        }
    }

    @Override
    public String getFilteredBooks(String keyword) throws IOException {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    

}
