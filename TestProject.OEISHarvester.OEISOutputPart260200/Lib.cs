using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A238110
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,10L,12L,18L,24L,30L,40L,60L,80L,111L,165L,246L,369L,596L,894L,1406L,2109L,3462L,5193L,8528L,12792L,21390L,32085L,53206L,79809L,135064L,202596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238110Inst : IEnumerable<long>
{
public static readonly long[] Value=A238110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238110.Bytes);
public long this[int i]=>Value[i];

public static A238110Inst Instance=new A238110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238111
{
public static readonly long[] Value={ 2L,4L,12L,44L,180L,788L,3612L,17116L,83172L,412196L,2075436L,10586892L,54595476L,284157492L,1490774076L,7875206076L,41854313412L,223636052036L,1200637707852L,6473448634348L,35037238641780L,190299310403924L,1036863750837852L,5665846701859484L,31042935297750180L,170499885177942628L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238111Inst : IEnumerable<long>
{
public static readonly long[] Value=A238111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238111.Bytes);
public long this[int i]=>Value[i];

public static A238111Inst Instance=new A238111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238176
{
public static readonly BigInteger[] Value={ 13447L,938601L,62220767L,4299264833L,296231759327L,20477016435713L,1415323543601575L,97848393158941641L,6764755034298286359L,BigInteger.Parse("467691084078389841001"),BigInteger.Parse("32334523298486930205287"),BigInteger.Parse("2235499269848346646569273") };
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
public class A238176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238176Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238176.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238176.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238176Inst Instance=new A238176Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238177
{
public static readonly BigInteger[] Value={ 79641L,12951743L,1917124097L,296231759327L,45437916131409L,6990206222515407L,1074790095990669977L,BigInteger.Parse("165289763647441313927"),BigInteger.Parse("25418549419229947264929"),BigInteger.Parse("3908964443570521894990351"),BigInteger.Parse("601134147109831035232694121") };
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
public class A238177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238177Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238177.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238177.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238177Inst Instance=new A238177Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238178
{
public static readonly BigInteger[] Value={ 479703L,180345769L,59356544695L,20477016435713L,6990206222515407L,2393955748528492505L,BigInteger.Parse("819219418493608549119"),BigInteger.Parse("280403032715254152090361"),BigInteger.Parse("95971012338423403955680535"),BigInteger.Parse("32847659961901588656466836065") };
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
public class A238178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238178Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238178.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238178.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238178Inst Instance=new A238178Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238179
{
public static readonly BigInteger[] Value={ 2918233L,2520461647L,1839517772097L,1415323543601575L,1074790095990669977L,BigInteger.Parse("819219418493608549119"),BigInteger.Parse("623815081258096395684729"),BigInteger.Parse("475145806308637114199428983"),BigInteger.Parse("361882122776558455831723569281") };
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
public class A238179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238179Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238179.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238179.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238179Inst Instance=new A238179Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238180
{
public static readonly long[] Value={ 81L,423L,423L,2329L,5321L,2329L,13447L,69023L,69023L,13447L,79641L,938601L,2027833L,938601L,79641L,479703L,12951743L,62220767L,62220767L,12951743L,479703L,2918233L,180345769L,1917124097L,4299264833L,1917124097L,180345769L,2918233L,17859079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238180Inst : IEnumerable<long>
{
public static readonly long[] Value=A238180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238180.Bytes);
public long this[int i]=>Value[i];

public static A238180Inst Instance=new A238180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238181
{
public static readonly long[] Value={ 1L,6L,5L,1L,9L,4L,2L,7L,9L,2L,7L,0L,4L,4L,9L,8L,6L,2L,3L,9L,6L,2L,6L,9L,3L,7L,6L,1L,1L,1L,4L,4L,9L,4L,0L,1L,6L,1L,1L,7L,6L,3L,1L,7L,5L,1L,5L,9L,6L,5L,6L,0L,6L,3L,3L,2L,1L,3L,8L,5L,2L,0L,9L,5L,6L,0L,8L,5L,9L,7L,5L,3L,0L,1L,0L,5L,3L,8L,0L,9L,8L,8L,2L,5L,7L,7L,6L,6L,5L,0L,0L,4L,2L,8L,2L,1L,7L,0L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238181Inst : IEnumerable<long>
{
public static readonly long[] Value=A238181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238181.Bytes);
public long this[int i]=>Value[i];

public static A238181Inst Instance=new A238181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238182
{
public static readonly long[] Value={ 1L,2L,2L,1L,8L,7L,9L,9L,4L,5L,3L,1L,9L,8L,8L,0L,1L,3L,8L,5L,1L,8L,8L,0L,6L,4L,7L,5L,2L,9L,0L,9L,9L,4L,8L,1L,2L,5L,6L,9L,0L,4L,1L,5L,4L,4L,0L,2L,1L,6L,7L,2L,4L,6L,4L,1L,8L,3L,5L,3L,3L,3L,5L,9L,8L,8L,7L,0L,0L,8L,1L,9L,3L,6L,3L,2L,7L,0L,4L,9L,6L,6L,6L,7L,7L,1L,5L,8L,6L,3L,0L,4L,6L,4L,5L,4L,4L,6L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238182Inst : IEnumerable<long>
{
public static readonly long[] Value=A238182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238182.Bytes);
public long this[int i]=>Value[i];

public static A238182Inst Instance=new A238182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238183
{
public static readonly long[] Value={ 1L,0L,1L,9L,4L,8L,3L,4L,9L,7L,4L,9L,4L,3L,8L,2L,2L,8L,6L,2L,0L,6L,4L,9L,6L,6L,7L,5L,9L,2L,8L,1L,2L,6L,5L,1L,5L,0L,6L,1L,8L,9L,4L,4L,2L,2L,9L,0L,4L,2L,8L,8L,8L,6L,3L,3L,3L,4L,0L,1L,4L,6L,3L,1L,6L,1L,9L,8L,5L,3L,7L,4L,0L,0L,6L,8L,7L,3L,5L,5L,5L,0L,0L,2L,7L,3L,1L,4L,6L,2L,1L,0L,0L,3L,1L,6L,6L,5L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238183Inst : IEnumerable<long>
{
public static readonly long[] Value=A238183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238183.Bytes);
public long this[int i]=>Value[i];

public static A238183Inst Instance=new A238183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238184
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,4L,7L,16L,37L,107L,282L,1020L,2879L,12507L,39347L,179231L,687974L,3225246L,14955561L,75999551L,392585613L,2271201137L,12183159188L,81562521256L,446611878413L,3336304592155L,19202329389234L,152803821604669L,958953289839930L,7835058287650579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238184Inst : IEnumerable<long>
{
public static readonly long[] Value=A238184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238184.Bytes);
public long this[int i]=>Value[i];

public static A238184Inst Instance=new A238184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238185
{
public static readonly long[] Value={ 2L,23L,97L,163L,463L,491L,557L,659L,677L,977L,1033L,1151L,1187L,1429L,1439L,1511L,1579L,1663L,1933L,2111L,2113L,2141L,2381L,2969L,3301L,3491L,3803L,3929L,4201L,4421L,4447L,4513L,4547L,4789L,5039L,5273L,5281L,5303L,5309L,5449L,5669L,5741L,5939L,5981L,6053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238185Inst : IEnumerable<long>
{
public static readonly long[] Value=A238185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238185.Bytes);
public long this[int i]=>Value[i];

public static A238185Inst Instance=new A238185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238186
{
public static readonly long[] Value={ 79L,107L,127L,151L,173L,179L,181L,199L,223L,227L,233L,251L,271L,307L,331L,367L,409L,421L,431L,439L,443L,457L,491L,521L,541L,569L,577L,641L,653L,659L,709L,727L,733L,743L,809L,823L,829L,919L,941L,947L,991L,997L,1009L,1021L,1087L,1109L,1129L,1171L,1187L,1201L,1213L,1231L,1249L,1259L,1301L,1321L,1327L,1361L,1373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238186Inst : IEnumerable<long>
{
public static readonly long[] Value=A238186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238186.Bytes);
public long this[int i]=>Value[i];

public static A238186Inst Instance=new A238186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238187
{
public static readonly long[] Value={ 4L,5L,5L,5L,9L,25L,65L,145L,289L,545L,1025L,1985L,3969L,8065L,16385L,33025L,66049L,131585L,262145L,523265L,1046529L,2095105L,4194305L,8392705L,16785409L,33562625L,67108865L,134201345L,268402689L,536838145L,1073741825L,2147549185L,4295098369L,8590065665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238187Inst : IEnumerable<long>
{
public static readonly long[] Value=A238187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238187.Bytes);
public long this[int i]=>Value[i];

public static A238187Inst Instance=new A238187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238188
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,2L,3L,9L,11L,13L,15L,48L,57L,68L,81L,254L,302L,359L,427L,1342L,1596L,1898L,2257L,7093L,8435L,10031L,11929L,37488L,44581L,53016L,63047L,198132L,235620L,280201L,333217L,1047170L,1245302L,1480922L,1761123L,5534517L,6581687L,7826989L,9307911L,29251104L,34785621L,41367308L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238188Inst : IEnumerable<long>
{
public static readonly long[] Value=A238188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238188.Bytes);
public long this[int i]=>Value[i];

public static A238188Inst Instance=new A238188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238189
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,2L,1L,4L,7L,3L,1L,1L,4L,13L,10L,4L,1L,6L,23L,33L,22L,6L,1L,1L,6L,34L,68L,72L,30L,6L,1L,8L,49L,139L,204L,145L,54L,8L,1L,1L,8L,65L,230L,467L,476L,269L,70L,9L,1L,10L,85L,377L,961L,1348L,1080L,472L,111L,12L,1L,1L,10L,106L,552L,1767L,3188L,3454L,2156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238189Inst : IEnumerable<long>
{
public static readonly long[] Value=A238189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238189.Bytes);
public long this[int i]=>Value[i];

public static A238189Inst Instance=new A238189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238190
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,2L,2L,1L,3L,4L,1L,3L,8L,1L,4L,12L,3L,1L,4L,18L,8L,1L,5L,24L,22L,1L,5L,32L,40L,6L,1L,6L,40L,73L,22L,1L,6L,50L,112L,66L,1L,7L,60L,172L,146L,10L,1L,7L,72L,240L,292L,48L,1L,8L,84L,335L,516L,174L,1L,8L,98L,440L,860L,448L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238190Inst : IEnumerable<long>
{
public static readonly long[] Value=A238190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238190.Bytes);
public long this[int i]=>Value[i];

public static A238190Inst Instance=new A238190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238191
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,2L,6L,4L,3L,6L,2L,5L,2L,9L,5L,6L,9L,7L,4L,6L,9L,3L,4L,9L,5L,6L,4L,1L,2L,6L,2L,6L,9L,7L,6L,4L,1L,5L,9L,6L,6L,2L,9L,7L,7L,6L,5L,6L,5L,7L,3L,6L,9L,1L,7L,8L,3L,8L,4L,2L,6L,7L,6L,4L,5L,8L,2L,6L,2L,6L,6L,1L,7L,2L,3L,2L,7L,2L,8L,9L,7L,7L,2L,5L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238191Inst : IEnumerable<long>
{
public static readonly long[] Value=A238191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238191.Bytes);
public long this[int i]=>Value[i];

public static A238191Inst Instance=new A238191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238208
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,0L,1L,1L,2L,2L,3L,3L,4L,4L,5L,6L,7L,8L,10L,12L,14L,17L,20L,24L,28L,33L,38L,45L,52L,60L,69L,80L,91L,105L,120L,137L,156L,178L,202L,230L,261L,295L,334L,378L,426L,481L,542L,609L,685L,769L,862L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238208Inst : IEnumerable<long>
{
public static readonly long[] Value=A238208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238208.Bytes);
public long this[int i]=>Value[i];

public static A238208Inst Instance=new A238208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238209
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,1L,1L,1L,2L,2L,3L,3L,4L,4L,6L,6L,8L,9L,11L,13L,16L,18L,22L,26L,30L,35L,41L,48L,55L,64L,73L,85L,97L,111L,127L,146L,165L,189L,214L,244L,276L,313L,353L,400L,451L,508L,572L,644L,722L,811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238209Inst : IEnumerable<long>
{
public static readonly long[] Value=A238209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238209.Bytes);
public long this[int i]=>Value[i];

public static A238209Inst Instance=new A238209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238210
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,1L,0L,1L,2L,2L,2L,3L,3L,4L,5L,6L,7L,8L,10L,12L,14L,17L,20L,23L,28L,32L,37L,44L,51L,58L,68L,78L,89L,103L,118L,134L,154L,175L,199L,227L,257L,291L,330L,373L,421L,475L,535L,602L,677L,760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238210Inst : IEnumerable<long>
{
public static readonly long[] Value=A238210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238210.Bytes);
public long this[int i]=>Value[i];

public static A238210Inst Instance=new A238210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238211
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,1L,2L,3L,3L,3L,5L,5L,6L,7L,9L,11L,13L,15L,18L,21L,25L,29L,34L,40L,46L,54L,62L,71L,82L,95L,108L,124L,142L,162L,184L,210L,238L,271L,306L,346L,392L,443L,498L,561L,632L,710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238211Inst : IEnumerable<long>
{
public static readonly long[] Value=A238211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238211.Bytes);
public long this[int i]=>Value[i];

public static A238211Inst Instance=new A238211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238212
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,2L,1L,2L,2L,3L,5L,4L,5L,7L,8L,10L,11L,13L,16L,19L,23L,26L,31L,36L,42L,49L,56L,65L,75L,86L,100L,114L,130L,149L,170L,193L,220L,250L,283L,321L,363L,410L,463L,522L,587L,660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238212Inst : IEnumerable<long>
{
public static readonly long[] Value=A238212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238212.Bytes);
public long this[int i]=>Value[i];

public static A238212Inst Instance=new A238212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238213
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,2L,2L,2L,2L,3L,4L,5L,6L,7L,8L,10L,12L,15L,17L,20L,23L,27L,33L,38L,44L,51L,59L,68L,79L,91L,104L,119L,136L,155L,178L,202L,230L,261L,296L,335L,379L,428L,483L,544L,612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238213Inst : IEnumerable<long>
{
public static readonly long[] Value=A238213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238213.Bytes);
public long this[int i]=>Value[i];

public static A238213Inst Instance=new A238213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238214
{
public static readonly long[] Value={ 1L,8L,1L,8L,5L,7L,0L,0L,5L,6L,7L,5L,3L,3L,1L,4L,0L,0L,3L,6L,2L,7L,0L,7L,1L,3L,9L,2L,1L,9L,5L,2L,2L,8L,9L,3L,2L,3L,6L,9L,6L,8L,0L,2L,7L,1L,5L,5L,5L,5L,9L,7L,7L,6L,4L,9L,9L,7L,3L,7L,1L,0L,8L,1L,6L,6L,2L,4L,6L,1L,7L,8L,1L,3L,2L,5L,8L,9L,2L,5L,2L,1L,6L,9L,1L,3L,5L,1L,8L,6L,9L,8L,0L,4L,8L,4L,3L,2L,3L,8L,9L,5L,4L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238214Inst : IEnumerable<long>
{
public static readonly long[] Value=A238214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238214.Bytes);
public long this[int i]=>Value[i];

public static A238214Inst Instance=new A238214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238215
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,4L,5L,6L,8L,9L,11L,13L,15L,18L,21L,24L,28L,33L,38L,44L,51L,59L,68L,79L,90L,104L,119L,136L,156L,178L,202L,230L,261L,296L,335L,379L,427L,482L,543L,610L,686L,770L,863L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238215Inst : IEnumerable<long>
{
public static readonly long[] Value=A238215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238215.Bytes);
public long this[int i]=>Value[i];

public static A238215Inst Instance=new A238215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238216
{
public static readonly long[] Value={ 3L,5L,13L,29L,61L,127L,257L,641L,1409L,2879L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238216Inst : IEnumerable<long>
{
public static readonly long[] Value=A238216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238216.Bytes);
public long this[int i]=>Value[i];

public static A238216Inst Instance=new A238216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238217
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,2L,2L,3L,3L,5L,5L,7L,8L,10L,11L,14L,16L,19L,22L,26L,30L,35L,41L,47L,55L,63L,73L,84L,97L,110L,127L,145L,166L,188L,215L,243L,277L,313L,354L,400L,452L,508L,573L,644L,723L,811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238217Inst : IEnumerable<long>
{
public static readonly long[] Value=A238217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238217.Bytes);
public long this[int i]=>Value[i];

public static A238217Inst Instance=new A238217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238218
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,0L,1L,1L,1L,2L,2L,2L,3L,4L,5L,6L,7L,9L,10L,12L,15L,17L,20L,24L,27L,32L,38L,43L,50L,59L,67L,77L,90L,102L,117L,135L,153L,175L,200L,226L,257L,292L,330L,373L,422L,475L,535L,603L,677L,760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238218Inst : IEnumerable<long>
{
public static readonly long[] Value=A238218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238218.Bytes);
public long this[int i]=>Value[i];

public static A238218Inst Instance=new A238218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238219
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,2L,1L,2L,3L,4L,4L,5L,6L,8L,9L,11L,13L,16L,18L,21L,25L,29L,34L,40L,46L,53L,62L,71L,82L,94L,108L,124L,142L,161L,185L,210L,238L,270L,307L,347L,392L,442L,499L,562L,632L,709L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238219Inst : IEnumerable<long>
{
public static readonly long[] Value=A238219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238219.Bytes);
public long this[int i]=>Value[i];

public static A238219Inst Instance=new A238219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238220
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,2L,2L,2L,3L,3L,5L,6L,7L,8L,9L,12L,14L,16L,19L,22L,27L,31L,36L,42L,48L,56L,65L,75L,86L,99L,114L,130L,149L,170L,193L,220L,250L,283L,321L,364L,410L,463L,522L,587L,661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238220Inst : IEnumerable<long>
{
public static readonly long[] Value=A238220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238220.Bytes);
public long this[int i]=>Value[i];

public static A238220Inst Instance=new A238220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238221
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,2L,3L,3L,4L,4L,6L,7L,9L,11L,12L,14L,17L,20L,24L,28L,32L,37L,44L,51L,59L,69L,78L,90L,104L,119L,136L,156L,177L,202L,230L,261L,296L,336L,379L,428L,483L,544L,612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238221Inst : IEnumerable<long>
{
public static readonly long[] Value=A238221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238221.Bytes);
public long this[int i]=>Value[i];

public static A238221Inst Instance=new A238221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238222
{
public static readonly long[] Value={ 1L,4L,24L,29L,34L,69L,84L,99L,109L,224L,229L,259L,284L,289L,319L,389L,409L,474L,489L,494L,514L,589L,679L,694L,709L,749L,759L,844L,949L,1079L,1099L,1134L,1174L,1189L,1194L,1269L,1294L,1304L,1329L,1364L,1409L,1474L,1714L,1749L,1784L,1844L,1854L,1924L,2014L,2059L,2099L,2149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238222Inst : IEnumerable<long>
{
public static readonly long[] Value=A238222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238222.Bytes);
public long this[int i]=>Value[i];

public static A238222Inst Instance=new A238222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238223
{
public static readonly long[] Value={ 2L,1L,7L,9L,5L,0L,7L,8L,9L,4L,4L,7L,1L,5L,1L,0L,6L,5L,4L,9L,2L,8L,2L,2L,8L,2L,2L,4L,4L,2L,3L,1L,9L,8L,2L,0L,8L,8L,6L,6L,0L,4L,5L,3L,9L,5L,6L,2L,9L,3L,9L,9L,6L,3L,4L,8L,1L,2L,3L,4L,0L,1L,7L,6L,2L,6L,5L,8L,7L,3L,3L,6L,2L,9L,2L,5L,3L,7L,0L,9L,4L,4L,9L,1L,2L,5L,9L,6L,3L,2L,2L,9L,8L,6L,2L,2L,9L,4L,5L,1L,4L,4L,8L,8L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238223Inst : IEnumerable<long>
{
public static readonly long[] Value=A238223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238223.Bytes);
public long this[int i]=>Value[i];

public static A238223Inst Instance=new A238223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238256
{
public static readonly long[] Value={ 1L,2L,3L,5L,5L,7L,11L,11L,13L,17L,17L,19L,19L,19L,23L,29L,29L,29L,31L,31L,37L,41L,41L,43L,43L,43L,47L,47L,47L,53L,59L,59L,59L,61L,61L,67L,71L,71L,71L,73L,73L,79L,79L,79L,83L,83L,83L,83L,89L,89L,97L,101L,101L,103L,107L,107L,109L,109L,109L,109L,109L,109L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238256Inst : IEnumerable<long>
{
public static readonly long[] Value=A238256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238256.Bytes);
public long this[int i]=>Value[i];

public static A238256Inst Instance=new A238256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238257
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,15L,17L,19L,35L,37L,39L,55L,57L,59L,75L,77L,79L,95L,97L,99L,155L,157L,159L,175L,177L,179L,195L,197L,199L,355L,357L,359L,375L,377L,379L,395L,397L,399L,555L,557L,559L,575L,577L,579L,595L,597L,599L,755L,757L,759L,775L,777L,779L,795L,797L,799L,955L,957L,959L,975L,977L,979L,995L,997L,999L,1555L,1557L,1559L,1575L,1577L,1579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238257Inst : IEnumerable<long>
{
public static readonly long[] Value=A238257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238257.Bytes);
public long this[int i]=>Value[i];

public static A238257Inst Instance=new A238257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238258
{
public static readonly long[] Value={ 3L,0L,8L,8L,2L,7L,7L,3L,0L,4L,7L,4L,1L,7L,4L,0L,1L,7L,9L,1L,1L,5L,8L,4L,0L,0L,8L,2L,0L,2L,5L,4L,3L,8L,2L,7L,6L,8L,3L,6L,4L,4L,4L,8L,9L,7L,1L,4L,2L,0L,1L,3L,8L,7L,6L,7L,2L,4L,7L,7L,3L,0L,1L,2L,1L,7L,6L,5L,1L,6L,8L,1L,2L,7L,8L,8L,2L,6L,6L,6L,6L,9L,5L,2L,0L,3L,2L,7L,1L,1L,3L,0L,9L,6L,1L,9L,4L,6L,0L,0L,9L,7L,3L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238258Inst : IEnumerable<long>
{
public static readonly long[] Value=A238258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238258.Bytes);
public long this[int i]=>Value[i];

public static A238258Inst Instance=new A238258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238259
{
public static readonly long[] Value={ 0L,4L,16L,36L,64L,121L,196L,289L,441L,576L,784L,1024L,1369L,1681L,2116L,2500L,3025L,3600L,4356L,5041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238259Inst : IEnumerable<long>
{
public static readonly long[] Value=A238259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238259.Bytes);
public long this[int i]=>Value[i];

public static A238259Inst Instance=new A238259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238260
{
public static readonly long[] Value={ 6L,3L,1L,2L,6L,6L,8L,7L,8L,8L,7L,4L,1L,1L,5L,4L,6L,7L,9L,7L,0L,0L,4L,8L,2L,3L,2L,5L,7L,9L,7L,0L,6L,8L,7L,9L,5L,5L,6L,1L,5L,4L,6L,9L,0L,5L,1L,4L,4L,6L,1L,1L,4L,0L,8L,9L,2L,0L,0L,6L,9L,7L,3L,4L,0L,5L,0L,8L,5L,4L,1L,5L,0L,3L,7L,6L,6L,1L,7L,0L,8L,5L,6L,0L,4L,0L,0L,8L,5L,0L,1L,7L,6L,1L,1L,0L,9L,3L,3L,5L,4L,6L,3L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238260Inst : IEnumerable<long>
{
public static readonly long[] Value=A238260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238260.Bytes);
public long this[int i]=>Value[i];

public static A238260Inst Instance=new A238260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238261
{
public static readonly long[] Value={ 4L,9L,1L,0L,8L,1L,4L,9L,6L,4L,5L,6L,8L,2L,5L,5L,8L,9L,8L,7L,5L,1L,5L,3L,4L,8L,0L,5L,2L,4L,0L,3L,5L,2L,1L,9L,7L,8L,9L,8L,7L,0L,5L,2L,8L,1L,7L,6L,7L,8L,4L,7L,1L,7L,6L,1L,3L,9L,4L,1L,1L,2L,0L,2L,2L,5L,6L,4L,1L,7L,8L,7L,7L,8L,7L,9L,9L,4L,7L,9L,7L,2L,9L,5L,1L,8L,1L,9L,7L,4L,1L,5L,3L,5L,5L,4L,4L,6L,1L,4L,2L,5L,0L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238261Inst : IEnumerable<long>
{
public static readonly long[] Value=A238261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238261.Bytes);
public long this[int i]=>Value[i];

public static A238261Inst Instance=new A238261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238262
{
public static readonly long[] Value={ 2L,4L,2L,5L,2L,1L,9L,1L,2L,8L,1L,5L,2L,3L,5L,9L,8L,5L,9L,4L,9L,3L,2L,1L,0L,8L,0L,3L,8L,6L,3L,9L,2L,0L,2L,9L,5L,1L,3L,8L,3L,2L,8L,7L,2L,3L,5L,3L,2L,7L,6L,1L,2L,1L,1L,5L,4L,1L,0L,1L,7L,8L,0L,6L,6L,8L,7L,0L,5L,1L,9L,4L,8L,3L,8L,5L,5L,0L,9L,5L,1L,1L,5L,9L,2L,0L,4L,4L,5L,3L,9L,3L,9L,9L,8L,0L,6L,5L,5L,0L,4L,2L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238262Inst : IEnumerable<long>
{
public static readonly long[] Value=A238262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238262.Bytes);
public long this[int i]=>Value[i];

public static A238262Inst Instance=new A238262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238263
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,7L,7L,8L,8L,9L,9L,9L,9L,10L,10L,11L,11L,12L,12L,13L,12L,13L,13L,13L,13L,14L,13L,14L,14L,14L,14L,15L,14L,15L,16L,15L,15L,17L,16L,18L,18L,17L,17L,20L,18L,19L,19L,18L,18L,21L,18L,19L,21L,19L,20L,21L,18L,20L,20L,20L,18L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238263Inst : IEnumerable<long>
{
public static readonly long[] Value=A238263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238263.Bytes);
public long this[int i]=>Value[i];

public static A238263Inst Instance=new A238263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238264
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,12L,14L,18L,20L,24L,26L,28L,30L,36L,42L,45L,48L,50L,56L,54L,60L,80L,72L,81L,93L,84L,115L,90L,110L,105L,114L,108L,129L,120L,132L,144L,153L,205L,150L,165L,186L,168L,189L,195L,204L,180L,231L,216L,234L,246L,210L,279L,276L,255L,240L,252L,288L,270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238264Inst : IEnumerable<long>
{
public static readonly long[] Value=A238264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238264.Bytes);
public long this[int i]=>Value[i];

public static A238264Inst Instance=new A238264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238265
{
public static readonly long[] Value={ 2L,3L,23L,6911L,238878721L,5944066965503999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238265Inst : IEnumerable<long>
{
public static readonly long[] Value=A238265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238265.Bytes);
public long this[int i]=>Value[i];

public static A238265Inst Instance=new A238265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238266
{
public static readonly long[] Value={ 3L,5L,7L,9L,11L,13L,17L,19L,23L,25L,27L,31L,37L,43L,47L,49L,53L,71L,79L,70L,89L,97L,103L,87L,113L,139L,157L,163L,191L,181L,199L,223L,241L,239L,271L,251L,311L,313L,293L,347L,353L,383L,397L,421L,463L,499L,523L,541L,467L,577L,607L,619L,613L,661L,631L,751L,719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238266Inst : IEnumerable<long>
{
public static readonly long[] Value=A238266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238266.Bytes);
public long this[int i]=>Value[i];

public static A238266Inst Instance=new A238266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238267
{
public static readonly long[] Value={ 2L,2L,2L,2L,2L,2L,4L,2L,4L,2L,2L,3L,6L,6L,4L,2L,3L,8L,6L,5L,9L,5L,9L,2L,6L,10L,9L,9L,8L,6L,13L,8L,7L,13L,8L,10L,15L,5L,13L,12L,17L,13L,8L,9L,13L,13L,15L,17L,13L,10L,20L,10L,14L,19L,14L,21L,14L,13L,14L,14L,14L,20L,10L,20L,16L,25L,15L,18L,21L,16L,20L,22L,13L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238267Inst : IEnumerable<long>
{
public static readonly long[] Value=A238267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238267.Bytes);
public long this[int i]=>Value[i];

public static A238267Inst Instance=new A238267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238268
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,3L,2L,3L,3L,3L,3L,4L,4L,3L,3L,4L,4L,3L,3L,5L,4L,4L,4L,5L,4L,4L,3L,4L,6L,4L,3L,7L,4L,3L,5L,6L,5L,5L,5L,6L,7L,4L,4L,9L,5L,5L,7L,6L,5L,5L,4L,5L,7L,4L,3L,10L,4L,4L,8L,8L,7L,7L,5L,6L,8L,5L,4L,10L,5L,5L,9L,8L,7L,8L,5L,7L,9L,5L,4L,13L,8L,6L,8L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238268Inst : IEnumerable<long>
{
public static readonly long[] Value=A238268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238268.Bytes);
public long this[int i]=>Value[i];

public static A238268Inst Instance=new A238268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238269
{
public static readonly long[] Value={ 4L,6L,8L,16L,24L,33L,36L,63L,48L,60L,93L,140L,84L,108L,132L,189L,165L,144L,120L,210L,297L,168L,204L,180L,276L,252L,285L,288L,462L,240L,372L,432L,336L,300L,396L,609L,360L,492L,552L,468L,564L,528L,576L,504L,708L,1089L,648L,480L,420L,540L,768L,672L,600L,816L,792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238269Inst : IEnumerable<long>
{
public static readonly long[] Value=A238269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238269.Bytes);
public long this[int i]=>Value[i];

public static A238269Inst Instance=new A238269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238270
{
public static readonly long[] Value={ 1L,0L,2L,0L,1L,1L,3L,3L,4L,8L,1L,7L,8L,1L,0L,3L,6L,4L,7L,4L,3L,0L,3L,6L,3L,9L,3L,9L,3L,1L,8L,2L,4L,3L,5L,1L,5L,4L,3L,6L,1L,0L,4L,9L,2L,5L,1L,0L,2L,9L,1L,0L,7L,3L,5L,8L,7L,3L,8L,8L,0L,3L,2L,5L,9L,0L,9L,3L,7L,2L,7L,6L,0L,5L,1L,9L,5L,2L,3L,3L,8L,4L,2L,8L,4L,8L,3L,6L,8L,4L,7L,8L,5L,5L,2L,0L,3L,8L,8L,9L,6L,6L,7L,3L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238270Inst : IEnumerable<long>
{
public static readonly long[] Value=A238270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238270.Bytes);
public long this[int i]=>Value[i];

public static A238270Inst Instance=new A238270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238271
{
public static readonly long[] Value={ 1L,8L,1L,9L,9L,5L,3L,8L,6L,7L,0L,2L,6L,3L,3L,8L,8L,7L,8L,2L,7L,8L,0L,0L,1L,0L,0L,3L,0L,0L,5L,6L,5L,5L,7L,3L,2L,2L,6L,3L,4L,4L,9L,8L,0L,1L,3L,5L,3L,8L,3L,0L,6L,1L,7L,5L,9L,2L,4L,9L,4L,7L,7L,1L,6L,3L,2L,4L,2L,0L,4L,8L,3L,6L,8L,5L,0L,5L,4L,1L,6L,4L,2L,2L,8L,9L,8L,3L,9L,5L,7L,7L,6L,4L,9L,2L,3L,9L,9L,0L,2L,6L,9L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238271Inst : IEnumerable<long>
{
public static readonly long[] Value=A238271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238271.Bytes);
public long this[int i]=>Value[i];

public static A238271Inst Instance=new A238271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238320
{
public static readonly BigInteger[] Value={ 121L,9489L,405636L,13265123L,459256128L,17315827838L,658399071392L,24577532667851L,910817281935043L,33837788379096408L,1260231451310023356L,BigInteger.Parse("46939033254320776972"),BigInteger.Parse("1747281376213884382709"),BigInteger.Parse("65029646539397230908874") };
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
public class A238320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238320Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238320.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238320.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238320Inst Instance=new A238320Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238321
{
public static readonly BigInteger[] Value={ 292L,50232L,4245918L,261676376L,17315827838L,1266938409578L,93481623913793L,6747651769489946L,483084194221969236L,BigInteger.Parse("34692892698038230306"),BigInteger.Parse("2498614025548228474087"),BigInteger.Parse("179957391346727247579782") };
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
public class A238321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238321Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238321.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238321.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238321Inst Instance=new A238321Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238322
{
public static readonly BigInteger[] Value={ 704L,267174L,44773061L,5206684654L,658399071392L,93481623913793L,13394202897232848L,1870978944598208826L,BigInteger.Parse("258935263347125019228"),BigInteger.Parse("35966277167888104298602"),BigInteger.Parse("5012062141964637477653480") };
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
public class A238322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238322Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238322.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238322.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238322Inst Instance=new A238322Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238323
{
public static readonly long[] Value={ 3L,9L,9L,22L,67L,22L,51L,376L,376L,51L,121L,1867L,4294L,1867L,121L,292L,9489L,41046L,41046L,9489L,292L,704L,50232L,405636L,721939L,405636L,50232L,704L,1691L,267174L,4245918L,13265123L,13265123L,4245918L,267174L,1691L,4059L,1408341L,44773061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238323Inst : IEnumerable<long>
{
public static readonly long[] Value=A238323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238323.Bytes);
public long this[int i]=>Value[i];

public static A238323Inst Instance=new A238323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238324
{
public static readonly long[] Value={ 1L,4L,9L,2L,11L,22L,9L,24L,7L,26L,5L,28L,3L,30L,1L,32L,65L,30L,67L,28L,69L,26L,71L,24L,73L,22L,75L,20L,77L,18L,79L,16L,81L,14L,83L,12L,85L,10L,87L,8L,89L,6L,91L,4L,93L,2L,95L,190L,93L,192L,91L,194L,89L,196L,87L,198L,85L,200L,83L,202L,81L,204L,79L,206L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238324Inst : IEnumerable<long>
{
public static readonly long[] Value=A238324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238324.Bytes);
public long this[int i]=>Value[i];

public static A238324Inst Instance=new A238324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238325
{
public static readonly long[] Value={ 1L,2L,2L,1L,2L,3L,2L,2L,3L,2L,2L,6L,1L,2L,2L,4L,3L,4L,2L,2L,4L,6L,2L,6L,2L,2L,4L,4L,2L,3L,9L,4L,2L,2L,4L,4L,2L,6L,6L,3L,12L,1L,2L,2L,4L,4L,2L,4L,6L,3L,6L,6L,12L,5L,2L,2L,4L,4L,2L,4L,6L,6L,4L,6L,3L,18L,2L,4L,10L,2L,2L,4L,4L,2L,4L,6L,4L,4L,6L,3L,6L,12L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238325Inst : IEnumerable<long>
{
public static readonly long[] Value=A238325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238325.Bytes);
public long this[int i]=>Value[i];

public static A238325Inst Instance=new A238325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238326
{
public static readonly long[] Value={ 1L,2L,3L,4L,1L,5L,2L,6L,3L,2L,7L,4L,4L,8L,5L,6L,3L,9L,6L,8L,6L,1L,10L,7L,10L,9L,4L,2L,11L,8L,12L,12L,8L,3L,2L,12L,9L,14L,15L,12L,5L,4L,4L,2L,13L,10L,16L,18L,16L,10L,5L,6L,3L,4L,14L,11L,18L,21L,20L,15L,6L,6L,8L,6L,6L,4L,15L,12L,20L,24L,24L,20L,7L,12L,10L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238326Inst : IEnumerable<long>
{
public static readonly long[] Value=A238326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238326.Bytes);
public long this[int i]=>Value[i];

public static A238326Inst Instance=new A238326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238327
{
public static readonly long[] Value={ 1L,4L,7L,13L,19L,25L,31L,39L,43L,49L,55L,61L,69L,73L,81L,85L,91L,99L,103L,109L,115L,129L,133L,139L,151L,159L,165L,169L,175L,181L,193L,199L,213L,225L,229L,235L,241L,253L,259L,265L,271L,279L,283L,295L,309L,313L,319L,333L,339L,349L,355L,361L,369L,375L,381L,385L,391L,399L,403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238327Inst : IEnumerable<long>
{
public static readonly long[] Value=A238327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238327.Bytes);
public long this[int i]=>Value[i];

public static A238327Inst Instance=new A238327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238328
{
public static readonly long[] Value={ 4L,40L,180L,544L,1280L,2592L,4732L,7968L,12636L,19120L,27808L,39168L,53716L,71960L,94500L,121984L,155040L,194400L,240844L,295120L,358092L,430672L,513728L,608256L,715300L,835848L,971028L,1122016L,1289920L,1476000L,1681564L,1907840L,2156220L,2428144L,2724960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238328Inst : IEnumerable<long>
{
public static readonly long[] Value=A238328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238328.Bytes);
public long this[int i]=>Value[i];

public static A238328Inst Instance=new A238328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238329
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,21L,144L,987L,46368L,2178309L,4807526976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238329Inst : IEnumerable<long>
{
public static readonly long[] Value=A238329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238329.Bytes);
public long this[int i]=>Value[i];

public static A238329Inst Instance=new A238329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238330
{
public static readonly long[] Value={ 135L,891L,200655L,307125L,544635L,1672125L,2876211L,3138345L,4538625L,5016375L,5417685L,6517665L,11764935L,13179375L,13615875L,14705145L,15049125L,18309375L,40847625L,45623655L,84418425L,98041125L,99684375L,135442125L,153778905L,203870601L,262840851L,270571875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238330Inst : IEnumerable<long>
{
public static readonly long[] Value=A238330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238330.Bytes);
public long this[int i]=>Value[i];

public static A238330Inst Instance=new A238330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238331
{
public static readonly long[] Value={ 0L,23L,0L,107L,2411L,3413L,5417L,4919L,5923L,8629L,9931L,10937L,14741L,14243L,16747L,18553L,19259L,22961L,24767L,28571L,24373L,31079L,29483L,33589L,35597L,498101L,475103L,528107L,555109L,570113L,607127L,641131L,659137L,717139L,756149L,786151L,754157L,817163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238331Inst : IEnumerable<long>
{
public static readonly long[] Value=A238331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238331.Bytes);
public long this[int i]=>Value[i];

public static A238331Inst Instance=new A238331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238332
{
public static readonly long[] Value={ 11L,19L,127L,139L,149L,151L,157L,163L,181L,191L,193L,199L,233L,269L,277L,421L,487L,1117L,1123L,1129L,1153L,1171L,1187L,1201L,1213L,1217L,1231L,1237L,1249L,1259L,1279L,1289L,1291L,1297L,1301L,1303L,1319L,1321L,1327L,1361L,1381L,1399L,1423L,1427L,1429L,1447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238332Inst : IEnumerable<long>
{
public static readonly long[] Value=A238332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238332.Bytes);
public long this[int i]=>Value[i];

public static A238332Inst Instance=new A238332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238333
{
public static readonly long[] Value={ 1L,9L,27L,39L,49L,51L,57L,63L,81L,91L,93L,99L,33L,69L,77L,21L,87L,117L,123L,129L,153L,171L,187L,201L,213L,217L,231L,237L,249L,259L,279L,289L,291L,297L,301L,303L,319L,321L,327L,361L,381L,399L,423L,427L,429L,447L,451L,453L,459L,471L,481L,483L,489L,493L,511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238333Inst : IEnumerable<long>
{
public static readonly long[] Value=A238333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238333.Bytes);
public long this[int i]=>Value[i];

public static A238333Inst Instance=new A238333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238334
{
public static readonly long[] Value={ 0L,1L,4L,9L,25L,36L,576L,676L,5776L,27556L,33856L,538756L,586756L,665856L,682276L,763876L,767376L,853776L,872356L,2637376L,2775556L,2835856L,5635876L,6885376L,7376656L,22886656L,23755876L,23775376L,26275876L,26687556L,26873856L,32672656L,32878756L,37527876L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238334Inst : IEnumerable<long>
{
public static readonly long[] Value=A238334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238334.Bytes);
public long this[int i]=>Value[i];

public static A238334Inst Instance=new A238334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238335
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,24L,26L,76L,166L,184L,734L,766L,816L,826L,874L,876L,924L,934L,1624L,1666L,1684L,2374L,2624L,2716L,4784L,4874L,4876L,5126L,5166L,5184L,5716L,5734L,6126L,6216L,6234L,7316L,7334L,7666L,8166L,8266L,8566L,8674L,8734L,8876L,9076L,9126L,9234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238335Inst : IEnumerable<long>
{
public static readonly long[] Value=A238335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238335.Bytes);
public long this[int i]=>Value[i];

public static A238335Inst Instance=new A238335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238368
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,15L,16L,18L,20L,22L,24L,25L,27L,28L,29L,30L,32L,33L,34L,35L,36L,38L,40L,42L,44L,45L,48L,49L,50L,54L,55L,56L,58L,60L,62L,63L,64L,66L,68L,70L,72L,75L,76L,77L,78L,80L,81L,84L,88L,90L,95L,96L,98L,99L,100L,108L,110L,112L,114L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238368Inst : IEnumerable<long>
{
public static readonly long[] Value=A238368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238368.Bytes);
public long this[int i]=>Value[i];

public static A238368Inst Instance=new A238368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238369
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,9L,10L,12L,14L,15L,16L,17L,18L,19L,20L,21L,23L,24L,25L,26L,27L,28L,30L,31L,32L,33L,34L,35L,36L,37L,38L,40L,41L,42L,43L,44L,46L,48L,49L,50L,51L,52L,53L,54L,56L,60L,61L,62L,63L,64L,65L,66L,68L,69L,70L,72L,74L,75L,76L,77L,80L,81L,82L,84L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238369Inst : IEnumerable<long>
{
public static readonly long[] Value=A238369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238369.Bytes);
public long this[int i]=>Value[i];

public static A238369Inst Instance=new A238369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238370
{
public static readonly long[] Value={ 27L,27L,72L,216L,459L,936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238370Inst : IEnumerable<long>
{
public static readonly long[] Value=A238370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238370.Bytes);
public long this[int i]=>Value[i];

public static A238370Inst Instance=new A238370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238371
{
public static readonly long[] Value={ 1L,3L,3L,5L,5L,4L,4L,9L,9L,11L,11L,9L,9L,5L,5L,12L,12L,12L,12L,7L,7L,23L,23L,8L,8L,20L,20L,29L,29L,6L,6L,33L,33L,35L,35L,20L,20L,39L,39L,41L,41L,28L,28L,12L,12L,36L,36L,15L,15L,51L,51L,53L,53L,36L,36L,44L,44L,24L,24L,20L,20L,7L,7L,65L,65L,36L,36L,69L,69L,60L,60L,42L,42L,15L,15L,20L,20L,52L,52L,81L,81L,83L,83L,9L,9L,60L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238371Inst : IEnumerable<long>
{
public static readonly long[] Value=A238371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238371.Bytes);
public long this[int i]=>Value[i];

public static A238371Inst Instance=new A238371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238372
{
public static readonly BigInteger[] Value={ 1L,2L,9L,40L,265L,1956L,18529L,183520L,2226753L,28663300L,421589641L,6696832704L,117283627201L,2190260755060L,44645172510345L,964646320357696L,22317294448547329L,547594529028427908L,14246751684203363593UL,BigInteger.Parse("390309056795283743200"),BigInteger.Parse("11276891642831796476481") };
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
public class A238372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238372Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238372.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238372.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238372Inst Instance=new A238372Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238373
{
public static readonly long[] Value={ 3L,4L,2L,4L,7L,12L,9L,8L,21L,12L,15L,15L,30L,16L,30L,40L,35L,60L,21L,57L,24L,24L,90L,63L,27L,28L,12L,12L,31L,220L,33L,63L,180L,420L,37L,225L,39L,24L,182L,99L,60L,40L,306L,264L,195L,48L,49L,60L,51L,144L,306L,84L,462L,60L,264L,265L,180L,240L,35L,35L,63L,144L,612L,544L,67L,1012L,870L,84L,840L,72L,195L,264L,180L,312L,650L,1023L,79L,180L,81L,228L,63L,84L,1740L,783L,87L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238373Inst : IEnumerable<long>
{
public static readonly long[] Value=A238373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238373.Bytes);
public long this[int i]=>Value[i];

public static A238373Inst Instance=new A238373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238374
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,12L,17L,22L,30L,38L,51L,64L,85L,106L,140L,174L,229L,284L,373L,462L,606L,750L,983L,1216L,1593L,1970L,2580L,3190L,4177L,5164L,6761L,8358L,10942L,13526L,17707L,21888L,28653L,35418L,46364L,57310L,75021L,92732L,121389L,150046L,196414L,242782L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238374Inst : IEnumerable<long>
{
public static readonly long[] Value=A238374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238374.Bytes);
public long this[int i]=>Value[i];

public static A238374Inst Instance=new A238374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238375
{
public static readonly long[] Value={ 1L,2L,4L,6L,11L,16L,28L,40L,69L,98L,168L,238L,407L,576L,984L,1392L,2377L,3362L,5740L,8118L,13859L,19600L,33460L,47320L,80781L,114242L,195024L,275806L,470831L,665856L,1136688L,1607520L,2744209L,3880898L,6625108L,9369318L,15994427L,22619536L,38613964L,54608392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238375Inst : IEnumerable<long>
{
public static readonly long[] Value=A238375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238375.Bytes);
public long this[int i]=>Value[i];

public static A238375Inst Instance=new A238375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238376
{
public static readonly long[] Value={ 4L,3L,3L,5L,15L,5L,10L,6L,13L,5L,4L,13L,4L,10L,8L,15L,20L,7L,10L,26L,123L,7L,3L,3L,29L,15L,5L,5L,68L,20L,25L,15L,8L,15L,12L,25L,10L,9L,9L,20L,61L,15L,12L,75L,250L,14L,105L,6L,4L,5L,4L,45L,12L,25L,60L,10L,68L,10L,11L,39L,16L,40L,7L,35L,85L,7L,29L,9L,447L,21L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238376Inst : IEnumerable<long>
{
public static readonly long[] Value=A238376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238376.Bytes);
public long this[int i]=>Value[i];

public static A238376Inst Instance=new A238376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238377
{
public static readonly long[] Value={ 1L,2L,6L,10L,17L,24L,34L,44L,57L,70L,86L,102L,121L,140L,162L,184L,209L,234L,262L,290L,321L,352L,386L,420L,457L,494L,534L,574L,617L,660L,706L,752L,801L,850L,902L,954L,1009L,1064L,1122L,1180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238377Inst : IEnumerable<long>
{
public static readonly long[] Value=A238377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238377.Bytes);
public long this[int i]=>Value[i];

public static A238377Inst Instance=new A238377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238378
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,8L,158L,536L,4670L,9795L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238378Inst : IEnumerable<long>
{
public static readonly long[] Value=A238378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238378.Bytes);
public long this[int i]=>Value[i];

public static A238378Inst Instance=new A238378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238379
{
public static readonly BigInteger[] Value={ 1L,35L,1259L,45289L,1629145L,58603931L,2108112371L,75833441425L,2727895778929L,98128414600019L,3529895029821755L,126978092658983161L,4567681440693572041L,BigInteger.Parse("164309553772309610315"),BigInteger.Parse("5910576254362452399299"),BigInteger.Parse("212616435603275976764449") };
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
public class A238379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238379Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238379.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238379.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238379Inst Instance=new A238379Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238380
{
public static readonly long[] Value={ 5L,14L,91L,1334L,1634L,2685L,3478L,5452L,9063L,13915L,16225L,20118L,20712L,33998L,42818L,47795L,64665L,79338L,84134L,103410L,106144L,109214L,111683L,122073L,123497L,133767L,166934L,170884L,203898L,224561L,228377L,267630L,289454L,383594L,384857L,391348L,440013L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238380Inst : IEnumerable<long>
{
public static readonly long[] Value=A238380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238380.Bytes);
public long this[int i]=>Value[i];

public static A238380Inst Instance=new A238380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238381
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,8L,11L,14L,18L,21L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238381Inst : IEnumerable<long>
{
public static readonly long[] Value=A238381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238381.Bytes);
public long this[int i]=>Value[i];

public static A238381Inst Instance=new A238381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238382
{
public static readonly long[] Value={ 356408L,399592L,643336L,652664L,5232010L,5799542L,9363584L,9437056L,10596368L,11199112L,15363832L,16517768L,31818952L,32205616L,34352624L,34860248L,46237730L,48641584L,48852176L,49215166L,52695376L,55349570L,56208368L,61319902L,91996816L,93259184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238382Inst : IEnumerable<long>
{
public static readonly long[] Value=A238382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238382.Bytes);
public long this[int i]=>Value[i];

public static A238382Inst Instance=new A238382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238383
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,11L,14L,18L,22L,28L,34L,43L,52L,65L,78L,97L,116L,144L,172L,213L,254L,314L,374L,462L,550L,679L,808L,997L,1186L,1463L,1740L,2146L,2552L,3147L,3742L,4614L,5486L,6764L,8042L,9915L,11788L,14533L,17278L,21301L,25324L,31220L,37116L,45757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238383Inst : IEnumerable<long>
{
public static readonly long[] Value=A238383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238383.Bytes);
public long this[int i]=>Value[i];

public static A238383Inst Instance=new A238383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238848
{
public static readonly long[] Value={ 3L,1L,2L,2L,4L,2L,14L,7L,6L,2L,4L,4L,14L,3L,4L,2L,16L,4L,12L,9L,2L,5L,16L,2L,2L,3L,16L,6L,10L,4L,2L,4L,22L,2L,6L,3L,6L,10L,6L,3L,22L,5L,2L,3L,4L,2L,18L,4L,26L,10L,4L,5L,6L,2L,2L,7L,6L,2L,10L,5L,2L,9L,4L,2L,16L,3L,6L,9L,2L,3L,30L,5L,14L,6L,24L,5L,16L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238848Inst : IEnumerable<long>
{
public static readonly long[] Value=A238848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238848.Bytes);
public long this[int i]=>Value[i];

public static A238848Inst Instance=new A238848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238849
{
public static readonly long[] Value={ 4L,9L,4L,3L,24L,2L,24L,30L,58L,3L,12L,19L,96L,3L,10L,165L,114L,11L,390L,159L,2L,30L,114L,10L,18L,12L,24L,6L,42L,19L,72L,24L,30L,72L,24L,3L,150L,189L,40L,54L,348L,5L,24L,93L,14L,33L,324L,9L,150L,81L,70L,39L,354L,3L,138L,42L,56L,51L,180L,16L,18L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238849Inst : IEnumerable<long>
{
public static readonly long[] Value=A238849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238849.Bytes);
public long this[int i]=>Value[i];

public static A238849Inst Instance=new A238849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238850
{
public static readonly long[] Value={ 2L,3L,5L,7L,31L,37L,71L,73L,79L,311L,313L,373L,733L,739L,797L,3733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238850Inst : IEnumerable<long>
{
public static readonly long[] Value=A238850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238850.Bytes);
public long this[int i]=>Value[i];

public static A238850Inst Instance=new A238850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238851
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,53L,59L,61L,83L,89L,113L,179L,191L,211L,863L,947L,977L,983L,991L,1429L,1439L,1823L,3061L,3067L,3389L,15161L,15643L,15733L,15737L,15739L,15859L,23029L,48989L,48991L,251737L,251831L,253751L,368471L,4060019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238851Inst : IEnumerable<long>
{
public static readonly long[] Value=A238851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238851.Bytes);
public long this[int i]=>Value[i];

public static A238851Inst Instance=new A238851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238852
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,311L,313L,347L,349L,353L,359L,367L,701L,709L,719L,727L,733L,739L,751L,769L,773L,787L,1103L,1109L,1123L,1163L,1181L,1193L,1301L,1303L,1319L,1321L,1327L,1361L,1777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238852Inst : IEnumerable<long>
{
public static readonly long[] Value=A238852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238852.Bytes);
public long this[int i]=>Value[i];

public static A238852Inst Instance=new A238852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238853
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,773L,809L,823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238853Inst : IEnumerable<long>
{
public static readonly long[] Value=A238853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238853.Bytes);
public long this[int i]=>Value[i];

public static A238853Inst Instance=new A238853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238854
{
public static readonly long[] Value={ 23L,53L,449L,191L,1171L,30671L,5827L,3733L,901687L,10357L,834469L,3043427L,5430889L,4060019L,498061L,34763L,118248433L,62344463L,218555173L,4463351L,114607657L,7903613L,14523874693L,211675817L,32814697L,93375223L,162466979L,8052409793L,12006877873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238854Inst : IEnumerable<long>
{
public static readonly long[] Value=A238854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238854.Bytes);
public long this[int i]=>Value[i];

public static A238854Inst Instance=new A238854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238855
{
public static readonly long[] Value={ 0L,3L,4L,12L,5L,12L,24L,17L,16L,33L,22L,29L,50L,39L,40L,39L,24L,65L,80L,100L,58L,58L,69L,122L,101L,90L,83L,125L,114L,133L,114L,122L,255L,203L,252L,123L,152L,221L,202L,308L,131L,250L,299L,397L,303L,143L,201L,484L,497L,423L,269L,253L,442L,944L,845L,378L,231L,460L,420L,455L,538L,438L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238855Inst : IEnumerable<long>
{
public static readonly long[] Value=A238855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238855.Bytes);
public long this[int i]=>Value[i];

public static A238855Inst Instance=new A238855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238856
{
public static readonly long[] Value={ 0L,3L,3L,4L,3L,4L,5L,4L,4L,6L,4L,6L,6L,6L,6L,5L,4L,7L,6L,7L,5L,6L,5L,8L,6L,6L,6L,6L,7L,7L,6L,6L,8L,6L,8L,7L,8L,8L,7L,8L,7L,8L,8L,8L,8L,7L,7L,9L,9L,8L,7L,8L,10L,10L,9L,8L,6L,9L,8L,7L,9L,9L,9L,9L,11L,8L,7L,9L,10L,9L,10L,9L,9L,11L,10L,10L,9L,9L,8L,9L,9L,8L,10L,10L,10L,9L,9L,9L,10L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238856Inst : IEnumerable<long>
{
public static readonly long[] Value=A238856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238856.Bytes);
public long this[int i]=>Value[i];

public static A238856Inst Instance=new A238856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238857
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,2L,1L,1L,0L,2L,4L,4L,2L,0L,3L,1L,1L,0L,3L,5L,3L,1L,0L,4L,7L,7L,5L,1L,0L,4L,5L,5L,3L,0L,4L,5L,6L,1L,0L,4L,8L,7L,9L,4L,1L,0L,5L,5L,7L,5L,0L,5L,10L,8L,4L,1L,1L,0L,6L,11L,17L,12L,3L,1L,0L,6L,11L,13L,6L,2L,1L,0L,6L,9L,11L,9L,4L,1L,0L,6L,13L,12L,7L,1L,0L,7L,9L,7L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238857Inst : IEnumerable<long>
{
public static readonly long[] Value=A238857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238857.Bytes);
public long this[int i]=>Value[i];

public static A238857Inst Instance=new A238857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238858
{
public static readonly long[] Value={ 1L,1L,0L,2L,0L,0L,4L,1L,0L,0L,8L,7L,0L,0L,0L,16L,33L,4L,0L,0L,0L,32L,131L,53L,1L,0L,0L,0L,64L,473L,429L,48L,0L,0L,0L,0L,128L,1611L,2748L,822L,26L,0L,0L,0L,0L,256L,5281L,15342L,9305L,1048L,8L,0L,0L,0L,0L,512L,16867L,78339L,83590L,21362L,937L,1L,0L,0L,0L,0L,1024L,52905L,376159L,647891L,307660L,35841L,594L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238858Inst : IEnumerable<long>
{
public static readonly long[] Value=A238858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238858.Bytes);
public long this[int i]=>Value[i];

public static A238858Inst Instance=new A238858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238859
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,14L,26L,51L,99L,195L,383L,759L,1504L,2988L,5944L,11840L,23602L,47084L,93975L,187647L,374812L,748857L,1496487L,2991017L,5978900L,11952780L,23897506L,47782081L,95543378L,191053334L,382052880L,764019152L,1527898772L,3055572646L,6110782652L,12220980359L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238859Inst : IEnumerable<long>
{
public static readonly long[] Value=A238859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238859.Bytes);
public long this[int i]=>Value[i];

public static A238859Inst Instance=new A238859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238860
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,4L,6L,6L,9L,11L,15L,18L,23L,26L,35L,43L,53L,64L,79L,91L,113L,135L,166L,197L,237L,277L,331L,387L,459L,541L,646L,754L,888L,1032L,1204L,1395L,1626L,1882L,2196L,2542L,2952L,3404L,3934L,4507L,5182L,5935L,6812L,7800L,8947L,10225L,11709L,13354L,15231L,17314L,19685L,22316L,25323L,28686L,32524L,36817L,41695L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238860Inst : IEnumerable<long>
{
public static readonly long[] Value=A238860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238860.Bytes);
public long this[int i]=>Value[i];

public static A238860Inst Instance=new A238860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238861
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,4L,6L,7L,10L,13L,18L,24L,32L,41L,55L,72L,95L,125L,164L,212L,275L,355L,459L,592L,763L,980L,1257L,1605L,2044L,2598L,3298L,4179L,5290L,6685L,8435L,10623L,13353L,16751L,20978L,26228L,32746L,40831L,50850L,63247L,78569L,97475L,120770L,149429L,184641L,227853L,280832L,345722L,425134L,522232L,640847L,785604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238861Inst : IEnumerable<long>
{
public static readonly long[] Value=A238861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238861.Bytes);
public long this[int i]=>Value[i];

public static A238861Inst Instance=new A238861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238862
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,5L,9L,11L,8L,10L,12L,14L,15L,13L,18L,20L,16L,24L,19L,17L,21L,23L,25L,22L,27L,29L,26L,28L,30L,32L,33L,31L,35L,37L,38L,36L,41L,43L,39L,47L,51L,34L,40L,42L,44L,46L,48L,45L,50L,52L,49L,53L,55L,57L,54L,58L,60L,61L,56L,65L,63L,66L,59L,64L,69L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238862Inst : IEnumerable<long>
{
public static readonly long[] Value=A238862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238862.Bytes);
public long this[int i]=>Value[i];

public static A238862Inst Instance=new A238862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238863
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,10L,13L,18L,24L,32L,41L,54L,68L,87L,111L,139L,174L,218L,269L,333L,410L,501L,611L,745L,902L,1090L,1315L,1578L,1891L,2263L,2695L,3205L,3805L,4503L,5322L,6277L,7384L,8673L,10172L,11904L,13908L,16227L,18894L,21971L,25516L,29578L,34245L,39597L,45717L,52720L,60721L,69842L,80243L,92091L,105559L,120865L,138248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238863Inst : IEnumerable<long>
{
public static readonly long[] Value=A238863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238863.Bytes);
public long this[int i]=>Value[i];

public static A238863Inst Instance=new A238863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238928
{
public static readonly BigInteger[] Value={ 238418L,48511734L,56843142724L,45110351036260L,38480818139601754L,BigInteger.Parse("32422371803174430046"),BigInteger.Parse("27384983539452851238098"),BigInteger.Parse("23112414212792231825095514"),BigInteger.Parse("19511733106501802492479425724"),BigInteger.Parse("16470999108488376648834147878040") };
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
public class A238928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238928Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238928.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238928.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238928Inst Instance=new A238928Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238929
{
public static readonly long[] Value={ 12L,116L,36L,782L,864L,144L,5008L,13090L,13456L,540L,34302L,191086L,611524L,176224L,2052L,238418L,3025468L,25080064L,22636472L,2391340L,7776L,1646042L,48511734L,1176627204L,2531484558L,873385842L,32225410L,29484L,11326068L,773430790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238929Inst : IEnumerable<long>
{
public static readonly long[] Value=A238929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238929.Bytes);
public long this[int i]=>Value[i];

public static A238929Inst Instance=new A238929Inst();

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