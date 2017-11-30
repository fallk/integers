using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A206457
{
public static readonly BigInteger[] Value={ 5L,216L,4048L,78050L,1679508L,40353460L,1073741632L,31381059366L,999999999700L,34522712143568L,1283918464548432L,51185893014090250L,2177953337809370548L,BigInteger.Parse("98526125335693358700"),BigInteger.Parse("4722366482869645212928"),BigInteger.Parse("239072435685151324846286") };
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
public class A206457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206457Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206457.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206457.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206457Inst Instance=new A206457Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206458
{
public static readonly BigInteger[] Value={ 6L,622L,16128L,390125L,10076832L,282473877L,8589932544L,282429533565L,9999999996000L,379749833577917L,15407021574579456L,665416609183171053L,BigInteger.Parse("30491346729331184928"),BigInteger.Parse("1477891880035400377125"),BigInteger.Parse("75557863725914323402752") };
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
public class A206458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206458Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206458.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206458.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206458Inst Instance=new A206458Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206459
{
public static readonly BigInteger[] Value={ 7L,1791L,64257L,1950000L,60459696L,1977314738L,68719456256L,2541865795524L,99999999950000L,4177248169342446L,184884258894932736L,8650415919381195128L,BigInteger.Parse("426878854210636550576"),BigInteger.Parse("22168378200531005606250"),BigInteger.Parse("1208925819614629174378496") };
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
public class A206459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206459Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206459.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206459.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206459Inst Instance=new A206459Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206460
{
public static readonly BigInteger[] Value={ 8L,5157L,256012L,9746876L,362750400L,13841186359L,549755617280L,22876792100667L,999999999400000L,45949729862605855L,2218611106738944000L,BigInteger.Parse("112455406951955165371"),BigInteger.Parse("5976303958948911170240"),BigInteger.Parse("332525673007965083334375") };
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
public class A206460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206460Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206460.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206460.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206460Inst Instance=new A206460Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206461
{
public static readonly BigInteger[] Value={ 9L,14849L,1020000L,48718765L,2176455745L,96888186864L,4398044676096L,205891128374562L,9999999993000000L,505447028486892844L,BigInteger.Parse("26623333280864342016"),BigInteger.Parse("1461920290375412323014"),BigInteger.Parse("83668255425284748853824") };
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
public class A206461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206461Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206461.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206461.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206461Inst Instance=new A206461Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206462
{
public static readonly long[] Value={ 2L,13L,19L,37L,67L,89L,103L,109L,127L,163L,193L,199L,211L,229L,307L,379L,389L,397L,449L,463L,467L,479L,487L,499L,509L,613L,643L,661L,683L,701L,719L,739L,757L,769L,797L,859L,877L,883L,887L,911L,929L,937L,967L,983L,997L,1009L,1093L,1109L,1163L,1201L,1237L,1279L };
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
public class A206462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206462Inst : IEnumerable<long>
{
public static readonly long[] Value=A206462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206462.Bytes);
public long this[int i]=>Value[i];

public static A206462Inst Instance=new A206462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206463
{
public static readonly long[] Value={ 1L,1L,2L,6L,19L,63L,220L,796L,2951L,11155L,42846L,166738L,655990L,2604868L,10426448L,42023678L,170407186L,694723354L,2845839124L,11707587484L,48350311989L,200377116719L,833062172188L,3473507707930L,14521668486233L,60859782366097L,255639891601242L };
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
public class A206463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206463Inst : IEnumerable<long>
{
public static readonly long[] Value=A206463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206463.Bytes);
public long this[int i]=>Value[i];

public static A206463Inst Instance=new A206463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206464
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,26L,74L,218L,672L,2126L,6908L,22876L,77100L,263514L,911992L,3189762L,11261448L,40083806L,143713968L,518594034L,1882217168L,6867064856L,25172021144L,92666294090L,342467464612L,1270183943200L,4726473541216L,17640820790092L,66025467919972L };
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
public class A206464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206464Inst : IEnumerable<long>
{
public static readonly long[] Value=A206464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206464.Bytes);
public long this[int i]=>Value[i];

public static A206464Inst Instance=new A206464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206465
{
public static readonly BigInteger[] Value={ 25L,1411L,110889L,68352739L,61244865529L,377599682448675L,3848918441303655721L,BigInteger.Parse("232902549300945882026755"),BigInteger.Parse("26631802795003317433250214201"),BigInteger.Parse("15822211869785299795988010016362883") };
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
public class A206465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206465Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206465.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206465.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206465Inst Instance=new A206465Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206466
{
public static readonly long[] Value={ 121L,1411L,11025L,106891L,958441L,8963667L,82609921L,767387611L,7109019225L,65954564131L,611588125681L,5672733227307L,52611971134921L,487976540781811L,4525907460768225L,41977494854894971L,389337236836785721L };
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
public class A206466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206466Inst : IEnumerable<long>
{
public static readonly long[] Value=A206466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206466.Bytes);
public long this[int i]=>Value[i];

public static A206466Inst Instance=new A206466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206467
{
public static readonly long[] Value={ 441L,11025L,110889L,1896129L,23707161L,356190129L,4803737481L,69030731169L,955680252921L,13523866505361L,188928681187689L,2659384141993089L,37267791691450329L,523625523775949169L,7345838128808607561L };
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
public class A206467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206467Inst : IEnumerable<long>
{
public static readonly long[] Value=A206467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206467.Bytes);
public long this[int i]=>Value[i];

public static A206467Inst Instance=new A206467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206468
{
public static readonly BigInteger[] Value={ 1849L,106891L,1896129L,68352739L,1693734025L,52552339515L,1457044540561L,43214597865811L,1240051361495769L,36294544907153707L,1052106476736321889L,BigInteger.Parse("30674877583244503491"),BigInteger.Parse("891844034416624515625"),BigInteger.Parse("25973093752500918767899") };
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
public class A206468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206468Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206468.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206468.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206468Inst Instance=new A206468Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206469
{
public static readonly BigInteger[] Value={ 7225L,958441L,23707161L,1693734025L,61244865529L,3420616959081L,144660587865049L,7310031634630729L,329657818912939449L,15990423345433902121UL,BigInteger.Parse("740325481079134598041"),BigInteger.Parse("35313542504161253544969") };
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
public class A206469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206469Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206469.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206469.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206469Inst Instance=new A206469Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206470
{
public static readonly BigInteger[] Value={ 29241L,8963667L,356190129L,52552339515L,3420616959081L,377599682448675L,30374762423377761L,2996776279527835851L,BigInteger.Parse("262356222717008105625"),BigInteger.Parse("24807486299199737090355"),BigInteger.Parse("2243325257562176033089041") };
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
public class A206470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206470Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206470.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206470.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206470Inst Instance=new A206470Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206471
{
public static readonly BigInteger[] Value={ 116281L,82609921L,4803737481L,1457044540561L,144660587865049L,30374762423377761L,3848918441303655721L,BigInteger.Parse("685519912635644947249"),BigInteger.Parse("97075380100800976220025"),BigInteger.Parse("16048326634124121062046721") };
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
public class A206471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206471Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206471.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206471.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206471Inst Instance=new A206471Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206472
{
public static readonly long[] Value={ 25L,121L,121L,441L,1411L,441L,1849L,11025L,11025L,1849L,7225L,106891L,110889L,106891L,7225L,29241L,958441L,1896129L,1896129L,958441L,29241L,116281L,8963667L,23707161L,68352739L,23707161L,8963667L,116281L,466489L,82609921L,356190129L,1693734025L };
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
public class A206472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206472Inst : IEnumerable<long>
{
public static readonly long[] Value=A206472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206472.Bytes);
public long this[int i]=>Value[i];

public static A206472Inst Instance=new A206472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206473
{
public static readonly long[] Value={ 7L,199L,1129L,1327L,19609L,19609L,31397L,155921L,360653L,370261L,370261L,1349533L,1357201L,1561919L,2010733L,15203977L,17051707L,17051707L,20831323L,20831323L,20831323L,47326693L,189695659L,189695659L,191912783L,436273009L,436273009L,436273009L,436273009L };
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
public class A206473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206473Inst : IEnumerable<long>
{
public static readonly long[] Value=A206473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206473.Bytes);
public long this[int i]=>Value[i];

public static A206473Inst Instance=new A206473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206474
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,2L,2L,1L,1L,1L,1L,3L,3L,1L,1L,0L,3L,3L,4L,4L,1L,1L,1L,1L,6L,6L,5L,5L,1L,1L,0L,4L,4L,10L,10L,6L,6L,1L,1L,1L,1L,10L,10L,15L,15L,7L,7L,1L,1L,0L,5L,5L,20L,20L,21L,21L,8L,8L,1L,1L,1L,1L,15L,15L,35L,35L,28L,28L,9L,9L,1L,1L };
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
public class A206474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206474Inst : IEnumerable<long>
{
public static readonly long[] Value=A206474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206474.Bytes);
public long this[int i]=>Value[i];

public static A206474Inst Instance=new A206474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206475
{
public static readonly long[] Value={ 0L,1L,1L,1L,-2L,4L,-1L,2L,-3L,6L,-4L,6L,-6L,2L,3L,5L,-9L,11L,-6L,0L,-2L,12L,-12L,11L,-9L,8L,-2L,10L,-20L,22L,-9L,-1L,-4L,8L,-3L,15L,-18L,6L,-4L,20L,-28L,30L,-12L,-2L,-6L,24L,-24L,21L,-22L,11L,4L,16L,-32L,20L,-10L,6L,-8L,30L,-34L,36L,-30L,12L,1L,5L,-28L,46L };
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
public class A206475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206475Inst : IEnumerable<long>
{
public static readonly long[] Value=A206475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206475.Bytes);
public long this[int i]=>Value[i];

public static A206475Inst Instance=new A206475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206476
{
public static readonly long[] Value={ 2L,6L,8L,9L,10L,11L,12L,13L,14L,18L,19L,20L,21L,24L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,59L,60L,61L,62L,64L,65L,66L,67L,68L,69L };
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
public class A206476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206476Inst : IEnumerable<long>
{
public static readonly long[] Value=A206476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206476.Bytes);
public long this[int i]=>Value[i];

public static A206476Inst Instance=new A206476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206477
{
public static readonly long[] Value={ 3L,3L,36L,76L,690L,2996L,22368L,147472L,1284653L,11006509L };
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
public class A206477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206477Inst : IEnumerable<long>
{
public static readonly long[] Value=A206477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206477.Bytes);
public long this[int i]=>Value[i];

public static A206477Inst Instance=new A206477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206478
{
public static readonly long[] Value={ 12L,8L,76L,694L,2529L,23679L,177885L,1482021L,14666021L };
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
public class A206478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206478Inst : IEnumerable<long>
{
public static readonly long[] Value=A206478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206478.Bytes);
public long this[int i]=>Value[i];

public static A206478Inst Instance=new A206478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206479
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,2L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,2L,1L,2L,1L,2L,0L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,2L,2L,2L,0L,1L,1L,1L,0L,1L,1L,0L,0L,2L,2L,0L,0L,1L,1L,0L,1L,0L,2L,0L,1L,0L,3L,0L,1L,0L,2L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L };
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
public class A206479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206479Inst : IEnumerable<long>
{
public static readonly long[] Value=A206479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206479.Bytes);
public long this[int i]=>Value[i];

public static A206479Inst Instance=new A206479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206480
{
public static readonly long[] Value={ 60L,46L,690L,2529L,67636L,184014L,2374017L,19353643L };
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
public class A206480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206480Inst : IEnumerable<long>
{
public static readonly long[] Value=A206480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206480.Bytes);
public long this[int i]=>Value[i];

public static A206480Inst Instance=new A206480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206481
{
public static readonly long[] Value={ 0L,1L,1L,7L,26L,57L,99L,159L,244L,353L,485L,647L,846L,1081L,1351L,1663L,2024L,2433L,2889L,3399L,3970L,4601L,5291L,6047L,6876L,7777L,8749L,9799L,10934L,12153L,13455L,14847L,16336L,17921L,19601L,21383L,23274L,25273L,27379L,29599L,31940L,34401L,36981L,39687L };
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
public class A206481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206481Inst : IEnumerable<long>
{
public static readonly long[] Value=A206481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206481.Bytes);
public long this[int i]=>Value[i];

public static A206481Inst Instance=new A206481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206482
{
public static readonly BigInteger[] Value={ 2L,3L,13L,61L,1021L,65521L,68719476731L,BigInteger.Parse("1427247692705959881058285969449495136382746621") };
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
public class A206482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206482Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206482.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206482.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206482Inst Instance=new A206482Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206483
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,1L,1L,2L,2L,2L,2L,2L,2L,3L,1L,2L,3L,1L,2L,2L,3L,3L,2L,3L,3L,3L,2L,2L,3L,3L,1L,3L,2L,3L,3L,2L,2L,3L,2L,3L,3L,2L,3L,4L,3L,3L,2L,2L,3L,3L,3L,1L,4L,4L,2L,2L,3L,2L,3L,3L,3L,3L,1L,4L,4L,2L,2L,4L,3L,2L,3L,3L,3L,4L,2L,3L,4L,3L,2L,4L,3L,3L,3L,3L,3L,3L,3L,2L,4L,3L,3L,4L,4L,3L,2L,3L,3L,4L,3L,3L,3L,4L,3L,4L,2L,2L,4L,3L,4L };
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
public class A206483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206483Inst : IEnumerable<long>
{
public static readonly long[] Value=A206483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206483.Bytes);
public long this[int i]=>Value[i];

public static A206483Inst Instance=new A206483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206484
{
public static readonly BigInteger[] Value={ 2L,5L,4L,116L,466L,895L,2011L,11887L,456586L,4673247L,3737L,4105421072L,84949477486L,25869451L,330137431L,7982039918L,726807741125074L,2180011073659L,144755460533L,772879344134036L,BigInteger.Parse("193884856434901466474"),324829874191095862L,70339720614511L,184390793325658393L };
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
public class A206484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206484Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206484.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206484.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206484Inst Instance=new A206484Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206485
{
public static readonly BigInteger[] Value={ 1L,3L,3L,105L,495L,1092L,2772L,18270L,774225L,8666515L,7524L,8918270907L,198041889045L,64422540L,874639920L,22416484563L,2156747215916961L,6815795571585L,475605193700L,2662311296532195L,BigInteger.Parse("698714939635041136731"),1222290775374865581L,275870385659700L,752514157132795200L };
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
public class A206485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206485Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206485.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206485.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206485Inst Instance=new A206485Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206486
{
public static readonly long[] Value={ 0L,2L,10L,10L,32L,32L,36L,36L,88L,88L,88L,106L,106L,106L,222L,140L,106L,284L,140L,268L,268L,222L,284L,370L,536L,284L,756L,330L,268L,708L,222L,490L,536L,268L,658L,1052L,370L,370L,708L,978L,284L,872L,330L,658L,1856L,756L,708L,1542L,798L,1712L,658L,872L,490L,2882L,1254L };
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
public class A206486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206486Inst : IEnumerable<long>
{
public static readonly long[] Value=A206486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206486.Bytes);
public long this[int i]=>Value[i];

public static A206486Inst Instance=new A206486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206487
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,3L,2L,2L,2L,1L,1L,3L,1L,3L,2L,2L,1L,4L,1L,4L,1L,3L,2L,6L,1L,1L,2L,2L,2L,6L,3L,2L,4L,4L,2L,6L,2L,3L,3L,2L,2L,5L,1L,3L,2L,6L,1L,4L,2L,4L,2L,4L,1L,12L,3L,2L,3L,1L,4L,6L,1L,3L,2L,6L,3L,10L,2L,6L,3L,3L,2L,12L,2L,5L,1L,4L,1L,12L,2L,4L,4L,4L,4L,12L,4L,3L,2L,4L,2L,6L,1L,3L,3L,6L,4L,6L,1L,8L,6L,2L,3L,10L,2L,6L,6L,5L,6L,6L,2L,6L,6L,2L,2L,20L,1L,6L,4L,3L,1L,12L,1L,1L,4L,12L,1L,12L,2L,2L,4L,4L,2L,6L,2L,12L,4L,6L,4L,15L,4L,4L,3L,9L,2L,12L,6L,4L,3L,6L,2L,24L,3L,4L,2L,6L };
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
public class A206487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206487Inst : IEnumerable<long>
{
public static readonly long[] Value=A206487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206487.Bytes);
public long this[int i]=>Value[i];

public static A206487Inst Instance=new A206487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206488
{
public static readonly long[] Value={ 0L,-1L,4L,4L,-12L,-12L,-12L,-12L,32L,32L,32L,32L,32L,32L,-80L,32L,32L,-80L,32L,-80L,-80L,-80L,-80L,-80L,192L,-80L,192L,-80L,-80L,192L,-80L,-80L,192L,-80L,192L,192L,-80L,-80L,192L,192L,-80L,192L,-80L,192L,-448L,192L,192L,192L,192L,-448L,192L,192L,-80L,-448L,-448L,192L,192L,192L,-80L,-448L };
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
public class A206488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206488Inst : IEnumerable<long>
{
public static readonly long[] Value=A206488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206488.Bytes);
public long this[int i]=>Value[i];

public static A206488Inst Instance=new A206488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206489
{
public static readonly long[] Value={ 0L,1L,4L,4L,64L,64L,36L,36L,1152L,1152L,1152L,656L,656L,656L,34372L,352L,656L,15236L,352L,19856L,19856L,34372L,15236L,8272L,1335008L,15236L,413904L,11028L,19856L,573408L,34372L,4240L,1335008L,19856L,809280L,226528L,8272L,8272L,573408L,322624L,15236L,328512L,11028L,809280L,18489168L,413904L,573408L,118720L,479936L,26095936L };
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
public class A206489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206489Inst : IEnumerable<long>
{
public static readonly long[] Value=A206489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206489.Bytes);
public long this[int i]=>Value[i];

public static A206489Inst Instance=new A206489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206490
{
public static readonly long[] Value={ 0L,2L,6L,6L,14L,14L,9L,9L,24L,24L,24L,19L,19L,19L,38L,12L,19L,29L,12L,31L,31L,38L,29L,24L,54L,29L,36L,24L,31L,45L,38L,15L,54L,31L,47L,34L,24L,24L,45L,38L,29L,36L,24L,47L,54L,36L,45L,29L,38L,61L,47L,36L,15L,41L,74L,29L,38L,45L,31L,52L,34L,54L,43L,18L,63L,63L,24L,38L,54L,54L,38L,39L,36L,34L,70L,29L,65L,52L };
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
public class A206490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206490Inst : IEnumerable<long>
{
public static readonly long[] Value=A206490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206490.Bytes);
public long this[int i]=>Value[i];

public static A206490Inst Instance=new A206490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206491
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,2L,3L,2L,1L,1L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,3L,4L,3L,1L,1L,1L,2L,2L,1L,1L,2L,3L,3L,1L,1L,2L,3L,3L,2L,1L,1L,4L,6L,4L,1L,1L,1L,1L,2L,1L,1L,3L,5L,5L,3L,1L,1L,1L,3L,3L,1L,1L,3L,4L,4L,3L,1L,1L,2L,4L,4L,3L,1L,1L,2L,2L,2L,2L,1L,1L,1L,2L,3L,2L,1L,1L,4L,7L,7L,4L,1L };
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
public class A206491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206491Inst : IEnumerable<long>
{
public static readonly long[] Value=A206491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206491.Bytes);
public long this[int i]=>Value[i];

public static A206491Inst Instance=new A206491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206492
{
public static readonly long[] Value={ 0L,3L,3L,9L,21L,19L,11L,25L,45L,74L,66L,49L,26L,55L,90L,134L,190L,170L,138L,97L,50L,103L,162L,230L,310L,405L,365L,310L,243L,167L,85L,173L,267L,370L,485L,615L,763L,693L,605L,502L,387L,263L,133L,269L,411L,562L,725L,903L,1099L,1316L,1204L,1071L,920L,754L,576L,389L };
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
public class A206492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206492Inst : IEnumerable<long>
{
public static readonly long[] Value=A206492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206492.Bytes);
public long this[int i]=>Value[i];

public static A206492Inst Instance=new A206492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206493
{
public static readonly long[] Value={ 1L,2L,6L,3L,24L,8L,12L,4L,20L,30L,120L,10L,40L,15L,72L,5L,60L,24L,20L,36L,36L,144L,120L,12L,252L,48L,56L,18L,180L,84L,720L,6L,336L,72L,126L,28L,60L,24L,112L,42L,240L,42L,90L,168L,192L,140L,504L,14L,63L,288L,168L,56L,30L,64L,1152L,21L,56L,210L,360L,96L,168L,840L,96L,7L,384L };
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
public class A206493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206493Inst : IEnumerable<long>
{
public static readonly long[] Value=A206493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206493.Bytes);
public long this[int i]=>Value[i];

public static A206493Inst Instance=new A206493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206494
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,3L,2L,6L,6L,4L,1L,12L,3L,8L,10L,24L,2L,30L,6L,20L,20L,5L,6L,60L,20L,15L,90L,40L,4L,60L,1L,120L,15L,10L,40L,180L,12L,30L,45L,120L,3L,120L,8L,30L,210L,36L,10L,360L,80L,140L,30L,90L,24L,630L,35L,240L,90L,24L,2L,420L,30L,6L,420L,720L,105L,105L,6L,60L,126L,280L,20L,1260L };
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
public class A206494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206494Inst : IEnumerable<long>
{
public static readonly long[] Value=A206494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206494.Bytes);
public long this[int i]=>Value[i];

public static A206494Inst Instance=new A206494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206495
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,6L,6L,8L,10L,11L,13L,17L,9L,10L,12L,14L,13L,13L,14L,19L,12L,12L,12L,16L,15L,15L,18L,21L,21L,15L,20L,22L,26L,34L,22L,29L,31L,41L,59L,18L,18L,20L,24L,28L,23L,26L,29L,37L,43L,21L,26L,26L,28L,38L,25L,30L,33L,35L,39L,51L,24L,24L,24L,24L,32L,34L,41L,41L,43L,67L,27L,30L,30L,36L,42L,42L,37L,37L,37L,38L,53L,30L,30L,40L,44L,52L,68L };
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
public class A206495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206495Inst : IEnumerable<long>
{
public static readonly long[] Value=A206495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206495.Bytes);
public long this[int i]=>Value[i];

public static A206495Inst Instance=new A206495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206496
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,1L,3L,4L,1L,6L,3L,4L,10L,1L,1L,15L,1L,10L,10L,5L,3L,10L,10L,15L,15L,10L,4L,60L,1L,1L,15L,5L,20L,45L,6L,5L,45L,20L,3L,60L,4L,15L,105L,18L,10L,15L,10L,70L,15L,45L,1L,105L,35L,20L,15L,24L,1L,210L,15L,6L,105L,1L,105L,105L,1L,15L,63L,140L };
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
public class A206496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206496Inst : IEnumerable<long>
{
public static readonly long[] Value=A206496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206496.Bytes);
public long this[int i]=>Value[i];

public static A206496Inst Instance=new A206496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206497
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,6L,2L,1L,1L,2L,1L,2L,1L,24L,2L,2L,6L,2L,2L,1L,2L,6L,2L,1L,6L,4L,1L,1L,1L,120L,1L,2L,2L,4L,2L,6L,1L,6L,1L,2L,2L,2L,2L,2L,1L,24L,8L,2L,2L,2L,24L,6L,1L,12L,6L,1L,2L,2L,2L,1L,4L,720L,1L,1L,6L,4L,2L,2L,2L,12L,2L,2L,2L,12L,2L,1L,1L,24L,24L,1L,2L,4L,2L,2L,1L,6L,6L,2L,2L,4L,1L,1L,6L,120L };
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
public class A206497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206497Inst : IEnumerable<long>
{
public static readonly long[] Value=A206497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206497.Bytes);
public long this[int i]=>Value[i];

public static A206497Inst Instance=new A206497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206498
{
public static readonly long[] Value={ 0L,2L,1L,1L,2L,2L,1L,1L,2L,2L,2L,2L,2L,2L,2L,1L,2L,3L,1L,2L,2L,2L,3L,2L,2L,3L,3L,2L,2L,3L,2L,1L,2L,2L,2L,3L,2L,2L,3L,2L,3L,3L,2L,2L,3L,3L,3L,2L,2L,3L,2L,3L,1L,4L,2L,2L,2L,3L,2L,3L,3L,2L,3L,1L,3L,3L,2L,2L,3L,3L,2L,3L,3L,3L,3L,2L,2L,4L,2L,2L,4L,3L,3L,3L,2L,3L,3L,2L,2L,4L,3L,3L,2L,3L,2L,2L,3L,3L,3L,3L,3L,3L,4L,3L,3L,2L,2L,4L,3L,3L,3L,2L,3L,3L,3L,3L,4L,2L,2L,3L };
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
public class A206498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206498Inst : IEnumerable<long>
{
public static readonly long[] Value=A206498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206498.Bytes);
public long this[int i]=>Value[i];

public static A206498Inst Instance=new A206498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206499
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,2L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,2L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,2L,1L,0L,0L,0L,0L,0L,4L,0L,0L,1L };
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
public class A206499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206499Inst : IEnumerable<long>
{
public static readonly long[] Value=A206499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206499.Bytes);
public long this[int i]=>Value[i];

public static A206499Inst Instance=new A206499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206500
{
public static readonly BigInteger[] Value={ 1L,4L,65L,3130L,178998L,10502458L,618242826L,36410671102L,2144479610070L,126304554589462L,7439032094765766L,438141046109721622L,BigInteger.Parse("25805450786659366998"),BigInteger.Parse("1519878816318690262678"),BigInteger.Parse("89517196729004371783830") };
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
public class A206500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206500Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206500.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206500.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206500Inst Instance=new A206500Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206501
{
public static readonly BigInteger[] Value={ 2L,34L,3130L,502599L,83045488L,13752277898L,2277207309720L,377099217207514L,62445595052884887L,10340702774554689140UL,BigInteger.Parse("1712370276674504142791"),BigInteger.Parse("283560339737534813492944") };
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
public class A206501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206501Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206501.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206501.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206501Inst Instance=new A206501Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206502
{
public static readonly long[] Value={ 5L,481L,178998L,83045488L,38638317841L };
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
public class A206502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206502Inst : IEnumerable<long>
{
public static readonly long[] Value=A206502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206502.Bytes);
public long this[int i]=>Value[i];

public static A206502Inst Instance=new A206502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206503
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,4L,4L,2L,5L,34L,65L,34L,5L,15L,481L,3130L,3130L,481L,15L,52L,8731L,178998L,502599L,178998L,8731L,52L,203L,174454L,10502458L,83045488L,83045488L,10502458L,174454L,203L,876L,3603244L,618242826L,13752277898L,38638317841L,13752277898L };
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
public class A206503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206503Inst : IEnumerable<long>
{
public static readonly long[] Value=A206503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206503.Bytes);
public long this[int i]=>Value[i];

public static A206503Inst Instance=new A206503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206504
{
public static readonly BigInteger[] Value={ 81L,7737L,2105607L,1483188648L,2671430859687L,12197461566772314L,BigInteger.Parse("140477097763717169946") };
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
public class A206504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206504Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206504.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206504.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206504Inst Instance=new A206504Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206505
{
public static readonly long[] Value={ 81L,549L,3399L,19797L,111495L,614367L,3337695L,17958813L,95989473L,510679479L,2707979133L,14326037895L,75662455155L,399129270627L,2103642300213L,11080520280189L,58338276097647L,307048060430277L,1615687942238055L };
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
public class A206505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206505Inst : IEnumerable<long>
{
public static readonly long[] Value=A206505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206505.Bytes);
public long this[int i]=>Value[i];

public static A206505Inst Instance=new A206505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206506
{
public static readonly long[] Value={ 549L,7737L,93405L,1020756L,10505604L,103812645L,997160112L,9383642739L,86977382523L,797102746356L,7242496383288L,65374662519669L,587135801448765L,5252624153233296L,46849534683131463L,416887973306651277L };
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
public class A206506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206506Inst : IEnumerable<long>
{
public static readonly long[] Value=A206506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206506.Bytes);
public long this[int i]=>Value[i];

public static A206506Inst Instance=new A206506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206507
{
public static readonly BigInteger[] Value={ 3399L,93405L,2105607L,41873838L,769739571L,13397007426L,224125465767L,3639506017737L,57759037910145L,900227925756975L,13830131604178527L,210015057307677960L,3159110458844182341L,BigInteger.Parse("47153204170712651499") };
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
public class A206507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206507Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206507.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206507.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206507Inst Instance=new A206507Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206508
{
public static readonly BigInteger[] Value={ 19797L,1020756L,41873838L,1483188648L,47830788954L,1444445274765L,41561685861258L,1152430341911256L,31037137973162439L,816543046767301710L,BigInteger.Parse("21075169065968338644"),BigInteger.Parse("535422905459574902352"),BigInteger.Parse("13424260728041018703732") };
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
public class A206508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206508Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206508.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206508.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206508Inst Instance=new A206508Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206509
{
public static readonly BigInteger[] Value={ 111495L,10505604L,769739571L,47830788954L,2671430859687L,138401623325535L,6781274991216915L,318257080720663863L,14433205926606629808UL,BigInteger.Parse("636578185379733865623"),BigInteger.Parse("27437199789684970128768"),BigInteger.Parse("1159984309083884155349523") };
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
public class A206509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206509Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206509.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206509.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206509Inst Instance=new A206509Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206510
{
public static readonly BigInteger[] Value={ 614367L,103812645L,13397007426L,1444445274765L,138401623325535L,12197461566772314L,1009956457230227994L,BigInteger.Parse("79674032690709828993"),BigInteger.Parse("6046585204361960568003"),BigInteger.Parse("444577014495524485388130") };
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
public class A206510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206510Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206510.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206510.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206510Inst Instance=new A206510Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206511
{
public static readonly BigInteger[] Value={ 3337695L,997160112L,224125465767L,41561685861258L,6781274991216915L,1009956457230227994L,BigInteger.Parse("140477097763717169946"),BigInteger.Parse("18526867118888845651956"),BigInteger.Parse("2341223589530713890986871") };
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
public class A206511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206511Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206511.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206511.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206511Inst Instance=new A206511Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206512
{
public static readonly long[] Value={ 81L,549L,549L,3399L,7737L,3399L,19797L,93405L,93405L,19797L,111495L,1020756L,2105607L,1020756L,111495L,614367L,10505604L,41873838L,41873838L,10505604L,614367L,3337695L,103812645L,769739571L,1483188648L,769739571L,103812645L };
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
public class A206512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206512Inst : IEnumerable<long>
{
public static readonly long[] Value=A206512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206512.Bytes);
public long this[int i]=>Value[i];

public static A206512Inst Instance=new A206512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206513
{
public static readonly BigInteger[] Value={ 15L,10998L,177097738L,45954984167446L,BigInteger.Parse("190187445308482279868"),BigInteger.Parse("12552495871839218224290213767"),BigInteger.Parse("13212265000747034021229857133763537610"),BigInteger.Parse("221780527293845666190504578213897949211421813469") };
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
public class A206513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206513Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206513.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206513.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206513Inst Instance=new A206513Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206514
{
public static readonly ulong[] Value={ 15L,186L,2786L,43804L,697369L,11136544L,177977851L,2844864002L,45475406828L,726936444140L,11620303055791L,185754246374086L,2969341279822087L,47465875753570892L,758757303430379258L,12128979771310068836UL };
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
public class A206514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206514Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A206514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206514.Bytes);
public ulong this[int i]=>Value[i];

public static A206514Inst Instance=new A206514Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206515
{
public static readonly BigInteger[] Value={ 186L,10998L,695541L,44350086L,2830665213L,180689239504L,11534052523389L,736261766040550L,46998354497911525L,3000081595834713716L,BigInteger.Parse("191506483600891877185"),BigInteger.Parse("12224578599211771061590"),BigInteger.Parse("780340796424907303135629") };
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
public class A206515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206515Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206515.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206515.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206515Inst Instance=new A206515Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206516
{
public static readonly BigInteger[] Value={ 2786L,695541L,177097738L,45142367398L,11507555684346L,2933481908580803L,747797195466172046L,BigInteger.Parse("190626930556386514119"),BigInteger.Parse("48594227014894390255783"),BigInteger.Parse("12387540901864509015493628"),BigInteger.Parse("3157806575432575464130353243") };
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
public class A206516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206516Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206516.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206516.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206516Inst Instance=new A206516Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206517
{
public static readonly BigInteger[] Value={ 43804L,44350086L,45142367398L,45954984167446L,46782397564239329L,BigInteger.Parse("47624714678427763425"),BigInteger.Parse("48482197805424282951252"),BigInteger.Parse("49355119922405928499997192"),BigInteger.Parse("50243759004969529025402006378"),BigInteger.Parse("51148398036881023231239431951179") };
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
public class A206517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206517Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206517.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206517.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206517Inst Instance=new A206517Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206518
{
public static readonly BigInteger[] Value={ 697369L,2830665213L,11507555684346L,46782397564239329L,BigInteger.Parse("190187445308482279868"),BigInteger.Parse("773181099472666620872437"),BigInteger.Parse("3143262221646752596264102690"),BigInteger.Parse("12778503510703479899595167222949") };
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
public class A206518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206518Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206518.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206518.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206518Inst Instance=new A206518Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206519
{
public static readonly BigInteger[] Value={ 11136544L,180689239504L,2933481908580803L,BigInteger.Parse("47624714678427763425"),BigInteger.Parse("773181099472666620872437"),BigInteger.Parse("12552495871839218224290213767"),BigInteger.Parse("203788158413867986023089008758269"),BigInteger.Parse("3308474580174074486151948611032236902") };
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
public class A206519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206519Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206519.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206519.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206519Inst Instance=new A206519Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206520
{
public static readonly BigInteger[] Value={ 177977851L,11534052523389L,747797195466172046L,BigInteger.Parse("48482197805424282951252"),BigInteger.Parse("3143262221646752596264102690"),BigInteger.Parse("203788158413867986023089008758269"),BigInteger.Parse("13212265000747034021229857133763537610") };
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
public class A206520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206520Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206520.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206520.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206520Inst Instance=new A206520Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206521
{
public static readonly long[] Value={ 15L,186L,186L,2786L,10998L,2786L,43804L,695541L,695541L,43804L,697369L,44350086L,177097738L,44350086L,697369L,11136544L,2830665213L,45142367398L,45142367398L,2830665213L,11136544L,177977851L,180689239504L,11507555684346L };
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
public class A206521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206521Inst : IEnumerable<long>
{
public static readonly long[] Value=A206521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206521.Bytes);
public long this[int i]=>Value[i];

public static A206521Inst Instance=new A206521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206522
{
public static readonly long[] Value={ 2L,5L,7L,10L,12L,13L,15L,17L,20L,22L,23L,24L,25L,27L,28L,29L,32L,34L,35L,37L,39L,40L,41L,42L,45L,47L,49L,52L,55L,58L,59L,60L,62L,64L,66L,69L,71L,72L,76L,79L,80L,82L,83L,87L,89L,92L,94L,99L,100L,103L,104L,105L,106L,111L,112L,114L,117L,118L,119L,121L,124L,126L,128L,129L,131L,135L,138L,139L,143L,144L,145L,146L,147L,149L,153L,156L,158L,159L,160L,167L,170L,171L,172L,174L,175L };
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
public class A206522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206522Inst : IEnumerable<long>
{
public static readonly long[] Value=A206522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206522.Bytes);
public long this[int i]=>Value[i];

public static A206522Inst Instance=new A206522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206523
{
public static readonly long[] Value={ 4L,9L,11L,19L,21L,26L,31L,33L,38L,44L,46L,48L,51L,61L,68L,70L,73L,75L,85L,91L,93L,97L,98L,108L,110L,120L,123L,125L,130L,133L,140L,152L,157L,162L,164L,165L,169L,179L,189L,191L,203L,204L,205L,210L,212L,220L,228L,232L,245L,251L,261L,263L,268L,269L,278L,283L,290L,292L,303L,306L,308L,313L,323L,324L,327L,335L,348L,350L,363L,372L,382L,389L,391L,395L,396L,406L,417L,418L,419L,421L };
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
public class A206523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206523Inst : IEnumerable<long>
{
public static readonly long[] Value=A206523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206523.Bytes);
public long this[int i]=>Value[i];

public static A206523Inst Instance=new A206523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206524
{
public static readonly long[] Value={ 6L,14L,16L,36L,50L,53L,54L,56L,57L,63L,65L,74L,77L,78L,81L,84L,86L,88L,95L,96L,101L,102L,107L,109L,113L,115L,116L,127L,132L,134L,136L,137L,141L,142L,148L,150L,151L,154L,155L,163L,166L,168L,173L,177L,180L,181L,182L,185L,188L,192L,196L,197L,200L,207L,209L,213L,216L,218L,221L,222L,223L,224L,225L,226L,229L,231L,234L,237L,239L,240L,241L,243L,244L,247L,254L };
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
public class A206524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206524Inst : IEnumerable<long>
{
public static readonly long[] Value=A206524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206524.Bytes);
public long this[int i]=>Value[i];

public static A206524Inst Instance=new A206524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206525
{
public static readonly long[] Value={ 51L,62L,164L,175L,277L,288L,390L,401L,503L,514L,616L,627L,729L,740L,842L,853L,955L,966L,1068L,1079L,1181L,1192L,1294L,1305L,1407L,1418L,1520L,1531L,1633L,1644L,1746L,1757L,1859L,1870L,1972L,1983L,2085L,2096L,2198L,2209L };
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
public class A206525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206525Inst : IEnumerable<long>
{
public static readonly long[] Value=A206525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206525.Bytes);
public long this[int i]=>Value[i];

public static A206525Inst Instance=new A206525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206526
{
public static readonly long[] Value={ 31L,106L,168L,243L,305L,380L,442L,517L,579L,654L,716L,791L,853L,928L,990L,1065L,1127L,1202L,1264L,1339L,1401L,1476L,1538L,1613L,1675L,1750L,1812L,1887L,1949L,2024L,2086L,2161L,2223L,2298L,2360L,2435L,2497L,2572L,2634L,2709L,2771L,2846L,2908L,2983L };
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
public class A206526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206526Inst : IEnumerable<long>
{
public static readonly long[] Value=A206526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206526.Bytes);
public long this[int i]=>Value[i];

public static A206526Inst Instance=new A206526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206527
{
public static readonly long[] Value={ 11L,33L,99L,2727L,8181L,243243L,729729L,21872187L,65616561L,1968319683L,5904959049L,177147177147L,531441531441L,15943231594323L,47829694782969L,1434890714348907L,4304672143046721L,129140163129140163L,387420489387420489L };
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
public class A206527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206527Inst : IEnumerable<long>
{
public static readonly long[] Value=A206527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206527.Bytes);
public long this[int i]=>Value[i];

public static A206527Inst Instance=new A206527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206528
{
public static readonly BigInteger[] Value={ 11L,55L,2525L,125125L,625625L,31253125L,1562515625L,7812578125L,390625390625L,19531251953125L,97656259765625L,4882812548828125L,244140625244140625L,12207031251220703125UL,BigInteger.Parse("61035156256103515625"),BigInteger.Parse("3051757812530517578125"),BigInteger.Parse("152587890625152587890625") };
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
public class A206528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206528Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206528.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206528.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206528Inst Instance=new A206528Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206529
{
public static readonly BigInteger[] Value={ 11L,77L,4949L,343343L,24012401L,1680716807L,117649117649L,823543823543L,57648015764801L,4035360740353607L,282475249282475249L,BigInteger.Parse("19773267431977326743"),BigInteger.Parse("1384128720113841287201"),BigInteger.Parse("9688901040796889010407"),BigInteger.Parse("678223072849678223072849") };
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
public class A206529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206529Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206529.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206529.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206529Inst Instance=new A206529Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206530
{
public static readonly long[] Value={ 6L,3L,0L,7L,9L,9L,3L,5L,1L,6L,4L,4L,3L,7L,4L,0L,0L,2L,7L,5L,1L,3L,5L,2L,1L,7L,3L,9L,8L,2L,4L,1L,6L,0L,1L,2L,8L,9L,7L,1L,3L,4L,2L,0L,4L,7L,2L,5L,7L,6L,3L,9L,3L,0L,2L,2L,5L,2L,4L,0L,1L,0L,1L,5L,3L,4L,9L,7L,9L,9L,3L,2L,6L,2L,4L,1L,2L,3L,5L,5L,6L,9L,1L,9L,2L,8L,6L,2L,1L,4L,8L,3L,8L,3L,9L,0L,7L,0L,0L,9L,1L,3L,9L };
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
public class A206530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206530Inst : IEnumerable<long>
{
public static readonly long[] Value=A206530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206530.Bytes);
public long this[int i]=>Value[i];

public static A206530Inst Instance=new A206530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206531
{
public static readonly BigInteger[] Value={ 0L,2L,58L,3250L,292498L,38609738L,7026972314L,1686473355362L,516060846740770L,196103121761492602L,BigInteger.Parse("90599642253809582122"),BigInteger.Parse("50011002524102889331346"),BigInteger.Parse("32507151640666878065374898"),BigInteger.Parse("24575406640344159817423422890") };
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
public class A206531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206531Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206531.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206531.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206531Inst Instance=new A206531Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206532
{
public static readonly BigInteger[] Value={ 1L,11L,331L,18535L,1668151L,220195931L,40075659443L,9618158266319L,2943156429493615L,1118399443207573699L,BigInteger.Parse("516700542761899048939"),BigInteger.Parse("285218699604568275014327"),BigInteger.Parse("185392154742969378759312551"),BigInteger.Parse("140156468985684850342040288555") };
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
public class A206532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206532Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206532.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206532.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206532Inst Instance=new A206532Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206533
{
public static readonly long[] Value={ 2L,1L,7L,5L,3L,4L,2L,6L,4L,9L,6L,7L,0L,0L,2L,1L,4L,1L,0L,7L,7L,6L,7L,8L,6L,7L,5L,9L,6L,5L,6L,0L,6L,9L,9L,7L,5L,8L,4L,8L,4L,4L,7L,4L,6L,7L,6L,2L,4L,1L,8L,4L,2L,1L,3L,7L,5L,0L,5L,4L,0L,0L,5L,5L,1L,4L,7L,0L,3L,0L,7L,1L,0L,2L,8L,9L,3L,5L,0L,6L,1L,8L,1L,9L,9L,9L,0L,8L,7L,8L,4L,0L,4L,8L,3L,5L,5L,8L,2L,9L,1L,0L,8L };
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
public class A206533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206533Inst : IEnumerable<long>
{
public static readonly long[] Value=A206533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206533.Bytes);
public long this[int i]=>Value[i];

public static A206533Inst Instance=new A206533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206534
{
public static readonly BigInteger[] Value={ 81L,2577L,141759L,22647363L,9567269487L,10370489275269L,28770371143057311L,BigInteger.Parse("203028344528664369537"),BigInteger.Parse("3648979640901069855030843") };
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
public class A206534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206534Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206534.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206534.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206534Inst Instance=new A206534Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206535
{
public static readonly long[] Value={ 81L,399L,1620L,6462L,26481L,110769L,469617L,2009553L,8655441L,37451697L,162572721L,707284113L,3081856785L,13442980209L,58681197681L,256284824145L,1119691708881L,4893034223409L,21386003380017L,93482466850833L,408662174944401L };
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
public class A206535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206535Inst : IEnumerable<long>
{
public static readonly long[] Value=A206535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206535.Bytes);
public long this[int i]=>Value[i];

public static A206535Inst Instance=new A206535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206536
{
public static readonly long[] Value={ 399L,2577L,14781L,91674L,594348L,3902463L,25900263L,172835859L,1158343314L,7783336557L,52398118053L,353178544149L,2382554812068L,16081864446159L,108592014091443L,733452273626199L,4954756282052310L,33475276596812193L };
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
public class A206536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206536Inst : IEnumerable<long>
{
public static readonly long[] Value=A206536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206536.Bytes);
public long this[int i]=>Value[i];

public static A206536Inst Instance=new A206536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206537
{
public static readonly long[] Value={ 1620L,14781L,141759L,1419921L,14528199L,150387285L,1567749888L,16417626507L,172416155157L,1814112395499L,19110547682607L,201479426103099L,2125267836114957L,22425737682248088L,236688761385595083L };
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
public class A206537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206537Inst : IEnumerable<long>
{
public static readonly long[] Value=A206537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206537.Bytes);
public long this[int i]=>Value[i];

public static A206537Inst Instance=new A206537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206538
{
public static readonly BigInteger[] Value={ 6462L,91674L,1419921L,22647363L,369441411L,6062752884L,100259781690L,1661323349889L,27605998634595L,459099135099705L,7643138171689107L,127288176601858407L,2120715004190021418L,BigInteger.Parse("35337966665490442968") };
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
public class A206538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206538Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206538.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206538.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206538Inst Instance=new A206538Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206539
{
public static readonly BigInteger[] Value={ 26481L,594348L,14528199L,369441411L,9567269487L,249853070682L,6556642024200L,172503406693200L,4545389492802288L,119878356782179572L,3163274433238575696L,BigInteger.Parse("83498862564488470557"),BigInteger.Parse("2204480938367057407965"),BigInteger.Parse("58208728563598806225396") };
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
public class A206539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206539Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206539.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206539.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206539Inst Instance=new A206539Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206540
{
public static readonly BigInteger[] Value={ 110769L,3902463L,150387285L,6062752884L,249853070682L,10370489275269L,433165769694465L,18115074102295746L,759196260042210954L,BigInteger.Parse("31822407182233848810"),BigInteger.Parse("1334925952358094973038"),BigInteger.Parse("55997558706291917520756") };
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
public class A206540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206540Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206540.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206540.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206540Inst Instance=new A206540Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206541
{
public static readonly BigInteger[] Value={ 469617L,25900263L,1567749888L,100259781690L,6556642024200L,433165769694465L,28770371143057311L,1915604623565617890L,BigInteger.Parse("127722868372348334343"),BigInteger.Parse("8521820836493432131926"),BigInteger.Parse("568800839142318486776736") };
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
public class A206541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206541Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A206541.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A206541.Bytes);
public BigInteger this[int i]=>Value[i];

public static A206541Inst Instance=new A206541Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206542
{
public static readonly long[] Value={ 81L,399L,399L,1620L,2577L,1620L,6462L,14781L,14781L,6462L,26481L,91674L,141759L,91674L,26481L,110769L,594348L,1419921L,1419921L,594348L,110769L,469617L,3902463L,14528199L,22647363L,14528199L,3902463L,469617L,2009553L,25900263L,150387285L };
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
public class A206542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206542Inst : IEnumerable<long>
{
public static readonly long[] Value=A206542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206542.Bytes);
public long this[int i]=>Value[i];

public static A206542Inst Instance=new A206542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206543
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,9L,7L,5L,3L,1L,1L,3L,5L,7L,9L,9L,7L,5L,3L,1L,1L,3L,5L,7L,9L,9L,7L,5L,3L,1L,1L,3L,5L,7L,9L,9L,7L,5L,3L,1L,1L,3L,5L,7L,9L,9L,7L,5L,3L,1L,1L,3L,5L,7L,9L,9L,7L,5L,3L,1L,1L };
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
public class A206543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206543Inst : IEnumerable<long>
{
public static readonly long[] Value=A206543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206543.Bytes);
public long this[int i]=>Value[i];

public static A206543Inst Instance=new A206543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206544
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,11L,9L,7L,5L,3L,1L,1L,3L,5L,7L,9L,11L,11L,9L,7L,5L,3L,1L,1L,3L,5L,7L,9L,11L,11L,9L,7L,5L,3L,1L,1L,3L,5L,7L,9L,11L,11L,9L,7L,5L,3L,1L,1L,3L,5L,7L,9L,11L,11L,9L,7L,5L,3L,1L,1L,3L,5L,7L,9L,11L,11L,9L,7L,5L,3L,1L };
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
public class A206544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206544Inst : IEnumerable<long>
{
public static readonly long[] Value=A206544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206544.Bytes);
public long this[int i]=>Value[i];

public static A206544Inst Instance=new A206544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206545
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,13L,15L,15L,13L,11L,9L,7L,5L,3L,1L,1L,3L,5L,7L,9L,11L,13L,15L,15L,13L,11L,9L,7L,5L,3L,1L,1L,3L,5L,7L,9L,11L,13L,15L,15L,13L,11L,9L,7L,5L,3L,1L,1L,3L,5L,7L,9L,11L,13L,15L,15L,13L,11L,9L,7L,5L,3L,1L,1L,3L,5L,7L,9L,11L,13L,15L,15L,13L,11L,9L,7L,5L,3L,1L };
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
public class A206545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206545Inst : IEnumerable<long>
{
public static readonly long[] Value=A206545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206545.Bytes);
public long this[int i]=>Value[i];

public static A206545Inst Instance=new A206545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206546
{
public static readonly long[] Value={ 1L,7L,11L,13L,13L,11L,7L,1L,1L,7L,11L,13L,13L,11L,7L,1L,1L,7L,11L,13L,13L,11L,7L,1L,1L,7L,11L,13L,13L,11L,7L,1L,1L,7L,11L,13L,13L,11L,7L,1L,1L,7L,11L,13L,13L,11L,7L,1L,1L,7L,11L,13L,13L,11L,7L,1L,1L,7L,11L,13L,13L,11L,7L,1L,1L,7L,11L,13L,13L,11L,7L,1L,1L,7L,11L,13L,13L,11L,7L,1L,1L,7L,11L,13L,13L,11L,7L,1L,1L,7L,11L,13L,13L,11L,7L,1L };
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
public class A206546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206546Inst : IEnumerable<long>
{
public static readonly long[] Value=A206546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206546.Bytes);
public long this[int i]=>Value[i];

public static A206546Inst Instance=new A206546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206547
{
public static readonly long[] Value={ 1L,5L,11L,13L,17L,19L,23L,25L,29L,31L,37L,41L,43L,47L,53L,55L,59L,61L,65L,67L,71L,73L,79L,83L,85L,89L,95L,97L,101L,103L,107L,109L,113L,115L,121L,125L,127L,131L,137L,139L,143L,145L,149L,151L,155L,157L,163L,167L,169L,173L,179L,181L,185L,187L,191L,193L,197L,199L,205L,209L,211L };
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
public class A206547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206547Inst : IEnumerable<long>
{
public static readonly long[] Value=A206547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206547.Bytes);
public long this[int i]=>Value[i];

public static A206547Inst Instance=new A206547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206548
{
public static readonly long[] Value={ 1L,5L,11L,13L,17L,19L,19L,17L,13L,11L,5L,1L,1L,5L,11L,13L,17L,19L,19L,17L,13L,11L,5L,1L,1L,5L,11L,13L,17L,19L,19L,17L,13L,11L,5L,1L,1L,5L,11L,13L,17L,19L,19L,17L,13L,11L,5L,1L,1L,5L,11L,13L,17L,19L,19L,17L,13L,11L,5L,1L,1L,5L,11L,13L,17L,19L,19L,17L,13L,11L,5L,1L };
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
public class A206548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206548Inst : IEnumerable<long>
{
public static readonly long[] Value=A206548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206548.Bytes);
public long this[int i]=>Value[i];

public static A206548Inst Instance=new A206548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206549
{
public static readonly long[] Value={ 3L,5L,13L,17L,31L,9L,23L,11L,27L,55L,75L,91L,33L,15L,37L,105L,129L,93L,19L,81L,183L,107L,89L,177L,241L,187L,217L,53L,155L,25L,203L,189L,213L,311L,269L,115L,63L,381L,143L,29L,179L,67L,109L,413L,301L,235L,489L,439L,483L,553L };
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
public class A206549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206549Inst : IEnumerable<long>
{
public static readonly long[] Value=A206549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206549.Bytes);
public long this[int i]=>Value[i];

public static A206549Inst Instance=new A206549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206550
{
public static readonly long[] Value={ 0L,1L,1L,3L,3L,5L,3L,3L,5L,3L,3L,0L,7L,5L,7L,3L,3L,5L,3L,0L,11L,3L,3L,0L,3L,7L,5L,0L,3L,0L,3L,3L,5L,3L,3L,0L,5L,13L,7L,0L,7L,0L,3L,0L,7L,3L,3L,0L,3L,3L,5L,0L,3L,5L,3L,0L,5L,3L,3L,0L,7L,7L,0L,3L,0L,0L,7L,0L,7L,0L,3L,0L,5L,5L,13L,0L,3L,0L,3L,0L,5L,7L,3L,0L,0L,5L,11L };
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
public class A206550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206550Inst : IEnumerable<long>
{
public static readonly long[] Value=A206550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206550.Bytes);
public long this[int i]=>Value[i];

public static A206550Inst Instance=new A206550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206551
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,13L,14L,15L,16L,17L,18L,19L,21L,22L,23L,25L,26L,27L,29L,31L,32L,33L,34L,35L,37L,38L,39L,41L,43L,45L,46L,47L,49L,50L,51L,53L,54L,55L,57L,58L,59L,61L,62L,64L,67L,69L,71L,73L,74L,75L,77L,79L,81L,82L,83L,86L,87L,89L,93L,94L,95L,97L,98L,99L };
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
public class A206551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206551Inst : IEnumerable<long>
{
public static readonly long[] Value=A206551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206551.Bytes);
public long this[int i]=>Value[i];

public static A206551Inst Instance=new A206551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206552
{
public static readonly long[] Value={ 12L,20L,24L,28L,30L,36L,40L,42L,44L,48L,52L,56L,60L,63L,65L,66L,68L,70L,72L,76L,78L,80L,84L,85L,88L,90L,91L,92L,96L,100L,102L,104L,105L,108L,110L,112L,114L,116L,117L,120L,124L,126L,130L,132L,133L,136L,138L,140L,144L,145L,148L,150L,152L,154L,156L,160L,164L,165L };
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
public class A206552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206552Inst : IEnumerable<long>
{
public static readonly long[] Value=A206552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206552.Bytes);
public long this[int i]=>Value[i];

public static A206552Inst Instance=new A206552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206553
{
public static readonly long[] Value={ 5L,5L,13L,7L,5L,5L,7L,7L,11L,13L,13L,11L,5L,11L,37L,11L,5L,23L,13L,47L,89L,13L,19L,19L,11L,7L,19L,23L,17L,13L,19L,43L,29L,79L,61L,17L,191L,43L,337L,53L,29L,17L,13L,13L,29L,11L,19L,11L,11L,13L,43L,163L,29L,13L,7L,53L,23L,97L,31L,29L,41L,83L,79L,23L,191L,97L };
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
public class A206553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206553Inst : IEnumerable<long>
{
public static readonly long[] Value=A206553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206553.Bytes);
public long this[int i]=>Value[i];

public static A206553Inst Instance=new A206553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206554
{
public static readonly long[] Value={ 1L,4L,5L,8L,9L,12L,16L,17L,33L,61L,92L,113L,137L,216L,237L,833L,872L,948L,1308L,1728L,2509L,4096L,5457L,6229L,6432L,6473L,6868L,7032L,8128L,8557L,10449L,11022L,15629L,29217L,40756L,60684L };
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
public class A206554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206554Inst : IEnumerable<long>
{
public static readonly long[] Value=A206554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206554.Bytes);
public long this[int i]=>Value[i];

public static A206554Inst Instance=new A206554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206555
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,1L,2L,3L,4L,5L,8L,10L,15L,18L,26L,32L,44L,56L,73L,92L,120L,149L,193L,238L,302L,373L,469L,576L,716L,876L,1081L,1316L,1615L,1954L,2383L,2875L,3483L,4188L,5048L,6043L,7253L,8653L,10341L,12293L,14634L,17340L,20567L,24300L,28717L,33830L };
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
public class A206555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206555Inst : IEnumerable<long>
{
public static readonly long[] Value=A206555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206555.Bytes);
public long this[int i]=>Value[i];

public static A206555Inst Instance=new A206555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A206556
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,1L,1L,2L,2L,5L,4L,8L,9L,14L,16L,26L,28L,42L,50L,69L,82L,114L,133L,179L,215L,279L,335L,434L,516L,657L,789L,987L,1182L,1473L,1754L,2164L,2583L,3154L,3755L,4567L,5414L,6542L,7753L,9307L,11000L,13158L,15501L,18456L,21712L,25731L,30196L,35677L };
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
public class A206556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A206556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A206556Inst : IEnumerable<long>
{
public static readonly long[] Value=A206556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A206556.Bytes);
public long this[int i]=>Value[i];

public static A206556Inst Instance=new A206556Inst();

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