import { AdditionalField } from './additionalField';

export class Type {
    Id: string;
    TopicId: string;
    Name: string;
    AdditionalFields: AdditionalField[];

    constructor(id: string, topicId: string, name: string) {
        this.Id = id;
        this.TopicId = topicId;
        this.Name = name;
    }
}
