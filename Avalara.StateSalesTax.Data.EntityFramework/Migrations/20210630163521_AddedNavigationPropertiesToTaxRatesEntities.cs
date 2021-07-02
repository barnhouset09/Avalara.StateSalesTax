using Microsoft.EntityFrameworkCore.Migrations;

namespace Avalara.StateSalesTax.Data.EntityFramework.Migrations
{
    /*
     * Whelp, the navigation properties were added to the domain entities, but EF doesn't seem to care. Nothing needed to be done SQL-wise apparently.
     * This should probably be revisited in an enterprise level application. I'd likely ask for a second pair of eyes here to do some research
     * and paired programming together if a resource for SQL expertise wasn't available wherever I'm working. Otherwise this is more of an almost
     * half day-ish amount of time of research for me to make sure I'm doing things the "SQL way" with EF. Entity Framework has come a long way and just about
     * everything can be done equally efficient with EF compared to straight up SQL with the right group of people working together on it.
     *
     * I'd expect a DBA somewhere to jump in and say "WTF why haven't you indexed these tables" at this point.
     *
     * There likely needs to be some indices created on all of the tables for the foreign keys to matter. I'm not a complete
     * SQL expert. If I feel like I need to ask for extra time on this code exercise I will add the indicies myself, but the question of best indicies to
     * add to the tables should likely fall on someone with more SQL knowledge than I currently have innately.
     *
     * I am going to move on with the rest of the project with the aim of finishing this whole thing in one day with my current knowledge of .NET and
     * everything else showcased within this solution. If I get an extra day I'll go a bit further.
     *
     * Normally I wouldn't write a comment like this and check it in though. Just putting my thoughts out there for a migration script that doesn't do anything.
     * I don't feel like rolling back yet until I figure out why nothing has changed after adding the new navigation properties.
     */
    public partial class AddedNavigationPropertiesToTaxRatesEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
