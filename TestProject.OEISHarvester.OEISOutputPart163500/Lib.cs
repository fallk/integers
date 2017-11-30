using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A289540
{
public static readonly BigInteger[] Value={ 1L,42L,12852L,4780104L,1974512526L,863778376440L,391960077239304L,182430901827757632L,BigInteger.Parse("86505196617272556900"),BigInteger.Parse("41607881477457256661154"),BigInteger.Parse("20239469012268054187498440"),BigInteger.Parse("9935363620927698868439915544"),BigInteger.Parse("4914082482014906612773260362232") };
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
public class A289540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289540Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A289540.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289540.Bytes);
public BigInteger this[int i]=>Value[i];

public static A289540Inst Instance=new A289540Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289541
{
public static readonly BigInteger[] Value={ 1L,1L,2L,8L,37L,187L,1304L,14606L,222379L,4141729L,107836478L,4466744372L,258501941713L,18779494904263L,1918824942497636L,311738238353418074L,BigInteger.Parse("71234670515346760951"),BigInteger.Parse("20564497734374127115501"),BigInteger.Parse("8363824677163863282113162"),BigInteger.Parse("5408580882753786431279731328") };
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
public class A289541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289541Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A289541.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289541.Bytes);
public BigInteger this[int i]=>Value[i];

public static A289541Inst Instance=new A289541Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289542
{
public static readonly BigInteger[] Value={ 0L,1L,12L,119L,1290L,16957L,285264L,6343523L,190424310L,7826128009L,444658035228L,35162773747631L,3888419271339330L,603295404971492053L,BigInteger.Parse("131635270366023841896"),BigInteger.Parse("40458451431717420232187"),BigInteger.Parse("17536781855825299937977230"),BigInteger.Parse("10728658644626168469625854241") };
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
public class A289542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289542Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A289542.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289542.Bytes);
public BigInteger this[int i]=>Value[i];

public static A289542Inst Instance=new A289542Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289543
{
public static readonly BigInteger[] Value={ 1L,0L,1L,1L,281L,9921L,16078337L,13596908545L,191426147495937L,3273234077014474753L,BigInteger.Parse("497324772153177747947521"),BigInteger.Parse("154709087482207635347155451905"),BigInteger.Parse("291534668371237082293312814285062145"),BigInteger.Parse("1534814232386517133354150755522868689240065"),BigInteger.Parse("39269743760371912650589750432327799926355436503041"),BigInteger.Parse("3338607968166762847572429548161284663670177988768356630529") };
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
public class A289543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289543Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A289543.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289543.Bytes);
public BigInteger this[int i]=>Value[i];

public static A289543Inst Instance=new A289543Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289544
{
public static readonly long[] Value={ 2467891035L,2497861035L,2647891053L,2697841053L,2847691053L,2867491035L,2897461035L,2897641053L,3247651089L,3257641089L,3427561098L,3467521098L,3478591206L,3498571206L,3527461098L,3567421098L,3578491206L,3598471206L,3647251089L,3657241089L,4236751098L,4256731098L };
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
public class A289544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289544Inst : IEnumerable<long>
{
public static readonly long[] Value=A289544.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289544.Bytes);
public long this[int i]=>Value[i];

public static A289544Inst Instance=new A289544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289545
{
public static readonly BigInteger[] Value={ 1L,1L,4L,36L,696L,27808L,2257888L,369572160L,121459776768L,79991977040128L,105466641591287296L,BigInteger.Parse("278244130564826548224"),BigInteger.Parse("1468496684404408240109568"),BigInteger.Parse("15502543140842029367582248960"),BigInteger.Parse("327332729703063815298568073396224"),BigInteger.Parse("13823536566775628445052117519260598272") };
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
public class A289545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289545Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A289545.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289545.Bytes);
public BigInteger this[int i]=>Value[i];

public static A289545Inst Instance=new A289545Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289546
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,3L,0L,1L,14L,21L,0L,1L,65L,315L,315L,0L,1L,372L,4650L,13020L,9765L,0L,1L,2823L,87234L,527310L,1025325L,615195L,0L,1L,29210L,2291715L,27448764L,105413175L,156259530L,78129765L,0L,1L,417197L,88508205L,2043137265L,14019952275L,38897461575L,46487210175L,19923090075L };
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
public class A289546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289546Inst : IEnumerable<long>
{
public static readonly long[] Value=A289546.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289546.Bytes);
public long this[int i]=>Value[i];

public static A289546Inst Instance=new A289546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289676
{
public static readonly long[] Value={ 2L,1L,1L,2L,2L,1L,4L,4L,3L,5L,4L,3L,10L,13L,12L,21L,18L,20L,43L,40L,39L,85L,71L,64L,146L,132L,116L,250L,231L,210L,462L,459L,438L,960L,990L,966L,2069L,2114L,2089L,4296L,4237L,4155L,8485L,8234L,8032L,16496L,16054L,15657L,32041L,31280L,30325L,61700L,60252L,58379L,118357L,115810L,112885L };
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
public class A289676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289676Inst : IEnumerable<long>
{
public static readonly long[] Value=A289676.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289676.Bytes);
public long this[int i]=>Value[i];

public static A289676Inst Instance=new A289676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289677
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,4L,4L,5L,11L,12L,13L,22L,19L,20L,43L,46L,44L,85L,88L,89L,171L,185L,192L,366L,380L,396L,774L,793L,814L,1586L,1589L,1610L,3136L,3106L,3130L,6123L,6078L,6103L,12088L,12147L,12229L,24283L,24534L,24736L,49040L,49482L,49879L,99031L,99792L,100747L,200444L,201892L,203765L,405931L,408478L,411403L };
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
public class A289677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289677Inst : IEnumerable<long>
{
public static readonly long[] Value=A289677.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289677.Bytes);
public long this[int i]=>Value[i];

public static A289677Inst Instance=new A289677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289678
{
public static readonly long[] Value={ 1L,1L,3L,6L,15L,42L,131L,442L,1551L,5723L,22171L,89156L,370199L,1589240L,7020127L,31906974L };
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
public class A289678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289678Inst : IEnumerable<long>
{
public static readonly long[] Value=A289678.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289678.Bytes);
public long this[int i]=>Value[i];

public static A289678Inst Instance=new A289678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289679
{
public static readonly BigInteger[] Value={ 1L,2L,10L,75L,728L,8526L,115764L,1776060L,30240210L,563870450L,11397261720L,247700513242L,5750374629244L,141819106313800L,3698639651089800L,101603353693132215L,2929908721122796680L,BigInteger.Parse("88427704298354261610"),BigInteger.Parse("2785943404258558905900"),BigInteger.Parse("91410200883108291556680"),BigInteger.Parse("3117102657076175159955420") };
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
public class A289679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289679Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A289679.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289679.Bytes);
public BigInteger this[int i]=>Value[i];

public static A289679Inst Instance=new A289679Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289680
{
public static readonly BigInteger[] Value={ 1L,2L,10L,70L,630L,6864L,87087L,1254110L,20128680L,355185012L,6817706350L,141150702840L,3130281211300L,73933388090280L,1850739337395090L,48898191857790150L,1358695827817964130L,BigInteger.Parse("39579468688851814800"),BigInteger.Parse("1205409232277565987210"),BigInteger.Parse("38286822212810480963940"),BigInteger.Parse("1265497066771343361031440") };
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
public class A289680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289680Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A289680.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289680.Bytes);
public BigInteger this[int i]=>Value[i];

public static A289680Inst Instance=new A289680Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289681
{
public static readonly long[] Value={ 1L,2L,6L,23L,108L,618L,4092L,30413L,252590L,2297954L,22640259L,240084189L,2721455329L,32783910297L };
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
public class A289681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289681Inst : IEnumerable<long>
{
public static readonly long[] Value=A289681.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289681.Bytes);
public long this[int i]=>Value[i];

public static A289681Inst Instance=new A289681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289682
{
public static readonly long[] Value={ 1L,1L,2L,5L,14L,10L,4L,13L,6L,14L,12L,2L,12L,4L,8L,13L,6L,6L,12L,6L,4L,12L,8L,2L,12L,12L,8L,4L,8L,8L,0L,13L,6L,6L,12L,14L,4L,12L,8L,6L,4L,4L,8L,12L,8L,8L,0L,2L,12L,12L,8L,12L,8L,8L,0L,4L,8L,8L,0L,8L,0L,0L,0L,13L,6L,6L,12L,14L,4L,12L,8L,14L,4L,4L,8L,12L,8L,8L,0L,6L,4L,4L,8L,4L,8L,8L,0L,12L };
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
public class A289682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289682Inst : IEnumerable<long>
{
public static readonly long[] Value=A289682.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289682.Bytes);
public long this[int i]=>Value[i];

public static A289682Inst Instance=new A289682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289683
{
public static readonly BigInteger[] Value={ 1L,1L,3L,18L,171L,2250L,37935L,780570L,18967095L,531545490L,16877619675L,598825908450L,23479803807075L,1008211866111450L,47052981361160775L,2371481399995958250L,BigInteger.Parse("128370589834339227375"),BigInteger.Parse("7427764736129937449250"),BigInteger.Parse("457497972176819368669875") };
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
public class A289683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289683Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A289683.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289683.Bytes);
public BigInteger this[int i]=>Value[i];

public static A289683Inst Instance=new A289683Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289684
{
public static readonly long[] Value={ 1L,2L,9L,42L,199L,950L,4554L,21884L,105323L,507398L,2446022L,11796884L,56912838L,274630876L,1325431956L,6397576888L,30882340531L,149084312006L,719736965358L,3474807470756L,16776410481266L,80998307687668L,391074406408716L,1888199373821896L,9116752061308798L };
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
public class A289684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289684Inst : IEnumerable<long>
{
public static readonly long[] Value=A289684.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289684.Bytes);
public long this[int i]=>Value[i];

public static A289684Inst Instance=new A289684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289685
{
public static readonly long[] Value={ 17L,19L,23L,31L,37L,47L,65L,151L,157L,251L,283L,371L,391L,635L,779L,799L,1517L,1799L,3355L,24619L,40375L,40793L };
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
public class A289685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289685Inst : IEnumerable<long>
{
public static readonly long[] Value=A289685.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289685.Bytes);
public long this[int i]=>Value[i];

public static A289685Inst Instance=new A289685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289686
{
public static readonly long[] Value={ 9L,11L,13L,15L,19L,27L,35L,39L,45L,51L,83L,99L,105L,111L,121L,123L,127L,133L,175L,177L,213L,263L,277L,285L,339L,347L,543L,681L,743L,1069L,1965L,2379L,2613L,2629L,2911L,3767L,3879L,4789L,5493L,5819L,11559L,14555L,17831L,19705L,24867L,37535L };
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
public class A289686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289686Inst : IEnumerable<long>
{
public static readonly long[] Value=A289686.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289686.Bytes);
public long this[int i]=>Value[i];

public static A289686Inst Instance=new A289686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289687
{
public static readonly long[] Value={ 8L,10L,16L,22L,26L,46L,52L,56L,70L,74L,286L,302L,308L,484L,698L,1100L,1226L,1528L,2486L,3796L,4256L,8524L,10688L,19424L,22226L,49346L };
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
public class A289687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289687Inst : IEnumerable<long>
{
public static readonly long[] Value=A289687.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289687.Bytes);
public long this[int i]=>Value[i];

public static A289687Inst Instance=new A289687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289688
{
public static readonly long[] Value={ 11L,13L,23L,29L,35L,37L,49L,95L,97L,101L,113L,133L,137L,361L,401L,701L,1027L,1331L,2087L,2743L,7781L,9391L,12787L,12797L,16123L,17317L,21701L,49657L };
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
public class A289688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289688Inst : IEnumerable<long>
{
public static readonly long[] Value=A289688.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289688.Bytes);
public long this[int i]=>Value[i];

public static A289688Inst Instance=new A289688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289689
{
public static readonly long[] Value={ 9L,15L,17L,65L,129L,135L,209L,225L,327L,357L,423L,1061L,1143L,3629L,4937L,6713L,33123L };
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
public class A289689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289689Inst : IEnumerable<long>
{
public static readonly long[] Value=A289689.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289689.Bytes);
public long this[int i]=>Value[i];

public static A289689Inst Instance=new A289689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289690
{
public static readonly long[] Value={ 5L,1L,2L,12L,0L };
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
public class A289690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289690Inst : IEnumerable<long>
{
public static readonly long[] Value=A289690.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289690.Bytes);
public long this[int i]=>Value[i];

public static A289690Inst Instance=new A289690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289691
{
public static readonly long[] Value={ 12L,30L,40L,45L,56L,63L,70L,105L,154L,165L,175L,176L,182L,195L,198L,208L,220L,231L,234L,260L,273L,275L,286L,297L,306L,325L,340L,351L,357L,374L,380L,385L,399L,418L,425L };
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
public class A289691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289691Inst : IEnumerable<long>
{
public static readonly long[] Value=A289691.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289691.Bytes);
public long this[int i]=>Value[i];

public static A289691Inst Instance=new A289691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289840
{
public static readonly long[] Value={ 0L,1L,3L,11L,19L,27L,35L,67L,83L,99L,115L,163L,179L,195L,211L,275L,323L,355L,387L,467L,483L,499L,515L,579L,627L,675L,707L,787L,803L,819L,835L,899L,947L,995L,1027L,1107L,1123L,1139L,1155L,1219L,1267L,1315L,1347L,1427L,1443L,1459L,1475L,1539L,1587L,1635L,1667L,1747L,1763L,1779L,1795L,1859L,1907L,1955L,1987L,2067L };
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
public class A289840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289840Inst : IEnumerable<long>
{
public static readonly long[] Value=A289840.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289840.Bytes);
public long this[int i]=>Value[i];

public static A289840Inst Instance=new A289840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289841
{
public static readonly long[] Value={ 0L,1L,2L,8L,8L,8L,8L,32L,16L,16L,16L,48L,16L,16L,16L,64L,48L,32L,32L,80L,16L,16L,16L,64L,48L,48L,32L,80L,16L,16L,16L,64L,48L,48L,32L,80L,16L,16L,16L,64L,48L,48L,32L,80L,16L,16L,16L,64L,48L,48L,32L,80L,16L,16L,16L,64L,48L,48L,32L,80L,16L,16L,16L,64L,48L,48L,32L,80L,16L,16L,16L,64L,48L,48L,32L,80L,16L,16L,16L,64L,48L };
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
public class A289841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289841Inst : IEnumerable<long>
{
public static readonly long[] Value=A289841.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289841.Bytes);
public long this[int i]=>Value[i];

public static A289841Inst Instance=new A289841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289843
{
public static readonly long[] Value={ 1L,2L,5L,13L,29L,73L,168L,410L,962L,2317L,5483L,13131L,31193L,74509L,177311L,423025L,1007505L,2402354L,5723761L,13644587L,32514730L,77501115L,184698088L,440216833L,1049148789L,2500520812L,5959478837L,14203542282L,33851496564L,80679640434L,192285583548L };
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
public class A289843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289843Inst : IEnumerable<long>
{
public static readonly long[] Value=A289843.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289843.Bytes);
public long this[int i]=>Value[i];

public static A289843Inst Instance=new A289843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289844
{
public static readonly long[] Value={ 1L,2L,3L,7L,16L,31L,64L,134L,274L,567L,1168L,2405L,4967L,10232L,21094L,43505L,89672L,184892L,381203L,785886L,1620327L,3340606L,6887304L,14199737L,29275538L,60357622L,124439898L,256558196L,528948160L,1090536002L,2248364880L,4635470266L,9556979689L,19703689739L };
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
public class A289844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289844Inst : IEnumerable<long>
{
public static readonly long[] Value=A289844.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289844.Bytes);
public long this[int i]=>Value[i];

public static A289844Inst Instance=new A289844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289845
{
public static readonly long[] Value={ 1L,2L,4L,9L,19L,43L,91L,202L,433L,952L,2055L,4494L,9737L,21236L,46099L,100403L,218164L,474833L,1032256L,2245929L,4883690L,10623848L,23103985L,50255443L,109298635L,237734446L,517055409L,1124617945L,2446001258L,5320100761L,11571106298L,25167245524L,54738437517L };
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
public class A289845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289845Inst : IEnumerable<long>
{
public static readonly long[] Value=A289845.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289845.Bytes);
public long this[int i]=>Value[i];

public static A289845Inst Instance=new A289845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289846
{
public static readonly long[] Value={ 1L,2L,4L,9L,18L,39L,80L,170L,353L,744L,1553L,3262L,6824L,14313L,29970L,62823L,131596L,275782L,577777L,1210704L,2536657L,5315210L,11136700L,23334969L,48893202L,102446199L,214654136L,449764562L,942387569L,1974580920L,4137324929L,8668915558L,18163921856L };
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
public class A289846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289846Inst : IEnumerable<long>
{
public static readonly long[] Value=A289846.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289846.Bytes);
public long this[int i]=>Value[i];

public static A289846Inst Instance=new A289846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289847
{
public static readonly long[] Value={ 2L,11L,53L,253L,1205L,5740L,27336L,130200L,620129L,2953634L,14067934L,67004505L,319137367L,1520027050L,7239773429L,34482491204L,164237487721L,782250685197L,3725800625523L,17745705518523L,84521448139914L,402569240665810L,1917406730442806L,9132462688572345L };
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
public class A289847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289847Inst : IEnumerable<long>
{
public static readonly long[] Value=A289847.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289847.Bytes);
public long this[int i]=>Value[i];

public static A289847Inst Instance=new A289847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289848
{
public static readonly long[] Value={ 2L,5L,1L,5L,4L,7L,6L,9L,1L,0L,7L,7L,2L,7L,2L,1L,7L,4L,6L,7L,2L,1L,4L,8L,8L,1L,2L,6L,4L,6L,7L,9L,1L,9L,4L,7L,7L,6L,7L,8L,6L,9L,4L,4L,1L,0L,4L,1L,2L,0L,4L,9L,6L,2L,6L,7L,1L,6L,0L,7L,2L,2L,8L,9L,9L,8L,5L,4L,6L,4L,0L,1L,6L,7L,8L,9L,4L,4L,9L,2L,4L,2L,7L,6L,6L,0L };
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
public class A289848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289848Inst : IEnumerable<long>
{
public static readonly long[] Value=A289848.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289848.Bytes);
public long this[int i]=>Value[i];

public static A289848Inst Instance=new A289848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289849
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,2L,4L,3L,4L,2L,5L,2L,4L,4L,5L,2L,6L,2L,5L,4L,4L,2L,6L,3L,4L,4L,5L,2L };
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
public class A289849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289849Inst : IEnumerable<long>
{
public static readonly long[] Value=A289849.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289849.Bytes);
public long this[int i]=>Value[i];

public static A289849Inst Instance=new A289849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289850
{
public static readonly BigInteger[] Value={ 11L,101L,941L,10391L,135131L,2027021L,654729071L,7905853580621L,BigInteger.Parse("221643095476699771871"),BigInteger.Parse("79777941814291672401518892224505807820921910393015244140621"),BigInteger.Parse("6462013286957625464523030270184970433494674741834234775390621") };
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
public class A289850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289850Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A289850.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289850.Bytes);
public BigInteger this[int i]=>Value[i];

public static A289850Inst Instance=new A289850Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289851
{
public static readonly BigInteger[] Value={ 7L,97L,937L,654729067L,BigInteger.Parse("13113070457687988603440617"),BigInteger.Parse("563862029680583509947946867"),BigInteger.Parse("536347102817482913555411512425352545980058003572241486357421867"),BigInteger.Parse("352999527454840466971061863960307904899505075341088595453568994140617") };
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
public class A289851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289851Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A289851.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289851.Bytes);
public BigInteger this[int i]=>Value[i];

public static A289851Inst Instance=new A289851Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289852
{
public static readonly BigInteger[] Value={ 89L,929L,135119L,34459409L,7905853580609L,BigInteger.Parse("669325572332691496707919692320662308340434243618803739488329723923351785805848442856791239207612629457179653299076271283992814866750698368061459208762618124485015869140609") };
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
public class A289852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289852Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A289852.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289852.Bytes);
public BigInteger this[int i]=>Value[i];

public static A289852Inst Instance=new A289852Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289853
{
public static readonly BigInteger[] Value={ 73L,BigInteger.Parse("25373791335626257947657609343"),BigInteger.Parse("488960130368663401543922783473071784646213671843"),BigInteger.Parse("2783097421140216173669833173554685254745646937315554685903182520041762334418182818434647284243799923238034037601108551025390593") };
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
public class A289853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289853Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A289853.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289853.Bytes);
public BigInteger this[int i]=>Value[i];

public static A289853Inst Instance=new A289853Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289854
{
public static readonly BigInteger[] Value={ 41L,881L,10331L,34459361L,13749310511L,213458046676811L,6190283353629311L,BigInteger.Parse("319830986772877770815561"),BigInteger.Parse("563862029680583509947946811"),BigInteger.Parse("25373791335626257947657609311"),BigInteger.Parse("488960130368663401543922783473071784646213671811") };
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
public class A289854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289854Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A289854.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289854.Bytes);
public BigInteger this[int i]=>Value[i];

public static A289854Inst Instance=new A289854Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289855
{
public static readonly BigInteger[] Value={ 10267L,135007L,13749310447L,BigInteger.Parse("1192568192774434123539907640497"),BigInteger.Parse("29215606371473169285018060091249259296747"),BigInteger.Parse("1009847364737869270905302433221592504062302663202724609247"),BigInteger.Parse("34720596058582394465875230149026168047833371128291024141249287753332469144201839599609247") };
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
public class A289855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289855Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A289855.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289855.Bytes);
public BigInteger this[int i]=>Value[i];

public static A289855Inst Instance=new A289855Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289856
{
public static readonly BigInteger[] Value={ 10139L,2026769L,13749310319L,213458046676619L,191898783962510369L,BigInteger.Parse("157952079428395476360490147277859119"),BigInteger.Parse("29215606371473169285018060091249259296619"),BigInteger.Parse("2395415678676082004163677716234578672981800778515369") };
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
public class A289856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289856Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A289856.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289856.Bytes);
public BigInteger this[int i]=>Value[i];

public static A289856Inst Instance=new A289856Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289889
{
public static readonly long[] Value={ 1L,1L,11L,1L,101L,11L,1101L,111L,10001L,1111L,111011L,10011L,1010011L,111111L,11011111L,1001111L,100011111L,11001111L,1110111111L,100001111L,10100010111L,1110011111L,110110110111L,10011111111L,1000110000111L,110000111111L,11101100100111L,1000000111111L };
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
public class A289889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289889Inst : IEnumerable<long>
{
public static readonly long[] Value=A289889.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289889.Bytes);
public long this[int i]=>Value[i];

public static A289889Inst Instance=new A289889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289890
{
public static readonly ulong[] Value={ 1L,10L,110L,1000L,10100L,110000L,1011000L,11100000L,100010000L,1111000000L,11011100000L,110010000000L,1100101000000L,11111100000000L,111110110000000L,1111001000000000L,11111000100000000L,111100110000000000L,1111110111000000000L,11110000100000000000UL };
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
public class A289890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289890Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A289890.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289890.Bytes);
public ulong this[int i]=>Value[i];

public static A289890Inst Instance=new A289890Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289891
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,3L,13L,7L,17L,15L,59L,19L,83L,63L,223L,79L,287L,207L,959L,271L,1303L,927L,3511L,1279L,4487L,3135L,15143L,4159L,21479L,15423L,57319L,19519L,73703L,49215L,245735L,65599L,344039L,245823L,917479L,311359L,1179623L,786495L,3932135L,1048639L,5504999L };
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
public class A289891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289891Inst : IEnumerable<long>
{
public static readonly long[] Value=A289891.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289891.Bytes);
public long this[int i]=>Value[i];

public static A289891Inst Instance=new A289891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289892
{
public static readonly long[] Value={ 1L,2L,6L,8L,20L,48L,88L,224L,272L,960L,1760L,3200L,6464L,16128L,32128L,61952L,127232L,248832L,519680L,985088L,1905664L,4091904L,7788544L,16719872L,29560832L,66109440L,119988224L,264273920L,486096896L,1057947648L,1945993216L,4231135232L,7783645184L };
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
public class A289892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289892Inst : IEnumerable<long>
{
public static readonly long[] Value=A289892.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289892.Bytes);
public long this[int i]=>Value[i];

public static A289892Inst Instance=new A289892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289893
{
public static readonly long[] Value={ 1L,3L,3L,2L,23L,18L,6L,270L,166L,28L,4842L,2532L,244L,120052L,49620L,2544L,3852972L };
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
public class A289893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289893Inst : IEnumerable<long>
{
public static readonly long[] Value=A289893.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289893.Bytes);
public long this[int i]=>Value[i];

public static A289893Inst Instance=new A289893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289894
{
public static readonly long[] Value={ 0L,6L,396L,201810L };
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
public class A289894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289894Inst : IEnumerable<long>
{
public static readonly long[] Value=A289894.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289894.Bytes);
public long this[int i]=>Value[i];

public static A289894Inst Instance=new A289894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289895
{
public static readonly long[] Value={ 0L,1L,5L,6L,14L,15L,19L,20L,30L,31L,35L,36L,44L,45L,49L,50L,55L,56L,60L,61L,69L,70L,74L,75L,85L,86L,90L,91L,92L,96L,97L,99L,100L,104L,105L,106L,110L,111L,121L,122L,126L,127L,135L,136L,140L,141L,145L,146L,147L,151L,152L,154L,155L,159L,160L,161L,165L,166L,170L,171L,175L,176L,177L,181L,182L,184L,185L,189L,190L,191L,195L,196L,200L };
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
public class A289895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289895Inst : IEnumerable<long>
{
public static readonly long[] Value=A289895.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289895.Bytes);
public long this[int i]=>Value[i];

public static A289895Inst Instance=new A289895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289896
{
public static readonly BigInteger[] Value={ 0L,0L,1L,8L,45L,242L,1414L,9432L,72246L,628260L,6116319L,65856928L,776628203L,9950798214L,137612550620L,2042588039056L,32384583304092L,546155914771464L,9761655297881037L,184309987662192600L,3665514979650544153L,BigInteger.Parse("76586509823743735706"),BigInteger.Parse("1677182881414143407490") };
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
public class A289896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289896Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A289896.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289896.Bytes);
public BigInteger this[int i]=>Value[i];

public static A289896Inst Instance=new A289896Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289897
{
public static readonly BigInteger[] Value={ 1L,2L,8L,80L,2080L,158080L,36674560L,28019363840L,73410733260800L,697108323044556800L,BigInteger.Parse("24883978699398499532800"),BigInteger.Parse("3487539382678098506520985600"),BigInteger.Parse("1982680089210029713351206397542400"),BigInteger.Parse("4739557099654791829171791869197156352000") };
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
public class A289897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289897Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A289897.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289897.Bytes);
public BigInteger this[int i]=>Value[i];

public static A289897Inst Instance=new A289897Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289898
{
public static readonly long[] Value={ 2L,2L,2L,11L,3L,12L,3L,12L,59L,3L,51L,15L,3L,12L,59L,62L,3L,51L,15L,3L,50L,15L,60L,251L,15L,3L,12L,3L,12L,15179L,15L,60L,3L,816L,3L,51L,62L,15L,60L,62L,3L,816L,3L,12L,3L,3226L,4094L,15L,3L,12L,59L,3L,816L,63L,63L,63L,3L,51L,15L,3L,808L,16363L,15L,3L,12L,15183L };
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
public class A289898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289898Inst : IEnumerable<long>
{
public static readonly long[] Value=A289898.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289898.Bytes);
public long this[int i]=>Value[i];

public static A289898Inst Instance=new A289898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289899
{
public static readonly long[] Value={ 71L,1093L,4871L };
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
public class A289899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289899Inst : IEnumerable<long>
{
public static readonly long[] Value=A289899.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289899.Bytes);
public long this[int i]=>Value[i];

public static A289899Inst Instance=new A289899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289900
{
public static readonly BigInteger[] Value={ 1L,1L,3L,9L,135L,2025L,212625L,22325625L,21097715625L,19937341265625L,207248662456171875L,BigInteger.Parse("2154349846231906640625"),BigInteger.Parse("291128066470548703880859375"),BigInteger.Parse("39341591262497599098939931640625"),BigInteger.Parse("79746389028864195813528714933837890625") };
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
public class A289900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289900Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A289900.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289900.Bytes);
public BigInteger this[int i]=>Value[i];

public static A289900Inst Instance=new A289900Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289901
{
public static readonly long[] Value={ 0L,0L,0L,2L,9L,30L,103L,435L,2469L,18958L,194091L,2661243L,49287232L };
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
public class A289901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289901Inst : IEnumerable<long>
{
public static readonly long[] Value=A289901.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289901.Bytes);
public long this[int i]=>Value[i];

public static A289901Inst Instance=new A289901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289902
{
public static readonly long[] Value={ 1L,1L,27L,441L,9261L,421875L,47177249L,10546683057L };
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
public class A289902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289902Inst : IEnumerable<long>
{
public static readonly long[] Value=A289902.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289902.Bytes);
public long this[int i]=>Value[i];

public static A289902Inst Instance=new A289902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289903
{
public static readonly long[] Value={ 1L,3L,3L,3L,3L,6L,9L,9L,9L,10L,15L,18L,18L,18L,21L,28L,30L,30L,34L,36L,45L,45L,48L,51L,55L,63L,63L,70L,75L,78L };
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
public class A289903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289903Inst : IEnumerable<long>
{
public static readonly long[] Value=A289903.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289903.Bytes);
public long this[int i]=>Value[i];

public static A289903Inst Instance=new A289903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A289904
{
public static readonly BigInteger[] Value={ 0L,0L,1L,16L,4913L,13481272L,272624565213L,43591165915025672L,BigInteger.Parse("54987285852263666792584") };
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
public class A289904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A289904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A289904Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A289904.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A289904.Bytes);
public BigInteger this[int i]=>Value[i];

public static A289904Inst Instance=new A289904Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290044
{
public static readonly BigInteger[] Value={ 1L,1L,7L,41L,343L,3497L,42583L,602537L,9719383L,176075177L,3539816023L,78209790377L,1883780763223L,49127973630377L,1379201149390423L,41470672541233577L,329725285558734423L,BigInteger.Parse("45290937289840177577"),BigInteger.Parse("1633052915424520654423"),BigInteger.Parse("62144013487721190961577") };
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
public class A290044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290044Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A290044.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290044.Bytes);
public BigInteger this[int i]=>Value[i];

public static A290044Inst Instance=new A290044Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290045
{
public static readonly long[] Value={ 7L,41L,176075177L,49127973630377L };
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
public class A290045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290045Inst : IEnumerable<long>
{
public static readonly long[] Value=A290045.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290045.Bytes);
public long this[int i]=>Value[i];

public static A290045Inst Instance=new A290045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290046
{
public static readonly BigInteger[] Value={ 1L,2L,46L,899L,45181L,1981844L,183812716L,13565497859L,1948425055741L,11509621621134L,42638364069002866L,6290021506693847759L,BigInteger.Parse("1672053831207666984241"),BigInteger.Parse("318158932941670103831384"),BigInteger.Parse("106827312624343125411048616"),BigInteger.Parse("25266964023001914822246560759") };
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
public class A290046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290046Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A290046.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290046.Bytes);
public BigInteger this[int i]=>Value[i];

public static A290046Inst Instance=new A290046Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290047
{
public static readonly BigInteger[] Value={ 2L,45181L,6290021506693847759L,BigInteger.Parse("25266964023001914822246560759"),BigInteger.Parse("10384129888710330539039375199241") };
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
public class A290047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290047Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A290047.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290047.Bytes);
public BigInteger this[int i]=>Value[i];

public static A290047Inst Instance=new A290047Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290048
{
public static readonly long[] Value={ 1L,-552L,8640L,116000L,-4868460L,67855536L,-544522240L,2742137280L,-8237774250L,10592091400L,3366617856L,113971542048L,-1217020425880L,4535746506000L,-5415752171520L,-19090509870144L,93580817811453L,-142801363479240L,-80721277168000L,665065363025280L };
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
public class A290048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290048Inst : IEnumerable<long>
{
public static readonly long[] Value=A290048.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290048.Bytes);
public long this[int i]=>Value[i];

public static A290048Inst Instance=new A290048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290049
{
public static readonly BigInteger[] Value={ 691L,214776L,10042488L,-31595258016L,-37453557900168L,-14820419119618224L,-2593285239712936608L,BigInteger.Parse("-222297419357081232192"),BigInteger.Parse("-10663770067272328258440"),BigInteger.Parse("-324599563661107722245352"),BigInteger.Parse("-6891830216922929182318512"),BigInteger.Parse("-109326152051786546417315808") };
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
public class A290049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290049Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A290049.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290049.Bytes);
public BigInteger this[int i]=>Value[i];

public static A290049Inst Instance=new A290049Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290050
{
public static readonly BigInteger[] Value={ 477481L,-150101784L,136249055208L,-63604855321056L,-195358116440088L,-7467654553124192784L,BigInteger.Parse("-1717686223249005340128"),BigInteger.Parse("-153060438018813351348672"),BigInteger.Parse("-7369907929791849766742040"),BigInteger.Parse("-224318806535938497072194232"),BigInteger.Parse("-4762271485690855450838091792") };
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
public class A290050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290050Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A290050.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290050.Bytes);
public BigInteger this[int i]=>Value[i];

public static A290050Inst Instance=new A290050Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290051
{
public static readonly long[] Value={ 6L,2L,294L,2L,126L,112L,310L,14L,150L,840L,3200L,98L,45360L,10500L,57120L,40320L,242250L,9548L,21839790L,3756480L,200425680L,678810L,1359540L };
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
public class A290051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290051Inst : IEnumerable<long>
{
public static readonly long[] Value=A290051.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290051.Bytes);
public long this[int i]=>Value[i];

public static A290051Inst Instance=new A290051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290052
{
public static readonly long[] Value={ 1L,1L,4L,23L,139L,860L,5393L,34142L,217717L,1396346L,8997695L,58205686L,377775385L,2458841504L,16043226825L,104901986083L,687221188145L,4509605878736L,29636894936761L,195035340954186L,1285062484293880L,8476508261617168L,55969236979211755L,369900194873712830L };
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
public class A290052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290052Inst : IEnumerable<long>
{
public static readonly long[] Value=A290052.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290052.Bytes);
public long this[int i]=>Value[i];

public static A290052Inst Instance=new A290052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290053
{
public static readonly long[] Value={ 1L,1L,0L,1L,-2L,3L,1L,-5L,10L,0L,1L,-9L,31L,-39L,40L,1L,-14L,77L,-196L,252L,0L,1L,-20L,162L,-664L,1457L,-1476L,1260L,1L,-27L,303L,-1809L,6168L,-11772L,12176L,0L,1L,-35L,520L,-4250L,20773L,-61595L,107730L,-95400L,72576L,1L,-44L,836L,-8954L,59279L,-249986L };
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
public class A290053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290053Inst : IEnumerable<long>
{
public static readonly long[] Value=A290053.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290053.Bytes);
public long this[int i]=>Value[i];

public static A290053Inst Instance=new A290053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290054
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,2L,0L,0L,1L,3L,1L,0L,0L,1L,4L,3L,0L,0L,0L,1L,5L,6L,1L,0L,0L,0L,1L,6L,10L,4L,0L,0L,0L,0L,1L,7L,15L,10L,1L,0L,0L,0L,0L,1L,8L,21L,20L,5L,0L,0L,0L,1L,0L,1L,9L,28L,35L,15L,1L,0L,0L,2L,0L,0L,1L,10L,36L,56L,35L,6L,0L,0L,3L,2L,0L,0L,1L,11L,45L,84L,70L,21L,1L,0L,4L,6L,0L,0L,0L };
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
public class A290054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290054Inst : IEnumerable<long>
{
public static readonly long[] Value=A290054.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290054.Bytes);
public long this[int i]=>Value[i];

public static A290054Inst Instance=new A290054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290055
{
public static readonly long[] Value={ 0L,1L,5L,10L,26L,40L,80L,110L,190L,245L,385L,476L,700L,840L,1176L,1380L,1860L,2145L,2805L,3190L,4070L,4576L,5720L,6370L,7826L,8645L,10465L,11480L,13720L,14960L,17680L,19176L,22440L,24225L,28101L,30210L,34770L,37240L,42560L,45430L,51590L,54901L,61985L,65780L,73876L,78200L,87400L,92300L,102700L,108225L,119925L,126126L };
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
public class A290055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290055Inst : IEnumerable<long>
{
public static readonly long[] Value=A290055.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290055.Bytes);
public long this[int i]=>Value[i];

public static A290055Inst Instance=new A290055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290056
{
public static readonly long[] Value={ 1L,2L,8L,27L,76L,192L,456L,1045L,2344L,5186L,11364L,24719L,53444L,114948L,246096L,524713L,1114640L,2359942L,4981516L,10486691L,22021196L,46138632L,96470488L,201328317L,419432376L,872417482L,1811941876L,3758099255L,7784631444L,16106130956L,33286000544L };
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
public class A290056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290056Inst : IEnumerable<long>
{
public static readonly long[] Value=A290056.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290056.Bytes);
public long this[int i]=>Value[i];

public static A290056Inst Instance=new A290056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290057
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,4L,3L,1L,1L,5L,13L,23L,30L,30L,23L,13L,5L,1L,1L,7L,26L,68L,139L,234L,334L,411L,440L,411L,334L,234L,139L,68L,26L,7L,1L,1L,9L,43L,145L,386L,860L,1660L,2838L,4362L,6090L,7779L,9135L,9892L,9892L,9135L,7779L,6090L,4362L,2838L,1660L,860L,386L,145L,43L,9L,1L };
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
public class A290057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290057Inst : IEnumerable<long>
{
public static readonly long[] Value=A290057.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290057.Bytes);
public long this[int i]=>Value[i];

public static A290057Inst Instance=new A290057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290058
{
public static readonly BigInteger[] Value={ 1L,1L,4L,30L,440L,9892L,331950L,15121926L,915201732L,70120569074L,6696969703276L,774618119733020L,107284227278413622L,17455779156567652806UL,BigInteger.Parse("3307802489634916900474"),BigInteger.Parse("720231707823173636419042"),BigInteger.Parse("178973636259170839478327332"),BigInteger.Parse("50249140887232774758578932120") };
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
public class A290058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290058Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A290058.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290058.Bytes);
public BigInteger this[int i]=>Value[i];

public static A290058Inst Instance=new A290058Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290059
{
public static readonly BigInteger[] Value={ 3L,10L,126L,1716L,352716L,5200300L,1166803110L,17672631900L,4116715363800L,15033633249770520L,232714176627630544L,BigInteger.Parse("873065282167813104916"),BigInteger.Parse("212392290424395860814420"),BigInteger.Parse("3318776542511877736535400"),BigInteger.Parse("812850570172585125274307760"),BigInteger.Parse("3136262529306125724764953838760") };
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
public class A290059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290059Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A290059.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290059.Bytes);
public BigInteger this[int i]=>Value[i];

public static A290059Inst Instance=new A290059Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290093
{
public static readonly long[] Value={ 1L,3L,2L,3L,10L,5L,2L,5L,7L,3L,21L,5L,10L,36L,14L,5L,27L,12L,2L,5L,16L,5L,14L,23L,7L,12L,29L,3L,21L,5L,21L,78L,27L,5L,27L,12L,10L,78L,14L,36L,136L,44L,14L,90L,25L,5L,27L,23L,27L,90L,61L,12L,42L,38L,2L,5L,16L,5L,14L,23L,16L,23L,67L,5L,27L,23L,14L,44L,40L,23L,61L,80L,7L,12L,67L,12L,25L,80L,29L,38L,121L,3L,21L,5L,21L,78L,27L,5L,27L,12L,21L,465L,27L,78L,300L,90L,27L };
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
public class A290093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290093Inst : IEnumerable<long>
{
public static readonly long[] Value=A290093.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290093.Bytes);
public long this[int i]=>Value[i];

public static A290093Inst Instance=new A290093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290094
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,5L,3L,5L,6L,2L,7L,5L,4L,8L,9L,5L,10L,11L,3L,5L,12L,5L,9L,13L,6L,11L,14L,2L,7L,5L,7L,15L,10L,5L,10L,11L,4L,15L,9L,8L,16L,17L,9L,18L,19L,5L,10L,13L,10L,18L,20L,11L,21L,22L,3L,5L,12L,5L,9L,13L,12L,13L,23L,5L,10L,13L,9L,17L,24L,13L,20L,25L,6L,11L,23L,11L,19L,25L,14L,22L,26L,2L,7L,5L,7L,15L,10L,5L,10L,11L,7L,27L,10L,15L,28L,18L,10L,29L,21L,5L,10L,13L };
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
public class A290094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290094Inst : IEnumerable<long>
{
public static readonly long[] Value=A290094.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290094.Bytes);
public long this[int i]=>Value[i];

public static A290094Inst Instance=new A290094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290095
{
public static readonly long[] Value={ 2L,4L,18L,8L,8L,12L,150L,100L,54L,16L,16L,24L,54L,16L,90L,40L,36L,16L,16L,24L,40L,60L,16L,36L,1470L,980L,882L,392L,392L,588L,750L,500L,162L,32L,32L,48L,162L,32L,270L,80L,108L,32L,32L,48L,80L,120L,32L,72L,750L,500L,162L,32L,32L,48L,1050L,700L,378L,112L,112L,168L,450L,200L,162L,32L,32L,72L,200L,300L,32L,48L,108L,32L,162L,32L,270L,80L,108L,32L,378L,112L,630L,280L };
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
public class A290095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290095Inst : IEnumerable<long>
{
public static readonly long[] Value=A290095.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290095.Bytes);
public long this[int i]=>Value[i];

public static A290095Inst Instance=new A290095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290096
{
public static readonly long[] Value={ 2L,4L,12L,8L,8L,12L,60L,36L,24L,16L,16L,24L,24L,16L,60L,24L,36L,16L,16L,24L,24L,60L,16L,36L,420L,180L,180L,72L,72L,180L,120L,72L,48L,32L,32L,48L,48L,32L,120L,48L,72L,32L,32L,48L,48L,120L,32L,72L,120L,72L,48L,32L,32L,48L,420L,180L,120L,48L,48L,120L,180L,72L,48L,32L,32L,72L,72L,180L,32L,48L,72L,32L,48L,32L,120L,48L,72L,32L };
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
public class A290096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290096Inst : IEnumerable<long>
{
public static readonly long[] Value=A290096.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290096.Bytes);
public long this[int i]=>Value[i];

public static A290096Inst Instance=new A290096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290097
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,3L,5L,6L,7L,8L,8L,7L,7L,8L,5L,7L,6L,8L,8L,7L,7L,5L,8L,6L,9L,10L,10L,11L,11L,10L,12L,11L,13L,14L,14L,13L,13L,14L,12L,13L,11L,14L,14L,13L,13L,12L,14L,11L,12L,11L,13L,14L,14L,13L,9L,10L,12L,13L,13L,12L,10L,11L,13L,14L,14L,11L,11L,10L,14L,13L,11L,14L,13L,14L,12L,13L,11L,14L,12L,13L,9L,12L,10L,13L,13L,14L,10L,11L,11L,14L,14L,11L,11L,14L,10L,13L,14L };
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
public class A290097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290097Inst : IEnumerable<long>
{
public static readonly long[] Value=A290097.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290097.Bytes);
public long this[int i]=>Value[i];

public static A290097Inst Instance=new A290097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290098
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L };
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
public class A290098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290098Inst : IEnumerable<long>
{
public static readonly long[] Value=A290098.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290098.Bytes);
public long this[int i]=>Value[i];

public static A290098Inst Instance=new A290098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290099
{
public static readonly long[] Value={ 1L,-1L,2L,1L,3L,-2L,5L,-1L,4L,-3L,7L,2L,11L,-5L,6L,1L,13L,-4L,17L,3L,10L,-7L,19L,-2L,9L,-11L,8L,5L,23L,-6L,29L,-1L,14L,-13L,15L,4L,31L,-17L,22L,-3L,37L,-10L,41L,7L,12L,-19L,43L,2L,25L,-9L,26L,11L,47L,-8L,21L,-5L,34L,-23L,53L,6L,59L,-29L,20L,1L,33L,-14L,61L,13L,38L,-15L,67L,-4L,71L,-31L,18L,17L,35L,-22L,73L,3L,16L,-37L,79L,10L,39L,-41L,46L,-7L,83L,-12L,55L };
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
public class A290099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290099Inst : IEnumerable<long>
{
public static readonly long[] Value=A290099.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290099.Bytes);
public long this[int i]=>Value[i];

public static A290099Inst Instance=new A290099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290100
{
public static readonly long[] Value={ 1L,2L,12L,3L,8L,23L,381L,5L,73L,12L,187L,47L,39L,786L,537L,8L,109L,124L,2020L,23L,19L,381L,267L,81L,7768L,60L,6061L,73L,1238L,1128L,118945L,12L,1120L,187L,141L,234L,190L,3999L,18578L,39L,3394L,28L,2896L,747L,576L,537L,56496L,128L,533L,606L,9757L,109L,95L,12337L,8656L,118L,11306L,2020L,9309L,2309L,1789L,258213L,176262L,19L };
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
public class A290100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290100Inst : IEnumerable<long>
{
public static readonly long[] Value=A290100.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290100.Bytes);
public long this[int i]=>Value[i];

public static A290100Inst Instance=new A290100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290101
{
public static readonly long[] Value={ 0L,1L,6L,1L,3L,1L,11L,1L,3L,1L,8L,1L,3L,1L,11L,1L,3L,1L,6L,1L,3L,1L,8L,1L,3L,1L,16L,1L,3L,1L,19L,1L,3L,1L,6L,1L,3L,1L,11L,1L,3L,1L,8L,1L,3L,1L,16L,1L,3L,1L,6L,1L,3L,1L,8L,1L,3L,1L,11L,1L,3L,1L,19L,1L,3L,1L,6L,1L,3L,1L,13L,1L,3L,1L,8L,1L,3L,1L,13L,1L,3L,1L,6L,1L,3L,1L,8L,1L,3L,1L,11L,1L,3L,1L,13L,1L,3L,1L,6L,1L,3L,1L,16L,1L,3L,1L,8L,1L,3L };
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
public class A290101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290101Inst : IEnumerable<long>
{
public static readonly long[] Value=A290101.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290101.Bytes);
public long this[int i]=>Value[i];

public static A290101Inst Instance=new A290101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290102
{
public static readonly long[] Value={ 1L,2L,9L,2L,3L,2L,52L,2L,3L,2L,18L,2L,3L,2L,49L,2L,3L,2L,9L,2L,3L,2L,18L,2L,3L,2L,395L,2L,3L,2L,1108L,2L,3L,2L,9L,2L,3L,2L,52L,2L,3L,2L,18L,2L,3L,2L,360L,2L,3L,2L,9L,2L,3L,2L,18L,2L,3L,2L,57L,2L,3L,2L,1116L,2L,3L,2L,9L,2L,3L,2L,115L,2L,3L,2L,18L,2L,3L,2L,109L,2L,3L,2L,9L,2L,3L,2L,18L,2L,3L,2L,56L,2L,3L,2L,105L,2L,3L,2L,9L,2L,3L,2L,368L,2L,3L,2L,18L };
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
public class A290102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290102Inst : IEnumerable<long>
{
public static readonly long[] Value=A290102.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290102.Bytes);
public long this[int i]=>Value[i];

public static A290102Inst Instance=new A290102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290103
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,4L,1L,2L,3L,5L,2L,6L,4L,6L,1L,7L,2L,8L,3L,4L,5L,9L,2L,3L,6L,2L,4L,10L,6L,11L,1L,10L,7L,12L,2L,12L,8L,6L,3L,13L,4L,14L,5L,6L,9L,15L,2L,4L,3L,14L,6L,16L,2L,15L,4L,8L,10L,17L,6L,18L,11L,4L,1L,6L,10L,19L,7L,18L,12L,20L,2L,21L,12L,6L,8L,20L,6L,22L,3L,2L,13L,23L,4L,21L,14L,10L,5L,24L,6L,12L,9L,22L,15L,24L,2L,25L,4L,10L,3L,26L,14L,27L,6L,12L };
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
public class A290103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290103Inst : IEnumerable<long>
{
public static readonly long[] Value=A290103.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290103.Bytes);
public long this[int i]=>Value[i];

public static A290103Inst Instance=new A290103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290104
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,3L,1L,4L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,4L,3L,1L,1L,1L,4L,1L,1L,2L,1L,1L,1L,1L,1L,4L,1L,3L,1L,1L,1L,1L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,8L,1L,1L,2L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,4L,2L,3L,1L,1L,1L,1L,2L,1L,1L,4L,1L,1L,2L,1L,1L,2L,3L,1L,4L,1L,1L,1L };
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
public class A290104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290104Inst : IEnumerable<long>
{
public static readonly long[] Value=A290104.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290104.Bytes);
public long this[int i]=>Value[i];

public static A290104Inst Instance=new A290104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290105
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,2L,3L,1L,2L,1L,1L,1L };
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
public class A290105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290105Inst : IEnumerable<long>
{
public static readonly long[] Value=A290105.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290105.Bytes);
public long this[int i]=>Value[i];

public static A290105Inst Instance=new A290105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290106
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,3L,1L,4L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,4L,3L,1L,1L,1L,4L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,3L,1L,1L,1L,1L,1L,8L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,4L,2L,3L,1L,1L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L };
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
public class A290106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290106Inst : IEnumerable<long>
{
public static readonly long[] Value=A290106.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290106.Bytes);
public long this[int i]=>Value[i];

public static A290106Inst Instance=new A290106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290107
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,3L,2L,1L,1L,2L,1L,1L,1L,4L,1L,2L,1L,2L,1L,1L,1L,3L,2L,1L,3L,2L,1L,1L,1L,5L,1L,1L,1L,2L,1L,1L,1L,3L,1L,1L,1L,2L,2L,1L,1L,4L,2L,2L,1L,2L,1L,3L,1L,3L,1L,1L,1L,2L,1L,1L,2L,6L,1L,1L,1L,2L,1L,1L,1L,6L,1L,1L,2L,2L,1L,1L,1L,4L,4L,1L,1L,2L,1L,1L,1L,3L,1L,2L,1L,2L,1L,1L,1L,5L,1L,2L,2L,2L,1L,1L,1L,3L,1L,1L,1L,6L,1L,1L,1L,4L,1L,1L,1L,2L,2L,1L,1L,3L };
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
public class A290107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290107Inst : IEnumerable<long>
{
public static readonly long[] Value=A290107.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290107.Bytes);
public long this[int i]=>Value[i];

public static A290107Inst Instance=new A290107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290109
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,3L,2L,1L,1L,2L,1L,1L,1L,4L,1L,1L,1L,2L,1L,1L,1L,3L,2L,1L,3L,2L,1L,1L,1L,5L,1L,1L,1L,4L,1L,1L,1L,3L,1L,1L,1L,2L,2L,1L,1L,4L,2L,1L,1L,2L,1L,1L,1L,3L,1L,1L,1L,2L,1L,1L,2L,6L,1L,1L,1L,2L,1L,1L,1L,9L,1L,1L,1L,2L,1L,1L,1L,4L,4L,1L,1L,2L,1L,1L,1L,3L,1L,1L,1L,2L,1L,1L,1L,5L,1L,1L,2L,4L,1L,1L,1L,3L,1L,1L,1L,8L,1L,1L,1L,4L,1L,1L,1L,2L,2L,1L,1L,3L };
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
public class A290109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290109Inst : IEnumerable<long>
{
public static readonly long[] Value=A290109.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290109.Bytes);
public long this[int i]=>Value[i];

public static A290109Inst Instance=new A290109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290144
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,15L,43L,45L,67L,78L,205L,207L,1109L,1116L,1117L,1155L,1162L,1163L,1171L,1711L,1712L,1828L,1829L };
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
public class A290144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290144Inst : IEnumerable<long>
{
public static readonly long[] Value=A290144.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290144.Bytes);
public long this[int i]=>Value[i];

public static A290144Inst Instance=new A290144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290145
{
public static readonly long[] Value={ 30L,66L,102L,138L,174L,210L,318L,1110L,1398L,6870L,19866L,89610L,291450L,705990L };
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
public class A290145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290145Inst : IEnumerable<long>
{
public static readonly long[] Value=A290145.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290145.Bytes);
public long this[int i]=>Value[i];

public static A290145Inst Instance=new A290145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290146
{
public static readonly BigInteger[] Value={ 54L,90L,126L,162L,198L,378L,4950L,12978L,82278L,94218606L,8855754260391450L,BigInteger.Parse("645856907610421353834"),BigInteger.Parse("1350253136232108126126"),BigInteger.Parse("27709820863862780667438") };
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
public class A290146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290146Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A290146.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290146.Bytes);
public BigInteger this[int i]=>Value[i];

public static A290146Inst Instance=new A290146Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290147
{
public static readonly long[] Value={ 1L,3L,12L,66L,408L,2712L,18912L,136488L,1010784L,7637664L,58650240L,456377664L,3590674176L,28516332288L,228297907200L,1840515987072L,14929020470784L,121749590032896L,997676696045568L,8210704762960896L,67835018440593408L,562407734010335232L,4677727530446635008L };
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
public class A290147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290147Inst : IEnumerable<long>
{
public static readonly long[] Value=A290147.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290147.Bytes);
public long this[int i]=>Value[i];

public static A290147Inst Instance=new A290147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290148
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,91L,1L,11L,21L,31L,41L,51L,61L,71L,81L,92L,2L,12L,22L,32L,42L,52L,62L,72L,82L,93L,3L,13L,23L,33L,43L,53L,63L,73L,83L,94L,4L,14L,24L,34L,44L,54L,64L,74L,84L,95L,5L,15L,25L,35L,45L,55L,65L,75L,85L,96L,6L,16L,26L,36L,46L,56L,66L,76L,86L,97L,7L };
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
public class A290148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290148Inst : IEnumerable<long>
{
public static readonly long[] Value=A290148.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290148.Bytes);
public long this[int i]=>Value[i];

public static A290148Inst Instance=new A290148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290149
{
public static readonly long[] Value={ 6L,2916L,4374L,109100L,113708L,3188646L };
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
public class A290149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290149Inst : IEnumerable<long>
{
public static readonly long[] Value=A290149.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290149.Bytes);
public long this[int i]=>Value[i];

public static A290149Inst Instance=new A290149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290150
{
public static readonly long[] Value={ 2L,3L,8L,9L,11L,14L,17L,23L,29L,38L,50L,129L,164L,578L,1592L,2951L,4505L,16826L,17438L,22748L };
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
public class A290150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290150Inst : IEnumerable<long>
{
public static readonly long[] Value=A290150.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290150.Bytes);
public long this[int i]=>Value[i];

public static A290150Inst Instance=new A290150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290151
{
public static readonly long[] Value={ 5L,7L,9L,2L,11L,3L,13L,4L,17L,6L,19L,8L,23L,22L,21L,10L,25L,12L,27L,16L,15L,14L,29L,18L,31L,20L,33L,24L,37L,26L,35L,28L,39L,32L,41L,30L,43L,34L,47L,36L,53L,38L,49L,52L,51L,40L,55L,44L,57L,46L,45L,42L,59L,48L,61L,50L,63L,54L,67L,56L,65L,58L,69L,62L,71L,60L,73L,64L,79L,66L,77L,68L,81L,82L,83L,72L,85L,70L,87L,74L,75L,76L,89L,78L,91L,80L,93L,84L,97L,86L,95L,88L,99L,92L,101L };
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
public class A290151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290151Inst : IEnumerable<long>
{
public static readonly long[] Value=A290151.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290151.Bytes);
public long this[int i]=>Value[i];

public static A290151Inst Instance=new A290151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290152
{
public static readonly long[] Value={ 1L,168L,-12636L,392832L,-7335174L,92207808L,-804651624L,4626614784L,-11834988165L,-73870961696L,1115908456740L,-7498139072256L,32630722986078L,-90379426346496L,94395618447768L,450271639673856L,-2625847472007243L,6203580643521072L,-3151366507609936L };
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
public class A290152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290152Inst : IEnumerable<long>
{
public static readonly long[] Value=A290152.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290152.Bytes);
public long this[int i]=>Value[i];

public static A290152Inst Instance=new A290152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290153
{
public static readonly long[] Value={ 2L,3L,8L,12L,15L,75L,92L,123L,126L,267L,272L,525L,561L,1041L,1947L,2571L,11667L,13656L,15981L,29852L,35256L };
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
public class A290153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290153Inst : IEnumerable<long>
{
public static readonly long[] Value=A290153.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290153.Bytes);
public long this[int i]=>Value[i];

public static A290153Inst Instance=new A290153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290154
{
public static readonly long[] Value={ 6L,20L,42L,78L,118L,184L,248L,332L,428L,534L,654L,772L,906L,1052L,1208L,1388L,1562L,1754L,1958L,2164L,2396L,2638L,2896L,3144L,3424L,3682L,3986L,4304L,4622L,4976L,5286L,5652L,6002L,6374L,6748L,7148L,7532L,7934L,8356L,8786L,9224L,9684L,10158L,10618L,11114L,11604L };
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
public class A290154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290154Inst : IEnumerable<long>
{
public static readonly long[] Value=A290154.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290154.Bytes);
public long this[int i]=>Value[i];

public static A290154Inst Instance=new A290154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290155
{
public static readonly long[] Value={ 0L,10L,1100L,1101L,1110000L,1110001L,1110010L,1110011L,11101000L,11101001L,11101010L,11101011L,11101100L,11101101L,11101110L,11101111L,111100000000L,111100000001L,111100000010L,111100000011L,111100000100L,111100000101L,111100000110L,111100000111L };
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
public class A290155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290155Inst : IEnumerable<long>
{
public static readonly long[] Value=A290155.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290155.Bytes);
public long this[int i]=>Value[i];

public static A290155Inst Instance=new A290155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A290156
{
public static readonly BigInteger[] Value={ BigInteger.Parse("99202581681909167232"),BigInteger.Parse("67600144946390082339"),BigInteger.Parse("139344212815127987596"),BigInteger.Parse("306146939443427237167"),BigInteger.Parse("513091297204945307102"),BigInteger.Parse("958582449463500531865"),BigInteger.Parse("1777820686111873076134"),BigInteger.Parse("3249494432780318915101"),BigInteger.Parse("5985897568355692523100"),BigInteger.Parse("11013212687247884514335") };
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
public class A290156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A290156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A290156Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A290156.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A290156.Bytes);
public BigInteger this[int i]=>Value[i];

public static A290156Inst Instance=new A290156Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}