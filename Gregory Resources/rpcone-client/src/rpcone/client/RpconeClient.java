/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package rpcone.client;

import java.net.MalformedURLException;
import java.net.URL;
import org.apache.xmlrpc.XmlRpcException;
import org.apache.xmlrpc.client.XmlRpcClient;
import org.apache.xmlrpc.client.XmlRpcClientConfigImpl;
import org.apache.xmlrpc.client.XmlRpcCommonsTransportFactory;

// http://www.java2s.com/Code/JarDownload/org-apache/

/**
 *
 * @author ipd
 */
public class RpconeClient {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws MalformedURLException, XmlRpcException {
        // client setup 
        XmlRpcClientConfigImpl config = new XmlRpcClientConfigImpl();
        config.setServerURL(new URL("http://127.0.0.1:8080/XmlRpcServlet"));
        // instatiate client
        XmlRpcClient client = new XmlRpcClient();
        client.setConfig(config);
        // make a call: int result = Calculator.call(2,3)
        Object[] params = new Object[] { new Integer(2), new Integer(3) };
        Integer result = (Integer) client.execute("Calculator.add", params);
        //
        System.out.println("Result is: " + result);
        // Echo call:
        Object[] params2 = new Object[] { "I am Jerry"};
        String result2 = (String) client.execute("Echo.echo", params2);
        System.out.println("Result2 is: " + result2);
    }

}
