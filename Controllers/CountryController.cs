using Microsoft.AspNetCore.Mvc;
using Master.Data;
using Master.Data.Entities;

namespace apinetcore.Controllers;

[ApiController]
[Route("[controller]")]
public class CountryController : ControllerBase {

	private MasterContext _context;

	//Injecting basically the database. context using efc
	//each http request it is inject the context.
	public CountryController (MasterContext context){
		_context = context;
	}

	[HttpGet]
	public List<Countries> Get() {
		return _context.Countries.ToList(); //entity framework core
	}

	[HttpPost]
	public void Create(Countries country) {
		_context.Countries.Add(country);
		_context.SaveChanges(); //commit
	}

	[HttpPut]
	public void Modify(Countries country) {
		//countries where cod = 1;
		_context.Update(country); // Send the key property, in this case is the Code prop
		_context.SaveChanges();
	}

	[HttpDelete]
	public void Delete(Countries country) {
		//countries where cod = 1;
		_context.Remove(country); // Send the key property, in this case is the Code prop 
		_context.SaveChanges();
	}
}