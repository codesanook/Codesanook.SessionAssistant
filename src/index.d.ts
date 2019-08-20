/*
interface chatHub {

}

interface Hub {
    start(): Promise<void>;
}

interface Connection {
    hub: Hub;
    clipboardHub: any;
}

interface JQueryStatic {
    connection: Connection;
}

declare module "" {

}
*/

declare namespace SignalR {

    interface Connection {
    }
}

interface SignalR {
    pushMessageHub: any;
}

interface Window {
    $: any;
    jQuery: any;
}


