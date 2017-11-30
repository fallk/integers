using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A146064
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,1L,49L,91L,755L,1733L,17237L,43939L,2178205L,7075949L,921596877L,3869156215L,535678119399L,2790029976011L,707504525942961L,4543722915142743L,2950922408069540377L,BigInteger.Parse("23782316720866894839"),BigInteger.Parse("30573780517964151258947") };
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
public class A146064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146064Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A146064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146064.Bytes);
public BigInteger this[int i]=>Value[i];

public static A146064Inst Instance=new A146064Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146065
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,5L,5L,17L,17L,53L,53L,497L,497L,10289L,10289L,196357L,196357L,5677027L,5677027L,310742317L,310742317L,27512226687L,27512226687L,3369038880519L,3369038880519L,646981592661815L,646981592661815L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146065Inst : IEnumerable<long>
{
public static readonly long[] Value=A146065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146065.Bytes);
public long this[int i]=>Value[i];

public static A146065Inst Instance=new A146065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146066
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,3L,9L,19L,69L,389L,2287L,15081L,141721L,1694175L,23795099L,418616469L,9434924199L,264113682081L,9153093458787L,397472720900369L,21616544571284115L,1466493314737915869L,BigInteger.Parse("124160358455186794957") };
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
public class A146066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146066Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A146066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146066.Bytes);
public BigInteger this[int i]=>Value[i];

public static A146066Inst Instance=new A146066Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146067
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,5L,9L,17L,41L,117L,275L,1237L,4103L,20885L,85925L,519635L,2644535L,20312399L,128516271L,1266040749L,10025925703L,122157386121L,1211481473503L,18256047371395L,225812595799851L,4272679708033791L,65914771408101775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146067Inst : IEnumerable<long>
{
public static readonly long[] Value=A146067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146067.Bytes);
public long this[int i]=>Value[i];

public static A146067Inst Instance=new A146067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146068
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,3L,9L,9L,19L,19L,69L,69L,389L,389L,2287L,2287L,15081L,15081L,141721L,141721L,1694175L,1694175L,23795099L,23795099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146068Inst : IEnumerable<long>
{
public static readonly long[] Value=A146068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146068.Bytes);
public long this[int i]=>Value[i];

public static A146068Inst Instance=new A146068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146069
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,9L,21L,35L,101L,287L,859L,3329L,15189L,75035L,399377L,2204921L,14787995L,102936591L,860535039L,7743744003L,81593423043L,911784626279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146069Inst : IEnumerable<long>
{
public static readonly long[] Value=A146069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146069.Bytes);
public long this[int i]=>Value[i];

public static A146069Inst Instance=new A146069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146070
{
public static readonly long[] Value={ 1L,1L,5L,1L,9L,25L,101L,401L,3215L,13761L,224503L,1483715L,30996399L,381934429L,12283193557L,226607791453L,11864500856825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146070Inst : IEnumerable<long>
{
public static readonly long[] Value=A146070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146070.Bytes);
public long this[int i]=>Value[i];

public static A146070Inst Instance=new A146070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146071
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,5L,5L,7L,2L,3L,11L,11L,3L,7L,7L,11L,3L,17L,11L,3L,19L,7L,23L,11L,17L,23L,29L,11L,29L,7L,11L,37L,23L,17L,31L,23L,43L,23L,43L,23L,3L,37L,29L,17L,23L,47L,17L,47L,43L,43L,37L,23L,29L,53L,59L,37L,67L,43L,23L,43L,17L,41L,23L,71L,59L,71L,47L,59L,7L,71L,83L,23L,23L,41L,67L,17L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146071Inst : IEnumerable<long>
{
public static readonly long[] Value=A146071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146071.Bytes);
public long this[int i]=>Value[i];

public static A146071Inst Instance=new A146071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146072
{
public static readonly long[] Value={ 3L,28L,2L,32L,2L,13L,18L,9L,18L,4L,2L,6L,17L,17L,5L,18L,8L,9L,3L,16L,20L,2L,10L,5L,12L,11L,3L,50L,13L,6L,2L,2L,2L,2L,10L,20L,12L,6L,25L,3L,9L,16L,11L,29L,13L,3L,38L,6L,7L,3L,60L,19L,6L,10L,5L,4L,5L,12L,7L,10L,11L,3L,5L,6L,5L,10L,3L,16L,10L,5L,48L,11L,3L,4L,14L,21L,13L,12L,4L,3L,16L,6L,11L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146072Inst : IEnumerable<long>
{
public static readonly long[] Value=A146072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146072.Bytes);
public long this[int i]=>Value[i];

public static A146072Inst Instance=new A146072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146073
{
public static readonly long[] Value={ 244823040L,21504L,7680L,1080L,504L,384L,128L,96L,60L,24L,24L,42L,42L,16L,20L,11L,12L,12L,14L,14L,15L,15L,21L,21L,23L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146073Inst : IEnumerable<long>
{
public static readonly long[] Value=A146073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146073.Bytes);
public long this[int i]=>Value[i];

public static A146073Inst Instance=new A146073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146074
{
public static readonly long[] Value={ 1L,43263L,712448L,5100480L,4080384L,20401920L,11658240L,15301440L,0L,12241152L,22256640L,40803840L,0L,34974720L,32643072L,0L,0L,0L,0L,0L,23316480L,0L,21288960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146074Inst : IEnumerable<long>
{
public static readonly long[] Value=A146074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146074.Bytes);
public long this[int i]=>Value[i];

public static A146074Inst Instance=new A146074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146075
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,410L,1312L,3034L,7585L,16605L,33210L,60024L,97539L,146370L,195160L,232060L,255266L,255266L,232060L,195160L,146370L,97539L,60024L,33210L,16605L,7585L,3034L,1312L,410L,0L,0L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146075Inst : IEnumerable<long>
{
public static readonly long[] Value=A146075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146075.Bytes);
public long this[int i]=>Value[i];

public static A146075Inst Instance=new A146075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146076
{
public static readonly long[] Value={ 0L,2L,0L,6L,0L,8L,0L,14L,0L,12L,0L,24L,0L,16L,0L,30L,0L,26L,0L,36L,0L,24L,0L,56L,0L,28L,0L,48L,0L,48L,0L,62L,0L,36L,0L,78L,0L,40L,0L,84L,0L,64L,0L,72L,0L,48L,0L,120L,0L,62L,0L,84L,0L,80L,0L,112L,0L,60L,0L,144L,0L,64L,0L,126L,0L,96L,0L,108L,0L,96L,0L,182L,0L,76L,0L,120L,0L,112L,0L,180L,0L,84L,0L,192L,0L,88L,0L,168L,0L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146076Inst : IEnumerable<long>
{
public static readonly long[] Value=A146076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146076.Bytes);
public long this[int i]=>Value[i];

public static A146076Inst Instance=new A146076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146077
{
public static readonly long[] Value={ 28L,35L,45L,55L,70L,77L,95L,105L,112L,115L,119L,143L,153L,154L,155L,161L,165L,175L,186L,187L,196L,203L,209L,215L,221L,225L,231L,235L,238L,247L,253L,275L,276L,280L,285L,287L,295L,299L,319L,322L,323L,325L,329L,335L,341L,345L,355L,364L,371L,377L,385L,391L,395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146077Inst : IEnumerable<long>
{
public static readonly long[] Value=A146077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146077.Bytes);
public long this[int i]=>Value[i];

public static A146077Inst Instance=new A146077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146078
{
public static readonly long[] Value={ 1L,1L,-8L,-17L,55L,208L,-287L,-2159L,424L,19855L,16039L,-162656L,-307007L,1156897L,3919960L,-6492113L,-41771753L,16657264L,392603041L,242687665L,-3290739704L,-5474928689L,24141728647L,73416086848L,-143859470975L,-804604252607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146078Inst : IEnumerable<long>
{
public static readonly long[] Value=A146078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146078.Bytes);
public long this[int i]=>Value[i];

public static A146078Inst Instance=new A146078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146079
{
public static readonly long[] Value={ 2L,4L,8L,5L,4L,5L,8L,4L,2L,2L,4L,8L,5L,4L,5L,8L,4L,2L,2L,4L,8L,5L,4L,5L,8L,4L,2L,2L,4L,8L,5L,4L,5L,8L,4L,2L,2L,4L,8L,5L,4L,5L,8L,4L,2L,2L,4L,8L,5L,4L,5L,8L,4L,2L,2L,4L,8L,5L,4L,5L,8L,4L,2L,2L,4L,8L,5L,4L,5L,8L,4L,2L,2L,4L,8L,5L,4L,5L,8L,4L,2L,2L,4L,8L,5L,4L,5L,8L,4L,2L,2L,4L,8L,5L,4L,5L,8L,4L,2L,2L,4L,8L,5L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146079Inst : IEnumerable<long>
{
public static readonly long[] Value=A146079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146079.Bytes);
public long this[int i]=>Value[i];

public static A146079Inst Instance=new A146079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146080
{
public static readonly long[] Value={ 1L,1L,-9L,-19L,71L,261L,-449L,-3059L,1431L,32021L,17711L,-302499L,-479609L,2545381L,7341471L,-18112339L,-91527049L,89596341L,1004866831L,108903421L,-9939764889L,-11028799099L,88368849791L,198656840781L,-685031657129L,-2671600064939L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146080Inst : IEnumerable<long>
{
public static readonly long[] Value=A146080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146080.Bytes);
public long this[int i]=>Value[i];

public static A146080Inst Instance=new A146080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146081
{
public static readonly long[] Value={ 110L,184L,258L,332L,406L,480L,554L,628L,702L,776L,850L,924L,998L,1072L,1146L,1220L,1294L,1368L,1442L,1516L,1590L,1664L,1738L,1812L,1886L,1960L,2034L,2108L,2182L,2256L,2330L,2404L,2478L,2552L,2626L,2700L,2774L,2848L,2922L,2996L,3070L,3144L,3218L,3292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146081Inst : IEnumerable<long>
{
public static readonly long[] Value=A146081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146081.Bytes);
public long this[int i]=>Value[i];

public static A146081Inst Instance=new A146081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146082
{
public static readonly long[] Value={ 2L,4L,6L,8L,1L,3L,5L,7L,0L,2L,4L,6L,8L,1L,3L,5L,7L,0L,2L,4L,6L,8L,1L,3L,5L,7L,0L,2L,4L,6L,8L,1L,3L,5L,7L,0L,2L,4L,6L,8L,1L,3L,5L,7L,0L,2L,4L,6L,8L,1L,3L,5L,7L,0L,2L,4L,6L,8L,1L,3L,5L,7L,0L,2L,4L,6L,8L,1L,3L,5L,7L,0L,2L,4L,6L,8L,1L,3L,5L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146082Inst : IEnumerable<long>
{
public static readonly long[] Value=A146082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146082.Bytes);
public long this[int i]=>Value[i];

public static A146082Inst Instance=new A146082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146083
{
public static readonly long[] Value={ 1L,1L,-10L,-21L,89L,320L,-659L,-4179L,3070L,49039L,15269L,-524160L,-692119L,5073641L,12686950L,-43123101L,-182679551L,291674560L,2301149621L,-907270539L,-26219916370L,-16239940441L,272179139629L,450818484480L,-2543152051439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146083Inst : IEnumerable<long>
{
public static readonly long[] Value=A146083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146083.Bytes);
public long this[int i]=>Value[i];

public static A146083Inst Instance=new A146083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146084
{
public static readonly long[] Value={ 1L,1L,-11L,-23L,109L,385L,-923L,-5543L,5533L,72049L,5653L,-858935L,-926771L,9380449L,20501701L,-92063687L,-338084099L,766680145L,4823689333L,-4376472407L,-62260744403L,-9743075519L,737385857317L,854302763545L,-7994327524259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146084Inst : IEnumerable<long>
{
public static readonly long[] Value=A146084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146084.Bytes);
public long this[int i]=>Value[i];

public static A146084Inst Instance=new A146084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146085
{
public static readonly long[] Value={ 1L,4L,7L,28L,31L,34L,55L,58L,61L,244L,247L,250L,271L,274L,277L,298L,301L,304L,487L,490L,493L,514L,517L,520L,541L,544L,547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146085Inst : IEnumerable<long>
{
public static readonly long[] Value=A146085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146085.Bytes);
public long this[int i]=>Value[i];

public static A146085Inst Instance=new A146085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146086
{
public static readonly long[] Value={ 3L,11L,45L,197L,903L,4271L,20625L,100937L,498123L,2470931L,12295605L,61300877L,305972943L,1528270391L,7636568985L,38168496017L,190799433363L,953868026651L,4768952712765L,23843601302357L,119214519727383L,596062138283711L,2980279310358945L,14901302408615897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146086Inst : IEnumerable<long>
{
public static readonly long[] Value=A146086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146086.Bytes);
public long this[int i]=>Value[i];

public static A146086Inst Instance=new A146086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146087
{
public static readonly long[] Value={ 2L,11L,20L,83L,92L,101L,164L,173L,182L,731L,740L,749L,812L,821L,830L,893L,902L,911L,1460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146087Inst : IEnumerable<long>
{
public static readonly long[] Value=A146087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146087.Bytes);
public long this[int i]=>Value[i];

public static A146087Inst Instance=new A146087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146088
{
public static readonly BigInteger[] Value={ 0L,105263157894736842L,157894736842105263L,210526315789473684L,263157894736842105L,315789473684210526L,368421052631578947L,421052631578947368L,473684210526315789L,BigInteger.Parse("105263157894736842105263157894736842"),BigInteger.Parse("157894736842105263157894736842105263") };
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
public class A146088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146088Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A146088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146088.Bytes);
public BigInteger this[int i]=>Value[i];

public static A146088Inst Instance=new A146088Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146089
{
public static readonly long[] Value={ 1L,32L,219L,698L,1657L,3336L,6023L,10054L,15813L,23732L,34291L,48018L,65489L,87328L,114207L,146846L,186013L,232524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146089Inst : IEnumerable<long>
{
public static readonly long[] Value=A146089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146089.Bytes);
public long this[int i]=>Value[i];

public static A146089Inst Instance=new A146089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146090
{
public static readonly long[] Value={ 1L,93L,538L,1532L,3630L,7540L,14138L,24480L,39802L,61520L,91230L,130708L,181910L,246972L,328210L,428120L,549378L,694840L,867542L,1070700L,1307710L,1582148L,1897770L,2258512L,2668490L,3132000L,3653518L,4237700L,4889382L,5613580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146090Inst : IEnumerable<long>
{
public static readonly long[] Value=A146090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146090.Bytes);
public long this[int i]=>Value[i];

public static A146090Inst Instance=new A146090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146091
{
public static readonly long[] Value={ 1L,10L,19L,82L,91L,100L,163L,172L,181L,730L,739L,748L,811L,820L,829L,892L,901L,910L,1459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146091Inst : IEnumerable<long>
{
public static readonly long[] Value=A146091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146091.Bytes);
public long this[int i]=>Value[i];

public static A146091Inst Instance=new A146091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146092
{
public static readonly long[] Value={ 1L,235L,1894L,5928L,14762L,31448L,59802L,104420L,170678L,264732L,393518L,564752L,786930L,1069328L,1422002L,1855788L,2382302L,3013940L,3763878L,4646072L,5675258L,6866952L,8237450L,9803828L,11583942L,13596428L,15860702L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146092Inst : IEnumerable<long>
{
public static readonly long[] Value=A146092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146092.Bytes);
public long this[int i]=>Value[i];

public static A146092Inst Instance=new A146092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146093
{
public static readonly long[] Value={ 1L,1L,2L,2L,0L,1L,2L,1L,0L,0L,1L,0L,1L,1L,1L,2L,2L,0L,1L,2L,1L,0L,0L,1L,0L,1L,1L,1L,2L,2L,0L,1L,2L,1L,0L,0L,1L,0L,1L,1L,1L,2L,2L,0L,1L,2L,1L,0L,0L,1L,0L,1L,1L,1L,2L,2L,0L,1L,2L,1L,0L,0L,1L,0L,1L,1L,1L,2L,2L,0L,1L,2L,1L,0L,0L,1L,0L,1L,1L,1L,2L,2L,0L,1L,2L,1L,0L,0L,1L,0L,1L,1L,1L,2L,2L,0L,1L,2L,1L,0L,0L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146093Inst : IEnumerable<long>
{
public static readonly long[] Value=A146093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146093.Bytes);
public long this[int i]=>Value[i];

public static A146093Inst Instance=new A146093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146094
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,0L,3L,1L,0L,3L,3L,2L,1L,1L,2L,1L,3L,0L,3L,1L,0L,3L,3L,2L,1L,1L,2L,1L,3L,0L,3L,1L,0L,3L,3L,2L,1L,1L,2L,1L,3L,0L,3L,1L,0L,3L,3L,2L,1L,1L,2L,1L,3L,0L,3L,1L,0L,3L,3L,2L,1L,1L,2L,1L,3L,0L,3L,1L,0L,3L,3L,2L,1L,1L,2L,1L,3L,0L,3L,1L,0L,3L,3L,2L,1L,1L,2L,1L,3L,0L,3L,1L,0L,3L,3L,2L,1L,1L,2L,1L,3L,0L,3L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146094Inst : IEnumerable<long>
{
public static readonly long[] Value=A146094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146094.Bytes);
public long this[int i]=>Value[i];

public static A146094Inst Instance=new A146094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146095
{
public static readonly long[] Value={ 1L,1L,2L,0L,0L,2L,3L,2L,0L,2L,0L,0L,2L,2L,2L,0L,2L,4L,4L,2L,2L,1L,3L,1L,4L,3L,4L,4L,0L,2L,2L,3L,4L,2L,4L,0L,2L,1L,1L,4L,2L,3L,2L,0L,1L,0L,0L,2L,1L,1L,0L,2L,3L,2L,1L,2L,0L,0L,3L,3L,2L,0L,3L,1L,0L,2L,3L,4L,1L,2L,0L,2L,0L,3L,2L,2L,2L,3L,0L,4L,4L,0L,3L,4L,3L,4L,3L,2L,2L,2L,2L,0L,4L,4L,4L,2L,4L,3L,3L,1L,1L,2L,1L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146095Inst : IEnumerable<long>
{
public static readonly long[] Value=A146095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146095.Bytes);
public long this[int i]=>Value[i];

public static A146095Inst Instance=new A146095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146096
{
public static readonly long[] Value={ 1L,1L,2L,5L,3L,4L,5L,1L,0L,3L,1L,0L,1L,1L,4L,5L,5L,0L,1L,5L,4L,3L,3L,4L,3L,1L,4L,1L,5L,2L,3L,1L,2L,1L,3L,0L,1L,3L,4L,1L,1L,2L,5L,3L,4L,5L,1L,0L,3L,1L,0L,1L,1L,4L,5L,5L,0L,1L,5L,4L,3L,3L,4L,3L,1L,4L,1L,5L,2L,3L,1L,2L,1L,3L,0L,1L,3L,4L,1L,1L,2L,5L,3L,4L,5L,1L,0L,3L,1L,0L,1L,1L,4L,5L,5L,0L,1L,5L,4L,3L,3L,4L,3L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146096Inst : IEnumerable<long>
{
public static readonly long[] Value=A146096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146096.Bytes);
public long this[int i]=>Value[i];

public static A146096Inst Instance=new A146096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146097
{
public static readonly long[] Value={ 1L,1L,2L,5L,1L,3L,0L,2L,3L,0L,6L,4L,3L,2L,5L,3L,6L,3L,0L,5L,0L,1L,2L,2L,3L,5L,5L,1L,3L,4L,5L,1L,3L,6L,4L,0L,2L,6L,4L,2L,3L,4L,2L,1L,3L,6L,5L,0L,6L,3L,4L,2L,4L,5L,6L,2L,0L,6L,6L,2L,4L,1L,2L,6L,5L,1L,6L,5L,3L,1L,4L,6L,0L,4L,1L,4L,5L,3L,6L,4L,5L,5L,2L,1L,2L,3L,2L,3L,0L,3L,3L,5L,5L,5L,3L,3L,6L,1L,3L,3L,1L,6L,2L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146097Inst : IEnumerable<long>
{
public static readonly long[] Value=A146097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146097.Bytes);
public long this[int i]=>Value[i];

public static A146097Inst Instance=new A146097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146098
{
public static readonly long[] Value={ 1L,1L,2L,5L,7L,4L,3L,5L,4L,3L,7L,2L,5L,5L,2L,1L,3L,4L,7L,1L,4L,7L,3L,2L,1L,1L,2L,5L,7L,4L,3L,5L,4L,3L,7L,2L,5L,5L,2L,1L,3L,4L,7L,1L,4L,7L,3L,2L,1L,1L,2L,5L,7L,4L,3L,5L,4L,3L,7L,2L,5L,5L,2L,1L,3L,4L,7L,1L,4L,7L,3L,2L,1L,1L,2L,5L,7L,4L,3L,5L,4L,3L,7L,2L,5L,5L,2L,1L,3L,4L,7L,1L,4L,7L,3L,2L,1L,1L,2L,5L,7L,4L,3L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146098Inst : IEnumerable<long>
{
public static readonly long[] Value=A146098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146098.Bytes);
public long this[int i]=>Value[i];

public static A146098Inst Instance=new A146098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146099
{
public static readonly long[] Value={ 1L,1L,2L,5L,6L,7L,5L,4L,0L,6L,1L,6L,4L,1L,7L,5L,5L,0L,4L,5L,1L,6L,6L,1L,6L,4L,1L,1L,5L,2L,6L,4L,5L,4L,6L,3L,1L,6L,1L,1L,1L,2L,5L,6L,7L,5L,4L,0L,6L,1L,6L,4L,1L,7L,5L,5L,0L,4L,5L,1L,6L,6L,1L,6L,4L,1L,1L,5L,2L,6L,4L,5L,4L,6L,3L,1L,6L,1L,1L,1L,2L,5L,6L,7L,5L,4L,0L,6L,1L,6L,4L,1L,7L,5L,5L,0L,4L,5L,1L,6L,6L,1L,6L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146099Inst : IEnumerable<long>
{
public static readonly long[] Value=A146099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146099.Bytes);
public long this[int i]=>Value[i];

public static A146099Inst Instance=new A146099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146100
{
public static readonly long[] Value={ 1L,1L,2L,5L,5L,2L,3L,7L,0L,7L,5L,0L,7L,7L,2L,5L,7L,4L,9L,7L,2L,1L,3L,6L,9L,3L,4L,9L,5L,2L,7L,3L,4L,7L,9L,0L,7L,1L,6L,9L,7L,8L,7L,5L,6L,5L,5L,2L,1L,1L,0L,7L,3L,2L,1L,7L,0L,5L,3L,8L,7L,5L,8L,1L,5L,2L,3L,9L,6L,7L,5L,2L,5L,3L,2L,7L,7L,8L,5L,9L,4L,5L,3L,4L,3L,9L,8L,7L,7L,2L,7L,5L,4L,9L,9L,2L,9L,3L,8L,1L,1L,2L,1L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146100Inst : IEnumerable<long>
{
public static readonly long[] Value=A146100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146100.Bytes);
public long this[int i]=>Value[i];

public static A146100Inst Instance=new A146100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146101
{
public static readonly long[] Value={ 1L,1L,2L,5L,4L,8L,5L,8L,4L,5L,2L,2L,3L,7L,9L,1L,2L,2L,1L,9L,7L,4L,5L,10L,5L,10L,3L,4L,3L,10L,5L,0L,9L,4L,4L,4L,2L,7L,7L,2L,4L,5L,9L,2L,8L,8L,6L,9L,3L,9L,6L,9L,3L,0L,10L,5L,3L,4L,1L,1L,4L,4L,1L,3L,10L,4L,8L,7L,5L,2L,5L,8L,5L,4L,2L,3L,1L,4L,1L,7L,7L,2L,2L,9L,6L,5L,4L,5L,5L,8L,3L,9L,4L,0L,4L,0L,9L,9L,10L,2L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146101Inst : IEnumerable<long>
{
public static readonly long[] Value=A146101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146101.Bytes);
public long this[int i]=>Value[i];

public static A146101Inst Instance=new A146101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146102
{
public static readonly long[] Value={ 1L,1L,2L,5L,3L,4L,11L,1L,0L,3L,7L,6L,1L,1L,10L,5L,11L,0L,7L,5L,4L,3L,3L,10L,9L,1L,10L,1L,11L,8L,3L,1L,8L,7L,3L,6L,1L,9L,10L,1L,7L,8L,11L,9L,4L,11L,7L,6L,9L,1L,6L,1L,7L,4L,11L,5L,0L,7L,11L,10L,9L,9L,10L,9L,7L,4L,7L,5L,8L,3L,7L,2L,1L,9L,6L,1L,3L,4L,7L,1L,8L,11L,3L,10L,5L,1L,6L,9L,7L,0L,7L,1L,4L,11L,11L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146102Inst : IEnumerable<long>
{
public static readonly long[] Value=A146102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146102.Bytes);
public long this[int i]=>Value[i];

public static A146102Inst Instance=new A146102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146103
{
public static readonly long[] Value={ 1L,1L,2L,5L,2L,0L,8L,6L,6L,9L,2L,9L,11L,2L,3L,7L,7L,2L,8L,1L,12L,2L,11L,11L,7L,0L,5L,10L,1L,9L,10L,9L,0L,1L,0L,9L,5L,7L,5L,2L,11L,10L,6L,6L,9L,1L,1L,9L,1L,12L,12L,7L,0L,8L,3L,12L,2L,10L,2L,10L,10L,0L,11L,6L,7L,8L,11L,2L,1L,12L,12L,12L,7L,10L,11L,4L,0L,2L,6L,0L,3L,0L,11L,11L,6L,4L,8L,2L,4L,2L,8L,6L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146103Inst : IEnumerable<long>
{
public static readonly long[] Value=A146103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146103.Bytes);
public long this[int i]=>Value[i];

public static A146103Inst Instance=new A146103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146104
{
public static readonly long[] Value={ 1L,1L,2L,5L,1L,10L,7L,9L,10L,7L,13L,4L,3L,9L,12L,3L,13L,10L,7L,5L,0L,1L,9L,2L,3L,5L,12L,1L,3L,4L,5L,1L,10L,13L,11L,0L,9L,13L,4L,9L,3L,4L,9L,1L,10L,13L,5L,0L,13L,3L,4L,9L,11L,12L,13L,9L,0L,13L,13L,2L,11L,1L,2L,13L,5L,8L,13L,5L,10L,1L,11L,6L,7L,11L,8L,11L,5L,10L,13L,11L,12L,5L,9L,8L,9L,3L,2L,3L,7L,10L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146104Inst : IEnumerable<long>
{
public static readonly long[] Value=A146104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146104.Bytes);
public long this[int i]=>Value[i];

public static A146104Inst Instance=new A146104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146105
{
public static readonly long[] Value={ 1L,1L,2L,5L,0L,7L,8L,7L,0L,12L,10L,0L,7L,7L,7L,5L,2L,9L,4L,2L,7L,6L,3L,1L,9L,13L,4L,4L,5L,2L,12L,13L,14L,7L,9L,0L,7L,6L,1L,4L,7L,8L,2L,0L,1L,5L,10L,12L,6L,1L,0L,7L,13L,7L,11L,2L,0L,10L,8L,13L,12L,0L,13L,6L,10L,7L,13L,14L,11L,12L,10L,2L,10L,3L,12L,7L,12L,13L,10L,4L,14L,5L,3L,4L,8L,4L,3L,12L,7L,12L,7L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146105Inst : IEnumerable<long>
{
public static readonly long[] Value=A146105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146105.Bytes);
public long this[int i]=>Value[i];

public static A146105Inst Instance=new A146105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146106
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,4L,11L,13L,12L,11L,7L,10L,13L,5L,10L,1L,3L,12L,15L,1L,12L,15L,11L,10L,9L,9L,2L,13L,7L,4L,3L,5L,12L,3L,15L,10L,5L,13L,10L,9L,11L,12L,7L,9L,12L,7L,3L,10L,1L,1L,2L,5L,15L,4L,11L,13L,12L,11L,7L,10L,13L,5L,10L,1L,3L,12L,15L,1L,12L,15L,11L,10L,9L,9L,2L,13L,7L,4L,3L,5L,12L,3L,15L,10L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146106Inst : IEnumerable<long>
{
public static readonly long[] Value=A146106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146106.Bytes);
public long this[int i]=>Value[i];

public static A146106Inst Instance=new A146106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146107
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,1L,16L,10L,9L,16L,1L,15L,11L,6L,15L,11L,14L,2L,3L,7L,3L,16L,0L,9L,2L,8L,0L,16L,9L,0L,4L,9L,8L,16L,5L,10L,10L,2L,16L,9L,11L,10L,8L,16L,8L,9L,4L,13L,0L,7L,4L,15L,3L,12L,1L,8L,3L,4L,1L,7L,7L,0L,13L,0L,13L,7L,11L,2L,1L,15L,13L,9L,11L,7L,5L,8L,14L,7L,13L,13L,13L,3L,1L,13L,3L,16L,11L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146107Inst : IEnumerable<long>
{
public static readonly long[] Value=A146107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146107.Bytes);
public long this[int i]=>Value[i];

public static A146107Inst Instance=new A146107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146108
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,16L,5L,13L,0L,15L,1L,6L,13L,1L,16L,5L,5L,0L,13L,5L,10L,15L,15L,10L,15L,13L,10L,1L,5L,2L,15L,13L,14L,13L,15L,12L,1L,15L,10L,1L,1L,2L,5L,15L,16L,5L,13L,0L,15L,1L,6L,13L,1L,16L,5L,5L,0L,13L,5L,10L,15L,15L,10L,15L,13L,10L,1L,5L,2L,15L,13L,14L,13L,15L,12L,1L,15L,10L,1L,1L,2L,5L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146108Inst : IEnumerable<long>
{
public static readonly long[] Value=A146108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146108.Bytes);
public long this[int i]=>Value[i];

public static A146108Inst Instance=new A146108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146109
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,14L,13L,3L,17L,0L,18L,4L,5L,7L,14L,16L,15L,1L,10L,2L,3L,7L,1L,10L,8L,16L,1L,17L,18L,3L,9L,12L,2L,11L,12L,16L,11L,12L,5L,10L,8L,11L,18L,5L,17L,18L,16L,2L,12L,2L,14L,13L,4L,9L,8L,4L,17L,15L,18L,0L,10L,4L,3L,16L,15L,18L,14L,14L,16L,8L,17L,13L,17L,12L,2L,13L,14L,18L,10L,14L,7L,0L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146109Inst : IEnumerable<long>
{
public static readonly long[] Value=A146109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146109.Bytes);
public long this[int i]=>Value[i];

public static A146109Inst Instance=new A146109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146110
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,12L,3L,17L,0L,7L,15L,10L,17L,17L,2L,5L,7L,4L,19L,17L,12L,11L,3L,6L,9L,13L,14L,9L,15L,12L,7L,13L,4L,7L,19L,10L,17L,1L,6L,9L,7L,8L,7L,5L,16L,15L,15L,2L,1L,1L,10L,17L,3L,12L,11L,17L,0L,15L,3L,18L,17L,5L,18L,1L,15L,12L,3L,9L,16L,7L,15L,2L,5L,13L,2L,17L,7L,8L,15L,9L,4L,15L,3L,14L,13L,9L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146110Inst : IEnumerable<long>
{
public static readonly long[] Value=A146110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146110.Bytes);
public long this[int i]=>Value[i];

public static A146110Inst Instance=new A146110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146111
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,10L,14L,16L,3L,0L,13L,18L,10L,16L,19L,17L,20L,3L,7L,5L,7L,15L,9L,16L,3L,19L,19L,1L,17L,11L,12L,1L,17L,13L,18L,0L,16L,6L,4L,16L,10L,11L,2L,15L,10L,20L,19L,0L,6L,10L,18L,16L,4L,19L,20L,2L,0L,13L,20L,16L,18L,15L,16L,6L,19L,1L,13L,5L,17L,15L,4L,20L,7L,18L,15L,4L,12L,10L,13L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146111Inst : IEnumerable<long>
{
public static readonly long[] Value=A146111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146111.Bytes);
public long this[int i]=>Value[i];

public static A146111Inst Instance=new A146111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146112
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,8L,5L,19L,4L,5L,13L,2L,3L,7L,20L,1L,13L,2L,1L,9L,18L,15L,5L,10L,5L,21L,14L,15L,3L,10L,5L,11L,20L,15L,15L,4L,13L,7L,18L,13L,15L,16L,9L,13L,8L,19L,17L,20L,3L,9L,6L,9L,3L,0L,21L,5L,14L,15L,1L,12L,15L,15L,12L,3L,21L,4L,19L,7L,16L,13L,5L,8L,5L,15L,2L,3L,1L,4L,1L,7L,18L,13L,13L,20L,17L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146112Inst : IEnumerable<long>
{
public static readonly long[] Value=A146112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146112.Bytes);
public long this[int i]=>Value[i];

public static A146112Inst Instance=new A146112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146113
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,6L,19L,3L,0L,10L,9L,1L,20L,1L,12L,9L,5L,6L,6L,9L,4L,16L,22L,2L,3L,7L,20L,21L,2L,22L,3L,10L,19L,10L,21L,21L,13L,21L,14L,11L,12L,15L,13L,20L,15L,1L,5L,10L,4L,18L,0L,1L,2L,13L,6L,6L,8L,19L,11L,11L,12L,2L,0L,4L,5L,10L,12L,16L,6L,15L,14L,22L,18L,1L,3L,15L,19L,12L,14L,4L,7L,22L,0L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146113Inst : IEnumerable<long>
{
public static readonly long[] Value=A146113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146113.Bytes);
public long this[int i]=>Value[i];

public static A146113Inst Instance=new A146113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146114
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,4L,11L,13L,12L,3L,7L,18L,13L,13L,10L,17L,11L,12L,7L,17L,4L,15L,3L,10L,9L,1L,10L,13L,23L,20L,3L,13L,20L,19L,15L,18L,13L,21L,10L,1L,19L,20L,23L,9L,4L,23L,19L,18L,9L,1L,18L,13L,7L,4L,11L,5L,12L,19L,23L,10L,21L,21L,10L,9L,19L,4L,7L,17L,20L,15L,19L,2L,1L,9L,18L,13L,15L,4L,19L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146114Inst : IEnumerable<long>
{
public static readonly long[] Value=A146114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146114.Bytes);
public long this[int i]=>Value[i];

public static A146114Inst Instance=new A146114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146115
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,2L,3L,2L,15L,22L,0L,20L,22L,12L,22L,20L,22L,4L,9L,7L,22L,1L,23L,21L,14L,3L,24L,14L,5L,22L,22L,3L,19L,22L,24L,20L,17L,16L,21L,9L,17L,13L,17L,10L,1L,15L,5L,7L,11L,6L,20L,2L,13L,7L,11L,12L,0L,20L,13L,18L,12L,20L,13L,11L,20L,22L,13L,9L,11L,7L,20L,12L,20L,8L,2L,22L,7L,23L,20L,4L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146115Inst : IEnumerable<long>
{
public static readonly long[] Value=A146115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146115.Bytes);
public long this[int i]=>Value[i];

public static A146115Inst Instance=new A146115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146116
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,0L,21L,19L,6L,9L,15L,22L,11L,15L,16L,7L,7L,2L,21L,1L,12L,15L,11L,24L,7L,13L,18L,23L,1L,22L,23L,9L,0L,1L,13L,22L,5L,7L,18L,15L,11L,10L,19L,19L,22L,1L,1L,22L,1L,25L,12L,7L,13L,8L,3L,25L,2L,23L,15L,10L,23L,13L,24L,19L,7L,8L,11L,15L,14L,25L,25L,12L,7L,23L,24L,17L,13L,2L,19L,13L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146116Inst : IEnumerable<long>
{
public static readonly long[] Value=A146116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146116.Bytes);
public long this[int i]=>Value[i];

public static A146116Inst Instance=new A146116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146117
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,25L,14L,13L,9L,6L,10L,6L,4L,1L,7L,23L,23L,0L,22L,5L,1L,15L,6L,1L,15L,13L,19L,10L,23L,2L,24L,13L,5L,4L,6L,21L,10L,24L,10L,19L,10L,20L,14L,24L,7L,23L,22L,0L,6L,1L,6L,22L,19L,7L,5L,23L,18L,13L,14L,1L,15L,24L,19L,15L,22L,10L,1L,23L,20L,24L,13L,14L,22L,15L,3L,1L,24L,10L,10L,19L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146117Inst : IEnumerable<long>
{
public static readonly long[] Value=A146117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146117.Bytes);
public long this[int i]=>Value[i];

public static A146117Inst Instance=new A146117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146118
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,24L,7L,9L,24L,7L,27L,18L,17L,9L,26L,17L,27L,24L,7L,5L,0L,15L,23L,2L,17L,5L,26L,1L,3L,4L,19L,1L,24L,27L,11L,14L,9L,13L,18L,9L,3L,4L,23L,1L,24L,27L,19L,14L,13L,17L,18L,9L,11L,12L,27L,9L,0L,27L,27L,2L,25L,1L,2L,13L,19L,8L,27L,5L,24L,15L,11L,6L,21L,25L,22L,25L,19L,24L,27L,25L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146118Inst : IEnumerable<long>
{
public static readonly long[] Value=A146118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146118.Bytes);
public long this[int i]=>Value[i];

public static A146118Inst Instance=new A146118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146119
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,23L,0L,7L,22L,6L,4L,28L,13L,13L,7L,20L,28L,17L,16L,20L,20L,15L,5L,25L,7L,24L,11L,21L,18L,2L,3L,7L,20L,9L,23L,7L,0L,28L,10L,3L,12L,26L,20L,27L,19L,16L,4L,7L,11L,6L,20L,1L,3L,2L,6L,3L,10L,20L,5L,10L,27L,0L,3L,1L,7L,28L,9L,13L,15L,9L,17L,18L,17L,6L,20L,11L,18L,17L,26L,21L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146119Inst : IEnumerable<long>
{
public static readonly long[] Value=A146119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146119.Bytes);
public long this[int i]=>Value[i];

public static A146119Inst Instance=new A146119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146120
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,22L,23L,7L,0L,27L,25L,0L,7L,7L,22L,5L,17L,24L,19L,17L,22L,21L,3L,16L,9L,13L,4L,19L,5L,2L,27L,13L,14L,7L,9L,0L,7L,21L,16L,19L,7L,8L,17L,15L,16L,5L,25L,12L,21L,1L,0L,7L,13L,22L,11L,17L,0L,25L,23L,28L,27L,15L,28L,21L,25L,22L,13L,29L,26L,27L,25L,2L,25L,3L,12L,7L,27L,28L,25L,19L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146120Inst : IEnumerable<long>
{
public static readonly long[] Value=A146120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146120.Bytes);
public long this[int i]=>Value[i];

public static A146120Inst Instance=new A146120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146121
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,21L,17L,9L,17L,5L,4L,11L,15L,1L,20L,30L,16L,8L,1L,21L,3L,25L,26L,19L,16L,2L,15L,16L,17L,12L,3L,2L,3L,7L,20L,5L,7L,26L,26L,22L,9L,15L,26L,16L,21L,19L,15L,24L,9L,22L,24L,28L,20L,14L,4L,18L,17L,0L,2L,29L,15L,5L,5L,10L,27L,25L,12L,2L,21L,17L,0L,24L,10L,11L,6L,9L,3L,8L,2L,0L,15L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146121Inst : IEnumerable<long>
{
public static readonly long[] Value=A146121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146121.Bytes);
public long this[int i]=>Value[i];

public static A146121Inst Instance=new A146121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146122
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,20L,11L,13L,12L,27L,7L,10L,29L,21L,26L,17L,3L,12L,15L,1L,12L,15L,27L,26L,9L,25L,18L,13L,7L,4L,3L,5L,12L,19L,31L,10L,5L,13L,10L,25L,27L,28L,7L,25L,12L,7L,19L,26L,17L,17L,2L,21L,31L,20L,27L,29L,12L,11L,23L,10L,13L,5L,26L,1L,19L,12L,31L,17L,12L,31L,11L,26L,25L,9L,18L,29L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146122Inst : IEnumerable<long>
{
public static readonly long[] Value=A146122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146122.Bytes);
public long this[int i]=>Value[i];

public static A146122Inst Instance=new A146122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146123
{
public static readonly long[] Value={ 1L,540L,4120L,12188L,31000L,67216L,129464L,228136L,375388L,585140L,873076L,1256644L,1755056L,2389288L,3182080L,4157936L,5343124L,6765676L,8455388L,10443820L,12764296L,15451904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146123Inst : IEnumerable<long>
{
public static readonly long[] Value=A146123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146123.Bytes);
public long this[int i]=>Value[i];

public static A146123Inst Instance=new A146123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146124
{
public static readonly long[] Value={ 0L,32L,516L,2307L,6472L,14379L,27684L,48331L,78552L,120867L,178084L,253299L,349896L,471547L,622212L,806139L,1027864L,1292211L,1604292L,1969507L,2393544L,2882379L,3442276L,4079787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146124Inst : IEnumerable<long>
{
public static readonly long[] Value=A146124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146124.Bytes);
public long this[int i]=>Value[i];

public static A146124Inst Instance=new A146124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146125
{
public static readonly long[] Value={ 0L,93L,2046L,8675L,24622L,56389L,112078L,201457L,335974L,528757L,794614L,1150033L,1613182L,2203909L,2943742L,3855889L,4965238L,6298357L,7883494L,9750577L,11931214L,14458693L,17367982L,20695729L,24480262L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146125Inst : IEnumerable<long>
{
public static readonly long[] Value=A146125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146125.Bytes);
public long this[int i]=>Value[i];

public static A146125Inst Instance=new A146125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146126
{
public static readonly long[] Value={ 0L,235L,9716L,43201L,125064L,290427L,583948L,1060251L,1783944L,2829619L,4281852L,6235203L,8794216L,12073419L,16197324L,21300427L,27527208L,35032131L,43979644L,54544179L,66910152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146126Inst : IEnumerable<long>
{
public static readonly long[] Value=A146126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146126.Bytes);
public long this[int i]=>Value[i];

public static A146126Inst Instance=new A146126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146127
{
public static readonly long[] Value={ 1L,1L,1L,29L,249L,3031L,82773L,3652185L,277821789L,35279858253L,7589314375275L,2802616385484099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146127Inst : IEnumerable<long>
{
public static readonly long[] Value=A146127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146127.Bytes);
public long this[int i]=>Value[i];

public static A146127Inst Instance=new A146127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146128
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,9L,13L,45L,103L,3361L,8833L,372663L,1287127L,106100985L,471171193L,109709730093L,638573372655L,304442910936313L,2309148561615411L,2461266528050264151L,BigInteger.Parse("24325578567487185537"),BigInteger.Parse("57639766702959393452219") };
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
public class A146128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146128Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A146128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146128.Bytes);
public BigInteger this[int i]=>Value[i];

public static A146128Inst Instance=new A146128Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146129
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,29L,29L,249L,249L,3031L,3031L,82773L,82773L,3652185L,3652185L,277821789L,277821789L,35279858253L,35279858253L,7589314375275L,7589314375275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146129Inst : IEnumerable<long>
{
public static readonly long[] Value=A146129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146129.Bytes);
public long this[int i]=>Value[i];

public static A146129Inst Instance=new A146129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146130
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,17L,59L,325L,2193L,20593L,247017L,3816169L,76385445L,1998729963L,68606304143L,3070344768595L,178823377788539L,13583194771026533L,1345184891829774733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146130Inst : IEnumerable<long>
{
public static readonly long[] Value=A146130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146130.Bytes);
public long this[int i]=>Value[i];

public static A146130Inst Instance=new A146130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146131
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,5L,9L,21L,39L,159L,427L,2501L,9027L,58503L,271185L,2371669L,14600987L,167228191L,1344019107L,19775648697L,206847230557L,3987249030381L,54541478154327L,1370106516904685L,24431476697291095L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146131Inst : IEnumerable<long>
{
public static readonly long[] Value=A146131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146131.Bytes);
public long this[int i]=>Value[i];

public static A146131Inst Instance=new A146131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146132
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,5L,5L,17L,17L,59L,59L,325L,325L,2193L,2193L,20593L,20593L,247017L,247017L,3816169L,3816169L,76385445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146132Inst : IEnumerable<long>
{
public static readonly long[] Value=A146132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146132.Bytes);
public long this[int i]=>Value[i];

public static A146132Inst Instance=new A146132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146133
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,17L,33L,85L,255L,1137L,4265L,27311L,122911L,972783L,6003645L,62308027L,499428829L,6712583897L,70003989585L,1225387976695L,16725199996985L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146133Inst : IEnumerable<long>
{
public static readonly long[] Value=A146133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146133.Bytes);
public long this[int i]=>Value[i];

public static A146133Inst Instance=new A146133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146134
{
public static readonly long[] Value={ 1L,1L,1L,5L,17L,39L,241L,1589L,13237L,156057L,2242755L,43222843L,1066074605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146134Inst : IEnumerable<long>
{
public static readonly long[] Value=A146134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146134.Bytes);
public long this[int i]=>Value[i];

public static A146134Inst Instance=new A146134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146135
{
public static readonly long[] Value={ 1L,5L,9L,13L,65L,69L,73L,77L,129L,133L,137L,141L,193L,197L,201L,205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146135Inst : IEnumerable<long>
{
public static readonly long[] Value=A146135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146135.Bytes);
public long this[int i]=>Value[i];

public static A146135Inst Instance=new A146135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146136
{
public static readonly long[] Value={ 1L,1L,9L,33L,153L,3123L,118071L,4682615L,398324801L,67438703311L,18607359075661L,8942742118054707L,7834339576388147577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146136Inst : IEnumerable<long>
{
public static readonly long[] Value=A146136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146136.Bytes);
public long this[int i]=>Value[i];

public static A146136Inst Instance=new A146136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146137
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,1L,149L,307L,3283L,9637L,237685L,792401L,149008323L,690862749L,219427051049L,1350088886833L,717485827831517L,5812692511149509L,9087725403509413361L,BigInteger.Parse("98388300257852844757"),BigInteger.Parse("382960435361198474272451") };
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
public class A146137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146137Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A146137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146137.Bytes);
public BigInteger this[int i]=>Value[i];

public static A146137Inst Instance=new A146137Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146138
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,9L,9L,33L,33L,153L,153L,3123L,3123L,118071L,118071L,4682615L,4682615L,398324801L,398324801L,67438703311L,67438703311L,18607359075661L,18607359075661L,8942742118054707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146138Inst : IEnumerable<long>
{
public static readonly long[] Value=A146138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146138.Bytes);
public long this[int i]=>Value[i];

public static A146138Inst Instance=new A146138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146139
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,7L,21L,61L,403L,3415L,36395L,473261L,8291363L,204964495L,6738662861L,291876652529L,16526293766701L,1250870357604441L,127503882340930419L,17331789387120484429UL,BigInteger.Parse("3122597067315836972733"),BigInteger.Parse("746394914944854757141353") };
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
public class A146139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146139Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A146139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146139.Bytes);
public BigInteger this[int i]=>Value[i];

public static A146139Inst Instance=new A146139Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146140
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,5L,13L,25L,57L,197L,913L,4565L,21033L,117411L,799889L,6782571L,62778947L,652383615L,7631737235L,109519353841L,1777185991253L,33840206146839L,713322877970345L,17898267949061373L,507994433535644661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146140Inst : IEnumerable<long>
{
public static readonly long[] Value=A146140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146140.Bytes);
public long this[int i]=>Value[i];

public static A146140Inst Instance=new A146140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146141
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,7L,7L,21L,21L,61L,61L,403L,403L,3415L,3415L,36395L,36395L,473261L,473261L,8291363L,8291363L,204964495L,204964495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146141Inst : IEnumerable<long>
{
public static readonly long[] Value=A146141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146141.Bytes);
public long this[int i]=>Value[i];

public static A146141Inst Instance=new A146141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146142
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,23L,43L,81L,319L,1397L,6447L,41775L,230237L,1798489L,13587111L,143546329L,1450499749L,20575847369L,276390467445L,5233548027451L,93375391444657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146142Inst : IEnumerable<long>
{
public static readonly long[] Value=A146142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146142.Bytes);
public long this[int i]=>Value[i];

public static A146142Inst Instance=new A146142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146143
{
public static readonly long[] Value={ 1L,1L,1L,1L,13L,51L,327L,1743L,13905L,216443L,3286293L,80038799L,2242888197L,93345565591L,4572631279405L,334861611729305L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146143Inst : IEnumerable<long>
{
public static readonly long[] Value=A146143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146143.Bytes);
public long this[int i]=>Value[i];

public static A146143Inst Instance=new A146143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146144
{
public static readonly long[] Value={ 1L,1L,5L,19L,97L,863L,18767L,490889L,19713443L,1413873475L,167866752937L,30662833126025L,9066289386941209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146144Inst : IEnumerable<long>
{
public static readonly long[] Value=A146144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146144.Bytes);
public long this[int i]=>Value[i];

public static A146144Inst Instance=new A146144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146145
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,1L,55L,103L,1119L,2577L,44665L,124149L,7114043L,25427717L,3924887627L,18243132743L,3963931303667L,23264020620581L,10118413718310299L,75049948209301973L,BigInteger.Parse("78694111409932613371"),BigInteger.Parse("745465591245660563073") };
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
public class A146145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146145Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A146145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146145.Bytes);
public BigInteger this[int i]=>Value[i];

public static A146145Inst Instance=new A146145Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146146
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,5L,5L,19L,19L,97L,97L,863L,863L,18767L,18767L,490889L,490889L,19713443L,19713443L,1413873475L,1413873475L,167866752937L,167866752937L,30662833126025L,30662833126025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146146Inst : IEnumerable<long>
{
public static readonly long[] Value=A146146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146146.Bytes);
public long this[int i]=>Value[i];

public static A146146Inst Instance=new A146146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146147
{
public static readonly BigInteger[] Value={ 1L,1L,3L,7L,17L,57L,295L,1823L,12191L,109351L,1406131L,21111023L,390067193L,9744306045L,307351023911L,11997000829617L,605954154512379L,39113863932012429L,3182367148757620917L,BigInteger.Parse("330528821610534812877") };
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
public class A146147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146147Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A146147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146147.Bytes);
public BigInteger this[int i]=>Value[i];

public static A146147Inst Instance=new A146147Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146148
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,7L,25L,61L,137L,491L,1895L,6799L,35271L,188161L,1045823L,6942831L,54475785L,429190219L,4220050567L,45840848045L,555820995851L,7424820570827L,118936859724455L,2001479983540325L,39919686781316217L,873987056828886899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146148Inst : IEnumerable<long>
{
public static readonly long[] Value=A146148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146148.Bytes);
public long this[int i]=>Value[i];

public static A146148Inst Instance=new A146148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146149
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,3L,3L,7L,7L,17L,17L,57L,57L,295L,295L,1823L,1823L,12191L,12191L,109351L,109351L,1406131L,1406131L,21111023L,21111023L,390067193L,390067193L,9744306045L,9744306045L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146149Inst : IEnumerable<long>
{
public static readonly long[] Value=A146149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146149.Bytes);
public long this[int i]=>Value[i];

public static A146149Inst Instance=new A146149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146150
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,11L,21L,45L,147L,455L,1443L,6641L,31711L,178915L,1031021L,7211761L,51418401L,452868901L,4229697689L,48322007005L,572003003167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146150Inst : IEnumerable<long>
{
public static readonly long[] Value=A146150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146150.Bytes);
public long this[int i]=>Value[i];

public static A146150Inst Instance=new A146150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146151
{
public static readonly long[] Value={ 1L,1L,1L,3L,9L,27L,119L,633L,3943L,30791L,332473L,4676705L,79725173L,1817184081L,50545874411L,1811092006865L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146151Inst : IEnumerable<long>
{
public static readonly long[] Value=A146151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146151.Bytes);
public long this[int i]=>Value[i];

public static A146151Inst Instance=new A146151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146152
{
public static readonly BigInteger[] Value={ 1L,1L,5L,13L,47L,375L,3972L,47068L,892007L,26215027L,1025956370L,55524872121L,4474246357794L,516153334755405L,83220252331733856L,BigInteger.Parse("19182699863712254411") };
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
public class A146152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146152Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A146152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146152.Bytes);
public BigInteger this[int i]=>Value[i];

public static A146152Inst Instance=new A146152Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146153
{
public static readonly BigInteger[] Value={ 1L,1L,3L,3L,9L,11L,82L,254L,1669L,6665L,68316L,226521L,4561686L,23734103L,704383992L,5907579541L,236178663400L,2337315883467L,150056765859689L,1811327966926780L,189399759509400492L,3276661629995792339L,BigInteger.Parse("507766610202105772758") };
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
public class A146153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146153Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A146153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146153.Bytes);
public BigInteger this[int i]=>Value[i];

public static A146153Inst Instance=new A146153Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146154
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,10L,10L,43L,65L,310L,319L,2668L,3017L,34910L,54223L,689528L,1137739L,18655423L,31210424L,700220638L,1365782613L,38696080322L,86209219516L,3066770236798L,7328473794260L,340900040830525L,897917903090606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146154Inst : IEnumerable<long>
{
public static readonly long[] Value=A146154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146154.Bytes);
public long this[int i]=>Value[i];

public static A146154Inst Instance=new A146154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146155
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,3L,7L,14L,42L,163L,719L,3628L,22263L,164206L,1435593L,15071126L,189778079L,2837151684L,50511089269L,1077365551719L,27499985838212L,837318042012350L,30417349994865723L,1319974251781005014L,BigInteger.Parse("68432608866087524550") };
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
public class A146155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146155Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A146155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146155.Bytes);
public BigInteger this[int i]=>Value[i];

public static A146155Inst Instance=new A146155Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146156
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,4L,7L,11L,20L,47L,126L,349L,1026L,3169L,10962L,42335L,178967L,817710L,4108982L,22332287L,134485764L,875416554L,6255533128L,48551931040L,415466055841L,3858971189964L,39521400790374L,437870905678969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146156Inst : IEnumerable<long>
{
public static readonly long[] Value=A146156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146156.Bytes);
public long this[int i]=>Value[i];

public static A146156Inst Instance=new A146156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146157
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,3L,3L,6L,7L,16L,23L,50L,65L,176L,221L,727L,1056L,3742L,5997L,23258L,37914L,168488L,284282L,1460179L,2612520L,15176540L,28767703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146157Inst : IEnumerable<long>
{
public static readonly long[] Value=A146157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146157.Bytes);
public long this[int i]=>Value[i];

public static A146157Inst Instance=new A146157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146158
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,8L,14L,23L,49L,124L,341L,1108L,3645L,13272L,50449L,210792L,970179L,4987095L,27600222L,171681370L,1133281367L,8288847384L,64922838278L,565664086802L,5311135075018L,55657682314667L,624953409635386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146158Inst : IEnumerable<long>
{
public static readonly long[] Value=A146158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146158.Bytes);
public long this[int i]=>Value[i];

public static A146158Inst Instance=new A146158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146159
{
public static readonly long[] Value={ 1L,1L,1L,1L,7L,15L,60L,184L,747L,3499L,25726L,170389L,1816278L,17509129L,246038108L,3281197739L,66149680918L,1268005261759L,37496297507935L,1034674372954972L,43395951886928470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146159Inst : IEnumerable<long>
{
public static readonly long[] Value=A146159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146159.Bytes);
public long this[int i]=>Value[i];

public static A146159Inst Instance=new A146159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146160
{
public static readonly long[] Value={ 1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L,4L,1L,16L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146160Inst : IEnumerable<long>
{
public static readonly long[] Value=A146160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146160.Bytes);
public long this[int i]=>Value[i];

public static A146160Inst Instance=new A146160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146161
{
public static readonly BigInteger[] Value={ 3L,8L,48L,512L,12288L,524288L,50331648L,8589934592L,3298534883328L,2251799813685248L,3458764513820540928L,BigInteger.Parse("9444732965739290427392"),BigInteger.Parse("58028439341502200385896448"),BigInteger.Parse("633825300114114700748351602688") };
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
public class A146161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146161Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A146161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146161.Bytes);
public BigInteger this[int i]=>Value[i];

public static A146161Inst Instance=new A146161Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146162
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,1L,0L,2L,4L,3L,0L,3L,8L,4L,0L,6L,14L,8L,0L,10L,22L,12L,0L,16L,36L,21L,0L,25L,56L,30L,0L,38L,84L,48L,0L,57L,126L,68L,0L,84L,184L,102L,0L,121L,264L,143L,0L,172L,376L,207L,0L,243L,528L,284L,0L,338L,732L,400L,0L,465L,1008L,542L,0L,636L,1374L,744L,0L,862L,1856L,996L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146162Inst : IEnumerable<long>
{
public static readonly long[] Value=A146162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146162.Bytes);
public long this[int i]=>Value[i];

public static A146162Inst Instance=new A146162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A146163
{
public static readonly long[] Value={ 1L,2L,3L,6L,10L,16L,25L,38L,57L,84L,121L,172L,243L,338L,465L,636L,862L,1158L,1546L,2050L,2701L,3540L,4613L,5980L,7719L,9916L,12682L,16158L,20506L,25926L,32667L,41022L,51348L,64080L,79730L,98922L,122407L,151068L,185968L,228384L,279816L,342052L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A146163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A146163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A146163Inst : IEnumerable<long>
{
public static readonly long[] Value=A146163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A146163.Bytes);
public long this[int i]=>Value[i];

public static A146163Inst Instance=new A146163Inst();

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