using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExternalMaster {
    internal class cBacktrack {

  //      public static void DoBacktrack() {
  //          while (true) {

  //              if (!can_shoot())
  //                  return;

		//		var current_sequence_number = Main.Memory.ReadInt($"{Main.ReadHex(hazedumper.signatures.dwClientState)}+{Main.ReadHex(hazedumper.signatures.clientstate_last_outgoing_command)}") + 2;

		//		var input = Main.Memory.ReadInt($"client.dll+{Main.ReadHex(hazedumper.signatures.dwInput)}");

		//		var ptr_usercmd = Main.Memory.ReadInt($"{Main.ReadHex(input)}+0xF4") + (current_sequence_number % 150) * 0x64;

		//		var ptr_old_usercmd = Main.Memory.ReadInt($"{Main.ReadHex(input)}+0xF4") + ((current_sequence_number - 1) % 150) * 0x64;
		//		var ptr_verified_old_usercmd = Main.Memory.ReadInt($"{Main.ReadHex(input)}+0xF8") + ((current_sequence_number - 1) % 150) * 0x68;

		//		while (Main.Memory.ReadInt($"{Main.ReadHex(ptr_usercmd + 0x4)}") < current_sequence_number) {
		//			Thread.Yield();
		//		}

		//		var old_usercmd = Main.Memory.ReadInt($"{Main.ReadHex(ptr_old_usercmd)}");

		//		if ((best_simtime_ != -1) && (GetAsyncKeyState(0x1) & 0x8000)) {
		//			old_usercmd.m_iButtons |= IN_ATTACK;
		//			old_usercmd.m_iTickCount = time_to_ticks(best_simtime_);
		//			g_ptr_memory->write_memory<usercmd_t>(ptr_old_usercmd, old_usercmd);
		//			g_ptr_memory->write_memory<usercmd_t>(ptr_verified_old_usercmd, old_usercmd);
		//		}

		//		Thread.Sleep(1);
  //          }
  //      }
  //      static bool can_shoot() {

  //          Entity pLocal = new Entity() { ID = Main.Memory.ReadInt($"client.dll+{Main.ReadHex(hazedumper.signatures.dwLocalPlayer)}") };

  //          var NextAttack = Main.Memory.ReadFloat($"{pLocal.WeaponBase()}+{Main.ReadHex(hazedumper.netvars.m_flNextPrimaryAttack)}", "", false);
  //          var ServerTime = pLocal.m_nTickBase() + Main.Memory.ReadFloat($"engine.dll+{Main.ReadHex(hazedumper.signatures.dwGlobalVars)}+0x20", "", false);

  //          return !(NextAttack > ServerTime);
  //      }
		//void best_simtime() {

		//	if (best_target_ == -1) {
		//		best_simtime_ = -1;
		//		return;
		//	}
		//	const c_entity local(local_player_index() );

		//	auto temp = FLT_MAX;
		//	const auto view_direction = angle_vector(get_viewangles() + (local.punch_angles() * 2.f));
		//	for (auto t = 0; t < 12; ++t) {
		//		const auto temp2 = distance_point_to_line(backtrack_positions_[best_target_][t].hitboxpos, local.eye_postition(), view_direction);
		//		if (temp > temp2 && backtrack_positions_[best_target_][t].simtime > local.simulation_time() - 1) {
		//			temp = temp2;
		//			best_simtime_ = backtrack_positions_[best_target_][t].simtime;
		//		}
		//	}
		//	if (max_backtrack_ms_ > 0 && !is_valid_tick(time_to_ticks(best_simtime_)))
		//		best_simtime_ = -1;
		//}
	}
}
