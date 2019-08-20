import React, { useState } from 'react';
export const ConnectionContext = React.createContext([{}, () => { }]);

export const ConnectionProvider = props => {
    const [connection, setConnection] = useState();

    const startConnection = async () => {
        await $.connection.hub.start();
        console.log('connected');
        setConnection($.connection);
    }

    return (
        <ConnectionContext.Provider value={[connection, setConnection]}>
            {props.children}
        </ConnectionContext.Provider>
    );
}
