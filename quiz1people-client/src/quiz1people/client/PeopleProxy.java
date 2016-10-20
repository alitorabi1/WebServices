package quiz1people.client;

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
import quiz1people.server.PeopleInt;


public class PeopleProxy implements PeopleInt {
    private XmlRpcClient rpc;
    public static final String SERVER_ENDPOINT = "http://127.0.0.1:8282/XmlRpcServlet";
   
    PeopleProxy() throws MalformedURLException {
        // client setup 
        XmlRpcClientConfigImpl config = new XmlRpcClientConfigImpl();
        config.setServerURL(new URL(SERVER_ENDPOINT));
        // instatiate client
        rpc = new XmlRpcClient();
        rpc.setTransportFactory(new XmlRpcCommonsTransportFactory(rpc));
        rpc.setConfig(config);
    }
    
    @Override
    public int addPerson(String name, int age, int height) throws IOException {
        try {
           Object[] params = new Object[]{ name, age, height };
           return (Integer) rpc.execute("People.addPerson", params);
        } catch (XmlRpcException ex) {
            throw new IOException(ex);           
        }
    }

    @Override
    public ArrayList<String> getFilteredPersonList(String nameContains, int minAge, int maxAge, int minHeight, int maxHeight) throws IOException {
        try {
            Object[] params = new Object[]{nameContains, minAge, maxAge, minHeight, maxHeight};
            Object[] objectArray = (Object[]) rpc.execute("People.getFilteredPersonList", params);            
            ArrayList<String> personList = new ArrayList<>();
            for (Object o : objectArray) {
                personList.add((String)o);
            }
            return personList;
        } catch (XmlRpcException ex) {
            throw new IOException(ex);           
        }  
    }
}
