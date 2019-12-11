export class DataItem {
/*    
    ID: number = 0;
    Operation: string;
    Data = [];
*/
    public id: number;
    public userID: string;
    public title: string;
    public description: string;
    public eventDate: Date;
    public startTime: Date;
    public endTime: Date;
    public location: string;
    public notifyBefore:number;
    public label: string;
}
