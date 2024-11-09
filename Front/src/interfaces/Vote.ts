export interface Vote {
    id?: number;
    pollId: number
    optionId: number;
    voterEmail: string;
}
