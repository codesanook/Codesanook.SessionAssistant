import './sass/style.scss'
import * as Components from './components';

//export React component as global
declare var global: any;
global.SessionAssistant = Components;