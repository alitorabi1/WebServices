package quiz1people.server;

import java.io.IOException;
import java.util.ArrayList;

public interface PeopleInt {
    public int addPerson(String name, int age, int height) throws IOException;
    public ArrayList<String> getFilteredPersonList(String nameContains, int minAge, int maxAge, int minHeight, int maxHeight) throws IOException;
}
