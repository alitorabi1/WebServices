package remotelibserver;

import org.apache.xmlrpc.server.PropertyHandlerMapping;
import org.apache.xmlrpc.server.XmlRpcServer;
import org.apache.xmlrpc.server.XmlRpcServerConfigImpl;
import org.apache.xmlrpc.webserver.WebServer;

public class Libraryserver {

    private static final int port = 8181;

    public static void main(String[] args) throws Exception {
        // Create web server and XML-RPC server connected to it
        WebServer webServer = new WebServer(port);
        XmlRpcServer xmlRpcServer = webServer.getXmlRpcServer();

        // tell XML-RPC server which classes contain methods to map
        PropertyHandlerMapping phm = new PropertyHandlerMapping();
        phm.addHandler("Library", remotelibserver.LibraryService.class);
        xmlRpcServer.setHandlerMapping(phm);

        // Set some additional options
        XmlRpcServerConfigImpl serverConfig
                = (XmlRpcServerConfigImpl) xmlRpcServer.getConfig();
        serverConfig.setEnabledForExtensions(true);
        serverConfig.setContentLengthOptional(false);

        // start web server and don't stop
        webServer.start();
    }

}
