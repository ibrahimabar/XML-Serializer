using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Galery
/// </summary>
public class Galery
{
    public string GaleryName { get; set; }
    public string GaleryCity { get; set; }
    public string GaleryDistrict { get; set; }
    public List<Car> CarList { get; set; }
	public Galery()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}