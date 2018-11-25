# ActivityLog
This is a micro service to provide object based activity logs

## Log entry
```
    {
        Id: 1001,
        Ref: '8784d8e3-d5da-4f17-97b8-5172fb4f9dbd', // lower case unique id of the source object
        Title: 'James Bond updated task status to In Progress.',
        Date: '2018-12-24T13:00:00.000Z', // UTC 
        Data : '{ foo: "bar" }'
    }
```

Get list of activities by object id
HTTP GET `\activity\{{object_guid}}?page=0&pageSize=10`

Add new entry
HTTP POST `\activity\{{object_guid}}`


No delete available at the moment :) Just keep adding records.
