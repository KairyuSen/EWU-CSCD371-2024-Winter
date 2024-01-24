using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo.Tests;

public class PersonTests
{
    [Fact]
    public void Constructor_ValidName_SuccessfulInitialization()
    {
        Person person = new(); // Simplified new.
    
    }

    [Fact]
    public void FirstName_SetInigo_Success()
    {
        Person person = new();
        person.FirstName = "Inigo";
        Assert.Equal("Inigo", person.FirstName);
    }

    [Fact]
    public void Constructor_SetInigo_ThrowNull()
    {
        PersonTests? person;
        Assert.Throws<ArgumentNullException>(
            () =>
            {
                person = new(null!);
            }
            );
    }

    [Fact]
    public void FirstName_SetNull_Success()
    {
        Person person = new();
     
        Assert.throws<ArgumentNullException>(
            () => person.FirstName = null);
        
    }
}

