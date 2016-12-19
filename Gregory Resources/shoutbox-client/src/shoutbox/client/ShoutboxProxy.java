/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package shoutbox.client;

import java.io.IOException;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.logging.Level;
import java.util.logging.Logger;
import org.apache.xmlrpc.XmlRpcException;
import org.apache.xmlrpc.client.XmlRpcClient;
import org.apache.xmlrpc.client.XmlRpcClientConfigImpl;
import org.apache.xmlrpc.client.XmlRpcCommonsTransportFactory;
import shoutbox.server.ShoutboxInt;

/**
 *
 * @author ipd
 */
public class ShoutboxProxy implements ShoutboxInt {

    private XmlRpcClient rpc;
    public static final String SERVER_ENDPOINT = "http://127.0.0.1:8181/XmlRpcServlet";

    ShoutboxProxy() throws MalformedURLException {
        // client setup 
        XmlRpcClientConfigImpl config = new XmlRpcClientConfigImpl();
        config.setServerURL(new URL(SERVER_ENDPOINT));
        // instatiate client
        rpc = new XmlRpcClient();
        rpc.setTransportFactory(new XmlRpcCommonsTransportFactory(rpc));
        rpc.setConfig(config);
    }

    @Override
    public int addShout(String shout) throws IOException {
        try {
            Object[] params1 = new Object[]{ shout };
            return (Integer) rpc.execute("Remotelib.addShout", params1);
        } catch (XmlRpcException ex) {
            throw new IOException(ex);           
            // alternative: extract the original exception using
            // throw ex.getCause();
        }
    }

    @Override
    public String getAllShouts() throws IOException {
        try {
            Object[] params2 = new Object[]{};
            return (String) rpc.execute("Shoutbox.getAllShouts", params2);        
        } catch (XmlRpcException ex) {
            throw new IOException(ex);           
            // alternative: extract the original exception using
            // throw ex.getCause();
        }  
    }

}
