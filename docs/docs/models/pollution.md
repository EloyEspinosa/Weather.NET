## PollutionModel
This serializable class contains the model of the api response of AirPollution.
### Properties
- *Coordinates* (object): Coordinates of the location analyzed.
    - *Longitude* (double): The longitude of the location analyzed.
    - *Latitude* (double): The latitude of the location analyzed.
- *AirDescriptions* (object[]): Information about the air.
    - *AnalysisDate* (long): The moment of the analysis in unix seconds (utc).
    - *Main* (object): Contains the Air Quality Index.
        - *AirQuality* (int): The Air Quality index, to get more information, get AirDescriptions[0].AirQualityDescription.
    - *AirQualityDescription* (string): The Air Quality index.
    - *AirComponents* (object): Concentration of different components in the air.
        - *CarbonMonoxide* (double): Concentration of carbon monoxide in the air in micrograms per cubic meter.
        - *NitrogenMonoxide* (double): Concentration of nitrogen monoxide in the air in micrograms per cubic meter.
        - *NitrogenDioxide* (double): Concentration of nitrogen dioxide in the air in micrograms per cubic meter.
        - *Ozone* (double): Concentration of ozone in the air in micrograms per cubic meter.
        - *SulphurDioxide* (double): Concentration of sulphur dioxide in the air in micrograms per cubic meter.
        - *FineParticulateMatter* (double): Concentration of fine particle matter in the air in micrograms per cubic meter.
        - *CoarseParticulateMatter* (double): Concentration of coarse particulate matter in the air in micrograms per cubic meter.
        - *Ammonia* (double): Concentration of ammonia in the air in micrograms per cubic meter.

[Back](https://eloyespinosa.github.io/Weather.NET/docs/models)