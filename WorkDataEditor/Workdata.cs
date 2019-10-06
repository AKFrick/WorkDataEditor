using System.Data;


namespace WorkDataEditor
{
    class Workdata : DataTable
    {
        public Workdata()
        {
            Columns.Add(new DataColumn("returnStroke"));
            Columns.Add(new DataColumn("forgeThickness"));
            Columns.Add(new DataColumn("dwell"));
            Columns.Add(new DataColumn("returnSpeed"));
            Columns.Add(new DataColumn("forgeSpeed"));
            Columns.Add(new DataColumn("swageOffset"));
            Columns.Add(new DataColumn("toolLocation"));
            Columns.Add(new DataColumn("traverseStep"));
            Columns.Add(new DataColumn("fixedRotateStep"));
            Columns.Add(new DataColumn("varRotateStep"));
            Columns.Add(new DataColumn("travRotStep"));
            Columns.Add(new DataColumn("rotTravStep"));
            Columns.Add(new DataColumn("tongsClampForce"));
        }
    }
}
