/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package rpcone.server;

import org.apache.xmlrpc.server.PropertyHandlerMapping;
import org.apache.xmlrpc.server.XmlRpcServer;
import org.apache.xmlrpc.server.XmlRpcServerConfigImpl;
import org.apache.xmlrpc.webserver.WebServer;

// http://www.java2s.com/Code/JarDownload/org-apache/

/**
 *
 * @author ipd
 */
public class RpconeServer {

    private static final int port = 8080;

    public static void main(String[] args) throws Exception {
        // create web server and XML-RPC server connected to it
        WebServer webServer = new WebServer(port);
        XmlRpcServer xmlRpcServer = webServer.getXmlRpcServer();

        // tell XML-RPC server which classes contain methods to map
        PropertyHandlerMapping phm = new PropertyHandlerMapping();
        phm.addHandler("Calculator", rpcone.server.Calculator.class);
        phm.addHandler("Echo", rpcone.server.Echo.class);
        xmlRpcServer.setHandlerMapping(phm);

        // set some additional options
        XmlRpcServerConfigImpl serverConfig
                = (XmlRpcServerConfigImpl) xmlRpcServer.getConfig();        
        serverConfig.setEnabledForExtensions(true);
        serverConfig.setContentLengthOptional(false);
        
        // start web server and don't stop
        webServer.start();
    }

}
