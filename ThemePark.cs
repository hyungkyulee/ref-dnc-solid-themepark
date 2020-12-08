using System;
using System.Collections.Generic;
using SOLIDApp;

public class ThemePark {

    public string ThemeParkName;
    public float TicketCost;
    public int AverageDailyAttendance;
    public List<ThemeParkRide> ThemeParkRides;

    public List<Restaurant> Restaurants;
    // public string ThemeParkRideAName { get; set; }  
    // public string ThemeParkRideBName { get; set; }  
    // public string ThemeParkRideCName { get; set; }  
    // public float ThemeParkRideASpeed { get; set; }  
    // public float ThemeParkRideBSpeed { get; set; }  
    // public float ThemeParkRideCSpeed { get; set; }  
    // public string RestaurantAName { get; set; }  
    // public string RestaurantBName { get; set; }  
    // public string RestaurantCName { get; set; }  
    // public float RestaurantAIncome { get; set; }  
    // public float RestaurantBIncome { get; set; }  
    // public float RestaurantCIncome { get; set; }  
    // public float RestaurantALoss { get; set; }  
    // public float RestaurantBLoss { get; set; }  
    // public float RestaurantCLoss { get; set; }  
    private float TotalIncome { get; set; }  
    private float TotalCost { get; set; }  
    //
    // private List<(string, float, float)> ThemeParkFood; 

    public ThemePark()
    {
        ThemeParkRides = new List<ThemeParkRide>();
        // ThemeParkFood = new List<(string, float, float)>();
        Restaurants = new List<Restaurant>();
    }
 
    // private List<(string, float, float)> ConvertRestaurantsToList() {
    //     ThemeParkFood.Add((RestaurantAName, RestaurantAIncome, RestaurantALoss));
    //     ThemeParkFood.Add((RestaurantBName, RestaurantBIncome, RestaurantBLoss));
    //     ThemeParkFood.Add((RestaurantCName, RestaurantCIncome, RestaurantCLoss));
    //     return ThemeParkFood;
    // }

    private void CalculateTotalRestaurantIncome() {
        TotalIncome += AverageDailyAttendance * (Restaurant.TotalIncome/3);
    }

    private void CalculateTotalRestaurantCost() {
        TotalCost += AverageDailyAttendance * (Restaurant.TotalLoss/3);
    }

    private void CalculateTotalRideIncome() {
        TotalIncome += TicketCost * AverageDailyAttendance;
    }

    private void CalculateTotalRideCost() {
        TotalCost += (float)(ThemeParkRide.TotalSpeed * .50 * 12); // question
    }

    private float CalculateProfit()  
    {  
        CalculateTotalRestaurantIncome();
        CalculateTotalRestaurantCost();
        CalculateTotalRideCost();
        CalculateTotalRideIncome();
        return TotalIncome - TotalCost;  
    }

    public void PrintRides() {
        Console.WriteLine(ThemeParkName + " contains the following rides: \n");
        foreach (ThemeParkRide ride in ThemeParkRides) {
            Console.WriteLine(ride.RideDetails());
        }
    }

    public void PrintRestaurants() {
        Console.WriteLine(ThemeParkName + " contains the following restaurants: \n");
        // foreach ((string, float, float) restaurant in ConvertRestaurantsToList()) {
        foreach (Restaurant store in Restaurants) {
            Console.WriteLine(store.RestaurantDetails());
        }
    }

    public void PrintProfit() {
        Console.WriteLine(ThemeParkName + " makes " + CalculateProfit() + " in income.");
    }
}