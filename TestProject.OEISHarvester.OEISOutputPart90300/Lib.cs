using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A109941
{
public static readonly BigInteger[] Value={ 45L,2430L,165150L,12370500L,989955000L,82499850000L,7071428928571L,618749955000000L,55000000350000000L,4949999995500000000L,BigInteger.Parse("449999999955000000000"),BigInteger.Parse("41250000000150000000000"),BigInteger.Parse("3807692307689192307692307"),BigInteger.Parse("353571428571466428571428572"),BigInteger.Parse("32999999999999850000000000000") };
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
public class A109941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109941Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109941.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109941Inst Instance=new A109941Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109942
{
public static readonly long[] Value={ 9L,9L,8L,9L,9L,7L,9L,9L,8L,99L,98L,97L,99L,99L,98L,99L,99L,97L,99L,99L,97L,97L,99L,97L,99L,99L,98L,99L,99L,97L,99L,99L,98L,99L,99L,97L,99L,99L,98L,99L,99L,97L,99L,97L,98L,99L,99L,97L,99L,99L,98L,99L,99L,97L,98L,99L,98L,99L,99L,97L,99L,99L,97L,99L,99L,97L,99L,99L,98L,99L,99L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109942Inst : IEnumerable<long>
{
public static readonly long[] Value=A109942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109942.Bytes);
public long this[int i]=>Value[i];

public static A109942Inst Instance=new A109942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109943
{
public static readonly long[] Value={ 1L,11L,30L,63L,116L,187L,281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109943Inst : IEnumerable<long>
{
public static readonly long[] Value=A109943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109943.Bytes);
public long this[int i]=>Value[i];

public static A109943Inst Instance=new A109943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109944
{
public static readonly long[] Value={ 1L,20L,30L,41L,50L,61L,70L,83L,97L,101L,110L,127L,130L,149L,151L,163L,170L,181L,190L,2003L,211L,223L,230L,241L,251L,263L,271L,281L,290L,307L,310L,3203L,331L,347L,353L,367L,370L,383L,397L,401L,410L,421L,430L,443L,457L,461L,470L,487L,491L,503L,5101L,521L,530L,541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109944Inst : IEnumerable<long>
{
public static readonly long[] Value=A109944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109944.Bytes);
public long this[int i]=>Value[i];

public static A109944Inst Instance=new A109944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109945
{
public static readonly long[] Value={ 3L,5L,11L,29L,41L,71L,137L,281L,461L,599L,641L,827L,881L,1091L,1301L,1607L,2129L,2267L,2381L,2687L,3527L,3557L,3581L,4127L,4229L,4337L,4547L,5009L,5741L,6131L,6791L,6959L,7211L,7487L,7547L,8009L,8597L,8861L,9041L,9281L,10007L,10037L,10427L,10889L,11117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109945Inst : IEnumerable<long>
{
public static readonly long[] Value=A109945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109945.Bytes);
public long this[int i]=>Value[i];

public static A109945Inst Instance=new A109945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109946
{
public static readonly long[] Value={ 2L,19L,41L,79L,331L,439L,499L,619L,829L,1031L,1069L,1279L,1451L,1481L,1511L,1811L,1889L,1901L,1931L,2089L,2179L,2791L,3019L,3109L,3181L,3449L,3491L,3769L,3821L,3911L,4159L,4231L,4639L,4861L,4951L,5081L,5419L,5441L,5749L,5849L,6101L,6131L,6709L,7151L,7349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109946Inst : IEnumerable<long>
{
public static readonly long[] Value=A109946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109946.Bytes);
public long this[int i]=>Value[i];

public static A109946Inst Instance=new A109946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109947
{
public static readonly BigInteger[] Value={ 2L,13L,739L,4937L,24691L,123457L,29629609L,24691357L,1234567891L,530864193131L,12345678910111L,1851851836516681L,74074073460667279L,BigInteger.Parse("76543209242689521469"),BigInteger.Parse("8395061658875624936221"),BigInteger.Parse("123456789101112131415161") };
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
public class A109947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109947Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109947.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109947Inst Instance=new A109947Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109948
{
public static readonly BigInteger[] Value={ 2L,43L,643L,51853L,108643L,3925927L,45925927L,525925927L,9876543211L,65925925927L,6665925925927L,1453331851851853L,1154657766913580249L,BigInteger.Parse("45219875551604938273"),BigInteger.Parse("7873482297771358024693"),BigInteger.Parse("742965003571105432098767") };
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
public class A109948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109948Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109948.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109948Inst Instance=new A109948Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109949
{
public static readonly BigInteger[] Value={ 2L,727L,147853L,7405927L,3456720989L,24691308643L,34567894320989L,8888888711111113L,518518517481481483L,BigInteger.Parse("271604936041728395063"),BigInteger.Parse("3703703673033329629629631"),BigInteger.Parse("22222222038200179997777777779") };
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
public class A109949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109949Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109949.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109949Inst Instance=new A109949Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109950
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,5L,6L,8L,10L,11L,14L,16L,18L,23L,25L,29L,32L,39L,41L,49L,51L,57L,66L,71L,74L,82L,92L,92L,106L,105L,117L,123L,129L,132L,145L,153L,157L,173L,173L,187L,204L,214L,218L,250L,257L,266L,298L,301L,329L,359L,368L,370L,412L,433L,433L,478L,475L,508L,538L,526L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109950Inst : IEnumerable<long>
{
public static readonly long[] Value=A109950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109950.Bytes);
public long this[int i]=>Value[i];

public static A109950Inst Instance=new A109950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109951
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,1L,1L,2L,2L,1L,3L,2L,2L,5L,2L,4L,3L,7L,2L,8L,2L,6L,9L,5L,3L,8L,10L,0L,14L,-1L,12L,6L,6L,3L,13L,8L,4L,16L,0L,14L,17L,10L,4L,32L,7L,9L,32L,3L,28L,30L,9L,2L,42L,21L,0L,45L,-3L,33L,30L,-12L,2L,62L,18L,-1L,54L,-22L,60L,6L,19L,-18L,146L,-22L,16L,95L,-7L,61L,11L,74L,10L,135L,25L,-15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109951Inst : IEnumerable<long>
{
public static readonly long[] Value=A109951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109951.Bytes);
public long this[int i]=>Value[i];

public static A109951Inst Instance=new A109951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109952
{
public static readonly long[] Value={ 5L,15L,45L,55L,65L,75L,115L,125L,145L,155L,175L,195L,205L,215L,255L,265L,295L,315L,325L,345L,395L,405L,425L,475L,505L,525L,545L,555L,565L,595L,645L,665L,695L,705L,715L,745L,765L,775L,805L,815L,845L,855L,875L,925L,945L,975L,995L,1025L,1045L,1055L,1065L,1095L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109952Inst : IEnumerable<long>
{
public static readonly long[] Value=A109952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109952.Bytes);
public long this[int i]=>Value[i];

public static A109952Inst Instance=new A109952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109953
{
public static readonly long[] Value={ 2L,7L,11L,17L,29L,37L,43L,53L,73L,79L,83L,97L,137L,191L,233L,251L,263L,269L,271L,277L,281L,359L,379L,389L,433L,461L,479L,521L,541L,577L,601L,631L,647L,677L,691L,719L,739L,827L,829L,863L,881L,929L,947L,983L,997L,1033L,1063L,1087L,1109L,1187L,1223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109953Inst : IEnumerable<long>
{
public static readonly long[] Value=A109953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109953.Bytes);
public long this[int i]=>Value[i];

public static A109953Inst Instance=new A109953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109954
{
public static readonly long[] Value={ 1L,-3L,1L,6L,-5L,1L,-10L,15L,-7L,1L,15L,-35L,28L,-9L,1L,-21L,70L,-84L,45L,-11L,1L,28L,-126L,210L,-165L,66L,-13L,1L,-36L,210L,-462L,495L,-286L,91L,-15L,1L,45L,-330L,924L,-1287L,1001L,-455L,120L,-17L,1L,-55L,495L,-1716L,3003L,-3003L,1820L,-680L,153L,-19L,1L,66L,-715L,3003L,-6435L,8008L,-6188L,3060L,-969L,190L,-21L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109954Inst : IEnumerable<long>
{
public static readonly long[] Value=A109954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109954.Bytes);
public long this[int i]=>Value[i];

public static A109954Inst Instance=new A109954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109955
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,10L,7L,1L,1L,20L,28L,10L,1L,1L,35L,84L,55L,13L,1L,1L,56L,210L,220L,91L,16L,1L,1L,84L,462L,715L,455L,136L,19L,1L,1L,120L,924L,2002L,1820L,816L,190L,22L,1L,1L,165L,1716L,5005L,6188L,3876L,1330L,253L,25L,1L,1L,220L,3003L,11440L,18564L,15504L,7315L,2024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109955Inst : IEnumerable<long>
{
public static readonly long[] Value=A109955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109955.Bytes);
public long this[int i]=>Value[i];

public static A109955Inst Instance=new A109955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109956
{
public static readonly long[] Value={ 1L,-1L,1L,3L,-4L,1L,-12L,18L,-7L,1L,55L,-88L,42L,-10L,1L,-273L,455L,-245L,75L,-13L,1L,1428L,-2448L,1428L,-510L,117L,-16L,1L,-7752L,13566L,-8379L,3325L,-910L,168L,-19L,1L,43263L,-76912L,49588L,-21252L,6578L,-1472L,228L,-22L,1L,-246675L,444015L,-296010L,134550L,-45630L,11700L,-2223L,297L,-25L,1L,1430715L,-2601300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109956Inst : IEnumerable<long>
{
public static readonly long[] Value=A109956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109956.Bytes);
public long this[int i]=>Value[i];

public static A109956Inst Instance=new A109956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109957
{
public static readonly long[] Value={ 1L,-1L,4L,-16L,74L,-368L,1926L,-10455L,58333L,-332489L,1927761L,-11334128L,67416570L,-404956315L,2453012916L,-14967587873L,91910798556L,-567566697627L,3522334450512L,-21957276973619L,137425078658354L,-863229921626723L,5440215989173113L,-34388244134246836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109957Inst : IEnumerable<long>
{
public static readonly long[] Value=A109957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109957.Bytes);
public long this[int i]=>Value[i];

public static A109957Inst Instance=new A109957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109958
{
public static readonly long[] Value={ 10L,22L,33L,44L,55L,65L,77L,86L,96L,107L,1111L,127L,1313L,149L,158L,168L,1717L,188L,1919L,209L,2110L,2213L,2323L,249L,2510L,2615L,279L,2811L,2929L,3010L,3131L,3210L,3314L,3419L,3512L,3610L,3737L,3821L,3916L,4011L,4141L,4212L,4343L,4415L,4511L,4625L,4747L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109958Inst : IEnumerable<long>
{
public static readonly long[] Value=A109958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109958.Bytes);
public long this[int i]=>Value[i];

public static A109958Inst Instance=new A109958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109959
{
public static readonly long[] Value={ 10L,12L,14L,22L,38L,82L,90L,92L,96L,116L,117L,122L,134L,147L,158L,165L,178L,198L,210L,218L,236L,262L,274L,304L,314L,332L,333L,352L,358L,360L,369L,387L,390L,399L,420L,448L,454L,478L,482L,496L,522L,561L,562L,603L,605L,622L,637L,639L,640L,651L,694L,704L,714L,720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109959Inst : IEnumerable<long>
{
public static readonly long[] Value=A109959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109959.Bytes);
public long this[int i]=>Value[i];

public static A109959Inst Instance=new A109959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109960
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,15L,9L,1L,1L,35L,45L,13L,1L,1L,70L,165L,91L,17L,1L,1L,126L,495L,455L,153L,21L,1L,1L,210L,1287L,1820L,969L,231L,25L,1L,1L,330L,3003L,6188L,4845L,1771L,325L,29L,1L,1L,495L,6435L,18564L,20349L,10626L,2925L,435L,33L,1L,1L,715L,12870L,50388L,74613L,53130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109960Inst : IEnumerable<long>
{
public static readonly long[] Value=A109960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109960.Bytes);
public long this[int i]=>Value[i];

public static A109960Inst Instance=new A109960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109961
{
public static readonly long[] Value={ 1L,1L,2L,6L,17L,45L,117L,305L,798L,2090L,5473L,14329L,37513L,98209L,257114L,673134L,1762289L,4613733L,12078909L,31622993L,82790070L,216747218L,567451585L,1485607537L,3889371025L,10182505537L,26658145586L,69791931222L,182717648081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109961Inst : IEnumerable<long>
{
public static readonly long[] Value=A109961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109961.Bytes);
public long this[int i]=>Value[i];

public static A109961Inst Instance=new A109961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109962
{
public static readonly long[] Value={ 1L,-1L,1L,4L,-5L,1L,-22L,30L,-9L,1L,140L,-200L,72L,-13L,1L,-969L,1425L,-570L,130L,-17L,1L,7084L,-10626L,4554L,-1196L,204L,-21L,1L,-53820L,81900L,-36855L,10647L,-2142L,294L,-25L,1L,420732L,-647280L,302064L,-93496L,21080L,-3472L,400L,-29L,1L,-3362260L,5217300L,-2504304L,816816L,-200277L,37485L,-5250L,522L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109962Inst : IEnumerable<long>
{
public static readonly long[] Value=A109962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109962.Bytes);
public long this[int i]=>Value[i];

public static A109962Inst Instance=new A109962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109963
{
public static readonly long[] Value={ 1L,-1L,5L,-27L,171L,-1178L,8582L,-65029L,507317L,-4047608L,32874104L,-270893586L,2259210814L,-19032956491L,161735556091L,-1384662302187L,11931865642979L,-103409449621325L,900778907303037L,-7882176975668156L,69253864680597564L,-610717827031587856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109963Inst : IEnumerable<long>
{
public static readonly long[] Value=A109963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109963.Bytes);
public long this[int i]=>Value[i];

public static A109963Inst Instance=new A109963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109964
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,3L,3L,4L,4L,4L,5L,5L,6L,6L,7L,7L,8L,8L,8L,9L,9L,10L,10L,11L,11L,12L,12L,13L,13L,14L,14L,15L,15L,16L,16L,16L,17L,17L,18L,18L,19L,19L,20L,20L,21L,21L,22L,22L,23L,23L,24L,24L,25L,25L,26L,26L,27L,27L,28L,28L,29L,29L,30L,30L,31L,31L,32L,32L,32L,33L,33L,34L,34L,35L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109964Inst : IEnumerable<long>
{
public static readonly long[] Value=A109964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109964.Bytes);
public long this[int i]=>Value[i];

public static A109964Inst Instance=new A109964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109965
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,6L,8L,10L,13L,16L,20L,24L,28L,33L,38L,44L,50L,57L,64L,72L,80L,88L,97L,106L,116L,126L,137L,148L,160L,172L,185L,198L,212L,226L,241L,256L,272L,288L,304L,321L,338L,356L,374L,393L,412L,432L,452L,473L,494L,516L,538L,561L,584L,608L,632L,657L,682L,708L,734L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109965Inst : IEnumerable<long>
{
public static readonly long[] Value=A109965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109965.Bytes);
public long this[int i]=>Value[i];

public static A109965Inst Instance=new A109965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109966
{
public static readonly BigInteger[] Value={ 1L,1L,8L,512L,262144L,1073741824L,35184372088832L,9223372036854775808UL,BigInteger.Parse("19342813113834066795298816"),BigInteger.Parse("324518553658426726783156020576256"),BigInteger.Parse("43556142965880123323311959751266331066368") };
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
public class A109966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109966Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109966.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109966Inst Instance=new A109966Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109967
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,1L,1L,2L,1L,2L,2L,1L,3L,2L,2L,2L,3L,1L,3L,2L,2L,2L,1L,2L,1L,2L,0L,2L,0L,1L,0L,2L,0L,0L,2L,-1L,2L,0L,2L,0L,3L,0L,3L,2L,0L,4L,1L,3L,1L,4L,0L,4L,1L,4L,2L,0L,4L,0L,4L,0L,4L,0L,4L,0L,5L,2L,0L,6L,0L,5L,1L,6L,0L,7L,1L,7L,4L,0L,8L,1L,7L,1L,8L,0L,8L,1L,8L,4L,0L,9L,0L,8L,0L,9L,-1L,9L,0L,10L,4L,-1L,11L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109967Inst : IEnumerable<long>
{
public static readonly long[] Value=A109967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109967.Bytes);
public long this[int i]=>Value[i];

public static A109967Inst Instance=new A109967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109968
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,4L,5L,6L,8L,9L,11L,12L,14L,16L,18L,20L,21L,24L,24L,27L,27L,30L,30L,30L,31L,32L,32L,31L,32L,31L,32L,29L,31L,29L,30L,28L,28L,28L,27L,29L,27L,28L,26L,30L,28L,30L,29L,30L,30L,31L,31L,32L,35L,31L,38L,33L,35L,34L,36L,38L,39L,38L,37L,39L,38L,43L,40L,44L,42L,44L,43L,44L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109968Inst : IEnumerable<long>
{
public static readonly long[] Value=A109968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109968.Bytes);
public long this[int i]=>Value[i];

public static A109968Inst Instance=new A109968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109969
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,1L,1L,2L,1L,2L,1L,2L,2L,2L,2L,1L,3L,0L,3L,0L,3L,0L,0L,1L,1L,0L,-1L,1L,-1L,1L,-3L,2L,-2L,1L,-2L,0L,0L,-1L,2L,-2L,1L,-2L,4L,-2L,2L,-1L,1L,0L,1L,0L,1L,3L,-4L,7L,-5L,2L,-1L,2L,2L,1L,-1L,-1L,2L,-1L,5L,-3L,4L,-2L,2L,-1L,1L,0L,2L,4L,-4L,6L,-3L,2L,-1L,2L,0L,1L,3L,1L,1L,-4L,8L,-6L,4L,1L,2L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109969Inst : IEnumerable<long>
{
public static readonly long[] Value=A109969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109969.Bytes);
public long this[int i]=>Value[i];

public static A109969Inst Instance=new A109969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109970
{
public static readonly long[] Value={ 1L,0L,1L,0L,-2L,1L,0L,1L,-4L,1L,0L,0L,6L,-6L,1L,0L,0L,-4L,15L,-8L,1L,0L,0L,1L,-20L,28L,-10L,1L,0L,0L,0L,15L,-56L,45L,-12L,1L,0L,0L,0L,-6L,70L,-120L,66L,-14L,1L,0L,0L,0L,1L,-56L,210L,-220L,91L,-16L,1L,0L,0L,0L,0L,28L,-252L,495L,-364L,120L,-18L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109970Inst : IEnumerable<long>
{
public static readonly long[] Value=A109970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109970.Bytes);
public long this[int i]=>Value[i];

public static A109970Inst Instance=new A109970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109971
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,7L,4L,1L,0L,30L,18L,6L,1L,0L,143L,88L,33L,8L,1L,0L,728L,455L,182L,52L,10L,1L,0L,3876L,2448L,1020L,320L,75L,12L,1L,0L,21318L,13566L,5814L,1938L,510L,102L,14L,1L,0L,120175L,76912L,33649L,11704L,3325L,760L,133L,16L,1L,0L,690690L,444015L,197340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109971Inst : IEnumerable<long>
{
public static readonly long[] Value=A109971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109971.Bytes);
public long this[int i]=>Value[i];

public static A109971Inst Instance=new A109971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109972
{
public static readonly long[] Value={ 1L,0L,1L,2L,8L,34L,162L,822L,4365L,23956L,134814L,773746L,4511693L,26652346L,159170385L,959412290L,5829083420L,35661048886L,219491344362L,1358204062536L,8444658457530L,52729475008690L,330518562341537L,2078987880103170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109972Inst : IEnumerable<long>
{
public static readonly long[] Value=A109972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109972.Bytes);
public long this[int i]=>Value[i];

public static A109972Inst Instance=new A109972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109973
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,3L,2L,0L,1L,1L,3L,2L,1L,3L,3L,0L,1L,1L,3L,2L,1L,3L,3L,0L,1L,1L,3L,2L,2L,3L,3L,4L,1L,0L,1L,1L,4L,2L,2L,3L,2L,4L,2L,5L,1L,0L,1L,1L,5L,2L,2L,3L,2L,4L,1L,5L,2L,6L,1L,0L,1L,1L,5L,2L,4L,3L,1L,4L,1L,5L,1L,6L,2L,7L,1L,0L,1L,1L,6L,2L,4L,3L,1L,4L,1L,5L,1L,6L,1L,7L,2L,8L,1L,0L,1L,1L,7L,2L,4L,3L,1L,4L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109973Inst : IEnumerable<long>
{
public static readonly long[] Value=A109973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109973.Bytes);
public long this[int i]=>Value[i];

public static A109973Inst Instance=new A109973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109974
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,1L,3L,4L,5L,1L,2L,7L,10L,9L,1L,4L,6L,21L,28L,17L,1L,2L,12L,26L,73L,82L,33L,1L,4L,8L,50L,126L,273L,244L,65L,1L,3L,15L,50L,252L,626L,1057L,730L,129L,1L,4L,13L,85L,344L,1394L,3126L,4161L,2188L,257L,1L,2L,18L,91L,585L,2402L,8052L,15626L,16513L,6562L,513L,1L,6L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109974Inst : IEnumerable<long>
{
public static readonly long[] Value=A109974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109974.Bytes);
public long this[int i]=>Value[i];

public static A109974Inst Instance=new A109974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109975
{
public static readonly long[] Value={ 1L,2L,4L,9L,20L,44L,96L,208L,448L,960L,2048L,4352L,9216L,19456L,40960L,86016L,180224L,376832L,786432L,1638400L,3407872L,7077888L,14680064L,30408704L,62914560L,130023424L,268435456L,553648128L,1140850688L,2348810240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109975Inst : IEnumerable<long>
{
public static readonly long[] Value=A109975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109975.Bytes);
public long this[int i]=>Value[i];

public static A109975Inst Instance=new A109975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109976
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,16L,19L,46L,66L,159L,274L,667L,1320L,3263L,7156L,18084L,42794L,111018L,278752L,743889L,1959482L,5383395L,14761634L,41740307L,118517301L,344580865L,1009349749L,3013665637L,9081346743L,27808754039L,86015003997L,269796018547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109976Inst : IEnumerable<long>
{
public static readonly long[] Value=A109976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109976.Bytes);
public long this[int i]=>Value[i];

public static A109976Inst Instance=new A109976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109977
{
public static readonly long[] Value={ 1L,-2L,1L,4L,-3L,1L,-15L,11L,-5L,1L,107L,-76L,35L,-9L,1L,-1475L,1041L,-476L,125L,-17L,1L,40914L,-28858L,13177L,-3460L,479L,-33L,1L,-2327019L,1641270L,-749336L,196731L,-27260L,1901L,-65L,1L,271813931L,-191712888L,87527566L,-22979242L,3184213L,-222196L,7655L,-129L,1L,-64930439315L,45796039830L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109977Inst : IEnumerable<long>
{
public static readonly long[] Value=A109977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109977.Bytes);
public long this[int i]=>Value[i];

public static A109977Inst Instance=new A109977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109978
{
public static readonly long[] Value={ 1L,1L,1L,-1L,1L,1L,2L,-2L,2L,1L,-5L,5L,-4L,5L,1L,13L,-14L,11L,-7L,12L,1L,-33L,40L,-35L,20L,-5L,27L,1L,80L,-111L,113L,-77L,21L,34L,58L,1L,-184L,293L,-350L,294L,-144L,-27L,238L,121L,1L,402L,-731L,1021L,-1042L,716L,-249L,-153L,1063L,248L,1L,-840L,1726L,-2796L,3409L,-2982L,1755L,-724L,318L,4037L,503L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109978Inst : IEnumerable<long>
{
public static readonly long[] Value=A109978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109978.Bytes);
public long this[int i]=>Value[i];

public static A109978Inst Instance=new A109978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109979
{
public static readonly long[] Value={ 1L,2L,1L,8L,4L,1L,36L,20L,6L,1L,172L,104L,36L,8L,1L,852L,552L,212L,56L,10L,1L,4324L,2968L,1236L,368L,80L,12L,1L,22332L,16104L,7164L,2336L,580L,108L,14L,1L,116876L,87976L,41372L,14512L,3980L,856L,140L,16L,1L,618084L,483192L,238356L,88848L,26372L,6312L,1204L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109979Inst : IEnumerable<long>
{
public static readonly long[] Value=A109979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109979.Bytes);
public long this[int i]=>Value[i];

public static A109979Inst Instance=new A109979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109980
{
public static readonly long[] Value={ 1L,2L,8L,36L,172L,852L,4324L,22332L,116876L,618084L,3296308L,17702412L,95627580L,519170004L,2830862532L,15494401116L,85091200620L,468692890308L,2588521289812L,14330490031020L,79509491551772L,442019710668852L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109980Inst : IEnumerable<long>
{
public static readonly long[] Value=A109980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109980.Bytes);
public long this[int i]=>Value[i];

public static A109980Inst Instance=new A109980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109981
{
public static readonly long[] Value={ 11L,23L,29L,41L,43L,47L,61L,67L,83L,89L,101L,113L,131L,137L,139L,151L,157L,173L,179L,191L,193L,197L,199L,223L,227L,229L,241L,263L,269L,281L,283L,311L,313L,317L,331L,337L,353L,359L,373L,379L,397L,401L,409L,421L,443L,449L,461L,463L,467L,487L,557L,571L,577L,593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109981Inst : IEnumerable<long>
{
public static readonly long[] Value=A109981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109981.Bytes);
public long this[int i]=>Value[i];

public static A109981Inst Instance=new A109981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109982
{
public static readonly long[] Value={ 11L,41L,67L,83L,157L,179L,191L,241L,283L,331L,353L,401L,461L,599L,739L,773L,797L,919L,991L,10079L,10169L,10433L,10457L,10589L,10631L,10723L,10853L,10909L,11311L,11447L,11867L,11953L,12097L,12143L,12301L,12457L,12479L,12503L,12547L,12763L,13003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109982Inst : IEnumerable<long>
{
public static readonly long[] Value=A109982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109982.Bytes);
public long this[int i]=>Value[i];

public static A109982Inst Instance=new A109982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109983
{
public static readonly long[] Value={ 1L,0L,1L,2L,0L,0L,1L,6L,6L,0L,0L,0L,1L,12L,30L,20L,0L,0L,0L,0L,1L,20L,90L,140L,70L,0L,0L,0L,0L,0L,1L,30L,210L,560L,630L,252L,0L,0L,0L,0L,0L,0L,1L,42L,420L,1680L,3150L,2772L,924L,0L,0L,0L,0L,0L,0L,0L,1L,56L,756L,4200L,11550L,16632L,12012L,3432L,0L,0L,0L,0L,0L,0L,0L,0L,1L,72L,1260L,9240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109983Inst : IEnumerable<long>
{
public static readonly long[] Value=A109983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109983.Bytes);
public long this[int i]=>Value[i];

public static A109983Inst Instance=new A109983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109984
{
public static readonly long[] Value={ 0L,5L,44L,321L,2184L,14325L,91860L,580097L,3622928L,22437477L,138049020L,844881345L,5148375192L,31258302933L,189199514532L,1142148091905L,6878977097760L,41347348295877L,248082231062988L,1486116788646977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109984Inst : IEnumerable<long>
{
public static readonly long[] Value=A109984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109984.Bytes);
public long this[int i]=>Value[i];

public static A109984Inst Instance=new A109984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109985
{
public static readonly long[] Value={ 179L,331L,919L,1003757L,1008701L,1026217L,1037471L,1044149L,1054733L,1063849L,1074377L,1082231L,1087519L,1093109L,1114039L,1119241L,1120313L,1148753L,1154561L,1157333L,1159339L,1161767L,1169059L,1170251L,1178743L,1180247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109985Inst : IEnumerable<long>
{
public static readonly long[] Value=A109985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109985.Bytes);
public long this[int i]=>Value[i];

public static A109985Inst Instance=new A109985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109986
{
public static readonly long[] Value={ 5L,7L,3L,2L,89L,83L,11L,59L,53L,41L,47L,43L,19L,97L,17L,79L,71L,73L,61L,67L,13L,31L,37L,29L,23L,881L,887L,883L,811L,859L,857L,853L,809L,877L,863L,839L,829L,821L,827L,823L,587L,557L,541L,547L,509L,599L,593L,571L,577L,569L,563L,503L,521L,523L,487L,457L,449L,443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109986Inst : IEnumerable<long>
{
public static readonly long[] Value=A109986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109986.Bytes);
public long this[int i]=>Value[i];

public static A109986Inst Instance=new A109986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109987
{
public static readonly long[] Value={ 4L,9L,6L,85L,87L,86L,82L,15L,58L,55L,51L,57L,49L,46L,14L,95L,94L,91L,93L,74L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109987Inst : IEnumerable<long>
{
public static readonly long[] Value=A109987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109987.Bytes);
public long this[int i]=>Value[i];

public static A109987Inst Instance=new A109987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109988
{
public static readonly long[] Value={ 8L,18L,50L,52L,45L,44L,42L,98L,99L,92L,70L,78L,75L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109988Inst : IEnumerable<long>
{
public static readonly long[] Value=A109988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109988.Bytes);
public long this[int i]=>Value[i];

public static A109988Inst Instance=new A109988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109989
{
public static readonly long[] Value={ 88L,84L,81L,54L,56L,40L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109989Inst : IEnumerable<long>
{
public static readonly long[] Value=A109989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109989.Bytes);
public long this[int i]=>Value[i];

public static A109989Inst Instance=new A109989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109990
{
public static readonly long[] Value={ 3L,17L,23L,27L,41L,53L,57L,59L,89L,93L,101L,137L,141L,153L,167L,171L,191L,201L,213L,237L,239L,243L,249L,261L,263L,267L,269L,279L,291L,317L,323L,339L,347L,351L,359L,369L,377L,383L,417L,419L,431L,447L,471L,477L,479L,489L,491L,509L,513L,521L,527L,543L,549L,551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109990Inst : IEnumerable<long>
{
public static readonly long[] Value=A109990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109990.Bytes);
public long this[int i]=>Value[i];

public static A109990Inst Instance=new A109990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109991
{
public static readonly long[] Value={ 1L,3L,7L,19L,21L,31L,37L,39L,49L,61L,63L,67L,87L,93L,117L,129L,169L,177L,211L,223L,237L,241L,259L,261L,289L,301L,321L,327L,337L,339L,379L,397L,411L,423L,427L,463L,469L,471L,493L,499L,513L,523L,547L,589L,591L,607L,609L,643L,651L,657L,661L,663L,667L,681L,721L,729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109991Inst : IEnumerable<long>
{
public static readonly long[] Value=A109991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109991.Bytes);
public long this[int i]=>Value[i];

public static A109991Inst Instance=new A109991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109992
{
public static readonly long[] Value={ 1L,7L,23L,29L,31L,41L,49L,67L,73L,103L,109L,119L,131L,133L,137L,139L,149L,173L,181L,191L,223L,233L,241L,251L,257L,259L,277L,289L,317L,347L,349L,367L,371L,377L,391L,397L,401L,409L,431L,439L,469L,487L,497L,523L,527L,529L,551L,559L,563L,571L,577L,581L,607L,611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109992Inst : IEnumerable<long>
{
public static readonly long[] Value=A109992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109992.Bytes);
public long this[int i]=>Value[i];

public static A109992Inst Instance=new A109992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109993
{
public static readonly long[] Value={ 2L,14L,16L,18L,26L,30L,36L,42L,62L,132L,242L,294L,302L,666L,816L,824L,998L,1218L,1472L,2522L,3098L,4148L,6404L,8102L,25656L,26490L,56702L,76442L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109993Inst : IEnumerable<long>
{
public static readonly long[] Value=A109993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109993.Bytes);
public long this[int i]=>Value[i];

public static A109993Inst Instance=new A109993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109994
{
public static readonly long[] Value={ 2699L,4679L,10259L,14489L,18719L,19949L,31607L,42797L,49139L,85487L,90749L,104651L,129887L,226799L,294269L,396269L,422657L,458987L,481571L,665279L,710531L,729059L,1082399L,1251947L,1302449L,1994687L,2035151L,2510567L,2811269L,3090089L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109994Inst : IEnumerable<long>
{
public static readonly long[] Value=A109994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109994.Bytes);
public long this[int i]=>Value[i];

public static A109994Inst Instance=new A109994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109995
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,5L,18L,86L,549L,4647L,52060L,772976L,15240116L,400345371L,14063594530L,663256392496L,42161077371566L,3625838175218123L,423372648479289300L,BigInteger.Parse("67333725775723184308"),BigInteger.Parse("14628921614102655999804"),BigInteger.Parse("4352732830667872529962044") };
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
public class A109995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109995Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109995.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109995Inst Instance=new A109995Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109996
{
public static readonly long[] Value={ 23L,47L,53L,59L,71L,83L,89L,107L,131L,139L,149L,167L,179L,191L,223L,227L,239L,251L,263L,269L,293L,311L,317L,347L,349L,359L,383L,389L,419L,431L,439L,449L,461L,467L,479L,491L,503L,509L,557L,569L,571L,587L,593L,599L,607L,619L,643L,647L,659L,683L,701L,719L,727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109996Inst : IEnumerable<long>
{
public static readonly long[] Value=A109996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109996.Bytes);
public long this[int i]=>Value[i];

public static A109996Inst Instance=new A109996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109997
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,29L,31L,37L,41L,43L,61L,67L,73L,79L,97L,101L,103L,109L,113L,127L,137L,151L,157L,163L,173L,181L,193L,197L,199L,211L,229L,233L,241L,257L,271L,277L,281L,283L,307L,313L,331L,337L,353L,367L,373L,379L,397L,401L,409L,421L,433L,443L,457L,463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109997Inst : IEnumerable<long>
{
public static readonly long[] Value=A109997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109997.Bytes);
public long this[int i]=>Value[i];

public static A109997Inst Instance=new A109997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109998
{
public static readonly long[] Value={ 17L,43L,67L,71L,101L,103L,109L,127L,137L,149L,151L,163L,181L,197L,223L,241L,257L,269L,283L,311L,317L,349L,353L,373L,389L,401L,409L,433L,449L,461L,463L,487L,521L,523L,557L,569L,571L,599L,617L,631L,643L,647L,677L,701L,709L,739L,751L,769L,773L,787L,797L,821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109998Inst : IEnumerable<long>
{
public static readonly long[] Value=A109998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109998.Bytes);
public long this[int i]=>Value[i];

public static A109998Inst Instance=new A109998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109999
{
public static readonly long[] Value={ 2L,7L,22L,70L,223L,707L,2236L,7071L,22360L,70710L,223606L,707106L,2236068L,7071076L,22360524L,70704438L,223890647L,707106781L,2236067977L,7071067811L,22360679774L,70710678118L,223606797749L,707106781186L,2236067977499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109999Inst : IEnumerable<long>
{
public static readonly long[] Value=A109999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109999.Bytes);
public long this[int i]=>Value[i];

public static A109999Inst Instance=new A109999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110000
{
public static readonly long[] Value={ 1L,4L,6L,5L,8L,7L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110000Inst : IEnumerable<long>
{
public static readonly long[] Value=A110000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110000.Bytes);
public long this[int i]=>Value[i];

public static A110000Inst Instance=new A110000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110001
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,4L,8L,16L,3L,9L,27L,81L,4L,16L,64L,256L,5L,25L,125L,625L,6L,36L,216L,1296L,7L,49L,343L,2401L,8L,64L,512L,4096L,9L,81L,729L,6561L,10L,100L,1000L,10000L,11L,121L,1331L,14641L,12L,144L,1728L,20736L,13L,169L,2197L,28561L,14L,196L,2744L,38416L,15L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110001Inst : IEnumerable<long>
{
public static readonly long[] Value=A110001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110001.Bytes);
public long this[int i]=>Value[i];

public static A110001Inst Instance=new A110001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110002
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,22L,44L,222L,292L,414L,646L,717L,848L,979L,27072L,28882L,45954L,74247L,90109L,96569L,118811L,2376732L,5136315L,5185815L,5266625L,5635365L,5684865L,6344436L,7424247L,7481847L,7484847L,7929297L,9858589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110002Inst : IEnumerable<long>
{
public static readonly long[] Value=A110002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110002.Bytes);
public long this[int i]=>Value[i];

public static A110002Inst Instance=new A110002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110003
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,8L,4L,16L,3L,27L,9L,81L,4L,64L,16L,256L,5L,125L,25L,625L,6L,216L,36L,1296L,7L,343L,49L,2401L,8L,512L,64L,4096L,9L,729L,81L,6561L,10L,1000L,100L,10000L,11L,1331L,121L,14641L,12L,1728L,144L,20736L,13L,2197L,169L,28561L,14L,2744L,196L,38416L,15L,3375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110003Inst : IEnumerable<long>
{
public static readonly long[] Value=A110003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110003.Bytes);
public long this[int i]=>Value[i];

public static A110003Inst Instance=new A110003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110004
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,8L,16L,4L,3L,27L,81L,9L,4L,64L,256L,16L,5L,125L,625L,25L,6L,216L,1296L,36L,7L,343L,2401L,49L,8L,512L,4096L,64L,9L,729L,6561L,81L,10L,1000L,10000L,100L,11L,1331L,14641L,121L,12L,1728L,20736L,144L,13L,2197L,28561L,169L,14L,2744L,38416L,196L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110004Inst : IEnumerable<long>
{
public static readonly long[] Value=A110004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110004.Bytes);
public long this[int i]=>Value[i];

public static A110004Inst Instance=new A110004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110005
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,4L,16L,8L,3L,9L,81L,27L,4L,16L,256L,64L,5L,25L,625L,125L,6L,36L,1296L,216L,7L,49L,2401L,343L,8L,64L,4096L,512L,9L,81L,6561L,729L,10L,100L,10000L,1000L,11L,121L,14641L,1331L,12L,144L,20736L,1728L,13L,169L,28561L,2197L,14L,196L,38416L,2744L,15L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110005Inst : IEnumerable<long>
{
public static readonly long[] Value=A110005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110005.Bytes);
public long this[int i]=>Value[i];

public static A110005Inst Instance=new A110005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110006
{
public static readonly long[] Value={ 1L,2L,3L,3L,2L,3L,3L,4L,3L,2L,3L,3L,2L,3L,3L,4L,3L,2L,3L,3L,4L,3L,2L,3L,3L,2L,3L,3L,4L,3L,2L,3L,3L,2L,3L,3L,4L,3L,2L,3L,3L,4L,3L,2L,3L,3L,2L,3L,3L,4L,3L,2L,3L,3L,4L,3L,2L,3L,3L,2L,3L,3L,4L,3L,2L,3L,3L,2L,3L,3L,4L,3L,2L,3L,3L,4L,3L,2L,3L,3L,2L,3L,3L,4L,3L,2L,3L,3L,2L,3L,3L,4L,3L,2L,3L,3L,4L,3L,2L,3L,3L,2L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110006Inst : IEnumerable<long>
{
public static readonly long[] Value=A110006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110006.Bytes);
public long this[int i]=>Value[i];

public static A110006Inst Instance=new A110006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110007
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,5L,4L,5L,5L,4L,5L,4L,4L,5L,4L,5L,5L,4L,5L,4L,5L,5L,4L,5L,4L,4L,5L,4L,5L,5L,4L,5L,4L,4L,5L,4L,5L,5L,4L,5L,4L,5L,5L,4L,5L,4L,4L,5L,4L,5L,5L,4L,5L,4L,5L,5L,4L,5L,4L,4L,5L,4L,5L,5L,4L,5L,4L,4L,5L,4L,5L,5L,4L,5L,4L,5L,5L,4L,5L,4L,4L,5L,4L,5L,5L,4L,5L,4L,4L,5L,4L,5L,5L,4L,5L,4L,5L,5L,4L,5L,4L,4L,5L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110007Inst : IEnumerable<long>
{
public static readonly long[] Value=A110007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110007.Bytes);
public long this[int i]=>Value[i];

public static A110007Inst Instance=new A110007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110008
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,16L,8L,4L,3L,81L,27L,9L,4L,256L,64L,16L,5L,625L,125L,25L,6L,1296L,216L,36L,7L,2401L,343L,49L,8L,4096L,512L,64L,9L,6561L,729L,81L,10L,10000L,1000L,100L,11L,14641L,1331L,121L,12L,20736L,1728L,144L,13L,28561L,2197L,169L,14L,38416L,2744L,196L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110008Inst : IEnumerable<long>
{
public static readonly long[] Value=A110008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110008.Bytes);
public long this[int i]=>Value[i];

public static A110008Inst Instance=new A110008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110009
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,16L,4L,8L,3L,81L,9L,27L,4L,256L,16L,64L,5L,625L,25L,125L,6L,1296L,36L,216L,7L,2401L,49L,343L,8L,4096L,64L,512L,9L,6561L,81L,729L,10L,10000L,100L,1000L,11L,14641L,121L,1331L,12L,20736L,144L,1728L,13L,28561L,169L,2197L,14L,38416L,196L,2744L,15L,50625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110009Inst : IEnumerable<long>
{
public static readonly long[] Value=A110009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110009.Bytes);
public long this[int i]=>Value[i];

public static A110009Inst Instance=new A110009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110010
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,6L,7L,6L,6L,7L,6L,5L,6L,6L,7L,6L,6L,7L,6L,7L,6L,6L,7L,6L,5L,6L,6L,7L,6L,6L,7L,6L,5L,6L,6L,7L,6L,6L,7L,6L,7L,6L,6L,7L,6L,5L,6L,6L,7L,6L,6L,7L,6L,7L,6L,6L,7L,6L,5L,6L,6L,7L,6L,6L,7L,6L,5L,6L,6L,7L,6L,6L,7L,6L,7L,6L,6L,7L,6L,5L,6L,6L,7L,6L,6L,7L,6L,5L,6L,6L,7L,6L,6L,7L,6L,7L,6L,6L,7L,6L,5L,6L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110010Inst : IEnumerable<long>
{
public static readonly long[] Value=A110010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110010.Bytes);
public long this[int i]=>Value[i];

public static A110010Inst Instance=new A110010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110011
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,8L,7L,8L,8L,7L,8L,7L,8L,8L,7L,8L,8L,9L,8L,7L,8L,8L,7L,8L,7L,8L,8L,7L,8L,8L,7L,8L,7L,8L,8L,7L,8L,8L,9L,8L,7L,8L,8L,7L,8L,7L,8L,8L,7L,8L,8L,9L,8L,7L,8L,8L,7L,8L,7L,8L,8L,7L,8L,8L,7L,8L,7L,8L,8L,7L,8L,8L,9L,8L,7L,8L,8L,7L,8L,7L,8L,8L,7L,8L,8L,7L,8L,7L,8L,8L,7L,8L,8L,9L,8L,7L,8L,8L,7L,8L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110011Inst : IEnumerable<long>
{
public static readonly long[] Value=A110011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110011.Bytes);
public long this[int i]=>Value[i];

public static A110011Inst Instance=new A110011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110012
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,2L,3L,3L,2L,2L,3L,3L,2L,3L,3L,2L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,2L,3L,3L,2L,3L,3L,2L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,2L,3L,3L,2L,3L,3L,2L,2L,3L,3L,2L,3L,3L,2L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,2L,3L,3L,2L,3L,3L,2L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,2L,3L,3L,2L,3L,3L,2L,2L,3L,3L,2L,3L,3L,2L,2L,3L,3L,2L,3L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110012Inst : IEnumerable<long>
{
public static readonly long[] Value=A110012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110012.Bytes);
public long this[int i]=>Value[i];

public static A110012Inst Instance=new A110012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110013
{
public static readonly long[] Value={ 25L,49L,81L,121L,169L,289L,361L,441L,529L,729L,961L,1089L,1521L,1681L,1849L,2401L,2809L,3249L,3721L,3969L,5041L,5929L,6241L,6889L,7921L,8281L,8649L,9409L,10201L,11449L,11881L,12321L,12769L,14161L,14641L,16641L,17161L,17689L,18769L,19881L,23409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110013Inst : IEnumerable<long>
{
public static readonly long[] Value=A110013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110013.Bytes);
public long this[int i]=>Value[i];

public static A110013Inst Instance=new A110013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110014
{
public static readonly long[] Value={ 3L,7L,19L,47L,59L,103L,139L,227L,307L,367L,467L,503L,619L,839L,887L,1039L,1319L,1567L,1699L,1907L,1979L,2203L,2687L,3407L,4003L,4759L,4987L,5827L,6079L,6599L,7703L,8287L,9203L,9679L,10499L,10667L,11527L,12239L,13159L,14503L,16747L,17387L,19379L,22447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110014Inst : IEnumerable<long>
{
public static readonly long[] Value=A110014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110014.Bytes);
public long this[int i]=>Value[i];

public static A110014Inst Instance=new A110014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110015
{
public static readonly long[] Value={ 25L,49L,121L,289L,361L,625L,841L,1369L,1849L,2209L,2809L,3025L,3721L,5041L,5329L,6241L,7921L,9409L,10201L,11449L,11881L,13225L,16129L,20449L,24025L,28561L,29929L,34969L,36481L,39601L,46225L,49729L,55225L,58081L,63001L,64009L,69169L,73441L,78961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110015Inst : IEnumerable<long>
{
public static readonly long[] Value=A110015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110015.Bytes);
public long this[int i]=>Value[i];

public static A110015Inst Instance=new A110015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110016
{
public static readonly long[] Value={ 5L,7L,11L,17L,19L,25L,29L,37L,43L,47L,53L,55L,61L,71L,73L,79L,89L,97L,101L,107L,109L,115L,127L,143L,155L,169L,173L,187L,191L,199L,215L,223L,235L,241L,251L,253L,263L,271L,281L,295L,317L,323L,341L,367L,377L,389L,395L,397L,403L,415L,425L,433L,439L,443L,449L,457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110016Inst : IEnumerable<long>
{
public static readonly long[] Value=A110016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110016.Bytes);
public long this[int i]=>Value[i];

public static A110016Inst Instance=new A110016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110017
{
public static readonly BigInteger[] Value={ 1L,38L,17370L,31532760L,152770174200L,1623335272297200L,BigInteger.Parse("33237789624004165200"),BigInteger.Parse("1195230914866984819824000"),BigInteger.Parse("70405077040237339921593072000"),BigInteger.Parse("6434319990707289925222982683680000"),BigInteger.Parse("873465373058505314477955434719930080000") };
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
public class A110017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110017Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110017.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110017Inst Instance=new A110017Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110018
{
public static readonly long[] Value={ 10611L,145215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110018Inst : IEnumerable<long>
{
public static readonly long[] Value=A110018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110018.Bytes);
public long this[int i]=>Value[i];

public static A110018Inst Instance=new A110018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110019
{
public static readonly long[] Value={ 12L,30L,70L,88L,97998L,98048L,99988L,111644L,130304L,869696L,888356L,9866958L,9908612L,38713866L,43672638L,56327362L,61286134L,97845666L,99916796L,3276615836L,3611536474L,6388463526L,6723384164L,9938713866L,9956658572L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110019Inst : IEnumerable<long>
{
public static readonly long[] Value=A110019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110019.Bytes);
public long this[int i]=>Value[i];

public static A110019Inst Instance=new A110019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110020
{
public static readonly long[] Value={ 1L,2L,5L,12L,8L,2L,5L,7L,3L,2L,5L,4L,6L,13L,7L,2L,11L,15L,6L,2L,36L,13L,2L,6L,3L,7L,3L,4L,2L,9L,4L,2L,2L,2L,2L,2L,6L,5L,2L,3L,2L,2L,2L,2L,11L,3L,59L,8L,2L,4L,104L,103L,5L,6L,2L,2L,2L,59L,2L,2L,3L,9L,20L,4L,2L,3L,4L,3L,4L,2L,2L,2L,2L,2L,2L,4L,3L,4L,2L,3L,2L,37L,2L,49L,6L,2L,6L,10L,2L,4L,8L,15L,2L,2L,23L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110020Inst : IEnumerable<long>
{
public static readonly long[] Value=A110020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110020.Bytes);
public long this[int i]=>Value[i];

public static A110020Inst Instance=new A110020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110021
{
public static readonly long[] Value={ 2L,2L,2L,3L,2L,4L,2L,3L,5L,2L,6L,4L,2L,3L,5L,5L,2L,6L,3L,2L,6L,3L,5L,8L,4L,2L,3L,2L,4L,14L,3L,5L,2L,9L,2L,6L,6L,3L,5L,5L,2L,10L,2L,4L,2L,2L,2L,3L,2L,4L,5L,2L,10L,5L,5L,5L,2L,6L,4L,2L,3L,13L,3L,2L,4L,4L,6L,3L,2L,4L,5L,7L,6L,6L,3L,5L,2L,4L,8L,9L,2L,10L,2L,6L,3L,5L,8L,4L,2L,3L,11L,7L,3L,2L,3L,5L,2L,2L,18L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110021Inst : IEnumerable<long>
{
public static readonly long[] Value=A110021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110021.Bytes);
public long this[int i]=>Value[i];

public static A110021Inst Instance=new A110021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110022
{
public static readonly long[] Value={ 1531L,6841L,15391L,44371L,57991L,83431L,105871L,145021L,150151L,199621L,209431L,212851L,231241L,242551L,291271L,319681L,346141L,377491L,381631L,451411L,481021L,506791L,507781L,512821L,537811L,588871L,680431L,727561L,749761L,782911L,787711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110022Inst : IEnumerable<long>
{
public static readonly long[] Value=A110022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110022.Bytes);
public long this[int i]=>Value[i];

public static A110022Inst Instance=new A110022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110023
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,2L,6L,6L,2L,3L,8L,24L,8L,3L,4L,15L,40L,40L,15L,4L,5L,24L,90L,80L,90L,24L,5L,7L,35L,168L,210L,210L,168L,35L,7L,9L,56L,280L,448L,630L,448L,280L,56L,9L,12L,81L,504L,840L,1512L,1512L,840L,504L,81L,12L,16L,120L,810L,1680L,3150L,4032L,3150L,1680L,810L,120L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110023Inst : IEnumerable<long>
{
public static readonly long[] Value=A110023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110023.Bytes);
public long this[int i]=>Value[i];

public static A110023Inst Instance=new A110023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110024
{
public static readonly long[] Value={ 2131L,2311L,6211L,7411L,10321L,18121L,22531L,23011L,24391L,29671L,31771L,35311L,41491L,46411L,54601L,56311L,60331L,61381L,67651L,78031L,85381L,96931L,99871L,109471L,126001L,134731L,156691L,162451L,165331L,170851L,185131L,205171L,224401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110024Inst : IEnumerable<long>
{
public static readonly long[] Value=A110024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110024.Bytes);
public long this[int i]=>Value[i];

public static A110024Inst Instance=new A110024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110025
{
public static readonly long[] Value={ 509L,1229L,1409L,2131L,2311L,2699L,3539L,6211L,6449L,7411L,10321L,10589L,11549L,11909L,12119L,17159L,18121L,19709L,19889L,22349L,22531L,23011L,24391L,26189L,27479L,29671L,30389L,31771L,35311L,41491L,43649L,46411L,54601L,55229L,56311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110025Inst : IEnumerable<long>
{
public static readonly long[] Value=A110025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110025.Bytes);
public long this[int i]=>Value[i];

public static A110025Inst Instance=new A110025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110026
{
public static readonly long[] Value={ 1L,1L,3L,5L,21L,45L,231L,585L,1155L,9945L,21945L,69615L,504735L,348075L,4542615L,10094175L,140821065L,111035925L,140821065L,4108329225L,1830673845L,168441498225L,78718975335L,168441498225L,3699791840745L,1179090487575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110026Inst : IEnumerable<long>
{
public static readonly long[] Value=A110026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110026.Bytes);
public long this[int i]=>Value[i];

public static A110026Inst Instance=new A110026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110027
{
public static readonly long[] Value={ 2L,1531L,6841L,15391L,44371L,53639L,53849L,57991L,61409L,66749L,83431L,105871L,143609L,145021L,150151L,167729L,186149L,199621L,206369L,209431L,212851L,231241L,242551L,268049L,291271L,296099L,319681L,340919L,346141L,377491L,381631L,422069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110027Inst : IEnumerable<long>
{
public static readonly long[] Value=A110027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110027.Bytes);
public long this[int i]=>Value[i];

public static A110027Inst Instance=new A110027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110028
{
public static readonly long[] Value={ 23L,223L,227L,337L,353L,373L,557L,577L,733L,757L,773L,22573L,23327L,25237L,25253L,25523L,27253L,27527L,32233L,32237L,32257L,32323L,32327L,33223L,33353L,33377L,33533L,33773L,35227L,35353L,35533L,35537L,35573L,35753L,37223L,37337L,52237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110028Inst : IEnumerable<long>
{
public static readonly long[] Value=A110028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110028.Bytes);
public long this[int i]=>Value[i];

public static A110028Inst Instance=new A110028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110029
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,13L,12L,14L,16L,17L,19L,19L,18L,21L,20L,21L,23L,25L,24L,29L,28L,27L,32L,31L,30L,32L,37L,35L,38L,37L,36L,39L,40L,41L,40L,43L,42L,45L,46L,45L,49L,49L,48L,51L,50L,53L,56L,55L,54L,56L,58L,60L,59L,61L,60L,65L,66L,63L,66L,67L,67L,68L,70L,71L,70L,73L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110029Inst : IEnumerable<long>
{
public static readonly long[] Value=A110029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110029.Bytes);
public long this[int i]=>Value[i];

public static A110029Inst Instance=new A110029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110030
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,2L,3L,3L,4L,3L,1L,3L,1L,1L,2L,3L,1L,5L,3L,1L,5L,3L,1L,2L,6L,3L,5L,3L,1L,3L,3L,3L,1L,3L,1L,3L,3L,1L,4L,3L,1L,3L,1L,3L,5L,3L,1L,2L,3L,4L,2L,3L,1L,5L,5L,1L,3L,3L,2L,2L,3L,3L,1L,3L,1L,3L,3L,3L,2L,3L,5L,3L,1L,1L,5L,3L,1L,2L,3L,3L,5L,3L,1L,4L,9L,4L,3L,3L,9L,2L,5L,3L,1L,3L,1L,2L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110030Inst : IEnumerable<long>
{
public static readonly long[] Value=A110030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110030.Bytes);
public long this[int i]=>Value[i];

public static A110030Inst Instance=new A110030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110031
{
public static readonly long[] Value={ 1L,11L,16L,25L,32L,92L,193L,328L,781L,871L,1051L,2958L,3265L,3280L,4288L,32189L,36229L,40653L,154725L,213651L,325499L,669970L,1168038L,1477938L,3043509L,3132258L,4443863L,14999713L,22060373L,25601153L,25653515L,50124438L,66532253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110031Inst : IEnumerable<long>
{
public static readonly long[] Value=A110031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110031.Bytes);
public long this[int i]=>Value[i];

public static A110031Inst Instance=new A110031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110032
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-3L,1L,0L,5L,-7L,1L,-4L,22L,23L,-13L,1L,-64L,20L,172L,29L,-19L,1L,-240L,-1120L,-496L,354L,111L,-29L,1L,2656L,1760L,-4952L,-1816L,1054L,239L,-41L,1L,15360L,24800L,-28640L,-29040L,2384L,3938L,203L,-49L,1L,88064L,587136L,601216L,-63776L,-191224L,-21360L,6658L,511L,-65L,1L,-1714176L,-4244224L,4907392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110032Inst : IEnumerable<long>
{
public static readonly long[] Value=A110032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110032.Bytes);
public long this[int i]=>Value[i];

public static A110032Inst Instance=new A110032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110033
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-3L,1L,0L,3L,-8L,1L,0L,0L,9L,-21L,1L,0L,0L,0L,24L,-55L,1L,0L,0L,0L,0L,64L,-144L,1L,0L,0L,0L,0L,0L,168L,-377L,1L,0L,0L,0L,0L,0L,0L,441L,-987L,1L,0L,0L,0L,0L,0L,0L,0L,1155L,-2584L,1L,0L,0L,0L,0L,0L,0L,0L,0L,3025L,-6765L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,7920L,-17711L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110033Inst : IEnumerable<long>
{
public static readonly long[] Value=A110033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110033.Bytes);
public long this[int i]=>Value[i];

public static A110033Inst Instance=new A110033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110034
{
public static readonly long[] Value={ 1L,0L,-1L,-4L,-11L,-30L,-79L,-208L,-545L,-1428L,-3739L,-9790L,-25631L,-67104L,-175681L,-459940L,-1204139L,-3152478L,-8253295L,-21607408L,-56568929L,-148099380L,-387729211L,-1015088254L,-2657535551L,-6957518400L,-18215019649L,-47687540548L,-124847601995L,-326855265438L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110034Inst : IEnumerable<long>
{
public static readonly long[] Value=A110034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110034.Bytes);
public long this[int i]=>Value[i];

public static A110034Inst Instance=new A110034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110035
{
public static readonly long[] Value={ 1L,2L,5L,12L,31L,80L,209L,546L,1429L,3740L,9791L,25632L,67105L,175682L,459941L,1204140L,3152479L,8253296L,21607409L,56568930L,148099381L,387729212L,1015088255L,2657535552L,6957518401L,18215019650L,47687540549L,124847601996L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110035Inst : IEnumerable<long>
{
public static readonly long[] Value=A110035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110035.Bytes);
public long this[int i]=>Value[i];

public static A110035Inst Instance=new A110035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110036
{
public static readonly long[] Value={ 1L,-1L,2L,0L,0L,-2L,0L,2L,0L,-2L,2L,0L,-2L,0L,0L,2L,0L,-2L,2L,0L,0L,-2L,0L,2L,-2L,0L,2L,0L,-2L,0L,0L,2L,0L,-2L,2L,0L,0L,-2L,0L,2L,0L,-2L,2L,0L,-2L,0L,0L,2L,-2L,0L,2L,0L,0L,-2L,0L,2L,-2L,0L,2L,0L,-2L,0L,0L,2L,0L,-2L,2L,0L,0L,-2L,0L,2L,0L,-2L,2L,0L,-2L,0L,0L,2L,0L,-2L,2L,0L,0L,-2L,0L,2L,-2L,0L,2L,0L,-2L,0L,0L,2L,-2L,0L,2L,0L,0L,-2L,0L,2L,0L,-2L,2L,0L,-2L,0L,0L,2L,-2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110036Inst : IEnumerable<long>
{
public static readonly long[] Value=A110036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110036.Bytes);
public long this[int i]=>Value[i];

public static A110036Inst Instance=new A110036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110037
{
public static readonly long[] Value={ 1L,1L,-1L,0L,0L,1L,0L,-1L,0L,1L,-1L,0L,1L,0L,0L,-1L,0L,1L,-1L,0L,0L,1L,0L,-1L,1L,0L,-1L,0L,1L,0L,0L,-1L,0L,1L,-1L,0L,0L,1L,0L,-1L,0L,1L,-1L,0L,1L,0L,0L,-1L,1L,0L,-1L,0L,0L,1L,0L,-1L,1L,0L,-1L,0L,1L,0L,0L,-1L,0L,1L,-1L,0L,0L,1L,0L,-1L,0L,1L,-1L,0L,1L,0L,0L,-1L,0L,1L,-1L,0L,0L,1L,0L,-1L,1L,0L,-1L,0L,1L,0L,0L,-1L,1L,0L,-1L,0L,0L,1L,0L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110037Inst : IEnumerable<long>
{
public static readonly long[] Value=A110037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110037.Bytes);
public long this[int i]=>Value[i];

public static A110037Inst Instance=new A110037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110038
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,52L,202L,869L,4075L,20645L,112124L,648649L,3976633L,25719630L,174839120L,1245131903L,9263053753L,71806323461L,578719497070L,4839515883625L,41916097982471L,375401824277096L,3471395994487422L,33099042344383885L,325005134436155395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110038Inst : IEnumerable<long>
{
public static readonly long[] Value=A110038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110038.Bytes);
public long this[int i]=>Value[i];

public static A110038Inst Instance=new A110038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110039
{
public static readonly BigInteger[] Value={ 1L,1L,8L,730L,188790L,102737670L,102172297920L,167870491048260L,423971126389110300L,BigInteger.Parse("1559445481095305703900"),BigInteger.Parse("8010574937878696134151200"),BigInteger.Parse("55572909620219147733302926200"),BigInteger.Parse("506607333530572584517841616582600"),BigInteger.Parse("5931728848766374810152582924943605000") };
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
public class A110039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110039Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110039.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110039Inst Instance=new A110039Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110040
{
public static readonly BigInteger[] Value={ 1L,0L,0L,1L,10L,112L,1760L,35150L,848932L,24243520L,805036704L,30649435140L,1322299270600L,64008728200384L,3447361661136640L,205070807479444088L,13388424264027157520UL,BigInteger.Parse("953966524932871436800"),BigInteger.Parse("73817914562041635228928") };
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
public class A110040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110040Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110040.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110040Inst Instance=new A110040Inst();

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