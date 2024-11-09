import { PollOption } from "./PollOptions";

export interface Poll {
    id?: number;
    name: string;
    options: PollOption[];
}
