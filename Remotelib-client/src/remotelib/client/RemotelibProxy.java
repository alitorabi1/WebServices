package remotelib.client;

import java.io.IOException;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;
import org.apache.xmlrpc.XmlRpcException;
import org.apache.xmlrpc.client.XmlRpcClient;
import org.apache.xmlrpc.client.XmlRpcClientConfigImpl;
import org.apache.xmlrpc.client.XmlRpcCommonsTransportFactory;
import remotelib.server.LibraryInt;


public class RemotelibProxy implements LibraryInt {
    private XmlRpcClient rpc;
    public static final String SERVER_ENDPOINT = "http://127.0.0.1:8282/XmlRpcServlet";
   
    RemotelibProxy() throws MalformedURLException {
        // client setup 
        XmlRpcClientConfigImpl config = new XmlRpcClientConfigImpl();
        config.setServerURL(new URL(SERVER_ENDPOINT));
        // instatiate client
        rpc = new XmlRpcClient();
        rpc.setTransportFactory(new XmlRpcCommonsTransportFactory(rpc));
        rpc.setConfig(config);
    }
    
    @Override
    public int addBook(String title, String author, int yop) throws IOException {
        try {
           Object[] params = new Object[]{ title, author, yop };
           return (Integer) rpc.execute("Remotelibrary.addBook", params);
        } catch (XmlRpcException ex) {
            throw new IOException(ex);           
            // alternative: extract the original exception using
            // throw ex.getCause();
        }
    }

    @Override
    public ArrayList<String> getFilteredBooks(String keyword) throws IOException {
        try {
            Object[] params = new Object[]{keyword};
            Object[] objectArray = (Object[]) rpc.execute("Remotelibrary.getFilteredBooks", params);            
            ArrayList<String> bookList = new ArrayList<>();
            for (Object o : objectArray) {
                bookList.add((String)o);
            }
            /*
            ArrayList<Object> objectList = new ArrayList<Object>(Arrays.asList(objectArray));
            List<String> stringList = objectList.stream()
                           .map( Object::toString )
                           .collect( Collectors.toList() );
            ArrayList bookList = new ArrayList();
            bookList.addAll(stringList);*/
            //String[] bookListArray =  bookListString.split("\\r\\n|\\n|\\r");
            return bookList;
        } catch (XmlRpcException ex) {
            throw new IOException(ex);           
        }  
    }
    
}
