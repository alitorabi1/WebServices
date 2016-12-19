package shoutbox.server;

import java.io.IOException;

public interface ShoutboxInt {
    public int addShout(String shout) throws IOException;
    public String getAllShouts() throws IOException;
}
