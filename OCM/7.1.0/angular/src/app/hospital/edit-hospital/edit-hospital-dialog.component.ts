import {
  Component,
  Injector,
  OnInit,
  EventEmitter,
  Output
} from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { forEach as _forEach, includes as _includes, map as _map } from 'lodash-es';
import { AppComponentBase } from '@shared/app-component-base';
import {
  HospitalServiceProxy,
  HospitalDto,
  RoleDto
} from '@shared/service-proxies/service-proxies';

@Component({
  templateUrl: './edit-hospital-dialog.component.html'
})
export class EditHospitalDialogComponent extends AppComponentBase
  implements OnInit {
  saving = false;
  hospital = new HospitalDto();
  roles: RoleDto[] = [];
  checkedRolesMap: { [key: string]: boolean } = {};
  id: number;

  @Output() onSave = new EventEmitter<any>();

  constructor(
    injector: Injector,
    public _hospitalService: HospitalServiceProxy,
    public bsModalRef: BsModalRef
  ) {
    super(injector);
  }

  ngOnInit(): void {
    this._hospitalService.get(this.id).subscribe((result) => {
      this.hospital = result;
    });
  }

  save(): void {
    this.saving = true;

    this._hospitalService.update(this.hospital).subscribe(
      () => {
        this.notify.info(this.l('SavedSuccessfully'));
        this.bsModalRef.hide();
        this.onSave.emit();
      },
      () => {
        this.saving = false;
      }
    );
  }
}
