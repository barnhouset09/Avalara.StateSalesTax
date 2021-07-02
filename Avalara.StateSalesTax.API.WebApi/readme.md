# Project: API.WebApi

## Purpose

This is the actual WebAPI server that hosts our REST endpoints.

It utilizes Swagger to generate documentation following the OpenAPI spec.

It uses the generated OpenAPI spec document alongside with Swashbuckle to create an interactive UI for running the APIs.

Make sure to follow the instructions in the readme of the Avalara.StateSalesTax.Data.EntityFramework project before running this.

## Test JSON

For the main endpoint in this coding exercise, a POST body must be supplied.

I have been testing with this:

```
{
  "zipCode": "27587",
  "transactionItems": [
    {
      "itemName": "Aspirin",
      "purchasePrice": 5.99,
      "isFoodOrDrugItem": true,
      "isInterstatePurchase": false
    },
    {
      "itemName": "nVidia GeForce RTX 3090 Ti Graphics Card",
      "purchasePrice": 2999.99,
      "isFoodOrDrugItem": false,
      "isInterstatePurchase": false
    }
  ]
}
```