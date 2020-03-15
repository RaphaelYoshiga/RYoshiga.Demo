Feature: SimpleDeliveryApi
	In order to know what delivery options I have for my order
	As a customer
	I want to be shown delivery options

@mytag
Scenario: Simple delivery options
	Given I have those delivery options for country code GB
		| Name              | Price | DaysToDispatch | DaysToDeliver |
		| Standard Delivery | 3.00  | 2              | 2             |
		| Next Day Delivery | 3.00  | 0              | 0             |
	And the time is 01/01/2020 20:00
	When I ask for delivery options for GB
	Then I get those delivery options
		| Name              | Price | DeliveryDate |
		| Standard Delivery | 3.00  | 05/01/2020   |
		| Next Day Delivery | 3.00  | 02/01/2020   |