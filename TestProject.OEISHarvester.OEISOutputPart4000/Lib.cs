using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A238687
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,5L,6L,8L,13L,10L,18L,21L,27L,29L,41L,41L,62L,65L,77L,91L,114L,127L,151L,173L,213L,232L,279L,322L,372L,410L,491L,518L,630L,724L,814L,894L,1057L,1141L,1326L,1502L,1681L,1839L,2146L,2324L,2636L,2966L,3272L,3607L,4173L,4422L,5035L,5616L,6195L,6703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238687Inst : IEnumerable<long>
{
public static readonly long[] Value=A238687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238687.Bytes);
public long this[int i]=>Value[i];

public static A238687Inst Instance=new A238687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238686
{
public static readonly long[] Value={ 1L,1L,2L,3L,7L,11L,19L,30L,53L,87L,148L,219L,365L,555L,884L,1379L,2098L,3152L,4865L,7051L,10884L,15681L,23637L,34062L,50336L,72425L,105738L,149781L,217625L,308859L,440889L,623823L,885116L,1241075L,1744784L,2433371L,3401728L,4719635L,6548306L,9035003L,12472106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238686Inst : IEnumerable<long>
{
public static readonly long[] Value=A238686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238686.Bytes);
public long this[int i]=>Value[i];

public static A238686Inst Instance=new A238686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238685
{
public static readonly BigInteger[] Value={ 1L,-6L,210L,-17640L,2693880L,-649479600L,226750764240L,-108116216208000L,67478689070432640L,BigInteger.Parse("-53382381970299782400"),BigInteger.Parse("52192613508738839136000"),BigInteger.Parse("-61794396463636399635072000"),BigInteger.Parse("87121906773549083421777792000"),BigInteger.Parse("-144222462676882552982237906688000") };
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
public class A238685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238685Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238685.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238685.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238685Inst Instance=new A238685Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238684
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,2L,13L,21L,34L,55L,89L,6L,233L,377L,610L,987L,1597L,646L,4181L,6765L,10946L,17711L,28657L,966L,15005L,121393L,196418L,317811L,514229L,208010L,1346269L,2178309L,3524578L,5702887L,9227465L,207366L,24157817L,39088169L,63245986L,102334155L,165580141L,66978574L,433494437L,701408733L,1134903170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238684Inst : IEnumerable<long>
{
public static readonly long[] Value=A238684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238684.Bytes);
public long this[int i]=>Value[i];

public static A238684Inst Instance=new A238684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238683
{
public static readonly long[] Value={ 1L,0L,1L,0L,-1L,1L,0L,1L,-1L,1L,0L,-3L,11L,-3L,1L,0L,12L,-50L,35L,-2L,1L,0L,-60L,274L,-225L,17L,-5L,1L,0L,360L,-588L,406L,-147L,175L,-3L,1L,0L,-2520L,4356L,-3283L,6769L,-980L,46L,-7L,1L,0L,20160L,-36528L,29531L,-67284L,7483L,-648L,273L,-4L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238683Inst : IEnumerable<long>
{
public static readonly long[] Value=A238683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238683.Bytes);
public long this[int i]=>Value[i];

public static A238683Inst Instance=new A238683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238682
{
public static readonly long[] Value={ 109L,307L,151L,479L,1117L,1583L,727L,3433L,1931L,2383L,11689L,1871L,2143L,15091L,1637L,14779L,30637L,2897L,27281L,17401L,39839L,5647L,37483L,45281L,10687L,202219L,11927L,11087L,337021L,15737L,174413L,75277L,46307L,77489L,207457L,68219L,21467L,449131L,97961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238682Inst : IEnumerable<long>
{
public static readonly long[] Value=A238682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238682.Bytes);
public long this[int i]=>Value[i];

public static A238682Inst Instance=new A238682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238681
{
public static readonly long[] Value={ 89L,271L,137L,449L,1087L,1559L,647L,2677L,1831L,2297L,11119L,1787L,1567L,14071L,1511L,14653L,29473L,2399L,25943L,15307L,32993L,5309L,35977L,35963L,10457L,130069L,11801L,10831L,333673L,15451L,153529L,62497L,45677L,75389L,196699L,66383L,20411L,393097L,76631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238681Inst : IEnumerable<long>
{
public static readonly long[] Value=A238681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238681.Bytes);
public long this[int i]=>Value[i];

public static A238681Inst Instance=new A238681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238680
{
public static readonly long[] Value={ 83L,241L,131L,251L,991L,1553L,461L,2617L,1733L,1877L,11083L,1667L,1487L,13831L,1277L,14419L,26407L,2381L,23993L,7687L,30089L,4241L,30259L,27361L,9281L,127423L,11471L,10601L,290419L,15227L,125753L,62299L,43451L,55103L,192037L,61553L,14741L,358447L,63839L,98927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238680Inst : IEnumerable<long>
{
public static readonly long[] Value=A238680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238680.Bytes);
public long this[int i]=>Value[i];

public static A238680Inst Instance=new A238680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238679
{
public static readonly long[] Value={ 73L,103L,127L,211L,829L,1489L,433L,2551L,1291L,1601L,10663L,1619L,1399L,10723L,1109L,12413L,16447L,2347L,19961L,7237L,27509L,4013L,25867L,22013L,6947L,103483L,11351L,10289L,281959L,12203L,93083L,60457L,42197L,45821L,116167L,59723L,14303L,269377L,61613L,92717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238679Inst : IEnumerable<long>
{
public static readonly long[] Value=A238679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238679.Bytes);
public long this[int i]=>Value[i];

public static A238679Inst Instance=new A238679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238678
{
public static readonly long[] Value={ 53L,97L,71L,199L,787L,1019L,401L,1741L,1103L,1447L,10453L,1283L,1223L,9631L,1021L,12109L,15361L,1913L,14723L,6397L,26513L,2789L,25603L,21491L,6689L,87103L,10247L,8597L,254911L,12007L,71453L,47521L,37529L,39971L,109147L,59453L,12791L,256147L,59611L,78317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238678Inst : IEnumerable<long>
{
public static readonly long[] Value=A238678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238678.Bytes);
public long this[int i]=>Value[i];

public static A238678Inst Instance=new A238678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238677
{
public static readonly long[] Value={ 23L,79L,67L,173L,487L,853L,397L,1381L,881L,1061L,8713L,1187L,1091L,8581L,839L,9413L,6991L,1889L,12821L,5347L,20593L,2477L,20719L,21089L,5861L,83869L,8867L,6547L,193741L,9341L,62723L,39727L,36131L,35491L,107077L,51563L,12527L,224467L,50111L,71437L,1150309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238677Inst : IEnumerable<long>
{
public static readonly long[] Value=A238677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238677.Bytes);
public long this[int i]=>Value[i];

public static A238677Inst Instance=new A238677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238676
{
public static readonly long[] Value={ 19L,43L,61L,163L,457L,769L,389L,937L,311L,887L,4003L,953L,1049L,8101L,719L,8969L,6793L,1847L,7823L,4549L,18899L,2267L,16087L,20921L,4127L,56149L,8387L,5189L,177109L,9257L,61493L,36451L,34807L,30491L,92941L,39569L,10181L,141961L,45971L,64067L,497899L,33347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238676Inst : IEnumerable<long>
{
public static readonly long[] Value=A238676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238676.Bytes);
public long this[int i]=>Value[i];

public static A238676Inst Instance=new A238676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238675
{
public static readonly long[] Value={ 13L,37L,59L,113L,409L,563L,359L,541L,233L,281L,3229L,947L,827L,5431L,677L,3719L,5521L,1811L,7283L,3709L,16963L,2087L,9001L,20161L,3947L,49009L,7057L,3797L,169063L,6803L,52253L,36097L,31481L,27733L,71167L,34019L,6827L,93481L,41849L,46727L,486433L,26417L,23417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238675Inst : IEnumerable<long>
{
public static readonly long[] Value=A238675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238675.Bytes);
public long this[int i]=>Value[i];

public static A238675Inst Instance=new A238675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238674
{
public static readonly long[] Value={ 5L,31L,47L,41L,331L,523L,293L,277L,191L,197L,2389L,877L,811L,4111L,587L,2609L,5437L,1481L,6673L,1483L,12809L,1907L,5689L,13331L,3677L,25939L,4457L,3593L,162973L,6089L,38603L,33091L,26693L,16883L,65557L,19259L,5657L,49711L,23081L,25657L,480409L,17837L,21517L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238674Inst : IEnumerable<long>
{
public static readonly long[] Value=A238674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238674.Bytes);
public long this[int i]=>Value[i];

public static A238674Inst Instance=new A238674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238673
{
public static readonly long[] Value={ 3L,7L,11L,29L,193L,139L,107L,181L,101L,17L,379L,641L,167L,3691L,257L,2243L,1279L,1217L,3581L,757L,6113L,971L,5011L,5843L,317L,15199L,2741L,761L,59221L,6067L,14423L,5167L,13043L,3191L,43321L,8819L,2333L,23497L,15083L,15107L,414769L,13841L,20477L,29101L,3137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238673Inst : IEnumerable<long>
{
public static readonly long[] Value=A238673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238673.Bytes);
public long this[int i]=>Value[i];

public static A238673Inst Instance=new A238673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238672
{
public static readonly long[] Value={ 17L,197L,281L,887L,1061L,1447L,1601L,1877L,2297L,2383L,2927L,3539L,3637L,3697L,3727L,4201L,4421L,4967L,5261L,5387L,5737L,6007L,6353L,6737L,6997L,7451L,7621L,8039L,8369L,8447L,8627L,8699L,9181L,9371L,9467L,9689L,9839L,10151L,10193L,10391L,10567L,10739L,10939L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238672Inst : IEnumerable<long>
{
public static readonly long[] Value=A238672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238672.Bytes);
public long this[int i]=>Value[i];

public static A238672Inst Instance=new A238672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238623
{
public static readonly long[] Value={ 0L,1L,1L,3L,3L,8L,8L,17L,19L,35L,39L,66L,76L,120L,140L,209L,246L,355L,419L,585L,695L,946L,1123L,1498L,1781L,2335L,2775L,3583L,4255L,5428L,6436L,8118L,9616L,12013L,14202L,17592L,20763L,25525L,30069L,36711L,43165L,52382L,61468L,74173L,86878L,104303L,121925L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238623Inst : IEnumerable<long>
{
public static readonly long[] Value=A238623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238623.Bytes);
public long this[int i]=>Value[i];

public static A238623Inst Instance=new A238623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238622
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,3L,7L,5L,11L,7L,17L,11L,25L,15L,36L,22L,51L,30L,71L,42L,97L,56L,132L,77L,177L,101L,235L,135L,310L,176L,406L,231L,527L,297L,681L,385L,874L,490L,1116L,627L,1418L,792L,1793L,1002L,2256L,1255L,2829L,1575L,3532L,1958L,4393L,2436L,5445L,3010L,6727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238622Inst : IEnumerable<long>
{
public static readonly long[] Value=A238622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238622.Bytes);
public long this[int i]=>Value[i];

public static A238622Inst Instance=new A238622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238621
{
public static readonly long[] Value={ 1L,6L,8L,9L,48L,12L,24L,15L,120L,22L,54L,26L,90L,57L,44L,34L,156L,38L,114L,85L,228L,46L,232L,87L,348L,93L,138L,58L,318L,62L,372L,111L,333L,265L,354L,74L,366L,129L,296L,82L,369L,86L,402L,667L,387L,94L,328L,159L,438L,244L,530L,106L,423L,177L,474L,183L,1416L,118L,498L,122L,742L,201L,590L,415L,534L,134L,610L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238621Inst : IEnumerable<long>
{
public static readonly long[] Value=A238621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238621.Bytes);
public long this[int i]=>Value[i];

public static A238621Inst Instance=new A238621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238620
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,3L,5L,10L,15L,23L,33L,52L,68L,94L,132L,180L,239L,318L,412L,543L,693L,885L,1131L,1443L,1803L,2250L,2808L,3499L,4321L,5336L,6552L,8032L,9799L,11914L,14456L,17528L,21136L,25458L,30588L,36699L,43869L,52422L,62437L,74290L,88186L,104527L,123670L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238620Inst : IEnumerable<long>
{
public static readonly long[] Value=A238620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238620.Bytes);
public long this[int i]=>Value[i];

public static A238620Inst Instance=new A238620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238619
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,5L,8L,15L,22L,33L,47L,68L,93L,132L,176L,239L,314L,412L,536L,693L,884L,1131L,1427L,1803L,2249L,2808L,3489L,4321L,5325L,6552L,8022L,9799L,11913L,14456L,17502L,21136L,25457L,30588L,36673L,43869L,52398L,62437L,74277L,88186L,104526L,123670L,146028L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238619Inst : IEnumerable<long>
{
public static readonly long[] Value=A238619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238619.Bytes);
public long this[int i]=>Value[i];

public static A238619Inst Instance=new A238619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238618
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,2L,0L,1L,0L,5L,0L,1L,0L,4L,0L,4L,0L,7L,0L,1L,0L,16L,0L,1L,0L,10L,0L,11L,0L,10L,0L,1L,0L,26L,0L,1L,0L,26L,0L,24L,0L,13L,0L,1L,0L,60L,0L,5L,0L,17L,0L,19L,0L,52L,0L,1L,0L,117L,0L,1L,0L,36L,0L,46L,0L,23L,0L,29L,0L,160L,0L,1L,0L,30L,0L,61L,0L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238618Inst : IEnumerable<long>
{
public static readonly long[] Value=A238618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238618.Bytes);
public long this[int i]=>Value[i];

public static A238618Inst Instance=new A238618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238617
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,9L,10L,14L,15L,20L,23L,30L,33L,42L,44L,55L,58L,71L,78L,91L,99L,118L,124L,148L,155L,187L,202L,229L,244L,279L,290L,327L,344L,397L,427L,475L,501L,558L,597L,665L,714L,776L,824L,898L,948L,1032L,1084L,1245L,1308L,1395L,1452L,1606L,1692L,1807L,1919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238617Inst : IEnumerable<long>
{
public static readonly long[] Value=A238617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238617.Bytes);
public long this[int i]=>Value[i];

public static A238617Inst Instance=new A238617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238616
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,10L,12L,15L,19L,23L,25L,33L,41L,44L,51L,58L,67L,78L,84L,99L,117L,124L,132L,155L,186L,202L,219L,244L,268L,290L,317L,344L,396L,427L,449L,501L,557L,597L,639L,714L,752L,824L,885L,948L,1031L,1084L,1185L,1308L,1390L,1452L,1589L,1692L,1788L,1919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238616Inst : IEnumerable<long>
{
public static readonly long[] Value=A238616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238616.Bytes);
public long this[int i]=>Value[i];

public static A238616Inst Instance=new A238616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238615
{
public static readonly BigInteger[] Value={ 1L,1L,513L,290594892L,8006513870533064L,BigInteger.Parse("3157977415776418319210477"),BigInteger.Parse("9355115500676554620340590943203672"),BigInteger.Parse("139997247522791157386395916200494707946968395"),BigInteger.Parse("8097446373533819684208223226876398545717123633973546819") };
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
public class A238615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238615Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238615.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238615.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238615Inst Instance=new A238615Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238614
{
public static readonly BigInteger[] Value={ 1L,1L,257L,32294883L,125107148059080L,BigInteger.Parse("5052825953808096554227"),BigInteger.Parse("1203080775953722005263023646232"),BigInteger.Parse("1189959092808570377265545326042454670975"),BigInteger.Parse("3861166489120966379893685013624485791901912419888"),BigInteger.Parse("34687845413783594101366282545316028561007822069601179170488") };
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
public class A238614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238614Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238614.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238614.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238614Inst Instance=new A238614Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238613
{
public static readonly BigInteger[] Value={ 1L,1L,129L,3590508L,1955134763464L,8085018247233663602L,BigInteger.Parse("154721208025657067873668152"),BigInteger.Parse("10114611726199237476675435354424104"),BigInteger.Parse("1841159754991692001851990839259642586671980"),BigInteger.Parse("805821524592736878546553406787954567208757510893718") };
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
public class A238613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238613Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238613.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238613.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238613Inst Instance=new A238613Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238612
{
public static readonly BigInteger[] Value={ 1L,1L,65L,399675L,30569959880L,12940003469288602L,BigInteger.Parse("19900384510848921094632"),BigInteger.Parse("85980297709044488588773397089"),BigInteger.Parse("877979540384895591800176962368065072"),BigInteger.Parse("18720322073127387624828552135278902045913865"),BigInteger.Parse("759424638305250205001161810310150848799911916053194") };
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
public class A238612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238612Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238612.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238612.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238612Inst Instance=new A238612Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238611
{
public static readonly BigInteger[] Value={ 1L,1L,33L,44652L,478968264L,20735819929227L,2561606354507677872L,BigInteger.Parse("731267824140098782358035"),BigInteger.Parse("418829370245413954052212657987"),BigInteger.Parse("435014756168760380909523387186194290"),BigInteger.Parse("759593815557626617904440619008375351308296"),BigInteger.Parse("2102438285027143559802785522708457578986076133973") };
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
public class A238611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238611Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238611.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238611.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238611Inst Instance=new A238611Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238610
{
public static readonly BigInteger[] Value={ 1L,1L,17L,5043L,7566280L,33432635477L,331281477244572L,6242342067484101895L,BigInteger.Parse("200386212932492140762672"),BigInteger.Parse("10133053906998476170548376403"),BigInteger.Parse("761287353202857218355451068558296"),BigInteger.Parse("81209207250425252838671771562105020103"),BigInteger.Parse("11863819168025774694177783984734986151951164") };
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
public class A238610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238610Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238610.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238610.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238610Inst Instance=new A238610Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238609
{
public static readonly BigInteger[] Value={ 1L,1L,9L,588L,123464L,55567352L,44056912182L,54667189410224L,98149884074667116L,BigInteger.Parse("241192889005578902877"),BigInteger.Parse("778400276435728381405745"),BigInteger.Parse("3195674736701993615997749350"),BigInteger.Parse("16272552341081798500863569890566"),BigInteger.Parse("100683204917037438858515986247835992") };
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
public class A238609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238609Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238609.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238609.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238609Inst Instance=new A238609Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238608
{
public static readonly BigInteger[] Value={ 1L,1L,5L,75L,2280L,106852L,6889527L,569704489L,57733506640L,6944433285769L,968356321790171L,153738253618009045L,BigInteger.Parse("27396489338187214000"),BigInteger.Parse("5417302365503826145732"),BigInteger.Parse("1177436831956414016252071"),BigInteger.Parse("279074576444362385794783853"),BigInteger.Parse("71649589941044468875380333533") };
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
public class A238608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238608Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238608.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238608.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238608Inst Instance=new A238608Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238511
{
public static readonly BigInteger[] Value={ 25L,401L,14407L,430504L,13398587L,413256106L,12771744135L,394537124897L,12189010788413L,376564621157074L,11633561391153531L,359406052601243460L,11103456404402492173UL,BigInteger.Parse("343029107715954897545"),BigInteger.Parse("10597508186010294218619") };
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
public class A238511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238511Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238511.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238511.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238511Inst Instance=new A238511Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238510
{
public static readonly long[] Value={ 4L,25L,295L,3113L,33837L,365740L,3958594L,42834071L,463516595L,5015744275L,54275869563L,587324222844L,6355490845488L,68773364113485L,744203045653967L,8053091185427477L,87143257529984401L,942985390024669100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238510Inst : IEnumerable<long>
{
public static readonly long[] Value=A238510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238510.Bytes);
public long this[int i]=>Value[i];

public static A238510Inst Instance=new A238510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238509
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,2L,1L,1L,2L,1L,2L,3L,4L,1L,4L,5L,2L,1L,5L,2L,1L,1L,3L,5L,2L,3L,2L,2L,4L,7L,3L,2L,2L,5L,6L,3L,7L,3L,3L,4L,3L,3L,2L,2L,4L,7L,4L,8L,3L,9L,4L,6L,4L,3L,7L,3L,2L,3L,4L,5L,3L,7L,4L,3L,5L,1L,9L,10L,6L,8L,2L,3L,3L,6L,6L,3L,1L,2L,7L,1L,6L,5L,2L,6L,8L,3L,4L,1L,1L,1L,9L,12L,3L,2L,3L,8L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238509Inst : IEnumerable<long>
{
public static readonly long[] Value=A238509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238509.Bytes);
public long this[int i]=>Value[i];

public static A238509Inst Instance=new A238509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238508
{
public static readonly long[] Value={ 0L,5L,13L,50L,213L,536L,536L,4582L,63202L,163984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238508Inst : IEnumerable<long>
{
public static readonly long[] Value=A238508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238508.Bytes);
public long this[int i]=>Value[i];

public static A238508Inst Instance=new A238508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238507
{
public static readonly long[] Value={ 0L,8L,20L,57L,332L,332L,6814L,7926L,16724L,200633L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238507Inst : IEnumerable<long>
{
public static readonly long[] Value=A238507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238507.Bytes);
public long this[int i]=>Value[i];

public static A238507Inst Instance=new A238507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238506
{
public static readonly long[] Value={ 3L,7L,10L,11L,16L,13L,13L,15L,10L,12L,14L,16L,11L,13L,7L,21L,14L,25L,13L,10L,12L,9L,19L,14L,15L,11L,6L,15L,7L,13L,12L,9L,13L,9L,15L,17L,12L,12L,9L,7L,7L,8L,11L,14L,11L,14L,19L,15L,11L,9L,11L,11L,11L,15L,15L,17L,7L,15L,11L,16L,11L,18L,8L,10L,13L,9L,10L,13L,7L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238506Inst : IEnumerable<long>
{
public static readonly long[] Value=A238506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238506.Bytes);
public long this[int i]=>Value[i];

public static A238506Inst Instance=new A238506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238505
{
public static readonly long[] Value={ 3L,3L,3L,4L,6L,6L,9L,8L,10L,11L,12L,12L,14L,14L,16L,17L,19L,18L,20L,20L,22L,24L,25L,24L,41L,27L,30L,29L,34L,30L,32L,32L,42L,36L,36L,44L,39L,38L,40L,42L,42L,42L,46L,44L,46L,47L,49L,48L,52L,51L,58L,58L,54L,54L,56L,57L,59L,60L,60L,60L,71L,62L,65L,65L,66L,67L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238505Inst : IEnumerable<long>
{
public static readonly long[] Value=A238505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238505.Bytes);
public long this[int i]=>Value[i];

public static A238505Inst Instance=new A238505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238504
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,2L,3L,2L,3L,2L,1L,3L,2L,4L,3L,1L,2L,3L,1L,1L,2L,1L,2L,2L,1L,1L,4L,1L,2L,4L,4L,5L,5L,3L,4L,4L,6L,4L,2L,1L,1L,3L,4L,6L,4L,4L,1L,3L,3L,2L,4L,6L,2L,2L,3L,3L,3L,4L,10L,5L,6L,7L,5L,4L,5L,5L,3L,5L,6L,6L,5L,5L,4L,5L,6L,6L,4L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238504Inst : IEnumerable<long>
{
public static readonly long[] Value=A238504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238504.Bytes);
public long this[int i]=>Value[i];

public static A238504Inst Instance=new A238504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238503
{
public static readonly long[] Value={ 101L,141L,161L,173L,197L,201L,213L,221L,236L,241L,245L,261L,266L,269L,297L,317L,321L,325L,326L,333L,341L,350L,356L,365L,373L,377L,381L,389L,393L,401L,404L,413L,416L,426L,429L,441L,453L,461L,464L,465L,466L,476L,481L,485L,488L,493L,501L,505L,506L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238503Inst : IEnumerable<long>
{
public static readonly long[] Value=A238503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238503.Bytes);
public long this[int i]=>Value[i];

public static A238503Inst Instance=new A238503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238502
{
public static readonly long[] Value={ 1L,3L,4L,6L,4L,8L,5L,6L,12L,14L,8L,6L,18L,20L,6L,8L,12L,24L,6L,14L,10L,8L,30L,32L,9L,12L,18L,8L,38L,20L,14L,42L,8L,44L,12L,24L,48L,18L,14L,54L,10L,12L,20L,30L,60L,8L,62L,32L,14L,12L,68L,18L,24L,72L,74L,38L,20L,12L,14L,80L,42L,84L,18L,44L,30L,12L,90L,9L,14L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238502Inst : IEnumerable<long>
{
public static readonly long[] Value=A238502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238502.Bytes);
public long this[int i]=>Value[i];

public static A238502Inst Instance=new A238502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238501
{
public static readonly long[] Value={ 7L,11L,19L,31L,43L,47L,107L,127L,131L,151L,163L,167L,179L,191L,211L,223L,263L,283L,347L,367L,443L,487L,491L,523L,547L,587L,643L,659L,751L,827L,839L,911L,1039L,1051L,1087L,1103L,1123L,1163L,1171L,1223L,1259L,1283L,1291L,1327L,1427L,1439L,1447L,1487L,1523L,1543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238501Inst : IEnumerable<long>
{
public static readonly long[] Value=A238501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238501.Bytes);
public long this[int i]=>Value[i];

public static A238501Inst Instance=new A238501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238500
{
public static readonly long[] Value={ 233347L,233911L,239929L,337397L,373613L,379397L,733331L,796337L,1321997L,1933331L,2333347L,2333533L,2339929L,2392333L,2393257L,2393761L,2939971L,3136373L,3165713L,3217337L,3319733L,3499277L,3539311L,3727397L,3733967L,3739103L,3739199L,3739397L,3739433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238500Inst : IEnumerable<long>
{
public static readonly long[] Value=A238500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238500.Bytes);
public long this[int i]=>Value[i];

public static A238500Inst Instance=new A238500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238499
{
public static readonly long[] Value={ 3137L,3797L,13997L,19937L,19997L,23911L,23929L,29173L,29311L,31193L,37337L,37397L,43397L,59929L,73331L,78737L,79337L,103997L,109397L,127997L,139967L,173347L,173359L,193337L,193373L,193877L,199337L,199373L,199967L,229373L,233113L,233329L,233353L,233617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238499Inst : IEnumerable<long>
{
public static readonly long[] Value=A238499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238499.Bytes);
public long this[int i]=>Value[i];

public static A238499Inst Instance=new A238499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238498
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,4L,4L,1L,1L,6L,8L,6L,1L,1L,6L,12L,12L,6L,1L,1L,12L,24L,36L,24L,12L,1L,1L,8L,32L,48L,48L,32L,8L,1L,1L,12L,32L,96L,96L,96L,32L,12L,1L,1L,12L,48L,96L,192L,192L,96L,48L,12L,1L,1L,18L,72L,216L,288L,576L,288L,216L,72L,18L,1L,1L,12L,72L,216L,432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238498Inst : IEnumerable<long>
{
public static readonly long[] Value=A238498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238498.Bytes);
public long this[int i]=>Value[i];

public static A238498Inst Instance=new A238498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238497
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,13L,21L,34L,55L,89L,233L,377L,610L,987L,1597L,4181L,6765L,10946L,17711L,28657L,75025L,121393L,196418L,317811L,514229L,1346269L,2178309L,3524578L,5702887L,9227465L,24157817L,39088169L,63245986L,102334155L,165580141L,433494437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238497Inst : IEnumerable<long>
{
public static readonly long[] Value=A238497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238497.Bytes);
public long this[int i]=>Value[i];

public static A238497Inst Instance=new A238497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238496
{
public static readonly long[] Value={ 0L,0L,1L,3L,8L,17L,36L,73L,149L,300L,602L,1205L,2413L,4827L,9656L,19314L,38632L,77265L,154533L,309067L,618137L,1236276L,2472554L,4945109L,9890222L,19780446L,39560894L,79121791L,158243585L,316487171L,632974345L,1265948691L,2531897387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238496Inst : IEnumerable<long>
{
public static readonly long[] Value=A238496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238496.Bytes);
public long this[int i]=>Value[i];

public static A238496Inst Instance=new A238496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238159
{
public static readonly long[] Value={ 0L,1L,1L,2L,5L,11L,15L,35L,70L,124L,234L,447L,827L,1529L,2834L,5222L,9587L,17573L,32137L,58641L,106821L,194280L,352824L,639913L,1159238L,2097759L,3792375L,6849778L,12361822L,22292405L,40172089L,72344671L,130203409L,234200988L,421037335L,756538955L,1358728300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238159Inst : IEnumerable<long>
{
public static readonly long[] Value=A238159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238159.Bytes);
public long this[int i]=>Value[i];

public static A238159Inst Instance=new A238159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238158
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,0L,2L,2L,4L,0L,2L,3L,4L,6L,0L,3L,4L,6L,6L,9L,0L,3L,4L,6L,8L,9L,12L,0L,4L,5L,8L,9L,12L,12L,16L,0L,4L,6L,8L,10L,12L,15L,16L,20L,0L,5L,6L,10L,12L,15L,16L,20L,20L,25L,0L,5L,7L,10L,12L,15L,18L,20L,24L,25L,30L,0L,6L,8L,12L,14L,18L,20L,24L,25L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238158Inst : IEnumerable<long>
{
public static readonly long[] Value=A238158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238158.Bytes);
public long this[int i]=>Value[i];

public static A238158Inst Instance=new A238158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238157
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,1L,1L,4L,1L,1L,3L,2L,5L,1L,1L,3L,4L,1L,6L,1L,1L,3L,4L,1L,2L,7L,1L,1L,1L,1L,1L,6L,1L,8L,1L,1L,1L,1L,5L,3L,1L,2L,9L,1L,1L,1L,1L,5L,2L,1L,4L,1L,10L,1L,1L,1L,1L,1L,2L,1L,4L,3L,2L,11L,1L,1L,1L,1L,1L,3L,1L,8L,3L,1L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238157Inst : IEnumerable<long>
{
public static readonly long[] Value=A238157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238157.Bytes);
public long this[int i]=>Value[i];

public static A238157Inst Instance=new A238157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238156
{
public static readonly long[] Value={ 1L,0L,2L,0L,2L,3L,0L,2L,7L,4L,0L,2L,11L,16L,5L,0L,2L,15L,36L,30L,6L,0L,2L,19L,64L,91L,50L,7L,0L,2L,23L,100L,204L,196L,77L,8L,0L,2L,27L,144L,385L,540L,378L,112L,9L,0L,2L,31L,196L,650L,1210L,1254L,672L,156L,10L,0L,2L,35L,256L,1015L,2366L,3289L,2640L,1122L,210L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238156Inst : IEnumerable<long>
{
public static readonly long[] Value=A238156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238156.Bytes);
public long this[int i]=>Value[i];

public static A238156Inst Instance=new A238156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238155
{
public static readonly long[] Value={ 256L,1608L,1608L,10664L,15800L,10664L,72584L,165780L,165780L,72584L,499560L,1792226L,2842692L,1792226L,499560L,3342416L,18918620L,51036456L,51036456L,18918620L,3342416L,22488016L,202875630L,961463420L,1809464182L,961463420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238155Inst : IEnumerable<long>
{
public static readonly long[] Value=A238155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238155.Bytes);
public long this[int i]=>Value[i];

public static A238155Inst Instance=new A238155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238154
{
public static readonly BigInteger[] Value={ 22488016L,2177434900L,345494546192L,79094196555400L,18866641119536914L,4598319821027426208L,BigInteger.Parse("1158658575893011968206"),BigInteger.Parse("284756685386736905732440"),BigInteger.Parse("72205997284711788508129548"),BigInteger.Parse("18078425642652079031512663212") };
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
public class A238154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238154Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238154.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238154.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238154Inst Instance=new A238154Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238153
{
public static readonly BigInteger[] Value={ 3342416L,202875630L,18066348584L,2281444628340L,277864575306608L,35860617669682800L,4598319821027426208L,BigInteger.Parse("613027931066263159936"),BigInteger.Parse("77819025344992343939164"),BigInteger.Parse("10244282662874851704618310") };
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
public class A238153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238153Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238153.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238153.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238153Inst Instance=new A238153Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238152
{
public static readonly BigInteger[] Value={ 499560L,18918620L,961463420L,63323756608L,4251191656884L,277864575306608L,18866641119536914L,1284534193930221572L,BigInteger.Parse("89119678717291265162"),BigInteger.Parse("5911580739811828776912"),BigInteger.Parse("404550754817069896948456") };
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
public class A238152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238152Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238152.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238152.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238152Inst Instance=new A238152Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238151
{
public static readonly BigInteger[] Value={ 72584L,1792226L,51036456L,1809464182L,63323756608L,2281444628340L,79094196555400L,2844505175089988L,101330271941333424L,3668008970782023104L,BigInteger.Parse("128142380241244217044"),BigInteger.Parse("4600048293733349407056"),BigInteger.Parse("164177336504686826493264") };
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
public class A238151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238151Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238151.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238151.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238151Inst Instance=new A238151Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238150
{
public static readonly BigInteger[] Value={ 10664L,165780L,2842692L,51036456L,961463420L,18066348584L,345494546192L,6395305423256L,122012216692790L,2294811925941656L,43937555414461856L,817171885471409680L,15610406616306032674UL,BigInteger.Parse("292887836680612952740") };
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
public class A238150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238150Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238150.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238150.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238150Inst Instance=new A238150Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238149
{
public static readonly long[] Value={ 1608L,15800L,165780L,1792226L,18918620L,202875630L,2177434900L,23302931502L,247341832408L,2649887010098L,28404840743328L,303472276024264L,3232102394981984L,34598942786178958L,370449222024081488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238149Inst : IEnumerable<long>
{
public static readonly long[] Value=A238149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238149.Bytes);
public long this[int i]=>Value[i];

public static A238149Inst Instance=new A238149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238148
{
public static readonly long[] Value={ 256L,1608L,10664L,72584L,499560L,3342416L,22488016L,152285824L,1043035504L,6998475712L,47273279296L,319462663168L,2181201937664L,14658851660800L,99259562449664L,669930900621824L,4565506277964288L,30712312453320704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238148Inst : IEnumerable<long>
{
public static readonly long[] Value=A238148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238148.Bytes);
public long this[int i]=>Value[i];

public static A238148Inst Instance=new A238148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238147
{
public static readonly long[] Value={ 1L,11L,26L,126L,191L,341L,516L,1516L,2081L,2731L,3206L,4706L,5631L,7381L,9256L,19256L,24821L,30471L,33946L,40446L,44171L,48921L,52796L,67796L,76221L,85471L,91846L,109346L,119971L,138721L,158096L,258096L,313661L,369311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238147Inst : IEnumerable<long>
{
public static readonly long[] Value=A238147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238147.Bytes);
public long this[int i]=>Value[i];

public static A238147Inst Instance=new A238147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238146
{
public static readonly long[] Value={ -2L,-5L,6L,-10L,31L,-30L,-17L,101L,-247L,210L,-28L,288L,-1358L,2927L,-2310L,-41L,652L,-5102L,20581L,-40361L,30030L,-58L,1349L,-16186L,107315L,-390238L,716167L,-510510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238146Inst : IEnumerable<long>
{
public static readonly long[] Value=A238146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238146.Bytes);
public long this[int i]=>Value[i];

public static A238146Inst Instance=new A238146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238145
{
public static readonly long[] Value={ 256L,1810L,1810L,12981L,22698L,12981L,94458L,292176L,292176L,94458L,687254L,3817216L,6799917L,3817216L,687254L,4977790L,49554382L,160133604L,160133604L,49554382L,4977790L,36125717L,642717388L,3756442630L,6863396252L,3756442630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238145Inst : IEnumerable<long>
{
public static readonly long[] Value=A238145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238145.Bytes);
public long this[int i]=>Value[i];

public static A238145Inst Instance=new A238145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238144
{
public static readonly BigInteger[] Value={ 687254L,49554382L,3756442630L,292335443616L,22569314353994L,1735590139495580L,133985522364550954L,10333049915756021016UL,BigInteger.Parse("797211905675550168118"),BigInteger.Parse("61438742621951906133148"),BigInteger.Parse("4742650407234712152241198") };
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
public class A238144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238144Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238144.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238144.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238144Inst Instance=new A238144Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238127
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,6L,17L,57L,191L,663L,2415L,9108L,35695L,143989L,599802L,2566917L,11298164L,50967216L,235745644L,1115324000L,5397332497L,26669487517L,134528555379L,691856601631L,3626390958551L,19353306241764L,105122093620388L,580689432523534L,3260906342453966L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238127Inst : IEnumerable<long>
{
public static readonly long[] Value=A238127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238127.Bytes);
public long this[int i]=>Value[i];

public static A238127Inst Instance=new A238127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238126
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,8L,24L,70L,224L,744L,2588L,9317L,34924L,135297L,542123L,2236834L,9508297L,41511215L,186109781L,854874944L,4021672983L,19344343843L,95093249014L,477137036748L,2442413708120L,12742038926613L,67714763161526L,366266085720565L,2015454903261855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238126Inst : IEnumerable<long>
{
public static readonly long[] Value=A238126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238126.Bytes);
public long this[int i]=>Value[i];

public static A238126Inst Instance=new A238126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238125
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,2L,1L,1L,0L,4L,3L,2L,1L,0L,9L,8L,6L,2L,1L,0L,22L,24L,17L,9L,3L,1L,0L,59L,70L,57L,29L,13L,3L,1L,0L,170L,224L,191L,108L,49L,17L,4L,1L,0L,516L,744L,663L,399L,201L,69L,23L,4L,1L,0L,1658L,2588L,2415L,1573L,802L,322L,104L,28L,5L,1L,0L,5583L,9317L,9108L,6249L,3343L,1408L,510L,137L,35L,5L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238125Inst : IEnumerable<long>
{
public static readonly long[] Value=A238125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238125.Bytes);
public long this[int i]=>Value[i];

public static A238125Inst Instance=new A238125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238124
{
public static readonly long[] Value={ 0L,1L,1L,3L,7L,20L,56L,182L,589L,2088L,7522L,28820L,113092L,464477L,1955760L,8541860L,38215077L,176316928L,832181774L,4033814912L,19973824386L,101257416701L,523648869394L,2765873334372L,14883594433742L,81646343582385L,455752361294076L,2589414185398032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238124Inst : IEnumerable<long>
{
public static readonly long[] Value=A238124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238124.Bytes);
public long this[int i]=>Value[i];

public static A238124Inst Instance=new A238124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238123
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,3L,0L,1L,0L,7L,2L,0L,1L,0L,20L,5L,0L,0L,1L,0L,56L,14L,5L,0L,0L,1L,0L,182L,35L,14L,0L,0L,0L,1L,0L,589L,132L,28L,14L,0L,0L,0L,1L,0L,2088L,399L,90L,42L,0L,0L,0L,0L,1L,0L,7522L,1556L,285L,90L,42L,0L,0L,0L,0L,1L,0L,28820L,5346L,1232L,165L,132L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238123Inst : IEnumerable<long>
{
public static readonly long[] Value=A238123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238123.Bytes);
public long this[int i]=>Value[i];

public static A238123Inst Instance=new A238123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238122
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,5L,5L,7L,16L,3L,11L,43L,21L,1L,15L,99L,101L,17L,22L,215L,373L,145L,9L,30L,430L,1174L,836L,146L,4L,42L,834L,3337L,3846L,1324L,112L,1L,56L,1529L,8642L,15002L,8786L,1615L,66L,77L,2765L,21148L,52132L,47013L,15403L,1582L,32L,101L,4792L,48713L,164576L,214997L,112106L,21895L,1310L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238122Inst : IEnumerable<long>
{
public static readonly long[] Value=A238122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238122.Bytes);
public long this[int i]=>Value[i];

public static A238122Inst Instance=new A238122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238121
{
public static readonly long[] Value={ 1L,1L,0L,2L,0L,0L,3L,1L,0L,0L,5L,5L,0L,0L,0L,7L,16L,3L,0L,0L,0L,11L,43L,21L,1L,0L,0L,0L,15L,99L,101L,17L,0L,0L,0L,0L,22L,215L,373L,145L,9L,0L,0L,0L,0L,30L,430L,1174L,836L,146L,4L,0L,0L,0L,0L,42L,834L,3337L,3846L,1324L,112L,1L,0L,0L,0L,0L,56L,1529L,8642L,15002L,8786L,1615L,66L,0L,0L,0L,0L,0L,77L,2765L,21148L,52132L,47013L,15403L,1582L,32L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238121Inst : IEnumerable<long>
{
public static readonly long[] Value=A238121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238121.Bytes);
public long this[int i]=>Value[i];

public static A238121Inst Instance=new A238121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238120
{
public static readonly long[] Value={ 9L,3528L,12168L,51984L,207576L,450241L,711828L,798768L,1590121L,7154784L,8609599L,40589641L,95355225L,138393792L,244293408L,344157184L,726887051L,737461269L,1232922769L,1290821184L,1630544400L,1734139449L,2901360600L,3002319675L,3401256943L,4435426801L,4589212453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238120Inst : IEnumerable<long>
{
public static readonly long[] Value=A238120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238120.Bytes);
public long this[int i]=>Value[i];

public static A238120Inst Instance=new A238120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238119
{
public static readonly BigInteger[] Value={ 2L,1951L,BigInteger.Parse("147573952589676410491") };
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
public class A238119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238119Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238119.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238119.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238119Inst Instance=new A238119Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238118
{
public static readonly long[] Value={ 1L,6L,20L,101L,327L,1560L,5333L,24727L,88422L,403552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238118Inst : IEnumerable<long>
{
public static readonly long[] Value=A238118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238118.Bytes);
public long this[int i]=>Value[i];

public static A238118Inst Instance=new A238118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238117
{
public static readonly long[] Value={ 1L,4L,14L,40L,120L,320L,946L,2496L,7418L,19616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238117Inst : IEnumerable<long>
{
public static readonly long[] Value=A238117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238117.Bytes);
public long this[int i]=>Value[i];

public static A238117Inst Instance=new A238117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238116
{
public static readonly long[] Value={ 1L,14L,162L,1966L,25567L,351880L,5056350L,75100735L,1144833705L,17821104101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238116Inst : IEnumerable<long>
{
public static readonly long[] Value=A238116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238116.Bytes);
public long this[int i]=>Value[i];

public static A238116Inst Instance=new A238116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238115
{
public static readonly long[] Value={ 1L,6L,32L,182L,1117L,7280L,49625L,349998L,2535077L,18758264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238115Inst : IEnumerable<long>
{
public static readonly long[] Value=A238115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238115.Bytes);
public long this[int i]=>Value[i];

public static A238115Inst Instance=new A238115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238114
{
public static readonly long[] Value={ 2L,3L,3L,2L,5L,8L,2L,2L,7L,5L,7L,3L,3L,2L,2L,0L,8L,8L,1L,7L,6L,5L,8L,2L,8L,7L,7L,6L,0L,7L,1L,0L,2L,7L,7L,4L,8L,8L,3L,8L,4L,5L,9L,4L,8L,9L,0L,4L,2L,4L,2L,2L,6L,6L,1L,7L,8L,7L,1L,3L,0L,8L,9L,9L,7L,5L,7L,3L,4L,0L,0L,4L,1L,7L,1L,9L,3L,0L,4L,0L,1L,8L,6L,8L,7L,5L,4L,8L,0L,4L,5L,5L,1L,4L,1L,6L,8L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238114Inst : IEnumerable<long>
{
public static readonly long[] Value=A238114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238114.Bytes);
public long this[int i]=>Value[i];

public static A238114Inst Instance=new A238114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238113
{
public static readonly long[] Value={ 1L,3L,9L,33L,135L,591L,2709L,12837L,62379L,309147L,1556577L,7940169L,40946607L,213118119L,1118080557L,5906404557L,31390735059L,167727039027L,900478280889L,4855086475761L,26277928981335L,142724482802943L,777647813128389L,4249385026394613L,23282201473312635L,127874913883456971L,703929221807756049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238113Inst : IEnumerable<long>
{
public static readonly long[] Value=A238113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238113.Bytes);
public long this[int i]=>Value[i];

public static A238113Inst Instance=new A238113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238112
{
public static readonly long[] Value={ 0L,0L,1L,5L,23L,107L,509L,2473L,12235L,61463L,312761L,1609005L,8355423L,43741635L,230614773L,1223414481L,6525975315L,34981856303L,188341400945L,1018043304661L,5522585343271L,30056208280091L,164066282507501L,898029800045945L,4927810473507803L,27103503645610567L,149393131346947369L,825093297608481533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238112Inst : IEnumerable<long>
{
public static readonly long[] Value=A238112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238112.Bytes);
public long this[int i]=>Value[i];

public static A238112Inst Instance=new A238112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238063
{
public static readonly long[] Value={ 256L,1910L,1910L,14429L,26634L,14429L,109386L,373572L,373572L,109386L,828750L,5318512L,9814274L,5318512L,828750L,6261150L,75397960L,262520800L,262520800L,75397960L,6261150L,47346273L,1065216948L,6977336094L,13354392266L,6977336094L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238063Inst : IEnumerable<long>
{
public static readonly long[] Value=A238063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238063.Bytes);
public long this[int i]=>Value[i];

public static A238063Inst Instance=new A238063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238062
{
public static readonly BigInteger[] Value={ 828750L,75397960L,6977336094L,671554527276L,63695813996436L,5998978739140238L,566896410820429940L,BigInteger.Parse("54033178368612573500"),BigInteger.Parse("5122989898231059198784"),BigInteger.Parse("484206153842948387709372"),BigInteger.Parse("45892772643548159237585348") };
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
public class A238062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238062Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238062.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238062.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238062Inst Instance=new A238062Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238061
{
public static readonly BigInteger[] Value={ 109386L,5318512L,262520800L,13354392266L,671554527276L,33609979270956L,1685585654315194L,85098473872271626L,4277764782773457518L,BigInteger.Parse("214683849354172173654"),BigInteger.Parse("10789542245766948585368"),BigInteger.Parse("543143670841693059157856") };
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
public class A238061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238061Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238061.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238061.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238061Inst Instance=new A238061Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238060
{
public static readonly BigInteger[] Value={ 14429L,373572L,9814274L,262520800L,6977336094L,184559576240L,4896168992178L,130300801140848L,3460857040227988L,91752190849368036L,2436945806893773614L,BigInteger.Parse("64734113272662248736"),BigInteger.Parse("1719213625840543673114"),BigInteger.Parse("45616366483261333652780") };
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
public class A238060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238060Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238060.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238060.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238060Inst Instance=new A238060Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238059
{
public static readonly BigInteger[] Value={ 1910L,26634L,373572L,5318512L,75397960L,1065216948L,15062600632L,213664795084L,3026358430964L,42818955192388L,606190597854048L,8588163214676008L,121611558126976150L,1721588383113148144L,BigInteger.Parse("24377472762713256254") };
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
public class A238059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238059Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238059.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238059.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238059Inst Instance=new A238059Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238058
{
public static readonly long[] Value={ 256L,1910L,14429L,109386L,828750L,6261150L,47346273L,358316792L,2711887788L,20506077144L,155139948464L,1173585528600L,8880284390128L,67163140049616L,508174004578308L,3843778132646744L,29083916585165508L,219977779917187008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238058Inst : IEnumerable<long>
{
public static readonly long[] Value=A238058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238058.Bytes);
public long this[int i]=>Value[i];

public static A238058Inst Instance=new A238058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238057
{
public static readonly long[] Value={ 313L,317L,373L,797L,1373L,1913L,1973L,1997L,2113L,2293L,2311L,2347L,2383L,2389L,2953L,2971L,3167L,3313L,3373L,3593L,3673L,3677L,3719L,3733L,3761L,4337L,4397L,5233L,5347L,5953L,6173L,6197L,6737L,7193L,7331L,7433L,7577L,7877L,7919L,7937L,10313L,10337L,10937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238057Inst : IEnumerable<long>
{
public static readonly long[] Value=A238057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238057.Bytes);
public long this[int i]=>Value[i];

public static A238057Inst Instance=new A238057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238056
{
public static readonly long[] Value={ 23L,37L,53L,73L,113L,137L,173L,193L,197L,211L,223L,229L,233L,241L,271L,283L,293L,311L,331L,337L,347L,353L,359L,367L,379L,383L,389L,397L,433L,523L,541L,547L,571L,593L,613L,617L,673L,677L,719L,733L,743L,761L,773L,977L,1013L,1033L,1093L,1097L,1117L,1123L,1129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238056Inst : IEnumerable<long>
{
public static readonly long[] Value=A238056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238056.Bytes);
public long this[int i]=>Value[i];

public static A238056Inst Instance=new A238056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238055
{
public static readonly long[] Value={ 6L,19L,58L,175L,526L,1579L,4738L,14215L,42646L,127939L,383818L,1151455L,3454366L,10363099L,31089298L,93267895L,279803686L,839411059L,2518233178L,7554699535L,22664098606L,67992295819L,203976887458L,611930662375L,1835791987126L,5507375961379L,16522127884138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238055Inst : IEnumerable<long>
{
public static readonly long[] Value=A238055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238055.Bytes);
public long this[int i]=>Value[i];

public static A238055Inst Instance=new A238055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238054
{
public static readonly long[] Value={ 256L,1760L,1760L,12352L,20732L,12352L,87488L,249664L,249664L,87488L,618752L,3029204L,5166560L,3029204L,618752L,4375552L,36751872L,107643264L,107643264L,36751872L,4375552L,30949952L,446229436L,2246142916L,3856575692L,2246142916L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238054Inst : IEnumerable<long>
{
public static readonly long[] Value=A238054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238054.Bytes);
public long this[int i]=>Value[i];

public static A238054Inst Instance=new A238054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238053
{
public static readonly BigInteger[] Value={ 618752L,36751872L,2246142916L,138587835304L,8592543470668L,534423833189632L,33030647028012904L,2034659369169605752L,BigInteger.Parse("126176785028850855392"),BigInteger.Parse("7850115411967418863184"),BigInteger.Parse("485285595640102070586096") };
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
public class A238053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238053Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238053.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238053.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238053Inst Instance=new A238053Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238052
{
public static readonly BigInteger[] Value={ 87488L,3029204L,107643264L,3856575692L,138587835304L,4992665981296L,179067264236960L,6406096490763368L,230234758474631888L,8296139440639218484L,BigInteger.Parse("297580879697256404504"),BigInteger.Parse("10647086984036565715108"),BigInteger.Parse("382681325257590496249272") };
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
public class A238052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238052Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238052.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238052.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238052Inst Instance=new A238052Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238051
{
public static readonly BigInteger[] Value={ 12352L,249664L,5166560L,107643264L,2246142916L,46940148128L,978607916368L,20366342381968L,425018025343492L,8883521543001864L,185210728399683652L,3854629980225887640L,BigInteger.Parse("80442685685640839192"),BigInteger.Parse("1681395591128610885784") };
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
public class A238051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238051Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238051.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238051.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238051Inst Instance=new A238051Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238050
{
public static readonly long[] Value={ 1760L,20732L,249664L,3029204L,36751872L,446229436L,5413951288L,65636758792L,796414874192L,9671088645980L,117339031195880L,1422572305954956L,17261016589311336L,209605459590414108L,2543137127074039224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238050Inst : IEnumerable<long>
{
public static readonly long[] Value=A238050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238050.Bytes);
public long this[int i]=>Value[i];

public static A238050Inst Instance=new A238050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238049
{
public static readonly long[] Value={ 256L,1760L,12352L,87488L,618752L,4375552L,30949952L,218919168L,1548259072L,10950274048L,77458464768L,547885305856L,3874795835392L,27405049921536L,193853940023296L,1371182905425920L,9697383186169856L,68586135474405376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238049Inst : IEnumerable<long>
{
public static readonly long[] Value=A238049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238049.Bytes);
public long this[int i]=>Value[i];

public static A238049Inst Instance=new A238049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238048
{
public static readonly long[] Value={ 3L,7L,5L,5L,13L,13L,3L,7L,19L,19L,7L,11L,11L,31L,23L,5L,31L,13L,19L,37L,53L,3L,13L,43L,23L,47L,43L,73L,7L,5L,19L,67L,29L,59L,79L,83L,11L,13L,11L,29L,73L,31L,61L,97L,89L,3L,23L,43L,19L,59L,109L,41L,67L,103L,109L,13L,17L,29L,73L,23L,73L,157L,43L,71L,109L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238048Inst : IEnumerable<long>
{
public static readonly long[] Value=A238048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238048.Bytes);
public long this[int i]=>Value[i];

public static A238048Inst Instance=new A238048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237999
{
public static readonly BigInteger[] Value={ 0L,1L,1L,2L,9L,119L,4935L,596763L,211517867L,224663223092L,734961197081208L,7614278809664610952L,BigInteger.Parse("256261752606028225485183"),BigInteger.Parse("28642174350851846128820426827"),BigInteger.Parse("10830277060032417592098008847162727"),BigInteger.Parse("14068379226083299071248895931891435683229") };
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
public class A237999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237999Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A237999.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A237999.Bytes);
public BigInteger this[int i]=>Value[i];

public static A237999Inst Instance=new A237999Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237998
{
public static readonly BigInteger[] Value={ 0L,1L,3L,10L,64L,831L,26207L,2239706L,567852809L,454241403975L,1192075219982204L,10510218491798860052UL,BigInteger.Parse("315981966712495811700951"),BigInteger.Parse("32726459268483342710907384794"),BigInteger.Parse("11771239570056489326716955796095261"),BigInteger.Parse("14808470136486015545654676685321653888199") };
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
public class A237998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237998Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A237998.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A237998.Bytes);
public BigInteger this[int i]=>Value[i];

public static A237998Inst Instance=new A237998Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237997
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,2L,3L,4L,7L,9L,14L,20L,29L,43L,63L,92L,136L,198L,291L,426L,624L,915L,1341L,1965L,2881L,4221L,6187L,9067L,13288L,19475L,28542L,41830L,61306L,89847L,131678L,192983L,282830L,414508L,607491L,890321L,1304830L,1912320L,2802642L,4107471L,6019791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237997Inst : IEnumerable<long>
{
public static readonly long[] Value=A237997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237997.Bytes);
public long this[int i]=>Value[i];

public static A237997Inst Instance=new A237997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237996
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,2L,0L,1L,0L,0L,11L,0L,1L,0L,24L,0L,35L,0L,1L,0L,0L,274L,0L,85L,0L,1L,0L,720L,0L,1624L,0L,175L,0L,1L,0L,0L,13068L,0L,6769L,0L,322L,0L,1L,0L,40320L,0L,118124L,0L,22449L,0L,546L,0L,1L,0L,0L,1026576L,0L,723680L,0L,63273L,0L,870L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237996Inst : IEnumerable<long>
{
public static readonly long[] Value=A237996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237996.Bytes);
public long this[int i]=>Value[i];

public static A237996Inst Instance=new A237996Inst();

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