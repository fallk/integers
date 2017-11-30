using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A238081
{
public static readonly long[] Value={ 256L,1592L,1592L,9884L,14456L,9884L,59772L,132316L,132316L,59772L,378708L,1191324L,1781008L,1191324L,378708L,2285576L,10449784L,19616408L,19616408L,10449784L,2285576L,14349272L,92535056L,242829762L,336372000L,242829762L,92535056L };
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
public class A238081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238081Inst : IEnumerable<long>
{
public static readonly long[] Value=A238081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238081.Bytes);
public long this[int i]=>Value[i];

public static A238081Inst Instance=new A238081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238082
{
public static readonly long[] Value={ 4181L,10877L,75077L,162133L,330929L,1256293L,1346269L,2662277L,3636121L,4226777L,9401893L,13455077L,14787181L,16485493L,21692189L,24157817L,24493061L,25532501L,29604893L,31432381L,39247393L,73780877L,75245777L,77337941L,120485381L,124477513L,127835341L,132162581L,143221993L,143548501L };
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
public class A238082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238082Inst : IEnumerable<long>
{
public static readonly long[] Value=A238082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238082.Bytes);
public long this[int i]=>Value[i];

public static A238082Inst Instance=new A238082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238083
{
public static readonly long[] Value={ 67L,139L,337L,409L,577L,607L,631L,1297L,1321L,1429L,1459L,1549L,1627L,2377L,2557L,2767L,2851L,2917L,3001L,3187L,3319L,3499L,4027L,4099L,4621L,4861L,4969L,5059L,5431L,5449L,5581L,5827L,5857L,6007L,6037L,6379L,6481L,6781L,6997L,7411L,7927L,8089L,8191L,8311L };
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
public class A238083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238083Inst : IEnumerable<long>
{
public static readonly long[] Value=A238083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238083.Bytes);
public long this[int i]=>Value[i];

public static A238083Inst Instance=new A238083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238084
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,12L,14L,15L,23L,24L };
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
public class A238084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238084Inst : IEnumerable<long>
{
public static readonly long[] Value=A238084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238084.Bytes);
public long this[int i]=>Value[i];

public static A238084Inst Instance=new A238084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238085
{
public static readonly BigInteger[] Value={ 0L,1L,2L,10L,72L,716L,9088L,140344L,2554240L,53540368L,1270296064L,33653698464L,984753299456L,31542901202112L,1097763264864256L,41247391653500800L,1664188908529156096L,BigInteger.Parse("71759140177774010624"),BigInteger.Parse("3293251384307726942208"),BigInteger.Parse("160272893566770148403712") };
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
public class A238085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238085Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238085.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238085.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238085Inst Instance=new A238085Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238086
{
public static readonly long[] Value={ 3L,7L,5L,11L,31L,13L,29L,47L,37L,19L,193L,41L,59L,43L,23L,139L,331L,113L,61L,79L,53L,107L,523L,409L,163L,67L,97L,73L,181L,293L,563L,457L,173L,71L,103L,83L,101L,277L,359L,769L,487L,199L,127L,241L,89L,17L,191L,541L,389L,853L,787L,211L,131L,271L,109L };
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
public class A238086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238086Inst : IEnumerable<long>
{
public static readonly long[] Value=A238086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238086.Bytes);
public long this[int i]=>Value[i];

public static A238086Inst Instance=new A238086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238087
{
public static readonly BigInteger[] Value={ -1L,1L,-1L,1L,-5L,63L,-315L,99L,-675675L,135135L,-1640925L,83329155L,-4583103525L,5791834125L,-71152682225625L,14230536445125L,-26797763435625L,24833960277501375L,BigInteger.Parse("-73881031825566590625"),8546099690638125L,BigInteger.Parse("-106610328924292590271875") };
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
public class A238087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238087Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238087.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238087.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238087Inst Instance=new A238087Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238088
{
public static readonly long[] Value={ 1L,63L,72L,135L,81L,27L,36L,1881L,0L,9L,549L,1683L,1782L,3465L,1728L,1287L,1386L,891L,0L,1188L,95904L,693L,87912L,204795L,81918L,42957L,73926L,792L,0L,40959L,65934L,36963L,67932L,1485L,61938L,297L,53946L,28971L,0L,30969L,1881198L,26973L,47952L,114885L,4419558L };
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
public class A238088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238088Inst : IEnumerable<long>
{
public static readonly long[] Value=A238088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238088.Bytes);
public long this[int i]=>Value[i];

public static A238088Inst Instance=new A238088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238089
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,7L,16L,34L,73L,152L,318L,657L,1356L,2784L,5703L,11647L,23740L,48290L,98073L,198887L,402837L,815032L,1647424L,3327112L,6714352L,13540995L,27292175L,54978561L,110697947L,222790629L,448211668L,901392243L,1812185325L,3642182184L,7318157714L };
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
public class A238089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238089Inst : IEnumerable<long>
{
public static readonly long[] Value=A238089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238089.Bytes);
public long this[int i]=>Value[i];

public static A238089Inst Instance=new A238089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238090
{
public static readonly long[] Value={ 11L,13L,191L,223L,251L,3019L,3023L,3037L,3067L,3259L,3323L,3517L,3533L,3547L,3581L,3583L,4027L,4091L,4093L,48079L,48091L,48383L,48571L,48589L,49103L,49117L,52189L,52223L,52667L,52733L,53197L,56267L,56269L,56509L,56527L,56543L,56767L,56779L,56783L,56827L,64717L,64763L,769019L,769231L,769243L,769247L,769469L,769487L };
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
public class A238090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238090Inst : IEnumerable<long>
{
public static readonly long[] Value=A238090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238090.Bytes);
public long this[int i]=>Value[i];

public static A238090Inst Instance=new A238090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238091
{
public static readonly long[] Value={ 1L,4L,9L,18L,31L,33L,39L,56L,58L,94L,96L,103L,156L,239L,245L,253L,255L,257L,275L,277L,420L,610L,788L,790L,792L,1070L,1665L,1667L,1669L };
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
public class A238091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238091Inst : IEnumerable<long>
{
public static readonly long[] Value=A238091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238091.Bytes);
public long this[int i]=>Value[i];

public static A238091Inst Instance=new A238091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238092
{
public static readonly long[] Value={ 3L,5L,13L,19L,32L,38L,55L,57L,59L,95L,97L,104L,157L,244L,249L,254L,256L,258L,276L,419L,609L,787L,789L,791L,1069L,1664L,1666L,1668L,1670L };
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
public class A238092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238092Inst : IEnumerable<long>
{
public static readonly long[] Value=A238092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238092.Bytes);
public long this[int i]=>Value[i];

public static A238092Inst Instance=new A238092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238093
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,2L,1L,0L,1L,1L,2L,4L,1L,0L,1L,1L,2L,5L,4L,1L,0L,1L,1L,2L,5L,13L,4L,1L,0L,1L,1L,2L,5L,14L,25L,4L,1L,0L,1L,1L,2L,5L,14L,41L,25L,4L,1L,0L,1L,1L,2L,5L,14L,42L,106L,25L,4L,1L,0L,1L,1L,2L,5L,14L,42L,131L,196L,25L,4L,1L,0L,1L,1L,2L,5L,14L,42L,132L,392L,196L,25L,4L,1L,0L };
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
public class A238093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238093Inst : IEnumerable<long>
{
public static readonly long[] Value=A238093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238093.Bytes);
public long this[int i]=>Value[i];

public static A238093Inst Instance=new A238093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238094
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,2L,4L,4L,1L,1L,2L,5L,13L,25L,25L,1L,1L,2L,5L,14L,41L,106L,196L,196L,1L,1L,2L,5L,14L,42L,131L,392L,980L,1764L,1764L,1L,1L,2L,5L,14L,42L,132L,428L,1380L,4068L,9864L,17424L,17424L,1L,1L,2L,5L,14L,42L,132L,429L,1429L,4797L,15489L,44649L,105633L,184041L,184041L,1L,1L,2L,5L,14L,42L,132L,429L,1430L,4861L,16714L,56749L,181258L,511225L };
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
public class A238094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238094Inst : IEnumerable<long>
{
public static readonly long[] Value=A238094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238094.Bytes);
public long this[int i]=>Value[i];

public static A238094Inst Instance=new A238094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238095
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,2L,1L,0L,1L,1L,2L,4L,1L,0L,1L,1L,2L,5L,6L,1L,0L,1L,1L,2L,5L,13L,8L,1L,0L,1L,1L,2L,5L,14L,28L,10L,1L,0L,1L,1L,2L,5L,14L,41L,48L,12L,1L,0L };
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
public class A238095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238095Inst : IEnumerable<long>
{
public static readonly long[] Value=A238095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238095.Bytes);
public long this[int i]=>Value[i];

public static A238095Inst Instance=new A238095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238128
{
public static readonly long[] Value={ 1L,1L,0L,2L,0L,0L,3L,1L,0L,0L,5L,4L,1L,0L,0L,7L,13L,5L,1L,0L,0L,11L,37L,21L,6L,1L,0L,0L,15L,100L,78L,31L,7L,1L,0L,0L,22L,265L,292L,133L,43L,8L,1L,0L,0L,30L,694L,1028L,586L,215L,57L,9L,1L,0L,0L,42L,1828L,3691L,2453L,1073L,325L,73L,10L,1L,0L,0L,56L,4815L,13004L,10357L,5058L,1836L,467L,91L,11L,1L,0L,0L };
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
public class A238128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238128Inst : IEnumerable<long>
{
public static readonly long[] Value=A238128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238128.Bytes);
public long this[int i]=>Value[i];

public static A238128Inst Instance=new A238128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238129
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,3L,0L,0L,1L,8L,1L,0L,0L,1L,19L,5L,1L,0L,0L,1L,47L,21L,6L,1L,0L,0L,1L,114L,78L,31L,7L,1L,0L,0L,1L,286L,292L,133L,43L,8L,1L,0L,0L,1L,723L,1028L,586L,215L,57L,9L,1L,0L,0L,1L,1869L,3691L,2453L,1073L,325L,73L,10L,1L,0L,0L,1L,4870L,13004L,10357L,5058L,1836L,467L,91L,11L,1L,0L,0L };
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
public class A238129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238129Inst : IEnumerable<long>
{
public static readonly long[] Value=A238129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238129.Bytes);
public long this[int i]=>Value[i];

public static A238129Inst Instance=new A238129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238130
{
public static readonly long[] Value={ 1L,1L,0L,2L,0L,0L,2L,2L,0L,0L,3L,4L,1L,0L,0L,2L,10L,4L,0L,0L,0L,4L,12L,14L,2L,0L,0L,0L,2L,22L,29L,10L,1L,0L,0L,0L,4L,26L,56L,36L,6L,0L,0L,0L,0L,3L,34L,100L,86L,31L,2L,0L,0L,0L,0L,4L,44L,148L,200L,99L,16L,1L,0L,0L,0L,0L,2L,54L,230L,374L,278L,78L,8L,0L,0L,0L,0L,0L,6L,58L,322L,680L,654L,274L,52L,2L,0L,0L,0L,0L,0L };
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
public class A238130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238130Inst : IEnumerable<long>
{
public static readonly long[] Value=A238130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238130.Bytes);
public long this[int i]=>Value[i];

public static A238130Inst Instance=new A238130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238131
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,4L,4L,7L,10L,13L,16L,22L,25L,31L,42L,48L,59L,73L,89L,108L,132L,156L,190L,227L,271L,318L,380L,449L,526L,618L,722L,841L,980L,1138L,1321L,1526L,1760L,2028L,2333L,2683L,3070L,3517L,4017L,4584L,5228L,5948L,6757L,7673L,8696L,9845L,11132L,12577L };
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
public class A238131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238131Inst : IEnumerable<long>
{
public static readonly long[] Value=A238131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238131.Bytes);
public long this[int i]=>Value[i];

public static A238131Inst Instance=new A238131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238132
{
public static readonly long[] Value={ 0L,0L,0L,2L,2L,4L,4L,6L,6L,8L,12L,14L,18L,24L,32L,38L,50L,60L,76L,90L,110L,134L,162L,190L,228L,270L,322L,380L,446L,524L,616L,720L,838L,980L,1134L,1314L,1526L,1760L,2026L,2336L,2676L,3072L,3518L,4020L,4586L,5232L,5948L,6760L,7676L,8698L,9846L,11142L,12578L };
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
public class A238132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238132Inst : IEnumerable<long>
{
public static readonly long[] Value=A238132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238132.Bytes);
public long this[int i]=>Value[i];

public static A238132Inst Instance=new A238132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238133
{
public static readonly long[] Value={ 0L,1L,1L,-1L,-1L,-3L,0L,-2L,1L,2L,1L,2L,4L,1L,-1L,4L,-2L,-1L,-3L,-1L,-2L,-2L,-6L,0L,-1L,1L,-4L,0L,3L,2L,2L,2L,3L,0L,4L,7L,0L,0L,2L,-3L,7L,-2L,-1L,-3L,-2L,-4L,0L,-3L,-3L,-2L,-1L,-10L,-1L,0L,1L,-1L,0L,-6L,2L,2L,0L,4L,3L,4L,0L,2L,4L,3L,0L,5L,8L,2L,0L,1L,-1L,1L,-3L };
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
public class A238133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238133Inst : IEnumerable<long>
{
public static readonly long[] Value=A238133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238133.Bytes);
public long this[int i]=>Value[i];

public static A238133Inst Instance=new A238133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238134
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,2L,3L,3L,4L,4L,4L,3L,3L,3L,3L,4L,4L,4L,6L,5L,5L,5L,3L,4L,6L,6L,7L,6L,4L,4L,4L,4L,5L,5L,5L,5L,4L,4L,4L,4L,3L,3L,4L,4L,6L,6L,4L,5L,5L,5L,7L,6L,6L,6L,5L,5L,4L,4L,5L,5L,5L,5L,5L,6L,8L,8L,8L,7L,7L,7L,4L,4L,4L,4L };
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
public class A238134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238134Inst : IEnumerable<long>
{
public static readonly long[] Value=A238134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238134.Bytes);
public long this[int i]=>Value[i];

public static A238134Inst Instance=new A238134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238135
{
public static readonly long[] Value={ 1L,5L,6L,1L,6L,6L,9L,3L,3L,3L,8L,1L,1L,7L,6L,9L,1L,5L,8L,8L,1L,0L,3L,5L,9L,0L,9L,6L,8L,7L,9L,8L,8L,1L,9L,3L,6L,8L,5L,7L,7L,6L,7L,0L,9L,8L,4L,0L,3L,0L,3L,8L,7L,2L,9L,5L,7L,5L,2L,9L,3L,5L,4L,4L,9L,7L,0L,7L,5L,0L,3L,7L,4L,4L,0L,2L,9L,5L,7L,9L,1L,4L,5L,5L,2L,0L,5L,6L,5L,3L,7L,0L,9L,3L,5L,8L,1L,4L,7L,5L };
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
public class A238135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238135Inst : IEnumerable<long>
{
public static readonly long[] Value=A238135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238135.Bytes);
public long this[int i]=>Value[i];

public static A238135Inst Instance=new A238135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238136
{
public static readonly long[] Value={ 1429L,5827L,7411L,9601L,12601L,18457L,20011L,20521L,24919L,25999L,28591L,29947L,33211L,33349L,36037L,38149L,41227L,42649L,43579L,45307L,46099L,49999L,52057L,52387L,54319L,59107L,59197L,59629L,67891L,70951L,73477L,74761L,75037L,81157L,92041L,93607L,114889L };
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
public class A238136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238136Inst : IEnumerable<long>
{
public static readonly long[] Value=A238136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238136.Bytes);
public long this[int i]=>Value[i];

public static A238136Inst Instance=new A238136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238137
{
public static readonly long[] Value={ 3L,5L,7L,11L,17L,23L,29L,41L,53L,83L,113L,173L,233L,293L,353L,593L,953L,1553L,2153L,2753L,5153L,8753L,14753L,20753L,36353L,71153L,105953L,211313L,419873L,733793L,1047713L,2086673L,4102193L,8133233L,14179793L,26272913L,52439873L,90699953L,128960033L,167220113L };
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
public class A238137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238137Inst : IEnumerable<long>
{
public static readonly long[] Value=A238137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238137.Bytes);
public long this[int i]=>Value[i];

public static A238137Inst Instance=new A238137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238138
{
public static readonly long[] Value={ 62L,149L,257L,281L,286L,365L,403L,418L,526L,534L,573L,577L,579L,712L,744L,825L,849L,877L,973L,992L,1016L,1106L,1191L,1243L,1251L,1257L,1286L,1341L,1388L,1440L,1487L,1526L,1636L,1656L,1841L,1844L,1846L,1953L,1966L,2028L,2108L,2120L,2142L,2225L,2272L,2392L,2409L };
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
public class A238138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238138Inst : IEnumerable<long>
{
public static readonly long[] Value=A238138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238138.Bytes);
public long this[int i]=>Value[i];

public static A238138Inst Instance=new A238138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238139
{
public static readonly long[] Value={ 0L,2L,13L,5L,17L,113L,29L,53L,313L,37L,137L,41L,89L,241L,61L,97L,233L,101L,73L,193L,557L,229L,601L,157L,8581L,109L,337L,293L,4993L,181L,14621L,433L,197L,149L,21013L,509L,277L,281L,521L,11329L,257L,173L,1321L,6917L,373L,389L,3037L,821L,7109L,353L,773L,397L,457L };
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
public class A238139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238139Inst : IEnumerable<long>
{
public static readonly long[] Value=A238139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238139.Bytes);
public long this[int i]=>Value[i];

public static A238139Inst Instance=new A238139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238140
{
public static readonly long[] Value={ 256L,1810L,12981L,94458L,687254L,4977790L,36125717L,262009080L,1902689356L,13793932488L,100152908224L,726176038552L,5272782009672L,38229547221928L,277581361120444L,2012592670155936L,14613326239922048L,105952842547441728L };
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
public class A238140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238140Inst : IEnumerable<long>
{
public static readonly long[] Value=A238140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238140.Bytes);
public long this[int i]=>Value[i];

public static A238140Inst Instance=new A238140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238141
{
public static readonly long[] Value={ 1810L,22698L,292176L,3817216L,49554382L,642717388L,8350461834L,108497620520L,1408763005522L,18293990239076L,237617269565066L,3086156579656534L,40079416703850338L,520523252730903368L,6760388203460812474L };
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
public class A238141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238141Inst : IEnumerable<long>
{
public static readonly long[] Value=A238141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238141.Bytes);
public long this[int i]=>Value[i];

public static A238141Inst Instance=new A238141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238142
{
public static readonly BigInteger[] Value={ 12981L,292176L,6799917L,160133604L,3756442630L,88011173220L,2067349618435L,48473348771212L,1137529676425732L,26670004318339992L,626193786703761388L,14680761625172316224UL,BigInteger.Parse("344614066748843613158"),BigInteger.Parse("8079594620572921715820") };
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
public class A238142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238142Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238142.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238142.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238142Inst Instance=new A238142Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238143
{
public static readonly BigInteger[] Value={ 94458L,3817216L,160133604L,6863396252L,292335443616L,12430740302096L,529306438594610L,22541568260503428L,959479531581877652L,BigInteger.Parse("40849286077190837310"),BigInteger.Parse("1739380607057160297494"),BigInteger.Parse("74053634588756994371164") };
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
public class A238143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238143Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238143.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238143.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238143Inst Instance=new A238143Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238192
{
public static readonly long[] Value={ 0L,0L,5L,0L,5L,5L,5L,0L,5L,5L,5L,5L,5L,5L,5L,0L,5L,5L,5L,5L,21L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,0L,5L,5L,5L,5L,5L,5L,5L,5L,5L,21L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,0L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,85L,5L,5L,5L,5L,5L,5L,5L,5L,21L,85L,5L };
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
public class A238192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238192Inst : IEnumerable<long>
{
public static readonly long[] Value=A238192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238192.Bytes);
public long this[int i]=>Value[i];

public static A238192Inst Instance=new A238192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238193
{
public static readonly long[] Value={ 3L,21L,75L,151L,1365L,5461L,14563L,87381L,184111L,932067L };
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
public class A238193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238193Inst : IEnumerable<long>
{
public static readonly long[] Value=A238193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238193.Bytes);
public long this[int i]=>Value[i];

public static A238193Inst Instance=new A238193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238194
{
public static readonly long[] Value={ 130L,257L,487L,528L,815L,897L,1176L,1225L,1320L,1373L,1430L,2029L,2050L,2084L,2198L,2247L,2526L,2608L,2895L,2936L,2958L,3166L,3679L,3849L,3909L,3950L,4237L,4319L,4598L,4647L,4723L,4795L,5472L,5487L,5620L,5669L,5948L,6030L,6317L,6358L,6588L,6677L,6936L,7101L };
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
public class A238194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238194Inst : IEnumerable<long>
{
public static readonly long[] Value=A238194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238194.Bytes);
public long this[int i]=>Value[i];

public static A238194Inst Instance=new A238194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238195
{
public static readonly long[] Value={ 5L,-23L,-31L,-283L,-400L,-283L,2869L,3233L,3017L,3381L,49781L,33856L,91125L,61504L,49781L,-776887L,-836043L,-816631L,-830455L,-811043L,-870199L,-17600759L,-20502784L,-16861591L,-40960000L,-16861591L,-20502784L,-17600759L,370643273L,390714661L,239483061L };
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
public class A238195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238195Inst : IEnumerable<long>
{
public static readonly long[] Value=A238195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238195.Bytes);
public long this[int i]=>Value[i];

public static A238195Inst Instance=new A238195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238196
{
public static readonly long[] Value={ 5L,-31L,-23L,-283L,-400L,-283L,3381L,3017L,3233L,2869L,49781L,61504L,91125L,33856L,49781L,-870199L,-811043L,-830455L,-816631L,-836043L,-776887L,-17600759L,-20502784L,-16861591L,-40960000L,-16861591L,-20502784L,-17600759L,404197705L,384126317L,586376253L };
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
public class A238196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238196Inst : IEnumerable<long>
{
public static readonly long[] Value=A238196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238196.Bytes);
public long this[int i]=>Value[i];

public static A238196Inst Instance=new A238196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238197
{
public static readonly long[] Value={ -3L,-31L,-31L,229L,144L,229L,3381L,3233L,3233L,3381L,-43531L,-61504L,-19683L,-61504L,-43531L,-870199L,-836043L,-830455L,-830455L,-836043L,-870199L,15953673L,13424896L,16692841L,5308416L,16692841L,13424896L,15953673L,404197705L,390714661L,586376253L };
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
public class A238197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238197Inst : IEnumerable<long>
{
public static readonly long[] Value=A238197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238197.Bytes);
public long this[int i]=>Value[i];

public static A238197Inst Instance=new A238197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238198
{
public static readonly long[] Value={ -3L,-23L,-23L,229L,144L,229L,2869L,3017L,3017L,2869L,-43531L,-33856L,-19683L,-33856L,-43531L,-776887L,-811043L,-816631L,-816631L,-811043L,-776887L,15953673L,13424896L,16692841L,5308416L,16692841L,13424896L,15953673L,370643273L,384126317L,239483061L };
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
public class A238198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238198Inst : IEnumerable<long>
{
public static readonly long[] Value=A238198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238198.Bytes);
public long this[int i]=>Value[i];

public static A238198Inst Instance=new A238198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238199
{
public static readonly long[] Value={ 3L,5L,23L,31L,144L,229L,283L,400L,2869L,3017L,3233L,3381L,19683L,33856L,43531L,49781L,61504L,91125L,776887L,811043L,816631L,830455L,836043L,870199L,5308416L,13424896L,15953673L,16692841L,16861591L,17600759L,20502784L,40960000L,239483061L,370643273L };
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
public class A238199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238199Inst : IEnumerable<long>
{
public static readonly long[] Value=A238199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238199.Bytes);
public long this[int i]=>Value[i];

public static A238199Inst Instance=new A238199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238200
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,5L,9L,6L,5L,2L,1L,8L };
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
public class A238200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238200Inst : IEnumerable<long>
{
public static readonly long[] Value=A238200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238200.Bytes);
public long this[int i]=>Value[i];

public static A238200Inst Instance=new A238200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238201
{
public static readonly long[] Value={ 2L,3L,5L,61L,1680023L,7308036881L };
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
public class A238201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238201Inst : IEnumerable<long>
{
public static readonly long[] Value=A238201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238201.Bytes);
public long this[int i]=>Value[i];

public static A238201Inst Instance=new A238201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238202
{
public static readonly long[] Value={ 43L,503L,631L,827L,971L,1063L,1153L,1283L,1373L,1429L,1433L,1493L,1523L,1553L,1619L,1693L,1877L,2113L,2239L,2243L,2297L,2423L,2477L,2531L,2609L,2683L,2851L,2927L,2999L,3203L,3221L,3319L,3463L,3533L,3557L,3571L,3583L,3701L };
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
public class A238202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238202Inst : IEnumerable<long>
{
public static readonly long[] Value=A238202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238202.Bytes);
public long this[int i]=>Value[i];

public static A238202Inst Instance=new A238202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238203
{
public static readonly long[] Value={ 1L,4L,9L,16L,25L,36L,64L,100L,144L,169L,196L,225L,324L,400L,441L,484L,529L,576L,625L,841L,900L,961L,1089L,1444L,1521L,1849L,2209L,2601L,2704L,2809L,3025L,3136L,3249L,3364L,3721L,3844L,4096L,4225L,4356L,4489L,5476L,5625L,5776L,6241L,7056L,7921L,8464L,8836L,9025L };
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
public class A238203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238203Inst : IEnumerable<long>
{
public static readonly long[] Value=A238203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238203.Bytes);
public long this[int i]=>Value[i];

public static A238203Inst Instance=new A238203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238204
{
public static readonly long[] Value={ 10L,16L,22L,26L,28L,34L,36L,40L,46L,50L,52L,56L,58L,64L,66L,70L,76L,78L,82L,86L,88L,92L,94L,96L,100L,106L,112L,116L,118L,120L,124L,126L,130L,134L,136L,142L,144L,146L,154L,156L,160L,162L,166L,170L,172L,176L,178L,184L,186L,188L,196L,202L,204L,206L,210L,214L,216L };
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
public class A238204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238204Inst : IEnumerable<long>
{
public static readonly long[] Value=A238204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238204.Bytes);
public long this[int i]=>Value[i];

public static A238204Inst Instance=new A238204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238205
{
public static readonly long[] Value={ 3L,5L,7L,5L,5L,7L,7L,7L,5L,5L,7L,13L,11L,7L,7L,7L,11L,11L,13L,13L,7L,7L,7L,11L,11L,11L,17L,11L,13L,13L,13L,19L,13L,13L,11L,11L,11L,23L,11L,13L,17L,13L,13L,13L,19L,13L,13L,19L,17L,19L,19L,19L,29L,23L,23L,17L,11L,11L,11L,17L,11L,13L,17L,17L,19L,23L,19L,13L,13L,13L };
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
public class A238205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238205Inst : IEnumerable<long>
{
public static readonly long[] Value=A238205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238205.Bytes);
public long this[int i]=>Value[i];

public static A238205Inst Instance=new A238205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238206
{
public static readonly long[] Value={ 0L,2L,1L,3L,7L,4L,5L,10L,22L,13L,6L,16L,31L,67L,40L,8L,19L,49L,94L,202L,121L,9L,25L,58L,148L,283L,607L,364L,11L,28L,76L,175L,445L,850L,1822L,1093L,12L,34L,85L,229L,526L,1336L,2551L,5467L,3280L,14L,37L,103L,256L,688L,1579L,4009L,7654L,16402L,9841L,15L,43L,112L,310L };
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
public class A238206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238206Inst : IEnumerable<long>
{
public static readonly long[] Value=A238206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238206.Bytes);
public long this[int i]=>Value[i];

public static A238206Inst Instance=new A238206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238207
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,8L,4L,11L,17L,26L,6L,14L,35L,53L,80L,7L,20L,44L,107L,161L,242L,9L,23L,62L,134L,323L,485L,728L,10L,29L,71L,188L,404L,971L,1457L,2186L,12L,32L,89L,215L,566L,1214L,2915L,4373L,6560L,13L,28L,98L,269L,647L,1700L,3644L,8747L,13121L,19682L,15L,41L,116L };
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
public class A238207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238207Inst : IEnumerable<long>
{
public static readonly long[] Value=A238207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238207.Bytes);
public long this[int i]=>Value[i];

public static A238207Inst Instance=new A238207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238240
{
public static readonly long[] Value={ 18L,63L,72L,74L,83L,90L,99L,107L,162L,171L,227L,252L,288L,296L,315L,332L,347L,359L,360L,362L,387L,396L,407L,428L,450L,491L,495L,567L,626L,648L,666L,684L,711L,743L,747L,794L,810L,827L,842L,855L,866L,882L,887L,891L,908L,954L,963L,1008L,1031L,1143L,1152L,1163L };
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
public class A238240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238240Inst : IEnumerable<long>
{
public static readonly long[] Value=A238240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238240.Bytes);
public long this[int i]=>Value[i];

public static A238240Inst Instance=new A238240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238241
{
public static readonly long[] Value={ 1L,2L,1L,5L,4L,1L,10L,14L,6L,1L,20L,40L,27L,8L,1L,38L,105L,98L,44L,10L,1L,71L,256L,315L,192L,65L,12L,1L,130L,594L,924L,726L,330L,90L,14L,1L,235L,1324L,2534L,2472L,1430L,520L,119L,16L,1L,420L,2860L,6588L,7776L,5522L,2535L,770L,152L,18L,1L,744L,6020L,16407L,22968L };
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
public class A238241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238241Inst : IEnumerable<long>
{
public static readonly long[] Value=A238241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238241.Bytes);
public long this[int i]=>Value[i];

public static A238241Inst Instance=new A238241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238242
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,97L,101L,103L,107L,113L,131L,137L,139L,149L,151L,157L,167L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,241L,257L,263L,269L,277L,281L,293L,307L,311L,313L,317L,337L,353L };
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
public class A238242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238242Inst : IEnumerable<long>
{
public static readonly long[] Value=A238242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238242.Bytes);
public long this[int i]=>Value[i];

public static A238242Inst Instance=new A238242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238243
{
public static readonly BigInteger[] Value={ 1L,3L,8L,26L,132L,1058L,13756L,288878L,9821854L,540201972L,48077975510L,6923228473442L,1613112234311988L,608143312335619478L,BigInteger.Parse("370967420524727881582"),BigInteger.Parse("366144844057906419121436"),BigInteger.Parse("584733315960476551336933294"),BigInteger.Parse("1510950888441871408654635631698") };
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
public class A238243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238243Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238243.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238243.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238243Inst Instance=new A238243Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238244
{
public static readonly BigInteger[] Value={ 1L,4L,11L,36L,183L,1467L,19074L,400557L,13618941L,749041758L,66664716465L,9599719170963L,2236734566834382L,843248931696562017L,BigInteger.Parse("514381848334902830373"),BigInteger.Parse("507694884306549093578154"),BigInteger.Parse("810788730237558902444311941"),BigInteger.Parse("2095078078933852203916102055547") };
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
public class A238244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238244Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238244.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238244.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238244Inst Instance=new A238244Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238245
{
public static readonly long[] Value={ 20L,39L,56L,71L,80L,84L,95L,104L,111L,116L,119L,120L,156L,180L,191L,224L,239L,255L,284L,296L,311L,320L,336L,351L,359L,380L,399L,404L,416L,431L,444L,455L,464L,471L,476L,479L,480L,500L,504L,551L,596L,599L,624L,639L,680L,695L,696L,719L,720L,756L,764L,791L,824L };
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
public class A238245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238245Inst : IEnumerable<long>
{
public static readonly long[] Value=A238245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238245.Bytes);
public long this[int i]=>Value[i];

public static A238245Inst Instance=new A238245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238246
{
public static readonly long[] Value={ 3L,5L,6L,7L,9L,10L,12L,13L,14L,15L,17L,18L,20L,24L,25L,26L,28L,29L,30L,31L,33L,34L,36L,40L,48L,49L,50L,52L,56L,57L,58L,60L,61L,62L,63L,65L,66L,68L,72L,80L,96L,97L,98L,100L,104L,112L,113L,114L,116L,120L,121L,122L,124L,125L,126L,127L,129L,130L,132L,136L,144L };
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
public class A238246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238246Inst : IEnumerable<long>
{
public static readonly long[] Value=A238246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238246.Bytes);
public long this[int i]=>Value[i];

public static A238246Inst Instance=new A238246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238247
{
public static readonly long[] Value={ 11L,19L,21L,22L,23L,27L,35L,37L,38L,39L,41L,42L,44L,45L,46L,47L,51L,53L,54L,55L,59L,67L,69L,70L,71L,73L,74L,76L,77L,78L,79L,81L,82L,84L,88L,89L,90L,92L,93L,94L,95L,99L,101L,102L,103L,105L,106L,108L,109L,110L,111L,115L,117L,118L,119L,123L,131L,133L,134L,135L };
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
public class A238247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238247Inst : IEnumerable<long>
{
public static readonly long[] Value=A238247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238247.Bytes);
public long this[int i]=>Value[i];

public static A238247Inst Instance=new A238247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238248
{
public static readonly long[] Value={ 43L,75L,83L,85L,86L,87L,91L,107L,139L,147L,149L,150L,151L,155L,163L,165L,166L,167L,169L,170L,172L,173L,174L,175L,179L,181L,182L,183L,187L,203L,211L,213L,214L,215L,219L,235L,267L,275L,277L,278L,279L,283L,291L,293L,294L,295L,297L,298L,300L,301L,302L,303L,307L };
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
public class A238248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238248Inst : IEnumerable<long>
{
public static readonly long[] Value=A238248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238248.Bytes);
public long this[int i]=>Value[i];

public static A238248Inst Instance=new A238248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238249
{
public static readonly long[] Value={ 44L,180L,804L,2818L,9991L,29995L,90225L,241945L,649320L,1605951L,3974215L,9269399L,21628177L,48322967L,107991481L,233776405L,506133563L,1070574873L,2264593031L,4710021487L,9796211590L,20129009598L,41359935334L,84255978136L,171637137305L };
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
public class A238249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238249Inst : IEnumerable<long>
{
public static readonly long[] Value=A238249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238249.Bytes);
public long this[int i]=>Value[i];

public static A238249Inst Instance=new A238249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238250
{
public static readonly long[] Value={ 121L,804L,6828L,43456L,284992L,1473792L,7616082L,32986844L,142361644L,537301496L,2020791427L,6843417893L,23099713493L,71683038307L,221767602558L,640525984280L,1844757869502L,5018918602972L,13619020527533L,35234899933725L };
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
public class A238250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238250Inst : IEnumerable<long>
{
public static readonly long[] Value=A238250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238250.Bytes);
public long this[int i]=>Value[i];

public static A238250Inst Instance=new A238250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238251
{
public static readonly long[] Value={ 286L,2818L,43456L,523578L,6683137L,65450601L,640472606L,5080416791L,40066932588L,267891545518L,1781590953402L,10371478598345L,60084341166190L,311815187891138L,1610762741432521L,7583058204030841L,35540971632237331L };
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
public class A238251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238251Inst : IEnumerable<long>
{
public static readonly long[] Value=A238251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238251.Bytes);
public long this[int i]=>Value[i];

public static A238251Inst Instance=new A238251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238252
{
public static readonly BigInteger[] Value={ 676L,9991L,284992L,6683137L,171041320L,3320993180L,64353451945L,992794904591L,15160526139045L,192941078342371L,2433696873065044L,26454369332527825L,285456371748779982L,2719536243017821050L,BigInteger.Parse("25745538460612968692") };
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
public class A238252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238252Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238252.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238252.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238252Inst Instance=new A238252Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238253
{
public static readonly BigInteger[] Value={ 1482L,29995L,1473792L,65450601L,3320993180L,128727296869L,5017308028639L,154350327958339L,4704917436206270L,118251124084419007L,2946366157111042290L,BigInteger.Parse("62617673607295964138"),BigInteger.Parse("1321308517824396221455"),BigInteger.Parse("24384005345308756975149") };
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
public class A238253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238253Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238253.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238253.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238253Inst Instance=new A238253Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238254
{
public static readonly BigInteger[] Value={ 3249L,90225L,7616082L,640472606L,64353451945L,5017308028639L,395035485087390L,24520763755992781L,1504227932142140703L,BigInteger.Parse("75758809125961889230") };
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
public class A238254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238254Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238254.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238254.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238254Inst Instance=new A238254Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238255
{
public static readonly long[] Value={ 16L,44L,44L,121L,180L,121L,286L,804L,804L,286L,676L,2818L,6828L,2818L,676L,1482L,9991L,43456L,43456L,9991L,1482L,3249L,29995L,284992L,523578L,284992L,29995L,3249L,6840L,90225L,1473792L,6683137L,6683137L,1473792L,90225L,6840L,14400L,241945L,7616082L };
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
public class A238255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238255Inst : IEnumerable<long>
{
public static readonly long[] Value=A238255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238255.Bytes);
public long this[int i]=>Value[i];

public static A238255Inst Instance=new A238255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238288
{
public static readonly long[] Value={ 2L,3L,4L,5L,4L,6L,0L,7L,5L,8L,0L,9L,6L,10L,0L,6L,11L,7L,0L,12L,0L,0L,13L,8L,7L,14L,0L,0L,15L,9L,0L,16L,0L,8L,17L,10L,0L,8L,18L,0L,0L,0L,19L,11L,9L,0L,20L,0L,0L,0L,21L,12L,0L,9L,22L,0L,10L,0L,23L,13L,0L,0L,24L,0L,0L,0L,25L,14L,11L,10L,26L,0L,0L,0L,10L };
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
public class A238288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238288Inst : IEnumerable<long>
{
public static readonly long[] Value=A238288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238288.Bytes);
public long this[int i]=>Value[i];

public static A238288Inst Instance=new A238288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238289
{
public static readonly long[] Value={ 2L,2L,17L,4L,1L,1L,59L,3L,56L,1L,39L,10L,9L,130L,2L,18L,11L,7L,80L,67L,2L,19L,27L,17L,92L,73L,180L,65L,5L,110L,282L,4L,6L,8L,16L,2L,23L,198L,20L,3L,99L,83L,217L,13L,110L,28L,16L,6L,5L,3L,144L,31L,9L,187L,176L,145L,75L,11L,43L,424L,4L,54L,272L,8L,26L,131L,123L,107L,8L,4L,52L,9L,127L,84L,264L,33L,145L,663L,16L,285L };
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
public class A238289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238289Inst : IEnumerable<long>
{
public static readonly long[] Value=A238289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238289.Bytes);
public long this[int i]=>Value[i];

public static A238289Inst Instance=new A238289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238290
{
public static readonly long[] Value={ 0L,8L,14L,22L,28L,36L,42L,50L,56L,64L,70L,78L,84L,92L,98L,106L,112L,120L,126L,134L,140L,148L,154L,162L,168L,176L,182L,190L,196L,204L,210L,218L,224L,232L,238L,246L,252L,260L,266L,274L,280L,288L,294L,302L,308L,316L,322L,330L,336L,344L,350L,358L,364L,372L,378L };
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
public class A238290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238290Inst : IEnumerable<long>
{
public static readonly long[] Value=A238290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238290.Bytes);
public long this[int i]=>Value[i];

public static A238290Inst Instance=new A238290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238291
{
public static readonly long[] Value={ 1L,0L,6L,6L,0L,0L,4L,6L,4L,0L,8L,6L,8L,0L,0L,6L,2L,0L,2L,0L,6L,0L,6L,6L,0L,0L,4L,6L,4L,0L,8L,6L,8L,0L,0L,6L,2L,0L,2L,0L,6L,0L,6L,6L,0L,0L,4L,6L,4L,0L,8L,6L,8L,0L,0L,6L,2L,0L,2L,0L,6L,0L,6L,6L,0L,0L,4L,6L,4L,0L,8L,6L,8L,0L,0L,6L,2L,0L,2L,0L,6L,0L,6L,6L,0L,0L };
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
public class A238291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238291Inst : IEnumerable<long>
{
public static readonly long[] Value=A238291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238291.Bytes);
public long this[int i]=>Value[i];

public static A238291Inst Instance=new A238291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238292
{
public static readonly long[] Value={ 1L,8L,4L,0L,0L,2L,6L,0L,4L,0L,2L,0L,8L,2L,0L,0L,2L,8L,8L,0L,6L,8L,4L,0L,0L,2L,6L,0L,4L,0L,2L,0L,8L,2L,0L,0L,2L,8L,8L,0L,6L,8L,4L,0L,0L,2L,6L,0L,4L,0L,2L,0L,8L,2L,0L,0L,2L,8L,8L,0L,6L,8L,4L,0L,0L,2L,6L,0L,4L,0L,2L,0L,8L,2L,0L,0L,2L,8L,8L,0L,6L,8L,4L,0L,0L,2L };
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
public class A238292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238292Inst : IEnumerable<long>
{
public static readonly long[] Value=A238292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238292.Bytes);
public long this[int i]=>Value[i];

public static A238292Inst Instance=new A238292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238293
{
public static readonly long[] Value={ 256L,1836L,13405L,99036L,730412L,5365422L,39447709L,290457856L,2138629508L,15729683540L,115738375440L,851696818464L,6268744175264L,46119373785696L,339401856662548L,2497274479295728L,18379234719307992L,135224806527545920L };
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
public class A238293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238293Inst : IEnumerable<long>
{
public static readonly long[] Value=A238293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238293.Bytes);
public long this[int i]=>Value[i];

public static A238293Inst Instance=new A238293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238294
{
public static readonly ulong[] Value={ 1836L,23854L,315906L,4268354L,57285970L,765288116L,10243514512L,137637981750L,1846283781696L,24725132097080L,331342908417490L,4445026705220610L,59603288970762934L,798804042986151504L,10707950110350589226UL };
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
public class A238294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238294Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A238294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238294.Bytes);
public ulong this[int i]=>Value[i];

public static A238294Inst Instance=new A238294Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238295
{
public static readonly BigInteger[] Value={ 13405L,315906L,7627878L,189073818L,4621997125L,112528419472L,2750034208462L,67554373314860L,1653215422083590L,40384241838941956L,988021656834724822L,BigInteger.Parse("24205805789517777368"),BigInteger.Parse("592400882429439387800"),BigInteger.Parse("14487758327615866854556") };
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
public class A238295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238295Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238295.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238295.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238295Inst Instance=new A238295Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238296
{
public static readonly BigInteger[] Value={ 99036L,4268354L,189073818L,8714280010L,392415712138L,17607428730016L,793898547448114L,36113159594023596L,1630891185537648740L,BigInteger.Parse("73494040914542031290"),BigInteger.Parse("3319592692476774408982"),BigInteger.Parse("150347785166980499644630") };
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
public class A238296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238296Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238296.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238296.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238296Inst Instance=new A238296Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238297
{
public static readonly BigInteger[] Value={ 730412L,57285970L,4621997125L,392415712138L,32281789838154L,2648594773768716L,218538547460489793L,18239725108894787920UL,BigInteger.Parse("1507149175338125338486"),BigInteger.Parse("124265177170827734010508"),BigInteger.Parse("10276688578460208497958970") };
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
public class A238297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238297Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238297.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238297.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238297Inst Instance=new A238297Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238298
{
public static readonly long[] Value={ 256L,1836L,1836L,13405L,23854L,13405L,99036L,315906L,315906L,99036L,730412L,4268354L,7627878L,4268354L,730412L,5365422L,57285970L,189073818L,189073818L,57285970L,5365422L,39447709L,765288116L,4621997125L,8714280010L,4621997125L };
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
public class A238298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238298Inst : IEnumerable<long>
{
public static readonly long[] Value=A238298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238298.Bytes);
public long this[int i]=>Value[i];

public static A238298Inst Instance=new A238298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238299
{
public static readonly BigInteger[] Value={ 1L,4L,24L,164L,1208L,9348L,74920L,616420L,5176296L,44182916L,382205048L,3343343268L,29523386968L,262826367748L,2356256046216L,21254326842596L,192766180154120L,1756758963727620L,16079466335134168L,147748236828875428L,1362397741935948024L,12603116216808465284UL,BigInteger.Parse("116929440001191010664") };
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
public class A238299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238299Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238299.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238299.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238299Inst Instance=new A238299Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238300
{
public static readonly BigInteger[] Value={ 1L,8L,64L,520L,4304L,36232L,309504L,2677128L,23405520L,206522888L,1836913216L,16452907016L,148274884688L,1343569891720L,12233903203328L,111883174439304L,1027244073375312L,9465236716896264L,87498251217286720L,811252609543727624L,7542152541765899728L,BigInteger.Parse("70294794046928531848") };
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
public class A238300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238300Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238300.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238300.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238300Inst Instance=new A238300Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238301
{
public static readonly long[] Value={ 7L,6L,8L,5L,9L,7L,5L,6L,0L,5L,9L,3L,1L,5L,5L,1L,9L,8L,5L,0L,8L,3L,7L,2L,4L,8L,6L,2L,3L,0L,6L,3L,4L,7L,3L,9L,3L,7L,1L,3L,9L,3L,6L,6L,4L,8L,9L,7L,7L,0L,0L,4L,2L,6L,9L,4L,2L,1L,8L,1L,7L,3L,5L,4L,1L,6L,0L,7L,8L,9L,3L,7L,7L,7L,9L,8L,8L,1L,4L,3L,5L,9L,3L,2L,4L,3L,3L,3L,0L,2L,9L,1L,4L,0L,0L,7L,2L,1L,3L,9L,7L,8L,9L,7L,7L,8L };
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
public class A238301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238301Inst : IEnumerable<long>
{
public static readonly long[] Value=A238301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238301.Bytes);
public long this[int i]=>Value[i];

public static A238301Inst Instance=new A238301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238302
{
public static readonly BigInteger[] Value={ 1L,1L,3L,18L,159L,1872L,27585L,488736L,10122273L,240029568L,6413759739L,190698235200L,6244960476447L,223354435468032L,8662843993599081L,362162307560207616L,16235331377066437185UL,BigInteger.Parse("776899798554908971008"),BigInteger.Parse("39526189786699908619635"),BigInteger.Parse("2130538920122365706916864") };
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
public class A238302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238302Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238302.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238302.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238302Inst Instance=new A238302Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238303
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L };
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
public class A238303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238303Inst : IEnumerable<long>
{
public static readonly long[] Value=A238303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238303.Bytes);
public long this[int i]=>Value[i];

public static A238303Inst Instance=new A238303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238336
{
public static readonly long[] Value={ 0L,2L,5L,7L,13L,11L,15L,44L,53L,46L,59L,23L,43L,278L,191L,143L,79L,119L,187L,62L,47L,221L,214L,1643L,159L,238L,95L,473L,314L,3583L,671L,474L,958L,3071L,5719L,215L,1439L,7423L,1663L,447L,223L,3695L,4346L,4318L,12983L,319L,35069L,5983L,5471L,8567L,959L,3067L };
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
public class A238336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238336Inst : IEnumerable<long>
{
public static readonly long[] Value=A238336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238336.Bytes);
public long this[int i]=>Value[i];

public static A238336Inst Instance=new A238336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238337
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,3L,4L,2L,1L,3L,6L,2L,5L,6L,7L,1L,3L,1L,4L,4L,5L,6L,12L,2L,2L,4L,1L,2L,6L,3L,6L,1L,2L,4L,4L,1L,4L,7L,6L,2L,6L,7L,13L,8L,4L,10L,21L,1L,1L,1L,2L,3L,9L,2L,3L,1L,3L,5L,11L,4L,13L,20L,4L,1L,2L,3L,4L,4L,8L,6L,9L,1L,4L,9L,2L,3L,7L,9L,17L,1L,1L,2L,3L,2L };
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
public class A238337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238337Inst : IEnumerable<long>
{
public static readonly long[] Value=A238337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238337.Bytes);
public long this[int i]=>Value[i];

public static A238337Inst Instance=new A238337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238338
{
public static readonly long[] Value={ 13L,26L,13L,47L,28L,46L,24L,17L,25L,14L,19L,47L,17L,34L,68L,13L,24L,46L,45L,17L,46L,28L,49L,28L,56L,14L,45L,19L,45L,37L,16L,48L,59L,46L,14L,18L,15L,56L,59L,26L,36L,29L,25L,37L,69L,28L,28L,56L,47L,68L,58L,29L,35L,17L,78L,48L,49L,68L,19L,27L,79L,46L,59L,37L,28L,17L };
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
public class A238338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238338Inst : IEnumerable<long>
{
public static readonly long[] Value=A238338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238338.Bytes);
public long this[int i]=>Value[i];

public static A238338Inst Instance=new A238338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238339
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,5L,5L,1L,1L,7L,13L,7L,1L,1L,9L,25L,29L,9L,1L,1L,11L,41L,79L,61L,11L,1L,1L,13L,61L,169L,241L,125L,13L,1L,1L,15L,85L,311L,681L,727L,253L,15L,1L,1L,17L,113L,517L,1561L,2729L,2185L,509L,17L,1L,1L,19L,145L,799L,3109L,7811L,10921L,6559L,1021L,19L,1L };
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
public class A238339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238339Inst : IEnumerable<long>
{
public static readonly long[] Value=A238339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238339.Bytes);
public long this[int i]=>Value[i];

public static A238339Inst Instance=new A238339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238340
{
public static readonly long[] Value={ 1L,5L,15L,34L,64L,108L,169L,249L,351L,478L,632L,816L,1033L,1285L,1575L,1906L,2280L,2700L,3169L,3689L,4263L,4894L,5584L,6336L,7153L,8037L,8991L,10018L,11120L,12300L,13561L,14905L,16335L,17854L,19464L,21168L,22969L,24869L,26871L,28978L,31192L,33516L,35953L };
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
public class A238340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238340Inst : IEnumerable<long>
{
public static readonly long[] Value=A238340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238340.Bytes);
public long this[int i]=>Value[i];

public static A238340Inst Instance=new A238340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238341
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,3L,0L,1L,0L,6L,1L,0L,1L,0L,12L,3L,0L,0L,1L,0L,23L,7L,1L,0L,0L,1L,0L,46L,13L,4L,0L,0L,0L,1L,0L,91L,25L,10L,1L,0L,0L,0L,1L,0L,183L,46L,21L,5L,0L,0L,0L,0L,1L,0L,367L,89L,39L,15L,1L,0L,0L,0L,0L,1L,0L,737L,175L,70L,35L,6L,0L,0L,0L,0L,0L,1L,0L,1478L,351L,125L,71L,21L,1L,0L,0L,0L,0L,0L,1L };
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
public class A238341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238341Inst : IEnumerable<long>
{
public static readonly long[] Value=A238341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238341.Bytes);
public long this[int i]=>Value[i];

public static A238341Inst Instance=new A238341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238342
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,3L,0L,1L,0L,3L,4L,0L,1L,0L,8L,3L,4L,0L,1L,0L,11L,10L,5L,5L,0L,1L,0L,20L,18L,14L,5L,6L,0L,1L,0L,34L,35L,24L,21L,6L,7L,0L,1L,0L,59L,60L,59L,35L,27L,7L,8L,0L,1L,0L,96L,121L,108L,85L,49L,35L,8L,9L,0L,1L,0L,167L,217L,213L,175L,125L,63L,44L,9L,10L,0L,1L,0L,282L,391L,419L,366L,258L,176L,80L,54L,10L,11L,0L,1L };
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
public class A238342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238342Inst : IEnumerable<long>
{
public static readonly long[] Value=A238342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238342.Bytes);
public long this[int i]=>Value[i];

public static A238342Inst Instance=new A238342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238343
{
public static readonly long[] Value={ 1L,1L,0L,2L,0L,0L,3L,1L,0L,0L,5L,3L,0L,0L,0L,7L,9L,0L,0L,0L,0L,11L,19L,2L,0L,0L,0L,0L,15L,41L,8L,0L,0L,0L,0L,0L,22L,77L,29L,0L,0L,0L,0L,0L,0L,30L,142L,81L,3L,0L,0L,0L,0L,0L,0L,42L,247L,205L,18L,0L,0L,0L,0L,0L,0L,0L,56L,421L,469L,78L,0L,0L,0L,0L,0L,0L,0L,0L,77L,689L,1013L,264L,5L,0L,0L,0L,0L,0L,0L,0L,0L,101L,1113L,2059L,786L,37L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
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
public class A238343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238343Inst : IEnumerable<long>
{
public static readonly long[] Value=A238343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238343.Bytes);
public long this[int i]=>Value[i];

public static A238343Inst Instance=new A238343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238344
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,5L,3L,7L,9L,11L,19L,2L,15L,41L,8L,22L,77L,29L,30L,142L,81L,3L,42L,247L,205L,18L,56L,421L,469L,78L,77L,689L,1013L,264L,5L,101L,1113L,2059L,786L,37L,135L,1750L,4021L,2097L,189L,176L,2712L,7558L,5179L,751L,8L,231L,4128L,13780L,11998L,2558L,73L,297L,6208L,24440L,26400L,7762L,429L };
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
public class A238344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238344Inst : IEnumerable<long>
{
public static readonly long[] Value=A238344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238344.Bytes);
public long this[int i]=>Value[i];

public static A238344Inst Instance=new A238344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238345
{
public static readonly long[] Value={ 1L,2L,0L,3L,1L,0L,5L,2L,1L,0L,8L,5L,2L,1L,0L,14L,9L,6L,2L,1L,0L,24L,18L,12L,7L,2L,1L,0L,43L,33L,25L,16L,8L,2L,1L,0L,77L,62L,49L,35L,21L,9L,2L,1L,0L,140L,115L,95L,73L,49L,27L,10L,2L,1L,0L,256L,215L,181L,148L,108L,68L,34L,11L,2L,1L,0L,472L,401L,346L,291L,230L,158L,93L,42L,12L,2L,1L,0L,874L,753L,657L,569L,470L,353L,228L,125L,51L,13L,2L,1L,0L };
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
public class A238345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238345Inst : IEnumerable<long>
{
public static readonly long[] Value=A238345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238345.Bytes);
public long this[int i]=>Value[i];

public static A238345Inst Instance=new A238345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238346
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,5L,5L,4L,1L,1L,8L,9L,8L,5L,1L,1L,14L,15L,15L,12L,6L,1L,1L,24L,27L,27L,24L,17L,7L,1L,1L,43L,47L,50L,46L,37L,23L,8L,1L,1L,77L,85L,90L,89L,75L,55L,30L,9L,1L,1L,140L,153L,165L,167L,152L,118L,79L,38L,10L,1L,1L,256L,279L,301L,313L,299L,250L,180L,110L,47L,11L,1L,1L,472L,511L,552L,582L,578L,516L,398L,267L,149L,57L,12L,1L,1L };
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
public class A238346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238346Inst : IEnumerable<long>
{
public static readonly long[] Value=A238346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238346.Bytes);
public long this[int i]=>Value[i];

public static A238346Inst Instance=new A238346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238347
{
public static readonly long[] Value={ 1L,2L,0L,3L,1L,0L,6L,2L,0L,0L,10L,5L,1L,0L,0L,20L,9L,3L,0L,0L,0L,37L,19L,7L,1L,0L,0L,0L,72L,36L,16L,4L,0L,0L,0L,0L,140L,71L,33L,11L,1L,0L,0L,0L,0L,275L,139L,67L,26L,5L,0L,0L,0L,0L,0L,540L,274L,135L,58L,16L,1L,0L,0L,0L,0L,0L,1069L,539L,269L,123L,42L,6L,0L,0L,0L,0L,0L,0L,2118L,1068L,534L,254L,99L,22L,1L,0L };
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
public class A238347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238347Inst : IEnumerable<long>
{
public static readonly long[] Value=A238347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238347.Bytes);
public long this[int i]=>Value[i];

public static A238347Inst Instance=new A238347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238348
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,3L,2L,1L,4L,4L,4L,3L,1L,5L,7L,8L,7L,4L,1L,8L,11L,14L,14L,11L,5L,1L,12L,18L,23L,27L,25L,16L,6L,1L,19L,27L,39L,49L,51L,41L,22L,7L,1L,28L,44L,64L,85L,98L,92L,63L,29L,8L,1L,45L,69L,103L,144L,180L,189L,155L,92L,37L,9L,1L,70L,109L,166L,241L,319L,366L,344L,247L,129L,46L,10L,1L };
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
public class A238348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238348Inst : IEnumerable<long>
{
public static readonly long[] Value=A238348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238348.Bytes);
public long this[int i]=>Value[i];

public static A238348Inst Instance=new A238348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238349
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,0L,2L,1L,1L,0L,3L,4L,1L,0L,0L,6L,7L,3L,0L,0L,0L,11L,16L,4L,1L,0L,0L,0L,22L,29L,12L,1L,0L,0L,0L,0L,42L,60L,23L,3L,0L,0L,0L,0L,0L,82L,120L,47L,7L,0L,0L,0L,0L,0L,0L,161L,238L,100L,12L,1L,0L,0L,0L,0L,0L,0L,316L,479L,198L,30L,1L,0L,0L,0L,0L,0L,0L,0L,624L,956L,404L,61L,3L,0L,0L,0L,0L,0L,0L,0L,0L,1235L,1910L,818L,126L,7L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
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
public class A238349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238349Inst : IEnumerable<long>
{
public static readonly long[] Value=A238349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238349.Bytes);
public long this[int i]=>Value[i];

public static A238349Inst Instance=new A238349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238350
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,2L,1L,1L,3L,4L,1L,6L,7L,3L,11L,16L,4L,1L,22L,29L,12L,1L,42L,60L,23L,3L,82L,120L,47L,7L,161L,238L,100L,12L,1L,316L,479L,198L,30L,1L,624L,956L,404L,61L,3L,1235L,1910L,818L,126L,7L,2449L,3817L,1652L,258L,16L,4864L,7633L,3319L,537L,30L,1L,9676L,15252L,6686L,1083L,70L,1L,19267L,30491L,13426L,2205L };
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
public class A238350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238350Inst : IEnumerable<long>
{
public static readonly long[] Value=A238350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238350.Bytes);
public long this[int i]=>Value[i];

public static A238350Inst Instance=new A238350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238351
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,6L,11L,22L,42L,82L,161L,316L,624L,1235L,2449L,4864L,9676L,19267L,38399L,76582L,152819L,305085L,609282L,1217140L,2431992L,4860306L,9714696L,19419870L,38824406L,77624110L,155208405L,310352615L,620601689L,1241036325L,2481803050L,4963170896L };
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
public class A238351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238351Inst : IEnumerable<long>
{
public static readonly long[] Value=A238351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238351.Bytes);
public long this[int i]=>Value[i];

public static A238351Inst Instance=new A238351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238384
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,2L,3L,2L,1L,1L,1L,1L,2L,3L,3L,2L,1L,1L,1L,1L,2L,3L,4L,3L,2L,1L,1L,1L,1L,2L,3L,4L,4L,3L,2L,1L,1L,1L,1L,2L,3L,4L,6L,4L,3L,2L,1L,1L,1L,1L,2L,3L,4L,6L,6L,4L,3L,2L,1L,1L,1L,1L,2L,3L,4L,6L };
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
public class A238384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238384Inst : IEnumerable<long>
{
public static readonly long[] Value=A238384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238384.Bytes);
public long this[int i]=>Value[i];

public static A238384Inst Instance=new A238384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238385
{
public static readonly long[] Value={ 1L,1L,1L,-1L,2L,1L,2L,-3L,3L,1L,-6L,8L,-6L,4L,1L,24L,-30L,20L,-10L,5L,1L,-120L,144L,-90L,40L,-15L,6L,1L,720L,-840L,504L,-210L,70L,-21L,7L,1L,-5040L,5760L,-3360L,1344L,-420L,112L,-28L,8L,1L,40320L,-45360L,25920L,-10080L,3024L,-756L,168L,-36L,9L,1L,-362880L,403200L,-226800L,86400L,-25200L,6048L,-1260L,240L,-45L,10L,1L };
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
public class A238385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238385Inst : IEnumerable<long>
{
public static readonly long[] Value=A238385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238385.Bytes);
public long this[int i]=>Value[i];

public static A238385Inst Instance=new A238385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238386
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,1L,0L,0L,0L,1L,1L,2L,2L,1L,2L,1L,2L,3L,2L,3L,3L,2L,3L,2L,2L,2L,2L,3L,1L,1L,2L,2L,3L,2L,1L,2L,1L,1L,3L,3L,2L,1L,1L,3L,3L,5L,5L,2L,2L,2L,3L,4L,5L,5L,4L,3L,2L,2L,2L,3L,2L,3L,4L,1L,3L,4L,3L,4L,6L,7L,6L,3L,2L,2L,2L,3L,4L,5L,3L };
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
public class A238386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238386Inst : IEnumerable<long>
{
public static readonly long[] Value=A238386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238386.Bytes);
public long this[int i]=>Value[i];

public static A238386Inst Instance=new A238386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238387
{
public static readonly long[] Value={ 2L,5L,1L,6L,6L,8L,8L,3L,3L,3L,5L,5L,0L,7L,9L,5L,2L,2L,1L,0L,2L,9L,2L,3L,4L,8L,3L,1L,0L,5L,3L,9L,6L,0L,6L,2L,3L,9L,8L,7L,5L,4L,1L,8L,0L,4L,0L,7L,3L,4L,2L,6L,6L,5L,5L,0L,8L,9L,2L,1L,4L,2L,0L,6L,1L,8L,5L,9L,6L,4L,7L,1L,4L,6L,9L,0L,7L,0L,6L,5L,0L,7L,9L,2L,9L,3L,0L };
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
public class A238387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238387Inst : IEnumerable<long>
{
public static readonly long[] Value=A238387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238387.Bytes);
public long this[int i]=>Value[i];

public static A238387Inst Instance=new A238387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238388
{
public static readonly long[] Value={ 3L,1L,2L,9L,5L,6L,4L,4L,3L,2L,9L,2L,5L,7L,2L,2L,1L,6L,1L,3L,6L,0L,8L,8L,7L,8L,6L,7L,6L,2L,9L,2L,1L,1L,6L,8L,0L,1L,1L,7L,9L,3L,6L,9L,8L,7L,0L,9L,7L,0L,5L,0L,8L,2L,9L,8L,0L,8L,2L,0L,0L,7L,3L,7L,1L,2L,2L,1L,1L,8L,2L,5L,3L,7L,1L,7L,2L,7L,9L,7L,9L,3L,4L,7L,6L,2L,5L };
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
public class A238388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238388Inst : IEnumerable<long>
{
public static readonly long[] Value=A238388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238388.Bytes);
public long this[int i]=>Value[i];

public static A238388Inst Instance=new A238388Inst();

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