using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A258782
{
public static readonly long[] Value={ 0L,0L,1L,3L,5L,7L,9L,12L,15L,18L,22L,25L,29L,33L,36L,40L,44L,48L,53L,57L,61L,65L,70L,74L,79L,84L,88L,93L,98L,103L,108L,113L,118L,123L,128L,133L,138L,143L,149L,154L,159L,165L,170L,175L,181L,186L,192L,197L,203L,209L,214L,220L,226L,231L,237L,243L,249L,254L,260L,266L,272L,278L,284L,290L,296L,302L,308L,314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258782Inst : IEnumerable<long>
{
public static readonly long[] Value=A258782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258782.Bytes);
public long this[int i]=>Value[i];

public static A258782Inst Instance=new A258782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258783
{
public static readonly BigInteger[] Value={ 1L,1L,2L,1L,2L,2L,4L,223L,854L,4762L,1444L,2324506L,35548L,140343676L,21047728264L,88824427L,160465442L,96633020222386L,18457536052L,1397584483920886L,885721299987868L,2758893844640044L,3793843972393624L,BigInteger.Parse("56271391915038457502"),BigInteger.Parse("480348904858674456484"),BigInteger.Parse("85734822774933179463764"),BigInteger.Parse("2140418040120050844508958552") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258783Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258783.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258783Inst Instance=new A258783Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258784
{
public static readonly BigInteger[] Value={ 5L,75L,4875L,82875L,6215625L,242409375L,19527421875L,44815433203125L,7185407790234375L,1699625304228515625L,BigInteger.Parse("22095128954970703125"),BigInteger.Parse("1538152402200285498046875"),BigInteger.Parse("1024661605286766357421875"),BigInteger.Parse("177310518163637910787353515625"),BigInteger.Parse("1171727007531373860453094482421875") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258784Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258784.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258784Inst Instance=new A258784Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258785
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,63L,3105L,43108L,77781L,367573L,13859021L,77911127L,911360799L,35924813703L,74075186297L,89012345679L,111111111111L,811818896748L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258785Inst : IEnumerable<long>
{
public static readonly long[] Value=A258785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258785.Bytes);
public long this[int i]=>Value[i];

public static A258785Inst Instance=new A258785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258786
{
public static readonly long[] Value={ 5L,8L,41L,56L,64L,358L,614L,946L,1092L,1382L,1683L,2430L,2683L,2734L,2834L,2945L,3045L,3067L,3602L,4056L,4286L,5186L,5784L,6874L,7251L,8104L,8546L,9264L,12881L,14028L,14384L,15258L,17386L,21103L,22044L,23331L,24434L,24603L,25346L,26420L,26822L,26845L,27024L,27232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258786Inst : IEnumerable<long>
{
public static readonly long[] Value=A258786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258786.Bytes);
public long this[int i]=>Value[i];

public static A258786Inst Instance=new A258786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258787
{
public static readonly long[] Value={ 5L,8L,17L,7L,26L,449L,30L,18L,197L,557L,3L,9L,118L,1207L,19601L,22L,146L,19L,361L,8201L,132857L,38L,40L,224L,249L,4625L,296449L,4486949L,54L,28L,68L,99L,4033L,4625L,296449L,126664001L,42L,130L,28L,118L,557L,8201L,997757L,24800401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258787Inst : IEnumerable<long>
{
public static readonly long[] Value=A258787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258787.Bytes);
public long this[int i]=>Value[i];

public static A258787Inst Instance=new A258787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258788
{
public static readonly long[] Value={ 1L,1L,3L,12L,47L,192L,811L,3539L,15765L,71362L,327748L,1524081L,7161629L,33958506L,162312471L,781305581L,3784573140L,18435578714L,90261022638L,443956543235L,2192796266004L,10872208762458L,54095648185434L,270029668955605L,1351943521270155L,6787479872751732L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258788Inst : IEnumerable<long>
{
public static readonly long[] Value=A258788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258788.Bytes);
public long this[int i]=>Value[i];

public static A258788Inst Instance=new A258788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258789
{
public static readonly long[] Value={ 1L,1L,5L,27L,169L,1115L,7760L,55748L,411498L,3101490L,23785645L,185064559L,1457664666L,11602828475L,93205739436L,754751603157L,6155229065861L,50515624923790L,416930705579538L,3458726257239312L,28825340825747729L,241245120218823892L,2026803168946440648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258789Inst : IEnumerable<long>
{
public static readonly long[] Value=A258789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258789.Bytes);
public long this[int i]=>Value[i];

public static A258789Inst Instance=new A258789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258790
{
public static readonly BigInteger[] Value={ 1L,1L,6L,48L,411L,3765L,36308L,363446L,3742085L,39405777L,422669224L,4603472960L,50790334667L,566603884871L,6381702580969L,72481863380510L,829331355150992L,9551576115706329L,110654552651370400L,1288710163262774157L,15080440970246785366UL,BigInteger.Parse("177237948953055593475") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258790Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258790.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258790Inst Instance=new A258790Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258791
{
public static readonly ulong[] Value={ 1L,3L,20L,158L,1307L,11352L,102538L,954904L,9112038L,88723163L,878714118L,8829998320L,89848944237L,924291213496L,9600148608620L,100565064076006L,1061498376477423L,11281275452880277L,120635822090127386L,1297256892395670322L,14021436433125959714UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258791Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A258791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258791.Bytes);
public ulong this[int i]=>Value[i];

public static A258791Inst Instance=new A258791Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258792
{
public static readonly BigInteger[] Value={ 1L,6L,69L,915L,12978L,194688L,3051617L,49526487L,826910754L,14135805042L,246508115583L,4372617452085L,78714369892152L,1435357362134796L,26472477913596486L,493178852479545556L,9270953614684288962UL,BigInteger.Parse("175695092091980786166"),BigInteger.Parse("3354069936616380522256") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258792Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258792.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258792Inst Instance=new A258792Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258793
{
public static readonly BigInteger[] Value={ 1L,4L,55L,896L,16494L,326422L,6812064L,147937628L,3315019979L,76184664934L,1787702723767L,42688437971038L,1034621287862521L,25398832816003228L,630502487733706193L,15805630063826901440UL,BigInteger.Parse("399669931534045129915"),BigInteger.Parse("10184690536676439639278"),BigInteger.Parse("261340023300544414822171") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258793Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258793.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258793Inst Instance=new A258793Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258794
{
public static readonly BigInteger[] Value={ 1L,10L,294L,10592L,433350L,19269768L,910578172L,45070219993L,2313935076132L,122371149279812L,6631958513821919L,366896706349540194L,BigInteger.Parse("20656935779581469141"),BigInteger.Parse("1180759136663178459661"),BigInteger.Parse("68388869189063880001236"),BigInteger.Parse("4007252716834400744174729"),BigInteger.Parse("237231272998203169561835387") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258794Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258794.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258794Inst Instance=new A258794Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258795
{
public static readonly BigInteger[] Value={ 1L,5L,112L,3216L,104112L,3661517L,136580866L,5323418568L,214685704402L,8897404908604L,377068336570902L,16280261371485594L,714081427614467553L,BigInteger.Parse("31747177836376617322"),BigInteger.Parse("1428084942303149795972"),BigInteger.Parse("64902413675181889657064"),BigInteger.Parse("2976483322906106920966911") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258795Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258795.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258795Inst Instance=new A258795Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258796
{
public static readonly BigInteger[] Value={ 1L,15L,882L,67385L,5938518L,575782833L,59765085601L,6529604684991L,742474127495175L,87176531917206953L,10508492822243329854UL,BigInteger.Parse("1294860745291809207237"),BigInteger.Parse("162553748258042032103013"),BigInteger.Parse("20735748733960087597815855"),BigInteger.Parse("2682101373558320853655174803") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258796Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258796.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258796Inst Instance=new A258796Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258797
{
public static readonly long[] Value={ 1L,1L,2L,6L,16L,51L,166L,554L,1896L,6595L,23212L,82582L,296393L,1071738L,3900696L,14278074L,52526972L,194108087L,720197524L,2681854490L,10019539112L,37545876368L,141080872362L,531457445806L,2006678785762L,7593123695669L,28789152013570L,109356019134584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258797Inst : IEnumerable<long>
{
public static readonly long[] Value=A258797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258797.Bytes);
public long this[int i]=>Value[i];

public static A258797Inst Instance=new A258797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258798
{
public static readonly long[] Value={ 1L,3L,12L,62L,327L,1851L,10802L,64440L,391218L,2408001L,14989608L,94197594L,596756374L,3807010920L,24435261432L,157681777148L,1022391454116L,6657413851086L,43517229086467L,285447137446989L,1878287880309900L,12395149957521672L,82014499806039711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258798Inst : IEnumerable<long>
{
public static readonly long[] Value=A258798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258798.Bytes);
public long this[int i]=>Value[i];

public static A258798Inst Instance=new A258798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258799
{
public static readonly long[] Value={ 1L,1L,3L,13L,61L,324L,1800L,10340L,60969L,366486L,2237120L,13829487L,86394782L,544547651L,3458637273L,22113504345L,142212705879L,919294844898L,5969839457411L,38927450022860L,254776529381625L,1673102335692514L,11020847332241873L,72798664086854460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258799Inst : IEnumerable<long>
{
public static readonly long[] Value=A258799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258799.Bytes);
public long this[int i]=>Value[i];

public static A258799Inst Instance=new A258799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258800
{
public static readonly long[] Value={ 0L,1L,2L,4L,8L,16L,32L,64L,128L,256L,511L,1021L,2040L,4076L,8144L,16272L,32512L,64960L,129792L,259328L,518145L,1035269L,2068498L,4132920L,8257696L,16499120L,32965728L,65866496L,131603200L,262947072L,525375999L,1049716729L,2097364960L,4190597000L,8372936304L,16729373488L,33425781248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258800Inst : IEnumerable<long>
{
public static readonly long[] Value=A258800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258800.Bytes);
public long this[int i]=>Value[i];

public static A258800Inst Instance=new A258800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258801
{
public static readonly long[] Value={ 561L,62745L,656601L,11921001L,26719701L,45318561L,174352641L,230996949L,662086041L,684106401L,689880801L,1534274841L,1848112761L,2176838049L,3022354401L,5860426881L,6025532241L,6097778961L,7281824001L,7397902401L,10031651841L,10054063041L,10585115841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258801Inst : IEnumerable<long>
{
public static readonly long[] Value=A258801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258801.Bytes);
public long this[int i]=>Value[i];

public static A258801Inst Instance=new A258801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258802
{
public static readonly long[] Value={ 0L,0L,3L,3L,5L,4L,5L,5L,4L,4L,6L,7L,7L,7L,7L,4L,8L,8L,9L,6L,9L,9L,11L,7L,7L,9L,11L,11L,13L,10L,13L,10L,12L,11L,13L,17L,14L,11L,12L,9L,16L,9L,6L,13L,15L,10L,6L,11L,19L,12L,19L,13L,11L,16L,7L,17L,19L,19L,12L,7L,16L,19L,7L,10L,13L,19L,22L,7L,19L,19L,18L,18L,21L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258802Inst : IEnumerable<long>
{
public static readonly long[] Value=A258802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258802.Bytes);
public long this[int i]=>Value[i];

public static A258802Inst Instance=new A258802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258803
{
public static readonly long[] Value={ 2L,2L,5L,3L,2L,13L,11L,2L,23L,3L,11L,29L,19L,397L,2L,67L,131L,31L,5L,2L,5L,7L,1039L,5L,7L,67L,3L,787L,2L,13L,83L,149L,2L,89L,47L,43L,31L,809L,3L,5L,2L,307L,5L,61L,41L,5L,67L,19L,11L,1447L,101L,13L,881L,2L,37L,31L,331L,11L,1033L,3L,19L,839L,2L,61L,163L,59L,41L,1163L,3L,353L,67L,7L,313L,11L,7L,7L,101L,2L,71L,19L,7L,127L,409L,53L,149L,401L,283L,3L,2L,191L,43L,157L,163L,13L,2L,31L,89L,19L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258803Inst : IEnumerable<long>
{
public static readonly long[] Value=A258803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258803.Bytes);
public long this[int i]=>Value[i];

public static A258803Inst Instance=new A258803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258804
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,11L,26L,68L,160L,226L,198L,576L,1246L,122L,328L,5470L,3048L,22554L,69648L,24184L,262752L,4386396L,70190L,22222L,4639830L,1914046L,3227106L,35917950L,2738592L,325870L,124850L,8375086L,7397758L,129192L,6948110L,10496178L,82166L,740450L,44446188L,1473852L,184450L,342342L,14496L,740L,2906L,7040L,53772L,20464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258804Inst : IEnumerable<long>
{
public static readonly long[] Value=A258804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258804.Bytes);
public long this[int i]=>Value[i];

public static A258804Inst Instance=new A258804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258805
{
public static readonly BigInteger[] Value={ 2L,257L,65537L,37588592026706177L,92170395205042177L,147578905600000001L,284936905588473857L,3503536769037500417L,11007531417600000001UL,11763130845074473217UL,BigInteger.Parse("47330370277129322497"),BigInteger.Parse("50024641296100000001"),BigInteger.Parse("76872571987558646017"),BigInteger.Parse("416806419029812551937") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258805Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258805.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258805Inst Instance=new A258805Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258806
{
public static readonly long[] Value={ 1L,2L,129L,2188L,16385L,78126L,279937L,823544L,2097153L,4782970L,10000001L,19487172L,35831809L,62748518L,105413505L,170859376L,268435457L,410338674L,612220033L,893871740L,1280000001L,1801088542L,2494357889L,3404825448L,4586471425L,6103515626L,8031810177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258806Inst : IEnumerable<long>
{
public static readonly long[] Value=A258806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258806.Bytes);
public long this[int i]=>Value[i];

public static A258806Inst Instance=new A258806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258807
{
public static readonly long[] Value={ 0L,31L,242L,1023L,3124L,7775L,16806L,32767L,59048L,99999L,161050L,248831L,371292L,537823L,759374L,1048575L,1419856L,1889567L,2476098L,3199999L,4084100L,5153631L,6436342L,7962623L,9765624L,11881375L,14348906L,17210367L,20511148L,24299999L,28629150L,33554431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258807Inst : IEnumerable<long>
{
public static readonly long[] Value=A258807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258807.Bytes);
public long this[int i]=>Value[i];

public static A258807Inst Instance=new A258807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258808
{
public static readonly long[] Value={ 0L,127L,2186L,16383L,78124L,279935L,823542L,2097151L,4782968L,9999999L,19487170L,35831807L,62748516L,105413503L,170859374L,268435455L,410338672L,612220031L,893871738L,1279999999L,1801088540L,2494357887L,3404825446L,4586471423L,6103515624L,8031810175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258808Inst : IEnumerable<long>
{
public static readonly long[] Value=A258808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258808.Bytes);
public long this[int i]=>Value[i];

public static A258808Inst Instance=new A258808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258809
{
public static readonly long[] Value={ 0L,255L,6560L,65535L,390624L,1679615L,5764800L,16777215L,43046720L,99999999L,214358880L,429981695L,815730720L,1475789055L,2562890624L,4294967295L,6975757440L,11019960575L,16983563040L,25599999999L,37822859360L,54875873535L,78310985280L,110075314175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258809Inst : IEnumerable<long>
{
public static readonly long[] Value=A258809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258809.Bytes);
public long this[int i]=>Value[i];

public static A258809Inst Instance=new A258809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258810
{
public static readonly long[] Value={ 0L,511L,19682L,262143L,1953124L,10077695L,40353606L,134217727L,387420488L,999999999L,2357947690L,5159780351L,10604499372L,20661046783L,38443359374L,68719476735L,118587876496L,198359290367L,322687697778L,511999999999L,794280046580L,1207269217791L,1801152661462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258810Inst : IEnumerable<long>
{
public static readonly long[] Value=A258810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258810.Bytes);
public long this[int i]=>Value[i];

public static A258810Inst Instance=new A258810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258811
{
public static readonly long[] Value={ 3L,5L,3L,17L,5L,11L,5L,29L,11L,5L,17L,5L,149L,29L,3L,11L,5L,3L,11L,11L,41L,29L,5L,17L,5L,11L,3L,269L,11L,5L,41L,5L,5L,29L,11L,11L,179L,5L,59L,5L,29L,149L,29L,29L,3L,17L,5L,3L,17L,11L,41L,5L,149L,29L,11L,59L,3L,5L,17L,3L,461L,179L,1229L,17L,29L,107L,59L,179L,11L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258811Inst : IEnumerable<long>
{
public static readonly long[] Value=A258811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258811.Bytes);
public long this[int i]=>Value[i];

public static A258811Inst Instance=new A258811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258812
{
public static readonly long[] Value={ 0L,2047L,177146L,4194303L,48828124L,362797055L,1977326742L,8589934591L,31381059608L,99999999999L,285311670610L,743008370687L,1792160394036L,4049565169663L,8649755859374L,17592186044415L,34271896307632L,64268410079231L,116490258898218L,204799999999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258812Inst : IEnumerable<long>
{
public static readonly long[] Value=A258812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258812.Bytes);
public long this[int i]=>Value[i];

public static A258812Inst Instance=new A258812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258813
{
public static readonly long[] Value={ 9L,15L,27L,39L,51L,77L,143L,207L,329L,377L,473L,611L,903L,1241L,1243L,1273L,1437L,1591L,2117L,2303L,2975L,4189L,8401L,8657L,11993L,13849L,15611L,16771L,18239L,18599L,19359L,25331L,28877L,37291L,41747L,41807L,61549L,67037L,72601L,82169L,83411L,83711L,87449L,99329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258813Inst : IEnumerable<long>
{
public static readonly long[] Value=A258813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258813.Bytes);
public long this[int i]=>Value[i];

public static A258813Inst Instance=new A258813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258814
{
public static readonly long[] Value={ 9L,9L,9L,5L,5L,4L,5L,0L,7L,8L,9L,0L,5L,3L,9L,9L,0L,9L,4L,9L,6L,3L,4L,6L,5L,4L,9L,8L,9L,9L,0L,5L,8L,9L,8L,3L,0L,0L,2L,1L,8L,8L,4L,8L,1L,9L,4L,9L,9L,7L,5L,7L,9L,2L,2L,5L,2L,6L,4L,9L,2L,1L,8L,9L,4L,1L,9L,0L,1L,1L,2L,1L,4L,4L,5L,9L,1L,1L,0L,5L,0L,0L,0L,6L,7L,5L,7L,8L,6L,6L,7L,9L,9L,5L,3L,6L,6L,4L,2L,0L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258814Inst : IEnumerable<long>
{
public static readonly long[] Value=A258814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258814.Bytes);
public long this[int i]=>Value[i];

public static A258814Inst Instance=new A258814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258815
{
public static readonly long[] Value={ 9L,9L,9L,8L,4L,9L,9L,9L,0L,2L,4L,6L,8L,2L,9L,6L,5L,6L,3L,3L,8L,0L,6L,7L,0L,5L,9L,2L,4L,0L,4L,6L,3L,7L,8L,1L,4L,7L,6L,0L,0L,7L,4L,3L,3L,0L,0L,7L,4L,2L,8L,0L,6L,9L,7L,2L,4L,9L,8L,7L,4L,2L,9L,2L,4L,0L,6L,7L,1L,1L,5L,9L,3L,2L,5L,0L,7L,1L,7L,3L,5L,1L,1L,2L,6L,4L,2L,7L,0L,5L,0L,8L,1L,3L,5L,7L,0L,4L,2L,6L,2L,1L,2L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258815Inst : IEnumerable<long>
{
public static readonly long[] Value=A258815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258815.Bytes);
public long this[int i]=>Value[i];

public static A258815Inst Instance=new A258815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258816
{
public static readonly long[] Value={ 9L,9L,9L,9L,4L,9L,6L,8L,4L,1L,8L,7L,2L,2L,0L,0L,8L,9L,8L,2L,1L,3L,5L,8L,8L,7L,3L,2L,9L,3L,8L,4L,7L,5L,2L,7L,3L,7L,2L,7L,4L,7L,9L,9L,6L,9L,1L,7L,9L,6L,1L,6L,0L,1L,2L,2L,3L,1L,6L,2L,7L,2L,3L,0L,8L,2L,9L,7L,8L,6L,5L,1L,3L,7L,9L,0L,4L,8L,5L,6L,3L,8L,8L,6L,1L,7L,1L,3L,9L,0L,2L,5L,8L,3L,2L,6L,5L,2L,9L,7L,3L,0L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258816Inst : IEnumerable<long>
{
public static readonly long[] Value=A258816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258816.Bytes);
public long this[int i]=>Value[i];

public static A258816Inst Instance=new A258816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258817
{
public static readonly long[] Value={ 0L,1L,2L,0L,3L,3L,0L,0L,8L,5L,4L,0L,9L,7L,8L,0L,13L,9L,4L,0L,14L,11L,14L,0L,3L,13L,17L,0L,25L,15L,4L,0L,26L,17L,28L,0L,30L,19L,35L,0L,4L,21L,9L,0L,8L,23L,32L,0L,7L,25L,47L,0L,30L,27L,48L,0L,23L,29L,45L,0L,48L,31L,35L,0L,48L,33L,12L,0L,14L,35L,7L,0L,34L,37L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258817Inst : IEnumerable<long>
{
public static readonly long[] Value=A258817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258817.Bytes);
public long this[int i]=>Value[i];

public static A258817Inst Instance=new A258817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258818
{
public static readonly long[] Value={ 1L,2L,3L,0L,4L,9L,13L,4L,14L,25L,4L,30L,4L,9L,32L,30L,45L,48L,12L,7L,34L,74L,40L,76L,96L,57L,64L,90L,89L,50L,117L,87L,29L,46L,108L,113L,10L,70L,111L,150L,14L,153L,119L,26L,81L,78L,112L,209L,173L,177L,186L,126L,26L,25L,60L,74L,23L,27L,138L,49L,72L,211L,252L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258818Inst : IEnumerable<long>
{
public static readonly long[] Value=A258818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258818.Bytes);
public long this[int i]=>Value[i];

public static A258818Inst Instance=new A258818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258819
{
public static readonly long[] Value={ 2L,1L,156L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258819Inst : IEnumerable<long>
{
public static readonly long[] Value=A258819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258819.Bytes);
public long this[int i]=>Value[i];

public static A258819Inst Instance=new A258819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258820
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,2L,1L,1L,5L,2L,1L,1L,3L,10L,1L,1L,7L,5L,5L,1L,1L,4L,7L,5L,1L,1L,9L,28L,35L,3L,1L,1L,5L,12L,14L,7L,1L,1L,11L,15L,21L,14L,7L,1L,1L,6L,55L,30L,126L,28L,1L,1L,13L,22L,165L,42L,21L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258820Inst : IEnumerable<long>
{
public static readonly long[] Value=A258820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258820.Bytes);
public long this[int i]=>Value[i];

public static A258820Inst Instance=new A258820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258821
{
public static readonly long[] Value={ 2L,1L,12L,187561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258821Inst : IEnumerable<long>
{
public static readonly long[] Value=A258821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258821.Bytes);
public long this[int i]=>Value[i];

public static A258821Inst Instance=new A258821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258822
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,2L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258822Inst : IEnumerable<long>
{
public static readonly long[] Value=A258822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258822.Bytes);
public long this[int i]=>Value[i];

public static A258822Inst Instance=new A258822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258823
{
public static readonly long[] Value={ 2L,7L,8L,10L,18L,19L,24L,26L,41L,43L,44L,45L,46L,48L,52L,53L,64L,65L,66L,67L,72L,74L,76L,77L,97L,98L,99L,100L,101L,102L,112L,116L,117L,120L,122L,144L,148L,149L,153L,156L,157L,158L,160L,172L,173L,174L,175L,209L,210L,211L,246L,247L,248L,249L,250L,252L,253L,254L,255L,260L,261L,262L,264L,266L,268L,269L,272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258823Inst : IEnumerable<long>
{
public static readonly long[] Value=A258823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258823.Bytes);
public long this[int i]=>Value[i];

public static A258823Inst Instance=new A258823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258824
{
public static readonly long[] Value={ 1L,2L,24L,63105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258824Inst : IEnumerable<long>
{
public static readonly long[] Value=A258824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258824.Bytes);
public long this[int i]=>Value[i];

public static A258824Inst Instance=new A258824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258825
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258825Inst : IEnumerable<long>
{
public static readonly long[] Value=A258825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258825.Bytes);
public long this[int i]=>Value[i];

public static A258825Inst Instance=new A258825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258826
{
public static readonly long[] Value={ 2L,6L,7L,8L,17L,20L,21L,22L,23L,24L,36L,37L,38L,43L,48L,52L,53L,64L,68L,69L,70L,75L,86L,87L,89L,97L,98L,99L,105L,111L,112L,116L,117L,120L,122L,130L,131L,132L,133L,134L,137L,160L,169L,192L,208L,212L,213L,226L,227L,242L,243L,260L,261L,262L,264L,266L,268L,269L,273L,288L,290L,291L,292L,293L,294L,296L,298L,299L,305L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258826Inst : IEnumerable<long>
{
public static readonly long[] Value=A258826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258826.Bytes);
public long this[int i]=>Value[i];

public static A258826Inst Instance=new A258826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258827
{
public static readonly long[] Value={ 1L,4L,6L,5L,10L,7L,2L,8L,12L,9L,20L,11L,13L,3L,16L,14L,35L,15L,36L,17L,18L,19L,21L,23L,30L,24L,38L,25L,26L,29L,39L,33L,37L,34L,31L,22L,43L,41L,44L,32L,42L,40L,50L,47L,45L,28L,27L,46L,49L,48L,51L,53L,74L,52L,59L,54L,63L,55L,56L,58L,84L,57L,62L,65L,60L,64L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258827Inst : IEnumerable<long>
{
public static readonly long[] Value=A258827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258827.Bytes);
public long this[int i]=>Value[i];

public static A258827Inst Instance=new A258827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258828
{
public static readonly long[] Value={ 1L,2L,105L,305L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258828Inst : IEnumerable<long>
{
public static readonly long[] Value=A258828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258828.Bytes);
public long this[int i]=>Value[i];

public static A258828Inst Instance=new A258828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258829
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,2L,2L,1L,0L,5L,11L,3L,1L,0L,16L,38L,28L,4L,1L,0L,61L,263L,130L,62L,5L,1L,0L,272L,1260L,1263L,340L,129L,6L,1L,0L,1385L,10871L,8090L,4734L,819L,261L,7L,1L,0L,7936L,66576L,88101L,33855L,16066L,1890L,522L,8L,1L,0L,50521L,694599L,724189L,495371L,127538L,52022L,4260L,1040L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258829Inst : IEnumerable<long>
{
public static readonly long[] Value=A258829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258829.Bytes);
public long this[int i]=>Value[i];

public static A258829Inst Instance=new A258829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258830
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,20L,87L,522L,3271L,26168L,214955L,2149550L,21881103L,262573236L,3191361201L,44679056814L,631546127049L,10104738032784L,162891774138339L,2932051934490102L,53094870211027831L,1061897404220556620L,BigInteger.Parse("21342730463672017301"),BigInteger.Parse("469540070200784380622") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258830Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258830.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258830Inst Instance=new A258830Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258831
{
public static readonly long[] Value={ 1L,-2L,3L,-4L,5L,-8L,7L,-8L,9L,-10L,14L,-12L,16L,-14L,15L,-20L,17L,-18L,19L,-24L,26L,-22L,23L,-28L,25L,-32L,32L,-28L,29L,-30L,38L,-32L,33L,-40L,40L,-44L,42L,-38L,39L,-40L,57L,-42L,43L,-44L,45L,-62L,47L,-56L,49L,-56L,62L,-52L,53L,-60L,64L,-68L,64L,-58L,59L,-60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258831Inst : IEnumerable<long>
{
public static readonly long[] Value=A258831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258831.Bytes);
public long this[int i]=>Value[i];

public static A258831Inst Instance=new A258831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258832
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,1L,-2L,0L,-1L,1L,-1L,2L,-1L,1L,0L,1L,-2L,1L,0L,2L,-1L,1L,-1L,1L,-1L,1L,-2L,1L,0L,0L,-1L,2L,-2L,1L,-1L,0L,-3L,0L,-1L,1L,0L,2L,0L,1L,-1L,2L,-2L,1L,-1L,0L,-1L,1L,-1L,2L,-1L,1L,0L,1L,-2L,1L,0L,3L,0L,0L,-1L,1L,-2L,1L,-1L,1L,-1L,3L,-1L,0L,-1L,0L,-2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258832Inst : IEnumerable<long>
{
public static readonly long[] Value=A258832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258832.Bytes);
public long this[int i]=>Value[i];

public static A258832Inst Instance=new A258832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258833
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,9L,11L,12L,14L,15L,16L,18L,19L,21L,22L,23L,25L,26L,28L,29L,31L,32L,33L,35L,36L,38L,39L,40L,42L,43L,45L,46L,48L,49L,50L,52L,53L,55L,56L,57L,59L,60L,62L,63L,64L,66L,67L,69L,70L,72L,73L,74L,76L,77L,79L,80L,81L,83L,84L,86L,87L,89L,90L,91L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258833Inst : IEnumerable<long>
{
public static readonly long[] Value=A258833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258833.Bytes);
public long this[int i]=>Value[i];

public static A258833Inst Instance=new A258833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258834
{
public static readonly long[] Value={ 0L,3L,6L,10L,13L,17L,20L,24L,27L,30L,34L,37L,41L,44L,47L,51L,54L,58L,61L,65L,68L,71L,75L,78L,82L,85L,88L,92L,95L,99L,102L,105L,109L,112L,116L,119L,123L,126L,129L,133L,136L,140L,143L,146L,150L,153L,157L,160L,164L,167L,170L,174L,177L,181L,184L,187L,191L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258834Inst : IEnumerable<long>
{
public static readonly long[] Value=A258834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258834.Bytes);
public long this[int i]=>Value[i];

public static A258834Inst Instance=new A258834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258835
{
public static readonly long[] Value={ 1L,3L,3L,4L,7L,6L,9L,13L,9L,10L,15L,15L,13L,19L,18L,16L,30L,21L,19L,27L,21L,31L,31L,24L,25L,39L,33L,28L,48L,30L,35L,54L,33L,34L,52L,42L,45L,51L,39L,45L,55L,51L,50L,70L,45L,46L,78L,48L,54L,80L,57L,63L,78L,54L,55L,75L,84L,58L,79L,60L,61L,117L,63L,74L,87L,72L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258835Inst : IEnumerable<long>
{
public static readonly long[] Value=A258835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258835.Bytes);
public long this[int i]=>Value[i];

public static A258835Inst Instance=new A258835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258836
{
public static readonly long[] Value={ 4L,6L,4L,18L,6L,12L,6L,30L,12L,6L,18L,6L,150L,30L,4L,12L,60L,4L,12L,12L,42L,30L,240L,18L,6L,12L,4L,270L,12L,6L,42L,6L,6L,30L,12L,12L,180L,6L,60L,6L,30L,150L,30L,30L,4L,18L,2550L,4L,18L,12L,42L,6L,150L,30L,12L,60L,4L,6L,60L,4L,462L,180L,1230L,18L,30L,108L,60L,180L,12L,6L,30L,6L,570L,420L,462L,180L,6L,4L,198L,42L,522L,600L,1050L,42L,12L,12L,4L,60L,432L,18L,12L,60L,30L,60L,6L,12L,150L,60L,30L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258836Inst : IEnumerable<long>
{
public static readonly long[] Value=A258836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258836.Bytes);
public long this[int i]=>Value[i];

public static A258836Inst Instance=new A258836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258837
{
public static readonly long[] Value={ 1L,0L,-3L,-8L,-15L,-24L,-35L,-48L,-63L,-80L,-99L,-120L,-143L,-168L,-195L,-224L,-255L,-288L,-323L,-360L,-399L,-440L,-483L,-528L,-575L,-624L,-675L,-728L,-783L,-840L,-899L,-960L,-1023L,-1088L,-1155L,-1224L,-1295L,-1368L,-1443L,-1520L,-1599L,-1680L,-1763L,-1848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258837Inst : IEnumerable<long>
{
public static readonly long[] Value=A258837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258837.Bytes);
public long this[int i]=>Value[i];

public static A258837Inst Instance=new A258837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258838
{
public static readonly long[] Value={ 4L,6L,12L,18L,30L,42L,60L,72L,108L,150L,180L,192L,198L,228L,240L,270L,312L,348L,420L,432L,462L,522L,570L,600L,660L,810L,828L,858L,882L,1020L,1032L,1050L,1092L,1152L,1230L,1290L,1302L,1320L,1428L,1452L,1482L,1488L,1620L,1722L,1872L,1932L,1950L,1998L,2028L,2088L,2112L,2130L,2142L,2268L,2310L,2340L,2550L,2592L,2688L,2730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258838Inst : IEnumerable<long>
{
public static readonly long[] Value=A258838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258838.Bytes);
public long this[int i]=>Value[i];

public static A258838Inst Instance=new A258838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258839
{
public static readonly long[] Value={ 561L,162401L,410041L,488881L,656601L,2433601L,36765901L,109393201L,171454321L,176659201L,178837201L,189941761L,221884001L,288120421L,600892993L,618068881L,721244161L,931694401L,985052881L,1183104001L,1828377001L,1848112761L,1943951041L,2361232477L,2438403661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258839Inst : IEnumerable<long>
{
public static readonly long[] Value=A258839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258839.Bytes);
public long this[int i]=>Value[i];

public static A258839Inst Instance=new A258839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258840
{
public static readonly long[] Value={ 1L,3L,7L,38L,47L,157L,302L,327L,515L,616L,697L,798L,818L,1303L,2818L,3141L,3323L,5648L,6962L,9193L,9872L,13213L,13747L,15445L,16271L,17149L,18263L,20491L,20727L,24389L,26915L,29078L,31867L,37848L,38007L,40182L,41508L,43328L,46349L,55025L,62258L,63133L,66893L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258840Inst : IEnumerable<long>
{
public static readonly long[] Value=A258840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258840.Bytes);
public long this[int i]=>Value[i];

public static A258840Inst Instance=new A258840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258841
{
public static readonly long[] Value={ 1927L,1699L,1489L,1297L,1123L,967L,829L,709L,607L,523L,457L,409L,379L,367L,373L,397L,439L,499L,577L,673L,787L,919L,1069L,1237L,1423L,1627L,1849L,2089L,2347L,2623L,2917L,3229L,3559L,3907L,4273L,4657L,5059L,5479L,5917L,6373L,6847L,7339L,7849L,8377L,8923L,9487L,10069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258841Inst : IEnumerable<long>
{
public static readonly long[] Value=A258841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258841.Bytes);
public long this[int i]=>Value[i];

public static A258841Inst Instance=new A258841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258842
{
public static readonly long[] Value={ 182293L,6536953L,13116283L,23337661L,55898473L,56624329L,66112261L,66355291L,66846751L,67239919L,75289033L,76222261L,93331321L,97594157L,110397013L,115175383L,146385797L,147111617L,157333573L,158029141L,159289241L,163825601L,181950817L,187826449L,207820831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258842Inst : IEnumerable<long>
{
public static readonly long[] Value=A258842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258842.Bytes);
public long this[int i]=>Value[i];

public static A258842Inst Instance=new A258842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258843
{
public static readonly long[] Value={ 11L,123L,695L,991L,1919L,2839L,3707L,3841L,7615L,8047L,8055L,9347L,10703L,12847L,16195L,26743L,27089L,32127L,42251L,56419L,59027L,59179L,59389L,59815L,62749L,65113L,74671L,115289L,119211L,122847L,126895L,129495L,168739L,191051L,219295L,224281L,232315L,233729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258843Inst : IEnumerable<long>
{
public static readonly long[] Value=A258843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258843.Bytes);
public long this[int i]=>Value[i];

public static A258843Inst Instance=new A258843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258844
{
public static readonly long[] Value={ 9L,36L,49L,100L,225L,784L,961L,1296L,2601L,3969L,7225L,8281L,14400L,16129L,18496L,21609L,29241L,34969L,42025L,65025L,116964L,123201L,133225L,246016L,261121L,278784L,465124L,508369L,672400L,700569L,828100L,1046529L,1368900L,1590121L,1782225L,4064256L,4190209L,4326400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258844Inst : IEnumerable<long>
{
public static readonly long[] Value=A258844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258844.Bytes);
public long this[int i]=>Value[i];

public static A258844Inst Instance=new A258844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258845
{
public static readonly BigInteger[] Value={ 0L,0L,1L,7L,52L,332L,2832L,22704L,242112L,2662848L,30620160L,354965760L,5057925120L,68627036160L,1054183818240L,17469144806400L,321351896678400L,5609441772748800L,112707637036646400L,2192664093342105600L,BigInteger.Parse("47745925079924736000"),BigInteger.Parse("1065919878891012096000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258845Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258845.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258845Inst Instance=new A258845Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258846
{
public static readonly BigInteger[] Value={ 0L,0L,4L,54L,1024L,9375L,326592L,3294172L,201326592L,4649045868L,110000000000L,1426558353055L,178322008965120L,1817250639553518L,166680102383370240L,8319983917236328125L,BigInteger.Parse("590295810358705651712"),BigInteger.Parse("5790681833204357349239"),BigInteger.Parse("1298431466484785739988992") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258846Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258846.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258846Inst Instance=new A258846Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258847
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,10L,13L,20L,21L,33L,54L,86L,146L,339L,788L,2947L,14870L,94801L,706961L,5566784L,43958933L,317950465L,2406052444L,19645433193L,146175038733L,1479263447899L,16135114175706L,203382520812382L,2606355260220040L,32974597626726301L,406609097787758227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258847Inst : IEnumerable<long>
{
public static readonly long[] Value=A258847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258847.Bytes);
public long this[int i]=>Value[i];

public static A258847Inst Instance=new A258847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258848
{
public static readonly long[] Value={ 8L,12L,20L,32L,80L,208L,512L,2304L,12288L,81920L,622592L,4931584L,38944768L,278380544L,2122727424L,17483677696L,128412352512L,1348723408896L,14768867966976L,188484960780288L,2416519442792448L,30543291749302272L,375877192068366336L,6101345960934506496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258848Inst : IEnumerable<long>
{
public static readonly long[] Value=A258848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258848.Bytes);
public long this[int i]=>Value[i];

public static A258848Inst Instance=new A258848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258849
{
public static readonly long[] Value={ 0L,0L,0L,0L,4L,0L,4L,4L,12288L,81920L,0L,0L,278380544L,4L,4931584L,278380544L,14768867966976L,4L,128412352512L,14768867966976L,375877192068366336L,14768867966976L,14768867966976L,375877192068366336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258849Inst : IEnumerable<long>
{
public static readonly long[] Value=A258849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258849.Bytes);
public long this[int i]=>Value[i];

public static A258849Inst Instance=new A258849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258850
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,2L,0L,0L,1L,3L,0L,0L,0L,2L,4L,0L,0L,0L,1L,4L,5L,0L,0L,0L,0L,4L,3L,6L,0L,0L,0L,0L,4L,2L,7L,7L,0L,0L,0L,0L,4L,1L,4L,4L,8L,0L,0L,0L,0L,4L,0L,4L,4L,12L,9L,0L,0L,0L,0L,4L,0L,4L,4L,20L,12L,10L,0L,0L,0L,0L,4L,0L,4L,4L,32L,20L,11L,11L,0L,0L,0L,0L,4L,0L,4L,4L,80L,32L,5L,5L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258850Inst : IEnumerable<long>
{
public static readonly long[] Value=A258850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258850.Bytes);
public long this[int i]=>Value[i];

public static A258850Inst Instance=new A258850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258851
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,3L,7L,4L,12L,12L,11L,5L,20L,6L,15L,19L,32L,7L,33L,8L,32L,26L,21L,9L,52L,30L,25L,54L,44L,10L,53L,11L,80L,37L,31L,41L,84L,12L,35L,44L,84L,13L,73L,14L,64L,87L,41L,15L,128L,56L,85L,55L,76L,16L,135L,58L,116L,62L,49L,17L,136L,18L,53L,120L,192L,69L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258851Inst : IEnumerable<long>
{
public static readonly long[] Value=A258851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258851.Bytes);
public long this[int i]=>Value[i];

public static A258851Inst Instance=new A258851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258852
{
public static readonly long[] Value={ 0L,0L,0L,1L,4L,2L,4L,4L,20L,20L,5L,3L,32L,7L,19L,8L,80L,4L,37L,12L,80L,25L,26L,12L,76L,53L,30L,135L,64L,11L,16L,5L,208L,12L,11L,13L,188L,20L,41L,64L,188L,6L,21L,15L,192L,88L,13L,19L,448L,116L,86L,58L,108L,32L,351L,49L,156L,53L,56L,7L,260L,33L,16L,332L,704L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258852Inst : IEnumerable<long>
{
public static readonly long[] Value=A258852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258852.Bytes);
public long this[int i]=>Value[i];

public static A258852Inst Instance=new A258852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258853
{
public static readonly long[] Value={ 0L,0L,0L,0L,4L,1L,4L,4L,32L,32L,3L,2L,80L,4L,8L,12L,208L,4L,12L,20L,208L,30L,25L,20L,108L,16L,53L,351L,192L,5L,32L,3L,512L,20L,5L,6L,248L,32L,13L,192L,248L,7L,26L,19L,704L,172L,6L,8L,1600L,156L,71L,49L,324L,80L,864L,56L,332L,16L,116L,4L,536L,37L,32L,424L,2432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258853Inst : IEnumerable<long>
{
public static readonly long[] Value=A258853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258853.Bytes);
public long this[int i]=>Value[i];

public static A258853Inst Instance=new A258853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258854
{
public static readonly long[] Value={ 0L,0L,0L,0L,4L,0L,4L,4L,80L,80L,2L,1L,208L,4L,12L,20L,512L,4L,20L,32L,512L,53L,30L,32L,324L,32L,16L,864L,704L,3L,80L,2L,2304L,32L,3L,7L,460L,80L,6L,704L,460L,4L,25L,8L,2432L,228L,7L,12L,6720L,332L,20L,56L,1188L,208L,3888L,116L,424L,32L,156L,4L,956L,12L,80L,764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258854Inst : IEnumerable<long>
{
public static readonly long[] Value=A258854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258854.Bytes);
public long this[int i]=>Value[i];

public static A258854Inst Instance=new A258854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258855
{
public static readonly long[] Value={ 0L,0L,0L,0L,4L,0L,4L,4L,208L,208L,1L,0L,512L,4L,20L,32L,2304L,4L,32L,80L,2304L,16L,53L,80L,1188L,80L,32L,3888L,2432L,2L,208L,1L,12288L,80L,2L,4L,916L,208L,7L,2432L,916L,4L,30L,12L,9536L,476L,4L,20L,32512L,424L,32L,116L,4104L,512L,20736L,156L,764L,80L,332L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258855Inst : IEnumerable<long>
{
public static readonly long[] Value=A258855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258855.Bytes);
public long this[int i]=>Value[i];

public static A258855Inst Instance=new A258855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258856
{
public static readonly long[] Value={ 0L,0L,0L,0L,4L,0L,4L,4L,512L,512L,0L,0L,2304L,4L,32L,80L,12288L,4L,80L,208L,12288L,32L,16L,208L,4104L,208L,80L,20736L,9536L,1L,512L,0L,81920L,208L,1L,4L,1116L,512L,4L,9536L,1116L,4L,53L,20L,30848L,944L,4L,32L,137984L,764L,80L,156L,16092L,2304L,138240L,332L,936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258856Inst : IEnumerable<long>
{
public static readonly long[] Value=A258856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258856.Bytes);
public long this[int i]=>Value[i];

public static A258856Inst Instance=new A258856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258857
{
public static readonly long[] Value={ 0L,0L,0L,0L,4L,0L,4L,4L,2304L,2304L,0L,0L,12288L,4L,80L,208L,81920L,4L,208L,512L,81920L,80L,32L,512L,16092L,512L,208L,138240L,30848L,0L,2304L,0L,622592L,512L,0L,4L,3000L,2304L,4L,30848L,3000L,4L,16L,32L,114752L,2160L,4L,80L,772352L,936L,208L,332L,52056L,12288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258857Inst : IEnumerable<long>
{
public static readonly long[] Value=A258857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258857.Bytes);
public long this[int i]=>Value[i];

public static A258857Inst Instance=new A258857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258858
{
public static readonly long[] Value={ 0L,0L,0L,0L,4L,0L,4L,4L,12288L,12288L,0L,0L,81920L,4L,208L,512L,622592L,4L,512L,2304L,622592L,208L,80L,2304L,52056L,2304L,512L,1050624L,114752L,0L,12288L,0L,4931584L,2304L,0L,4L,11900L,12288L,4L,114752L,11900L,4L,32L,80L,423168L,9936L,4L,208L,3679488L,3084L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258858Inst : IEnumerable<long>
{
public static readonly long[] Value=A258858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258858.Bytes);
public long this[int i]=>Value[i];

public static A258858Inst Instance=new A258858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258859
{
public static readonly long[] Value={ 0L,0L,0L,0L,4L,0L,4L,4L,81920L,81920L,0L,0L,622592L,4L,512L,2304L,4931584L,4L,2304L,12288L,4931584L,512L,208L,12288L,193644L,12288L,2304L,8322048L,423168L,0L,81920L,0L,38944768L,12288L,0L,4L,37880L,81920L,4L,423168L,37880L,4L,80L,208L,2298880L,43632L,4L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258859Inst : IEnumerable<long>
{
public static readonly long[] Value=A258859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258859.Bytes);
public long this[int i]=>Value[i];

public static A258859Inst Instance=new A258859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258860
{
public static readonly long[] Value={ 0L,0L,0L,0L,4L,0L,4L,4L,622592L,622592L,0L,0L,4931584L,4L,2304L,12288L,38944768L,4L,12288L,81920L,38944768L,2304L,512L,81920L,714096L,81920L,12288L,65719296L,2298880L,0L,622592L,0L,278380544L,81920L,0L,4L,85988L,622592L,4L,2298880L,85988L,4L,208L,512L,13319168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258860Inst : IEnumerable<long>
{
public static readonly long[] Value=A258860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258860.Bytes);
public long this[int i]=>Value[i];

public static A258860Inst Instance=new A258860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258861
{
public static readonly long[] Value={ 0L,2L,3L,5L,4L,11L,13L,6L,19L,23L,29L,10L,8L,41L,43L,14L,53L,59L,61L,15L,12L,22L,79L,83L,89L,26L,21L,103L,107L,109L,25L,34L,16L,18L,139L,38L,151L,33L,163L,167L,173L,35L,181L,191L,28L,197L,199L,211L,223L,58L,229L,233L,24L,30L,27L,51L,49L,269L,55L,277L,281L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258861Inst : IEnumerable<long>
{
public static readonly long[] Value=A258861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258861.Bytes);
public long this[int i]=>Value[i];

public static A258861Inst Instance=new A258861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258862
{
public static readonly long[] Value={ 0L,3L,5L,11L,4L,10L,41L,13L,15L,83L,109L,29L,19L,35L,191L,43L,30L,277L,74L,14L,8L,42L,77L,431L,461L,21L,22L,563L,66L,599L,26L,78L,12L,61L,141L,163L,877L,18L,214L,218L,226L,38L,114L,201L,105L,1201L,215L,1297L,302L,55L,1447L,1471L,89L,25L,103L,170L,58L,291L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258862Inst : IEnumerable<long>
{
public static readonly long[] Value=A258862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258862.Bytes);
public long this[int i]=>Value[i];

public static A258862Inst Instance=new A258862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258863
{
public static readonly long[] Value={ 0L,1L,1L,2L,-1L,4L,-3L,8L,0L,-1L,-6L,15L,-14L,9L,4L,13L,-25L,26L,-25L,24L,-6L,-5L,-12L,43L,-22L,-5L,29L,-10L,-34L,43L,-42L,69L,-43L,-6L,10L,43L,-72L,23L,9L,40L,-71L,60L,-59L,50L,23L,-46L,-26L,113L,-72L,29L,-30L,21L,-60L,119L,-77L,58L,-54L,-13L,-32L,119L,-118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258863Inst : IEnumerable<long>
{
public static readonly long[] Value=A258863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258863.Bytes);
public long this[int i]=>Value[i];

public static A258863Inst Instance=new A258863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258864
{
public static readonly long[] Value={ 0L,0L,1L,3L,7L,10L,17L,21L,33L,45L,56L,61L,81L,87L,102L,121L,153L,160L,193L,201L,233L,259L,280L,289L,341L,371L,396L,450L,494L,504L,557L,568L,648L,685L,716L,757L,841L,853L,888L,932L,1016L,1029L,1102L,1116L,1180L,1267L,1308L,1323L,1451L,1507L,1592L,1647L,1723L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258864Inst : IEnumerable<long>
{
public static readonly long[] Value=A258864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258864.Bytes);
public long this[int i]=>Value[i];

public static A258864Inst Instance=new A258864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258865
{
public static readonly long[] Value={ 24L,43L,62L,81L,141L,160L,179L,258L,277L,359L,375L,378L,397L,476L,495L,593L,694L,713L,811L,1029L,1347L,1366L,1385L,1464L,1483L,1581L,1682L,1701L,1799L,2017L,2213L,2232L,2251L,2330L,2349L,2447L,2548L,2567L,2665L,2670L,2689L,2787L,2883L,3005L,3536L,3555L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258865Inst : IEnumerable<long>
{
public static readonly long[] Value=A258865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258865.Bytes);
public long this[int i]=>Value[i];

public static A258865Inst Instance=new A258865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258866
{
public static readonly long[] Value={ 11L,17L,31L,39L,53L,93L,95L,381L,727L,867L,1229L,1573L,3161L,4293L,5635L,7077L,7093L,8861L,37401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258866Inst : IEnumerable<long>
{
public static readonly long[] Value=A258866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258866.Bytes);
public long this[int i]=>Value[i];

public static A258866Inst Instance=new A258866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258867
{
public static readonly long[] Value={ 4L,7L,13L,16L,20L,22L,25L,26L,27L,31L,34L,37L,40L,41L,43L,48L,49L,52L,58L,59L,61L,62L,64L,67L,69L,70L,76L,79L,81L,83L,85L,88L,89L,90L,92L,94L,97L,102L,103L,106L,111L,112L,114L,115L,118L,121L,124L,125L,130L,132L,133L,135L,139L,140L,142L,145L,146L,147L,148L,151L,157L,158L,159L,160L,166L,167L,169L,174L,175L,178L,180L,181L,182L,184L,187L,188L,191L,193L,195L,196L,197L,199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258867Inst : IEnumerable<long>
{
public static readonly long[] Value=A258867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258867.Bytes);
public long this[int i]=>Value[i];

public static A258867Inst Instance=new A258867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258868
{
public static readonly long[] Value={ 1L,1L,2L,5L,26L,287L,356L,395L,544L,11008L,21957L,32125L,42450L,50867L,55408L,206970L,358276L,384287L,403461L,735802L,783831L,969795L,1192950L,1383108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258868Inst : IEnumerable<long>
{
public static readonly long[] Value=A258868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258868.Bytes);
public long this[int i]=>Value[i];

public static A258868Inst Instance=new A258868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258869
{
public static readonly long[] Value={ 1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258869Inst : IEnumerable<long>
{
public static readonly long[] Value=A258869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258869.Bytes);
public long this[int i]=>Value[i];

public static A258869Inst Instance=new A258869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258870
{
public static readonly long[] Value={ 2L,1L,6L,7L,3L,6L,0L,6L,2L,5L,8L,8L,2L,2L,6L,1L,9L,5L,1L,9L,0L,0L,2L,3L,1L,3L,6L,6L,8L,4L,7L,0L,2L,7L,4L,4L,1L,8L,2L,1L,6L,1L,3L,1L,7L,2L,9L,6L,3L,4L,9L,8L,5L,0L,9L,7L,5L,6L,2L,3L,2L,5L,9L,9L,8L,8L,2L,2L,1L,3L,7L,8L,7L,1L,9L,4L,8L,5L,3L,8L,1L,6L,7L,7L,0L,4L,2L,6L,8L,1L,2L,3L,6L,4L,1L,5L,4L,4L,4L,7L,3L,7L,9L,5L,0L,3L,6L,4L,6L,4L,3L,4L,5L,8L,1L,4L,2L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258870Inst : IEnumerable<long>
{
public static readonly long[] Value=A258870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258870.Bytes);
public long this[int i]=>Value[i];

public static A258870Inst Instance=new A258870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258871
{
public static readonly long[] Value={ 2L,0L,3L,4L,7L,4L,0L,8L,3L,5L,0L,0L,9L,4L,2L,9L,0L,6L,3L,5L,8L,6L,8L,2L,0L,8L,0L,9L,6L,4L,2L,8L,5L,0L,8L,9L,7L,7L,1L,0L,9L,0L,1L,0L,0L,6L,2L,3L,9L,2L,5L,4L,6L,9L,0L,5L,5L,7L,5L,3L,9L,4L,8L,0L,4L,5L,2L,9L,8L,4L,1L,2L,0L,1L,9L,1L,5L,2L,5L,8L,4L,9L,1L,3L,5L,3L,5L,9L,8L,1L,5L,4L,9L,6L,6L,7L,0L,7L,6L,8L,6L,7L,8L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258871Inst : IEnumerable<long>
{
public static readonly long[] Value=A258871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258871.Bytes);
public long this[int i]=>Value[i];

public static A258871Inst Instance=new A258871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258872
{
public static readonly BigInteger[] Value={ 1L,2L,14L,182L,3526L,91422L,2978910L,117081974L,5393393078L,285072735950L,17009730803086L,1131081110962662L,82949497319012070L,6651426091458349502L,BigInteger.Parse("578967663130916841662"),BigInteger.Parse("54369741954121640179286"),BigInteger.Parse("5479228772620109128533526"),BigInteger.Parse("589841997033535953174559662") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258872Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258872.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258872Inst Instance=new A258872Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258873
{
public static readonly BigInteger[] Value={ 1L,6L,450L,119280L,78863400L,109520755344L,286266696940224L,1296790704270547200L,BigInteger.Parse("9516008352506751089280"),BigInteger.Parse("106865158822383325849056000"),BigInteger.Parse("1750834760922461163750744303360"),BigInteger.Parse("40208636074137918720878142328872960"),BigInteger.Parse("1251936919292954052906797742408328704000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258873Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258873.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258873Inst Instance=new A258873Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258874
{
public static readonly BigInteger[] Value={ 1L,24L,22680L,115684800L,1906520616000L,80659993905114624L,BigInteger.Parse("7746053047976698430976"),BigInteger.Parse("1560262733456599283808153600"),BigInteger.Parse("616206470499428864091871431168000"),BigInteger.Parse("445310234257659546728524999957770240000"),BigInteger.Parse("549601486893233034601458951894087488929628160") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258874Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258874.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258874Inst Instance=new A258874Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258875
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,4L,5L,6L,8L,10L,12L,15L,19L,23L,29L,36L,44L,55L,68L,84L,104L,128L,158L,195L,241L,297L,367L,453L,559L,690L,851L,1050L,1296L,1599L,1973L,2434L,3003L,3705L,4571L,5640L,6958L,8585L,10592L,13068L,16123L,19892L,24542L,30279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258875Inst : IEnumerable<long>
{
public static readonly long[] Value=A258875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258875.Bytes);
public long this[int i]=>Value[i];

public static A258875Inst Instance=new A258875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258876
{
public static readonly long[] Value={ 25L,32L,46L,56L,70L,88L,92L,98L,100L,113L,121L,130L,145L,146L,152L,175L,176L,182L,185L,206L,209L,212L,218L,227L,236L,239L,244L,248L,274L,293L,295L,301L,316L,317L,320L,323L,331L,338L,350L,352L,355L,362L,377L,386L,394L,397L,398L,406L,409L,413L,439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258876Inst : IEnumerable<long>
{
public static readonly long[] Value=A258876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258876.Bytes);
public long this[int i]=>Value[i];

public static A258876Inst Instance=new A258876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258877
{
public static readonly long[] Value={ 97L,131L,199L,263L,349L,457L,479L,521L,541L,617L,661L,733L,829L,839L,881L,1039L,1049L,1091L,1103L,1277L,1289L,1301L,1361L,1433L,1487L,1499L,1549L,1571L,1759L,1913L,1933L,1993L,2089L,2099L,2129L,2141L,2221L,2273L,2357L,2377L,2389L,2441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258877Inst : IEnumerable<long>
{
public static readonly long[] Value=A258877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258877.Bytes);
public long this[int i]=>Value[i];

public static A258877Inst Instance=new A258877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258878
{
public static readonly BigInteger[] Value={ 1L,-2L,-20L,-3320L,-1598960L,-1757280800L,-3687555924800L,-13169930119702400L,BigInteger.Parse("-73877683147510880000"),BigInteger.Parse("-613509458527719828800000"),BigInteger.Parse("-7207218902820454669458560000"),BigInteger.Parse("-115535941439664355284062432000000"),BigInteger.Parse("-2454583328787383660694513356633600000"),BigInteger.Parse("-67459240631654340522067311327301145600000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258878Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258878.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258878Inst Instance=new A258878Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258879
{
public static readonly long[] Value={ 30L,60L,270L,570L,600L,1230L,1290L,1620L,2340L,2550L,3540L,4020L,4650L,5850L,6270L,6360L,6570L,10860L,11490L,14550L,15270L,17490L,19080L,19380L,19470L,23670L,26730L,29130L,32370L,34260L,41610L,48480L,49200L,49530L,51420L,51480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258879Inst : IEnumerable<long>
{
public static readonly long[] Value=A258879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258879.Bytes);
public long this[int i]=>Value[i];

public static A258879Inst Instance=new A258879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258880
{
public static readonly BigInteger[] Value={ 1L,6L,540L,184680L,157600080L,270419925600L,816984611467200L,3971317527112003200L,BigInteger.Parse("29097143353353192480000"),BigInteger.Parse("305823675529741700675520000"),BigInteger.Parse("4435486895868663971869188480000"),BigInteger.Parse("86036822683997062842122964537600000"),BigInteger.Parse("2175352015640142857526698650779456000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258880Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258880.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258880Inst Instance=new A258880Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258881
{
public static readonly long[] Value={ 0L,2L,6L,12L,20L,30L,42L,56L,72L,90L,11L,13L,17L,23L,31L,41L,53L,67L,83L,101L,24L,26L,30L,36L,44L,54L,66L,80L,96L,114L,39L,41L,45L,51L,59L,69L,81L,95L,111L,129L,56L,58L,62L,68L,76L,86L,98L,112L,128L,146L,75L,77L,81L,87L,95L,105L,117L,131L,147L,165L,96L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258881Inst : IEnumerable<long>
{
public static readonly long[] Value=A258881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258881.Bytes);
public long this[int i]=>Value[i];

public static A258881Inst Instance=new A258881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}