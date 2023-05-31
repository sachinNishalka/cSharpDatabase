# Connecting SQL DB TO C# Application

## Insert Data

1. import the library file

``` c#
using System.Data.SqlClient;
```

2. provide the connection with sql connection class

``` c#
SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\bin\testdb.mdf;Integrated Security=True;Connect Timeout=30");
```

3. make the query

``` c#
String sql = "insert into info(id) values ('" + id + "')";
```

4. open the connection 

``` c#
conn.Open();
```

5. make the sql command

``` c#
SqlCommand cmd = new SqlCommand(sql, conn);
```

6. run the command

``` c# 
 cmd.ExecuteNonQuery();
```

7. display the message

``` c#
MessageBox.Show("Inserted");
```

8. error handling

``` c#
int id = int.Parse(textBox1.Text);

            try {

                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nisha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\testdb.mdf;Integrated Security=True;Connect Timeout=30");

                String sql = "insert into info(id) values ('" + id + "')";

                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Inserted");


            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            
```

## Delete Data

``` c#

private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);

            try
            {

                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nisha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\testdb.mdf;Integrated Security=True;Connect Timeout=30");

                String sql = "delete from info WHERE id = '"+ id +"'";

                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Deleted");

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
 
```


