import { NavLink } from "react-router-dom";
import LoginButton from "../Login";
import LogoutButton from "../Logout";
import Profile from "../Profile";

const Navbar: React.FC = () => {
    const activeSytle = "underline text-gray-500 underline-offset-4";

    return (
        <nav className="flex justify-between items-center fixed 
            z-10 w-full py-5 px-8 text-md font-light top-0">
            <ul className="flex items-center gap-3">
                <li className="font-semibold text-lg">
                    <NavLink to="/">Onyx Drum</NavLink>
                </li>
                <li>
                    <NavLink to="/" 
                            className={({ isActive }) => (isActive ? activeSytle : undefined)}>
                        All
                    </NavLink>
                </li>
                 <li>
                    <NavLink to="/clothing" 
                            className={({ isActive }) => (isActive ? activeSytle : undefined)}>
                        Clothing
                    </NavLink>
                </li>
                <li>
                    <NavLink to="/electronics" 
                            className={({ isActive }) => (isActive ? activeSytle : undefined)}>
                        Electronics
                    </NavLink>
                </li>     
                <li>
                    <NavLink to="/sports" 
                            className={({ isActive }) => (isActive ? activeSytle : undefined)}>
                        Sports
                    </NavLink>
                </li> 
                <li>
                    <NavLink to="/toys" 
                            className={({ isActive }) => (isActive ? activeSytle : undefined)}>
                        Toys
                    </NavLink>
                </li>  
                <li>
                    <NavLink to="/clearance" 
                            className={({ isActive }) => (isActive ? activeSytle : undefined)}>
                        Clearance!
                    </NavLink>
                </li> 
            </ul>
            <div className="flex items-center gap-3">
                <li className="list-none">
                    <LoginButton/>
                </li>
                <li className="list-none">
                    <LogoutButton/>
                </li>
                <li className="list-none">
                    <Profile/>
                </li>
            </div>

        </nav>
            
    )
}



export default Navbar;