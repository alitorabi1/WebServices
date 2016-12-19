package shoutbox.server;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.Scanner;

public class ShoutboxService implements ShoutboxInt {

    private static final String FILE_NAME = "data.txt";

    // WARNING: XML-RPC does NOT like 'void' return types - it doesn't find the method
    @Override
    public int addShout(String shout) throws IOException {
        System.out.println("called addShout()");
        try {
            PrintWriter pw = new PrintWriter(new BufferedWriter(new FileWriter(FILE_NAME, true)));
            pw.println(shout);
            pw.close();
        } catch (IOException e) {
            e.printStackTrace();
            throw e;
        }
        return 0;
    }

    @Override
    public String getAllShouts() throws IOException {
        System.out.println("called getAllShouts()");
        try {
            // trick scanner into returning content of the entire text file
            Scanner scanner = new Scanner(new File(FILE_NAME)).useDelimiter("\u001A");
            return scanner.next();
        } catch (IOException e) {
            e.printStackTrace();
            throw e;
            //return "";
        }
    }

}
