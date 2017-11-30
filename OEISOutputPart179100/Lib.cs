using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A222205
{
public static readonly long[] Value={ 1L,4L,20L,110L,636L,3790L,23036L,141946L,883360L,5538098L,34917224L,221125102L,1405276324L,8956020294L,57209977908L,366147270370L,2347081505816L,15065301857194L,96808851937152L,622682497349910L,4008412023724124L,25821543284366686L,166438749582676204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222205Inst : IEnumerable<long>
{
public static readonly long[] Value=A222205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222205.Bytes);
public long this[int i]=>Value[i];

public static A222205Inst Instance=new A222205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222206
{
public static readonly long[] Value={ 2L,11L,349L,13691L,24329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222206Inst : IEnumerable<long>
{
public static readonly long[] Value=A222206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222206.Bytes);
public long this[int i]=>Value[i];

public static A222206Inst Instance=new A222206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222207
{
public static readonly BigInteger[] Value={ 2L,12L,788L,7636L,874202L,10018884L,1445893544L,2954512034024L,38700329118256L,93229749133527532L,17540746936557672236UL,BigInteger.Parse("243284404062970619608"),BigInteger.Parse("47694250379410432495952"),BigInteger.Parse("136236017676683906365850456"),BigInteger.Parse("404504597532158799519693872144"),BigInteger.Parse("5856120097210409121404621878992"),BigInteger.Parse("18102352585707069737371994385420772"),BigInteger.Parse("3894254646848417473467131712404310728") };
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
public class A222207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222207Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222207.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222207Inst Instance=new A222207Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222208
{
public static readonly long[] Value={ 1L,3L,2L,6L,4L,12L,5L,18L,8L,24L,7L,36L,9L,15L,16L,54L,10L,48L,11L,72L,20L,21L,13L,108L,28L,27L,32L,30L,14L,96L,17L,162L,42L,60L,40L,144L,19L,33L,90L,216L,22L,120L,23L,84L,64L,39L,25L,324L,35L,168L,50L,270L,26L,192L,56L,180L,44L,126L,29L,288L,31L,51L,80L,486L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222208Inst : IEnumerable<long>
{
public static readonly long[] Value=A222208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222208.Bytes);
public long this[int i]=>Value[i];

public static A222208Inst Instance=new A222208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222209
{
public static readonly long[] Value={ 1L,3L,2L,5L,7L,4L,11L,9L,13L,17L,19L,6L,23L,29L,14L,15L,31L,8L,37L,21L,22L,41L,43L,10L,47L,53L,26L,25L,59L,28L,61L,27L,38L,67L,49L,12L,71L,73L,46L,35L,79L,33L,83L,57L,89L,97L,101L,18L,103L,51L,62L,69L,107L,16L,109L,55L,74L,113L,127L,34L,131L,137L,121L,45L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222209Inst : IEnumerable<long>
{
public static readonly long[] Value=A222209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222209.Bytes);
public long this[int i]=>Value[i];

public static A222209Inst Instance=new A222209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222210
{
public static readonly long[] Value={ 1L,0L,2L,3L,4L,5L,6L,7L,8L,9L,1L,0L,2L,3L,4L,5L,6L,7L,8L,9L,21L,20L,22L,23L,24L,25L,26L,27L,28L,29L,31L,30L,32L,33L,34L,35L,36L,37L,38L,39L,41L,40L,42L,43L,44L,45L,46L,47L,48L,49L,51L,50L,52L,53L,54L,55L,56L,57L,58L,59L,61L,60L,62L,63L,64L,65L,66L,67L,68L,69L,71L,70L,72L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222210Inst : IEnumerable<long>
{
public static readonly long[] Value=A222210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222210.Bytes);
public long this[int i]=>Value[i];

public static A222210Inst Instance=new A222210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222211
{
public static readonly long[] Value={ 2L,1L,0L,3L,4L,5L,6L,7L,8L,9L,12L,11L,10L,13L,14L,15L,16L,17L,18L,19L,2L,1L,0L,3L,4L,5L,6L,7L,8L,9L,32L,31L,30L,33L,34L,35L,36L,37L,38L,39L,42L,41L,40L,43L,44L,45L,46L,47L,48L,49L,52L,51L,50L,53L,54L,55L,56L,57L,58L,59L,62L,61L,60L,63L,64L,65L,66L,67L,68L,69L,72L,71L,70L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222211Inst : IEnumerable<long>
{
public static readonly long[] Value=A222211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222211.Bytes);
public long this[int i]=>Value[i];

public static A222211Inst Instance=new A222211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222212
{
public static readonly long[] Value={ 3L,1L,2L,0L,4L,5L,6L,7L,8L,9L,13L,11L,12L,10L,14L,15L,16L,17L,18L,19L,23L,21L,22L,20L,24L,25L,26L,27L,28L,29L,3L,1L,2L,0L,4L,5L,6L,7L,8L,9L,43L,41L,42L,40L,44L,45L,46L,47L,48L,49L,53L,51L,52L,50L,54L,55L,56L,57L,58L,59L,63L,61L,62L,60L,64L,65L,66L,67L,68L,69L,73L,71L,72L,70L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222212Inst : IEnumerable<long>
{
public static readonly long[] Value=A222212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222212.Bytes);
public long this[int i]=>Value[i];

public static A222212Inst Instance=new A222212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222213
{
public static readonly long[] Value={ 4L,1L,2L,3L,0L,5L,6L,7L,8L,9L,14L,11L,12L,13L,10L,15L,16L,17L,18L,19L,24L,21L,22L,23L,20L,25L,26L,27L,28L,29L,34L,31L,32L,33L,30L,35L,36L,37L,38L,39L,4L,1L,2L,3L,0L,5L,6L,7L,8L,9L,54L,51L,52L,53L,50L,55L,56L,57L,58L,59L,64L,61L,62L,63L,60L,65L,66L,67L,68L,69L,74L,71L,72L,73L,70L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222213Inst : IEnumerable<long>
{
public static readonly long[] Value=A222213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222213.Bytes);
public long this[int i]=>Value[i];

public static A222213Inst Instance=new A222213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222214
{
public static readonly long[] Value={ 5L,1L,2L,3L,4L,0L,6L,7L,8L,9L,15L,11L,12L,13L,14L,10L,16L,17L,18L,19L,25L,21L,22L,23L,24L,20L,26L,27L,28L,29L,35L,31L,32L,33L,34L,30L,36L,37L,38L,39L,45L,41L,42L,43L,44L,40L,46L,47L,48L,49L,5L,1L,2L,3L,4L,0L,6L,7L,8L,9L,65L,61L,62L,63L,64L,60L,66L,67L,68L,69L,75L,71L,72L,73L,74L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222214Inst : IEnumerable<long>
{
public static readonly long[] Value=A222214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222214.Bytes);
public long this[int i]=>Value[i];

public static A222214Inst Instance=new A222214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222215
{
public static readonly long[] Value={ 6L,1L,2L,3L,4L,5L,0L,7L,8L,9L,16L,11L,12L,13L,14L,15L,10L,17L,18L,19L,26L,21L,22L,23L,24L,25L,20L,27L,28L,29L,36L,31L,32L,33L,34L,35L,30L,37L,38L,39L,46L,41L,42L,43L,44L,45L,40L,47L,48L,49L,56L,51L,52L,53L,54L,55L,50L,57L,58L,59L,6L,1L,2L,3L,4L,5L,0L,7L,8L,9L,76L,71L,72L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222215Inst : IEnumerable<long>
{
public static readonly long[] Value=A222215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222215.Bytes);
public long this[int i]=>Value[i];

public static A222215Inst Instance=new A222215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222216
{
public static readonly long[] Value={ 7L,1L,2L,3L,4L,5L,6L,0L,8L,9L,17L,11L,12L,13L,14L,15L,16L,10L,18L,19L,27L,21L,22L,23L,24L,25L,26L,20L,28L,29L,37L,31L,32L,33L,34L,35L,36L,30L,38L,39L,47L,41L,42L,43L,44L,45L,46L,40L,48L,49L,57L,51L,52L,53L,54L,55L,56L,50L,58L,59L,67L,61L,62L,63L,64L,65L,66L,60L,68L,69L,7L,1L,2L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222216Inst : IEnumerable<long>
{
public static readonly long[] Value=A222216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222216.Bytes);
public long this[int i]=>Value[i];

public static A222216Inst Instance=new A222216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222217
{
public static readonly long[] Value={ 8L,1L,2L,3L,4L,5L,6L,7L,0L,9L,18L,11L,12L,13L,14L,15L,16L,17L,10L,19L,28L,21L,22L,23L,24L,25L,26L,27L,20L,29L,38L,31L,32L,33L,34L,35L,36L,37L,30L,39L,48L,41L,42L,43L,44L,45L,46L,47L,40L,49L,58L,51L,52L,53L,54L,55L,56L,57L,50L,59L,68L,61L,62L,63L,64L,65L,66L,67L,60L,69L,78L,71L,72L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222217Inst : IEnumerable<long>
{
public static readonly long[] Value=A222217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222217.Bytes);
public long this[int i]=>Value[i];

public static A222217Inst Instance=new A222217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222218
{
public static readonly long[] Value={ 9L,1L,2L,3L,4L,5L,6L,7L,8L,0L,19L,11L,12L,13L,14L,15L,16L,17L,18L,10L,29L,21L,22L,23L,24L,25L,26L,27L,28L,20L,39L,31L,32L,33L,34L,35L,36L,37L,38L,30L,49L,41L,42L,43L,44L,45L,46L,47L,48L,40L,59L,51L,52L,53L,54L,55L,56L,57L,58L,50L,69L,61L,62L,63L,64L,65L,66L,67L,68L,60L,79L,71L,72L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222218Inst : IEnumerable<long>
{
public static readonly long[] Value=A222218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222218.Bytes);
public long this[int i]=>Value[i];

public static A222218Inst Instance=new A222218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222219
{
public static readonly BigInteger[] Value={ 5L,11L,13L,19L,23L,29L,53L,61L,113L,239L,251L,503L,1013L,1021L,4093L,8191L,65519L,65521L,262133L,1048571L,4194301L,BigInteger.Parse("302231454903657293676533") };
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
public class A222219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222219Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222219.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222219Inst Instance=new A222219Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222220
{
public static readonly long[] Value={ 0L,3L,2L,1L,4L,5L,6L,7L,8L,9L,30L,33L,32L,31L,34L,35L,36L,37L,38L,39L,20L,23L,22L,21L,24L,25L,26L,27L,28L,29L,10L,13L,12L,11L,14L,15L,16L,17L,18L,19L,40L,43L,42L,41L,44L,45L,46L,47L,48L,49L,50L,53L,52L,51L,54L,55L,56L,57L,58L,59L,60L,63L,62L,61L,64L,65L,66L,67L,68L,69L,70L,73L,72L,71L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222220Inst : IEnumerable<long>
{
public static readonly long[] Value=A222220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222220.Bytes);
public long this[int i]=>Value[i];

public static A222220Inst Instance=new A222220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222221
{
public static readonly long[] Value={ 0L,4L,2L,3L,1L,5L,6L,7L,8L,9L,40L,44L,42L,43L,41L,45L,46L,47L,48L,49L,20L,24L,22L,23L,21L,25L,26L,27L,28L,29L,30L,34L,32L,33L,31L,35L,36L,37L,38L,39L,10L,14L,12L,13L,11L,15L,16L,17L,18L,19L,50L,54L,52L,53L,51L,55L,56L,57L,58L,59L,60L,64L,62L,63L,61L,65L,66L,67L,68L,69L,70L,74L,72L,73L,71L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222221Inst : IEnumerable<long>
{
public static readonly long[] Value=A222221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222221.Bytes);
public long this[int i]=>Value[i];

public static A222221Inst Instance=new A222221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222222
{
public static readonly long[] Value={ 0L,5L,2L,3L,4L,1L,6L,7L,8L,9L,50L,55L,52L,53L,54L,51L,56L,57L,58L,59L,20L,25L,22L,23L,24L,21L,26L,27L,28L,29L,30L,35L,32L,33L,34L,31L,36L,37L,38L,39L,40L,45L,42L,43L,44L,41L,46L,47L,48L,49L,10L,15L,12L,13L,14L,11L,16L,17L,18L,19L,60L,65L,62L,63L,64L,61L,66L,67L,68L,69L,70L,75L,72L,73L,74L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222222Inst : IEnumerable<long>
{
public static readonly long[] Value=A222222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222222.Bytes);
public long this[int i]=>Value[i];

public static A222222Inst Instance=new A222222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222223
{
public static readonly long[] Value={ 0L,6L,2L,3L,4L,5L,1L,7L,8L,9L,60L,66L,62L,63L,64L,65L,61L,67L,68L,69L,20L,26L,22L,23L,24L,25L,21L,27L,28L,29L,30L,36L,32L,33L,34L,35L,31L,37L,38L,39L,40L,46L,42L,43L,44L,45L,41L,47L,48L,49L,50L,56L,52L,53L,54L,55L,51L,57L,58L,59L,10L,16L,12L,13L,14L,15L,11L,17L,18L,19L,70L,76L,72L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222223Inst : IEnumerable<long>
{
public static readonly long[] Value=A222223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222223.Bytes);
public long this[int i]=>Value[i];

public static A222223Inst Instance=new A222223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222224
{
public static readonly long[] Value={ 0L,7L,2L,3L,4L,5L,6L,1L,8L,9L,70L,77L,72L,73L,74L,75L,76L,71L,78L,79L,20L,27L,22L,23L,24L,25L,26L,21L,28L,29L,30L,37L,32L,33L,34L,35L,36L,31L,38L,39L,40L,47L,42L,43L,44L,45L,46L,41L,48L,49L,50L,57L,52L,53L,54L,55L,56L,51L,58L,59L,60L,67L,62L,63L,64L,65L,66L,61L,68L,69L,10L,17L,12L,13L,14L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222224Inst : IEnumerable<long>
{
public static readonly long[] Value=A222224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222224.Bytes);
public long this[int i]=>Value[i];

public static A222224Inst Instance=new A222224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222225
{
public static readonly long[] Value={ 0L,8L,2L,3L,4L,5L,6L,7L,1L,9L,80L,88L,82L,83L,84L,85L,86L,87L,81L,89L,20L,28L,22L,23L,24L,25L,26L,27L,21L,29L,30L,38L,32L,33L,34L,35L,36L,37L,31L,39L,40L,48L,42L,43L,44L,45L,46L,47L,41L,49L,50L,58L,52L,53L,54L,55L,56L,57L,51L,59L,60L,68L,62L,63L,64L,65L,66L,67L,61L,69L,70L,78L,72L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222225Inst : IEnumerable<long>
{
public static readonly long[] Value=A222225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222225.Bytes);
public long this[int i]=>Value[i];

public static A222225Inst Instance=new A222225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222226
{
public static readonly long[] Value={ 0L,9L,2L,3L,4L,5L,6L,7L,8L,1L,90L,99L,92L,93L,94L,95L,96L,97L,98L,91L,20L,29L,22L,23L,24L,25L,26L,27L,28L,21L,30L,39L,32L,33L,34L,35L,36L,37L,38L,31L,40L,49L,42L,43L,44L,45L,46L,47L,48L,41L,50L,59L,52L,53L,54L,55L,56L,57L,58L,51L,60L,69L,62L,63L,64L,65L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222226Inst : IEnumerable<long>
{
public static readonly long[] Value=A222226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222226.Bytes);
public long this[int i]=>Value[i];

public static A222226Inst Instance=new A222226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222227
{
public static readonly long[] Value={ 3L,7L,13L,31L,241L,65521L,1048573L,2305843009213693951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222227Inst : IEnumerable<long>
{
public static readonly long[] Value=A222227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222227.Bytes);
public long this[int i]=>Value[i];

public static A222227Inst Instance=new A222227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222228
{
public static readonly long[] Value={ 0L,1L,4L,3L,2L,5L,6L,7L,8L,9L,10L,11L,14L,13L,12L,15L,16L,17L,18L,19L,40L,41L,44L,43L,42L,45L,46L,47L,48L,49L,30L,31L,34L,33L,32L,35L,36L,37L,38L,39L,20L,21L,24L,23L,22L,25L,26L,27L,28L,29L,50L,51L,54L,53L,52L,55L,56L,57L,58L,59L,60L,61L,64L,63L,62L,65L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222228Inst : IEnumerable<long>
{
public static readonly long[] Value=A222228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222228.Bytes);
public long this[int i]=>Value[i];

public static A222228Inst Instance=new A222228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222229
{
public static readonly long[] Value={ 0L,1L,5L,3L,4L,2L,6L,7L,8L,9L,10L,11L,15L,13L,14L,12L,16L,17L,18L,19L,50L,51L,55L,53L,54L,52L,56L,57L,58L,59L,30L,31L,35L,33L,34L,32L,36L,37L,38L,39L,40L,41L,45L,43L,44L,42L,46L,47L,48L,49L,20L,21L,25L,23L,24L,22L,26L,27L,28L,29L,60L,61L,65L,63L,64L,62L,66L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222229Inst : IEnumerable<long>
{
public static readonly long[] Value=A222229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222229.Bytes);
public long this[int i]=>Value[i];

public static A222229Inst Instance=new A222229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222230
{
public static readonly long[] Value={ 0L,1L,6L,3L,4L,5L,2L,7L,8L,9L,10L,11L,16L,13L,14L,15L,12L,17L,18L,19L,60L,61L,66L,63L,64L,65L,62L,67L,68L,69L,30L,31L,36L,33L,34L,35L,32L,37L,38L,39L,40L,41L,46L,43L,44L,45L,42L,47L,48L,49L,50L,51L,56L,53L,54L,55L,52L,57L,58L,59L,20L,21L,26L,23L,24L,25L,22L,27L,28L,29L,70L,71L,76L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222230Inst : IEnumerable<long>
{
public static readonly long[] Value=A222230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222230.Bytes);
public long this[int i]=>Value[i];

public static A222230Inst Instance=new A222230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222231
{
public static readonly long[] Value={ 0L,1L,7L,3L,4L,5L,6L,2L,8L,9L,10L,11L,17L,13L,14L,15L,16L,12L,18L,19L,70L,71L,77L,73L,74L,75L,76L,72L,78L,79L,30L,31L,37L,33L,34L,35L,36L,32L,38L,39L,40L,41L,47L,43L,44L,45L,46L,42L,48L,49L,50L,51L,57L,53L,54L,55L,56L,52L,58L,59L,60L,61L,67L,63L,64L,65L,66L,62L,68L,69L,20L,21L,27L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222231Inst : IEnumerable<long>
{
public static readonly long[] Value=A222231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222231.Bytes);
public long this[int i]=>Value[i];

public static A222231Inst Instance=new A222231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222232
{
public static readonly long[] Value={ 0L,1L,8L,3L,4L,5L,6L,7L,2L,9L,10L,11L,18L,13L,14L,15L,16L,17L,12L,19L,80L,81L,88L,83L,84L,85L,86L,87L,82L,89L,30L,31L,38L,33L,34L,35L,36L,37L,32L,39L,40L,41L,48L,43L,44L,45L,46L,47L,42L,49L,50L,51L,58L,53L,54L,55L,56L,57L,52L,59L,60L,61L,68L,63L,64L,65L,66L,67L,62L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222232Inst : IEnumerable<long>
{
public static readonly long[] Value=A222232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222232.Bytes);
public long this[int i]=>Value[i];

public static A222232Inst Instance=new A222232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222233
{
public static readonly long[] Value={ 0L,1L,9L,3L,4L,5L,6L,7L,8L,2L,10L,11L,19L,13L,14L,15L,16L,17L,18L,12L,90L,91L,99L,93L,94L,95L,96L,97L,98L,92L,30L,31L,39L,33L,34L,35L,36L,37L,38L,32L,40L,41L,49L,43L,44L,45L,46L,47L,48L,42L,50L,51L,59L,53L,54L,55L,56L,57L,58L,52L,60L,61L,69L,63L,64L,65L,66L,67L,68L,62L,70L,71L,79L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222233Inst : IEnumerable<long>
{
public static readonly long[] Value=A222233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222233.Bytes);
public long this[int i]=>Value[i];

public static A222233Inst Instance=new A222233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222234
{
public static readonly long[] Value={ 0L,1L,2L,4L,3L,5L,6L,7L,8L,9L,10L,11L,12L,14L,13L,15L,16L,17L,18L,19L,20L,21L,22L,24L,23L,25L,26L,27L,28L,29L,40L,41L,42L,44L,43L,45L,46L,47L,48L,49L,30L,31L,32L,34L,33L,35L,36L,37L,38L,39L,50L,51L,52L,54L,53L,55L,56L,57L,58L,59L,60L,61L,62L,64L,63L,65L,66L,67L,68L,69L,70L,71L,72L,74L,73L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222234Inst : IEnumerable<long>
{
public static readonly long[] Value=A222234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222234.Bytes);
public long this[int i]=>Value[i];

public static A222234Inst Instance=new A222234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222235
{
public static readonly long[] Value={ 0L,1L,2L,5L,4L,3L,6L,7L,8L,9L,10L,11L,12L,15L,14L,13L,16L,17L,18L,19L,20L,21L,22L,25L,24L,23L,26L,27L,28L,29L,50L,51L,52L,55L,54L,53L,56L,57L,58L,59L,40L,41L,42L,45L,44L,43L,46L,47L,48L,49L,30L,31L,32L,35L,34L,33L,36L,37L,38L,39L,60L,61L,62L,65L,64L,63L,66L,67L,68L,69L,70L,71L,72L,75L,74L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222235Inst : IEnumerable<long>
{
public static readonly long[] Value=A222235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222235.Bytes);
public long this[int i]=>Value[i];

public static A222235Inst Instance=new A222235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222236
{
public static readonly long[] Value={ 0L,1L,2L,6L,4L,5L,3L,7L,8L,9L,10L,11L,12L,16L,14L,15L,13L,17L,18L,19L,20L,21L,22L,26L,24L,25L,23L,27L,28L,29L,60L,61L,62L,66L,64L,65L,63L,67L,68L,69L,40L,41L,42L,46L,44L,45L,43L,47L,48L,49L,50L,51L,52L,56L,54L,55L,53L,57L,58L,59L,30L,31L,32L,36L,34L,35L,33L,37L,38L,39L,70L,71L,72L,76L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222236Inst : IEnumerable<long>
{
public static readonly long[] Value=A222236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222236.Bytes);
public long this[int i]=>Value[i];

public static A222236Inst Instance=new A222236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222237
{
public static readonly long[] Value={ 0L,1L,2L,7L,4L,5L,6L,3L,8L,9L,10L,11L,12L,17L,14L,15L,16L,13L,18L,19L,20L,21L,22L,27L,24L,25L,26L,23L,28L,29L,70L,71L,72L,77L,74L,75L,76L,73L,78L,79L,40L,41L,42L,47L,44L,45L,46L,43L,48L,49L,50L,51L,52L,57L,54L,55L,56L,53L,58L,59L,60L,61L,62L,67L,64L,65L,66L,63L,68L,69L,30L,31L,32L,37L,34L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222237Inst : IEnumerable<long>
{
public static readonly long[] Value=A222237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222237.Bytes);
public long this[int i]=>Value[i];

public static A222237Inst Instance=new A222237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222238
{
public static readonly long[] Value={ 0L,1L,2L,8L,4L,5L,6L,7L,3L,9L,10L,11L,12L,18L,14L,15L,16L,17L,13L,19L,20L,21L,22L,28L,24L,25L,26L,27L,23L,29L,80L,81L,82L,88L,84L,85L,86L,87L,83L,89L,40L,41L,42L,48L,44L,45L,46L,47L,43L,49L,50L,51L,52L,58L,54L,55L,56L,57L,53L,59L,60L,61L,62L,68L,64L,65L,66L,67L,63L,69L,70L,71L,72L,78L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222238Inst : IEnumerable<long>
{
public static readonly long[] Value=A222238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222238.Bytes);
public long this[int i]=>Value[i];

public static A222238Inst Instance=new A222238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222239
{
public static readonly long[] Value={ 0L,1L,2L,9L,4L,5L,6L,7L,8L,3L,10L,11L,12L,19L,14L,15L,16L,17L,18L,13L,20L,21L,22L,29L,24L,25L,26L,27L,28L,23L,90L,91L,92L,99L,94L,95L,96L,97L,98L,93L,40L,41L,42L,49L,44L,45L,46L,47L,48L,43L,50L,51L,52L,59L,54L,55L,56L,57L,58L,53L,60L,61L,62L,69L,64L,65L,66L,67L,68L,63L,70L,71L,72L,79L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222239Inst : IEnumerable<long>
{
public static readonly long[] Value=A222239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222239.Bytes);
public long this[int i]=>Value[i];

public static A222239Inst Instance=new A222239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222240
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,4L,6L,7L,8L,9L,10L,11L,12L,13L,15L,14L,16L,17L,18L,19L,20L,21L,22L,23L,25L,24L,26L,27L,28L,29L,30L,31L,32L,33L,35L,34L,36L,37L,38L,39L,50L,51L,52L,53L,55L,54L,56L,57L,58L,59L,40L,41L,42L,43L,45L,44L,46L,47L,48L,49L,60L,61L,62L,63L,65L,64L,66L,67L,68L,69L,70L,71L,72L,73L,75L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222240Inst : IEnumerable<long>
{
public static readonly long[] Value=A222240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222240.Bytes);
public long this[int i]=>Value[i];

public static A222240Inst Instance=new A222240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222241
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,5L,4L,7L,8L,9L,10L,11L,12L,13L,16L,15L,14L,17L,18L,19L,20L,21L,22L,23L,26L,25L,24L,27L,28L,29L,30L,31L,32L,33L,36L,35L,34L,37L,38L,39L,60L,61L,62L,63L,66L,65L,64L,67L,68L,69L,50L,51L,52L,53L,56L,55L,54L,57L,58L,59L,40L,41L,42L,43L,46L,45L,44L,47L,48L,49L,70L,71L,72L,73L,76L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222241Inst : IEnumerable<long>
{
public static readonly long[] Value=A222241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222241.Bytes);
public long this[int i]=>Value[i];

public static A222241Inst Instance=new A222241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222242
{
public static readonly long[] Value={ 0L,1L,2L,3L,7L,5L,6L,4L,8L,9L,10L,11L,12L,13L,17L,15L,16L,14L,18L,19L,20L,21L,22L,23L,27L,25L,26L,24L,28L,29L,30L,31L,32L,33L,37L,35L,36L,34L,38L,39L,70L,71L,72L,73L,77L,75L,76L,74L,78L,79L,50L,51L,52L,53L,57L,55L,56L,54L,58L,59L,60L,61L,62L,63L,67L,65L,66L,64L,68L,69L,40L,41L,42L,43L,47L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222242Inst : IEnumerable<long>
{
public static readonly long[] Value=A222242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222242.Bytes);
public long this[int i]=>Value[i];

public static A222242Inst Instance=new A222242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222243
{
public static readonly long[] Value={ 0L,1L,2L,3L,8L,5L,6L,7L,4L,9L,10L,11L,12L,13L,18L,15L,16L,17L,14L,19L,20L,21L,22L,23L,28L,25L,26L,27L,24L,29L,30L,31L,32L,33L,38L,35L,36L,37L,34L,39L,80L,81L,82L,83L,88L,85L,86L,87L,84L,89L,50L,51L,52L,53L,58L,55L,56L,57L,54L,59L,60L,61L,62L,63L,68L,65L,66L,67L,64L,69L,70L,71L,72L,73L,78L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222243Inst : IEnumerable<long>
{
public static readonly long[] Value=A222243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222243.Bytes);
public long this[int i]=>Value[i];

public static A222243Inst Instance=new A222243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222244
{
public static readonly long[] Value={ 0L,1L,2L,3L,9L,5L,6L,7L,8L,4L,10L,11L,12L,13L,19L,15L,16L,17L,18L,14L,20L,21L,22L,23L,29L,25L,26L,27L,28L,24L,30L,31L,32L,33L,39L,35L,36L,37L,38L,34L,90L,91L,92L,93L,99L,95L,96L,97L,98L,94L,50L,51L,52L,53L,59L,55L,56L,57L,58L,54L,60L,61L,62L,63L,69L,65L,66L,67L,68L,64L,70L,71L,72L,73L,79L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222244Inst : IEnumerable<long>
{
public static readonly long[] Value=A222244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222244.Bytes);
public long this[int i]=>Value[i];

public static A222244Inst Instance=new A222244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222245
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,5L,7L,8L,9L,10L,11L,12L,13L,14L,16L,15L,17L,18L,19L,20L,21L,22L,23L,24L,26L,25L,27L,28L,29L,30L,31L,32L,33L,34L,36L,35L,37L,38L,39L,40L,41L,42L,43L,44L,46L,45L,47L,48L,49L,60L,61L,62L,63L,64L,66L,65L,67L,68L,69L,50L,51L,52L,53L,54L,56L,55L,57L,58L,59L,70L,71L,72L,73L,74L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222245Inst : IEnumerable<long>
{
public static readonly long[] Value=A222245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222245.Bytes);
public long this[int i]=>Value[i];

public static A222245Inst Instance=new A222245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222246
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,6L,5L,8L,9L,10L,11L,12L,13L,14L,17L,16L,15L,18L,19L,20L,21L,22L,23L,24L,27L,26L,25L,28L,29L,30L,31L,32L,33L,34L,37L,36L,35L,38L,39L,40L,41L,42L,43L,44L,47L,46L,45L,48L,49L,70L,71L,72L,73L,74L,77L,76L,75L,78L,79L,60L,61L,62L,63L,64L,67L,66L,65L,68L,69L,50L,51L,52L,53L,54L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222246Inst : IEnumerable<long>
{
public static readonly long[] Value=A222246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222246.Bytes);
public long this[int i]=>Value[i];

public static A222246Inst Instance=new A222246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222247
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,8L,6L,7L,5L,9L,10L,11L,12L,13L,14L,18L,16L,17L,15L,19L,20L,21L,22L,23L,24L,28L,26L,27L,25L,29L,30L,31L,32L,33L,34L,38L,36L,37L,35L,39L,40L,41L,42L,43L,44L,48L,46L,47L,45L,49L,80L,81L,82L,83L,84L,88L,86L,87L,85L,89L,60L,61L,62L,63L,64L,68L,66L,67L,65L,69L,70L,71L,72L,73L,74L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222247Inst : IEnumerable<long>
{
public static readonly long[] Value=A222247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222247.Bytes);
public long this[int i]=>Value[i];

public static A222247Inst Instance=new A222247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222248
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,9L,6L,7L,8L,5L,10L,11L,12L,13L,14L,19L,16L,17L,18L,15L,20L,21L,22L,23L,24L,29L,26L,27L,28L,25L,30L,31L,32L,33L,34L,39L,36L,37L,38L,35L,40L,41L,42L,43L,44L,49L,46L,47L,48L,45L,90L,91L,92L,93L,94L,99L,96L,97L,98L,95L,60L,61L,62L,63L,64L,69L,66L,67L,68L,65L,70L,71L,72L,73L,74L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222248Inst : IEnumerable<long>
{
public static readonly long[] Value=A222248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222248.Bytes);
public long this[int i]=>Value[i];

public static A222248Inst Instance=new A222248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222249
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,6L,8L,9L,10L,11L,12L,13L,14L,15L,17L,16L,18L,19L,20L,21L,22L,23L,24L,25L,27L,26L,28L,29L,30L,31L,32L,33L,34L,35L,37L,36L,38L,39L,40L,41L,42L,43L,44L,45L,47L,46L,48L,49L,50L,51L,52L,53L,54L,55L,57L,56L,58L,59L,70L,71L,72L,73L,74L,75L,77L,76L,78L,79L,60L,61L,62L,63L,64L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222249Inst : IEnumerable<long>
{
public static readonly long[] Value=A222249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222249.Bytes);
public long this[int i]=>Value[i];

public static A222249Inst Instance=new A222249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222250
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,8L,7L,6L,9L,10L,11L,12L,13L,14L,15L,18L,17L,16L,19L,20L,21L,22L,23L,24L,25L,28L,27L,26L,29L,30L,31L,32L,33L,34L,35L,38L,37L,36L,39L,40L,41L,42L,43L,44L,45L,48L,47L,46L,49L,50L,51L,52L,53L,54L,55L,58L,57L,56L,59L,80L,81L,82L,83L,84L,85L,88L,87L,86L,89L,70L,71L,72L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222250Inst : IEnumerable<long>
{
public static readonly long[] Value=A222250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222250.Bytes);
public long this[int i]=>Value[i];

public static A222250Inst Instance=new A222250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222251
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,9L,7L,8L,6L,10L,11L,12L,13L,14L,15L,19L,17L,18L,16L,20L,21L,22L,23L,24L,25L,29L,27L,28L,26L,30L,31L,32L,33L,34L,35L,39L,37L,38L,36L,40L,41L,42L,43L,44L,45L,49L,47L,48L,46L,50L,51L,52L,53L,54L,55L,59L,57L,58L,56L,90L,91L,92L,93L,94L,95L,99L,97L,98L,96L,70L,71L,72L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222251Inst : IEnumerable<long>
{
public static readonly long[] Value=A222251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222251.Bytes);
public long this[int i]=>Value[i];

public static A222251Inst Instance=new A222251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222252
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,7L,9L,10L,11L,12L,13L,14L,15L,16L,18L,17L,19L,20L,21L,22L,23L,24L,25L,26L,28L,27L,29L,30L,31L,32L,33L,34L,35L,36L,38L,37L,39L,40L,41L,42L,43L,44L,45L,46L,48L,47L,49L,50L,51L,52L,53L,54L,55L,56L,58L,57L,59L,60L,61L,62L,63L,64L,65L,66L,68L,67L,69L,80L,81L,82L,83L,84L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222252Inst : IEnumerable<long>
{
public static readonly long[] Value=A222252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222252.Bytes);
public long this[int i]=>Value[i];

public static A222252Inst Instance=new A222252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222253
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,9L,8L,7L,10L,11L,12L,13L,14L,15L,16L,19L,18L,17L,20L,21L,22L,23L,24L,25L,26L,29L,28L,27L,30L,31L,32L,33L,34L,35L,36L,39L,38L,37L,40L,41L,42L,43L,44L,45L,46L,49L,48L,47L,50L,51L,52L,53L,54L,55L,56L,59L,58L,57L,60L,61L,62L,63L,64L,65L,66L,69L,68L,67L,90L,91L,92L,93L,94L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222253Inst : IEnumerable<long>
{
public static readonly long[] Value=A222253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222253.Bytes);
public long this[int i]=>Value[i];

public static A222253Inst Instance=new A222253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222254
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,9L,8L,10L,11L,12L,13L,14L,15L,16L,17L,19L,18L,20L,21L,22L,23L,24L,25L,26L,27L,29L,28L,30L,31L,32L,33L,34L,35L,36L,37L,39L,38L,40L,41L,42L,43L,44L,45L,46L,47L,49L,48L,50L,51L,52L,53L,54L,55L,56L,57L,59L,58L,60L,61L,62L,63L,64L,65L,66L,67L,69L,68L,70L,71L,72L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222254Inst : IEnumerable<long>
{
public static readonly long[] Value=A222254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222254.Bytes);
public long this[int i]=>Value[i];

public static A222254Inst Instance=new A222254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222255
{
public static readonly BigInteger[] Value={ 2L,2L,2L,2L,5L,5L,193L,2903041L,250822656001L,1807729046323200001L,BigInteger.Parse("1472038679443987759104000001"),BigInteger.Parse("21817028147643299474152432146548259236610048000000000001") };
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
public class A222255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222255Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222255.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222255Inst Instance=new A222255Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222256
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,8L,6L,7L,14L,9L,10L,20L,12L,13L,26L,15L,16L,32L,18L,19L,38L,21L,22L,44L,24L,25L,50L,27L,28L,56L,30L,31L,62L,33L,34L,68L,36L,37L,74L,39L,40L,80L,42L,43L,86L,45L,46L,92L,48L,49L,98L,51L,52L,104L,54L,55L,110L,57L,58L,116L,60L,61L,122L,63L,64L,128L,66L,67L,134L,69L,70L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222256Inst : IEnumerable<long>
{
public static readonly long[] Value=A222256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222256.Bytes);
public long this[int i]=>Value[i];

public static A222256Inst Instance=new A222256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222257
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,9L,7L,8L,15L,10L,11L,21L,13L,14L,27L,16L,17L,33L,19L,20L,39L,22L,23L,45L,25L,26L,51L,28L,29L,57L,31L,32L,63L,34L,35L,69L,37L,38L,75L,40L,41L,81L,43L,44L,87L,46L,47L,93L,49L,50L,99L,52L,53L,105L,55L,56L,111L,58L,59L,117L,61L,62L,123L,64L,65L,129L,67L,68L,135L,70L,71L,141L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222257Inst : IEnumerable<long>
{
public static readonly long[] Value=A222257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222257.Bytes);
public long this[int i]=>Value[i];

public static A222257Inst Instance=new A222257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222258
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,11L,8L,9L,10L,19L,12L,13L,14L,27L,16L,17L,18L,35L,20L,21L,22L,43L,24L,25L,26L,51L,28L,29L,30L,59L,32L,33L,34L,67L,36L,37L,38L,75L,40L,41L,42L,83L,44L,45L,46L,91L,48L,49L,50L,99L,52L,53L,54L,107L,56L,57L,58L,115L,60L,61L,62L,123L,64L,65L,66L,131L,68L,69L,70L,139L,72L,73L,74L,147L,76L,77L,78L,155L,80L,81L,82L,163L,84L,85L,86L,171L,88L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222258Inst : IEnumerable<long>
{
public static readonly long[] Value=A222258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222258.Bytes);
public long this[int i]=>Value[i];

public static A222258Inst Instance=new A222258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222259
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,12L,9L,10L,11L,20L,13L,14L,15L,28L,17L,18L,19L,36L,21L,22L,23L,44L,25L,26L,27L,52L,29L,30L,31L,60L,33L,34L,35L,68L,37L,38L,39L,76L,41L,42L,43L,84L,45L,46L,47L,92L,49L,50L,51L,100L,53L,54L,55L,108L,57L,58L,59L,116L,61L,62L,63L,124L,65L,66L,67L,132L,69L,70L,71L,140L,73L,74L,75L,148L,77L,78L,79L,156L,81L,82L,83L,164L,85L,86L,87L,172L,89L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222259Inst : IEnumerable<long>
{
public static readonly long[] Value=A222259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222259.Bytes);
public long this[int i]=>Value[i];

public static A222259Inst Instance=new A222259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222260
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,14L,10L,11L,12L,13L,24L,15L,16L,17L,18L,34L,20L,21L,22L,23L,44L,25L,26L,27L,28L,54L,30L,31L,32L,33L,64L,35L,36L,37L,38L,74L,40L,41L,42L,43L,84L,45L,46L,47L,48L,94L,50L,51L,52L,53L,104L,55L,56L,57L,58L,114L,60L,61L,62L,63L,124L,65L,66L,67L,68L,134L,70L,71L,72L,73L,144L,75L,76L,77L,78L,154L,80L,81L,82L,83L,164L,85L,86L,87L,88L,174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222260Inst : IEnumerable<long>
{
public static readonly long[] Value=A222260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222260.Bytes);
public long this[int i]=>Value[i];

public static A222260Inst Instance=new A222260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222261
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,15L,11L,12L,13L,14L,25L,16L,17L,18L,19L,35L,21L,22L,23L,24L,45L,26L,27L,28L,29L,55L,31L,32L,33L,34L,65L,36L,37L,38L,39L,75L,41L,42L,43L,44L,85L,46L,47L,48L,49L,95L,51L,52L,53L,54L,105L,56L,57L,58L,59L,115L,61L,62L,63L,64L,125L,66L,67L,68L,69L,135L,71L,72L,73L,74L,145L,76L,77L,78L,79L,155L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222261Inst : IEnumerable<long>
{
public static readonly long[] Value=A222261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222261.Bytes);
public long this[int i]=>Value[i];

public static A222261Inst Instance=new A222261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222262
{
public static readonly long[] Value={ 1L,3L,7L,9L,11L,13L,19L,21L,33L,39L,49L,57L,61L,63L,77L,91L,99L,117L,121L,133L,143L,147L,169L,171L,183L,209L,231L,247L,273L,361L,363L,399L,427L,429L,441L,507L,539L,549L,627L,637L,671L,693L,741L,793L,819L,847L,931L,1001L,1083L,1089L,1159L,1183L,1197L,1281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222262Inst : IEnumerable<long>
{
public static readonly long[] Value=A222262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222262.Bytes);
public long this[int i]=>Value[i];

public static A222262Inst Instance=new A222262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222263
{
public static readonly long[] Value={ 1L,3L,15L,135L,315L,585L,819L,1155L,1365L,1485L,2295L,4455L,9009L,9405L,9945L,11115L,13923L,13965L,16965L,33705L,34335L,40365L,43785L,43875L,63063L,63855L,84825L,90675L,106425L,108927L,130815L,209385L,236115L,262845L,387387L,396495L,397575L,449295L,483945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222263Inst : IEnumerable<long>
{
public static readonly long[] Value=A222263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222263.Bytes);
public long this[int i]=>Value[i];

public static A222263Inst Instance=new A222263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222264
{
public static readonly long[] Value={ 1L,2L,3L,4L,8L,10L,14L,15L,16L,32L,44L,64L,110L,128L,135L,136L,152L,182L,184L,190L,248L,256L,315L,512L,585L,752L,819L,884L,1012L,1024L,1155L,1365L,1485L,1550L,1892L,2048L,2144L,2272L,2295L,2528L,4064L,4096L,4455L,6490L,7030L,8192L,8384L,8648L,9009L,9405L,9945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222264Inst : IEnumerable<long>
{
public static readonly long[] Value=A222264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222264.Bytes);
public long this[int i]=>Value[i];

public static A222264Inst Instance=new A222264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222265
{
public static readonly long[] Value={ 7L,31L,103L,223L,503L,1171L,1973L,4111L,4729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222265Inst : IEnumerable<long>
{
public static readonly long[] Value=A222265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222265.Bytes);
public long this[int i]=>Value[i];

public static A222265Inst Instance=new A222265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222266
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,4L,1L,5L,1L,2L,3L,6L,1L,7L,1L,2L,4L,8L,1L,9L,1L,2L,5L,10L,1L,11L,1L,3L,4L,12L,1L,13L,1L,2L,7L,14L,1L,3L,5L,15L,1L,2L,8L,16L,1L,17L,1L,2L,9L,18L,1L,19L,1L,4L,5L,20L,1L,3L,7L,21L,1L,2L,11L,22L,1L,23L,1L,2L,3L,4L,6L,8L,12L,24L,1L,25L,1L,2L,13L,26L,1L,3L,9L,27L,1L,4L,7L,28L,1L,29L,1L,2L,3L,5L,6L,10L,15L,30L,1L,31L,1L,2L,4L,8L,16L,32L,1L,3L,11L,33L,1L,2L,17L,34L,1L,5L,7L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222266Inst : IEnumerable<long>
{
public static readonly long[] Value=A222266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222266.Bytes);
public long this[int i]=>Value[i];

public static A222266Inst Instance=new A222266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222267
{
public static readonly long[] Value={ 28L,253L,1492L,5485L,17092L,41905L,95140L,191773L,364420L,638785L,1085500L,1745389L,2743084L,4136257L,6101740L,8747821L,12377764L,17066737L,23287564L,31174813L,41276548L,53767873L,69544324L,88722973L,112450132L,140859361L,175324636L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222267Inst : IEnumerable<long>
{
public static readonly long[] Value=A222267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222267.Bytes);
public long this[int i]=>Value[i];

public static A222267Inst Instance=new A222267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222268
{
public static readonly long[] Value={ 15L,649L,13307L,107201L,719981L,2912939L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222268Inst : IEnumerable<long>
{
public static readonly long[] Value=A222268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222268.Bytes);
public long this[int i]=>Value[i];

public static A222268Inst Instance=new A222268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222269
{
public static readonly long[] Value={ 1L,0L,0L,3L,4L,8L,10L,55L,72L,294L,378L,1883L,2440L,11920L,15408L,78255L,101330L,517050L,669658L,3451712L,4473984L,23156964L,30030364L,156076271L,202510224L,1055435486L,1370043450L,7157673375L,9295027344L,48656943008L,63208940422L,331450961443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222269Inst : IEnumerable<long>
{
public static readonly long[] Value=A222269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222269.Bytes);
public long this[int i]=>Value[i];

public static A222269Inst Instance=new A222269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222270
{
public static readonly long[] Value={ 0L,0L,4L,13L,40L,162L,888L,3617L,18136L,81560L,407644L,1901375L,9349056L,44712494L,218395880L,1057844425L,5154076928L,25146813236L,122532346416L,600293886818L,2928771248408L,14383619678744L,70298507431888L,345790800489643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222270Inst : IEnumerable<long>
{
public static readonly long[] Value=A222270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222270.Bytes);
public long this[int i]=>Value[i];

public static A222270Inst Instance=new A222270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222271
{
public static readonly long[] Value={ 0L,4L,4L,81L,364L,5996L,27980L,507909L,2380692L,44501178L,208717216L,3948025953L,18510211252L,352744650956L,1653908717680L,31689827693324L,148654828631998L,2860214905912758L,13427178703144724L,259196177077920492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222271Inst : IEnumerable<long>
{
public static readonly long[] Value=A222271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222271.Bytes);
public long this[int i]=>Value[i];

public static A222271Inst Instance=new A222271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222272
{
public static readonly BigInteger[] Value={ 3L,13L,81L,1042L,15309L,259827L,4721919L,86605540L,1596666209L,29636427761L,549614164013L,10257852048210L,190742396582721L,3570677543208821L,66567622846173385L,1248868982288193670L,BigInteger.Parse("23339378621029149099") };
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
public class A222272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222272Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222272.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222272Inst Instance=new A222272Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222273
{
public static readonly BigInteger[] Value={ 4L,40L,364L,15309L,204555L,12855928L,216228179L,15688878354L,283068206603L,21098476001644L,385931333870127L,28983257047817242L,532423461945542041L,BigInteger.Parse("40098523259553204426"),BigInteger.Parse("737871045332271072405"),BigInteger.Parse("55677626294569362982028") };
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
public class A222273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222273Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222273.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222273Inst Instance=new A222273Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222274
{
public static readonly long[] Value={ 8L,162L,5996L,259827L,12855928L,725139202L,46568936746L,3151092032773L,224016540173624L,16180093454621940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222274Inst : IEnumerable<long>
{
public static readonly long[] Value=A222274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222274.Bytes);
public long this[int i]=>Value[i];

public static A222274Inst Instance=new A222274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222275
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,3L,4L,4L,3L,4L,13L,4L,13L,4L,8L,40L,81L,81L,40L,8L,10L,162L,364L,1042L,364L,162L,10L,55L,888L,5996L,15309L,15309L,5996L,888L,55L,72L,3617L,27980L,259827L,204555L,259827L,27980L,3617L,72L,294L,18136L,507909L,4721919L,12855928L,12855928L,4721919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222275Inst : IEnumerable<long>
{
public static readonly long[] Value=A222275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222275.Bytes);
public long this[int i]=>Value[i];

public static A222275Inst Instance=new A222275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222276
{
public static readonly BigInteger[] Value={ 25L,2205L,194485L,17153945L,1513010465L,133450391205L,11770577485085L,1038187247574145L,91570083319317865L,8076654937439905005L,BigInteger.Parse("712376276332499775685"),BigInteger.Parse("62832938018547611186345"),BigInteger.Parse("5541984245134992804289265") };
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
public class A222276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222276Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222276.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222276Inst Instance=new A222276Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222277
{
public static readonly BigInteger[] Value={ 125L,46305L,17153945L,6354787485L,2354171487645L,872117822449905L,323081602357856985L,BigInteger.Parse("119687637492011211885"),BigInteger.Parse("44339047670574481807485"),BigInteger.Parse("16425682631297501047982145"),BigInteger.Parse("6084998755694142903356375385") };
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
public class A222277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222277Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222277.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222277Inst Instance=new A222277Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222278
{
public static readonly BigInteger[] Value={ 625L,972405L,1513010465L,2354171487645L,3662978221194885L,5699418948690910545L,BigInteger.Parse("8868023343395876315745"),BigInteger.Parse("13798220262404977892742445"),BigInteger.Parse("21469370911390982766132649045"),BigInteger.Parse("33405314494566540518963638820105") };
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
public class A222278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222278Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222278.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222278Inst Instance=new A222278Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222279
{
public static readonly BigInteger[] Value={ 3125L,20420505L,133450391205L,872117822449905L,5699418948690910545L,BigInteger.Parse("37246546285522069805565"),BigInteger.Parse("243411692308741298296892325"),BigInteger.Parse("1590731433240496702463084026185"),BigInteger.Parse("10395665338455031917089762271340425") };
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
public class A222279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222279Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222279.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222279Inst Instance=new A222279Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222280
{
public static readonly BigInteger[] Value={ 15625L,428830605L,11770577485085L,323081602357856985L,BigInteger.Parse("8868023343395876315745"),BigInteger.Parse("243411692308741298296892325"),BigInteger.Parse("6681224184095576349599961437005"),BigInteger.Parse("183387889786149096233229076843262145") };
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
public class A222280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222280Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222280.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222280Inst Instance=new A222280Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222281
{
public static readonly long[] Value={ 1L,5L,5L,25L,105L,25L,125L,2205L,2205L,125L,625L,46305L,194485L,46305L,625L,3125L,972405L,17153945L,17153945L,972405L,3125L,15625L,20420505L,1513010465L,6354787485L,1513010465L,20420505L,15625L,78125L,428830605L,133450391205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222281Inst : IEnumerable<long>
{
public static readonly long[] Value=A222281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222281.Bytes);
public long this[int i]=>Value[i];

public static A222281Inst Instance=new A222281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222282
{
public static readonly long[] Value={ 1L,0L,4L,208L,6582L,1249354L,262048125L,288902941734L,350421368609396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222282Inst : IEnumerable<long>
{
public static readonly long[] Value=A222282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222282.Bytes);
public long this[int i]=>Value[i];

public static A222282Inst Instance=new A222282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222283
{
public static readonly long[] Value={ 1L,0L,0L,3L,4L,4L,5L,20L,27L,48L,63L,175L,236L,512L,684L,1719L,2320L,5400L,7271L,17776L,24036L,57420L,77636L,188656L,255591L,617176L,836595L,2033175L,2759184L,6697744L,9094949L,22139780L,30086955L,73262232L,99615081L,242931321L,330503120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222283Inst : IEnumerable<long>
{
public static readonly long[] Value=A222283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222283.Bytes);
public long this[int i]=>Value[i];

public static A222283Inst Instance=new A222283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222284
{
public static readonly long[] Value={ 0L,0L,4L,11L,8L,44L,144L,352L,692L,2488L,6476L,17095L,43308L,131488L,340000L,939959L,2520616L,7194232L,19142160L,53471296L,145636612L,407743540L,1107902624L,3092203004L,8488056840L,23644607144L,64986279340L,181063135999L,499746197884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222284Inst : IEnumerable<long>
{
public static readonly long[] Value=A222284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222284.Bytes);
public long this[int i]=>Value[i];

public static A222284Inst Instance=new A222284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222285
{
public static readonly long[] Value={ 0L,4L,4L,35L,83L,532L,1427L,8540L,23798L,143594L,405187L,2455279L,6993039L,42590466L,121981025L,745909396L,2145554406L,13161790760L,37983541068L,233613349710L,675981684148L,4166412530876L,12082238135283L,74601934076542L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222285Inst : IEnumerable<long>
{
public static readonly long[] Value=A222285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222285.Bytes);
public long this[int i]=>Value[i];

public static A222285Inst Instance=new A222285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222286
{
public static readonly long[] Value={ 3L,11L,35L,208L,1125L,6619L,40321L,250681L,1569385L,9860229L,62350467L,395971584L,2523482587L,16126203359L,103311906743L,663339238220L,4267302505247L,27498492193747L,177468748791963L,1146905501859999L,7421110682709531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222286Inst : IEnumerable<long>
{
public static readonly long[] Value=A222286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222286.Bytes);
public long this[int i]=>Value[i];

public static A222286Inst Instance=new A222286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222287
{
public static readonly long[] Value={ 4L,8L,83L,1125L,6582L,89852L,564838L,7879795L,50958999L,723447048L,4750196831L,67994171066L,451003258750L,6495868727212L,43379306929941L,627562261878355L,4211483429644946L,61133435798313074L,411800332378830207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222287Inst : IEnumerable<long>
{
public static readonly long[] Value=A222287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222287.Bytes);
public long this[int i]=>Value[i];

public static A222287Inst Instance=new A222287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222288
{
public static readonly ulong[] Value={ 4L,44L,532L,6619L,89852L,1249354L,17801910L,256986006L,3744123550L,55066210090L,815041154350L,12128319606229L,181260757915998L,2718723553039248L,40900893166050078L,616897705864541974L,9325074227006211226UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222288Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A222288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222288.Bytes);
public ulong this[int i]=>Value[i];

public static A222288Inst Instance=new A222288Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222289
{
public static readonly BigInteger[] Value={ 5L,144L,1427L,40321L,564838L,17801910L,262048125L,8550246097L,129184703815L,4294346570524L,66002018148195L,2218403489369930L,34478463977532598L,1167416501197133512L,18284642742630658357UL,BigInteger.Parse("622321211264493492467") };
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
public class A222289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222289Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222289.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222289Inst Instance=new A222289Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222290
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,3L,4L,4L,3L,4L,11L,4L,11L,4L,4L,8L,35L,35L,8L,4L,5L,44L,83L,208L,83L,44L,5L,20L,144L,532L,1125L,1125L,532L,144L,20L,27L,352L,1427L,6619L,6582L,6619L,1427L,352L,27L,48L,692L,8540L,40321L,89852L,89852L,40321L,8540L,692L,48L,63L,2488L,23798L,250681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222290Inst : IEnumerable<long>
{
public static readonly long[] Value=A222290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222290.Bytes);
public long this[int i]=>Value[i];

public static A222290Inst Instance=new A222290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222291
{
public static readonly long[] Value={ 1L,3L,15L,27L,255L,703L,1819L,9663L,26623L,77671L,159487L,1212415L,4637979L,6631675L,19638399L,80049391L,319804831L,319804831L,319804831L,8528817511L,59436135663L,231913730799L,272025660543L,871673828443L,3716509988199L,3716509988199L,3716509988199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222291Inst : IEnumerable<long>
{
public static readonly long[] Value=A222291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222291.Bytes);
public long this[int i]=>Value[i];

public static A222291Inst Instance=new A222291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222292
{
public static readonly long[] Value={ 1L,3L,3L,3L,3L,7L,15L,15L,27L,27L,27L,27L,27L,27L,447L,447L,703L,703L,1819L,1819L,1819L,4255L,4255L,9663L,9663L,20895L,26623L,60975L,60975L,60975L,77671L,113383L,159487L,159487L,159487L,665215L,1042431L,1212415L,2684647L,3041127L,4637979L,5656191L,6416623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222292Inst : IEnumerable<long>
{
public static readonly long[] Value=A222292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222292.Bytes);
public long this[int i]=>Value[i];

public static A222292Inst Instance=new A222292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222293
{
public static readonly long[] Value={ 37L,30L,34L,30L,31L,29L,28L,38L,42L,32L,40L,40L,49L,30L,40L,40L,54L,45L,46L,40L,49L,44L,41L,48L,47L,54L,48L,41L,50L,44L,54L,45L,49L,60L,53L,47L,54L,50L,56L,44L,48L,50L,54L,47L,54L,38L,56L,47L,60L,48L,63L,48L,47L,45L,56L,53L,49L,49L,62L,52L,50L,54L,53L,52L,49L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222293Inst : IEnumerable<long>
{
public static readonly long[] Value=A222293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222293.Bytes);
public long this[int i]=>Value[i];

public static A222293Inst Instance=new A222293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222294
{
public static readonly long[] Value={ 2L,3L,3L,7L,7L,7L,7L,19L,15L,19L,27L,37L,27L,43L,27L,15L,39L,27L,39L,27L,73L,27L,27L,27L,63L,39L,27L,27L,109L,75L,127L,87L,27L,123L,99L,151L,123L,163L,27L,115L,79L,27L,127L,171L,87L,199L,187L,223L,151L,135L,27L,159L,241L,27L,171L,27L,79L,271L,277L,187L,27L,27L,307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222294Inst : IEnumerable<long>
{
public static readonly long[] Value=A222294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222294.Bytes);
public long this[int i]=>Value[i];

public static A222294Inst Instance=new A222294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222295
{
public static readonly long[] Value={ 1L,4L,4L,2L,3L,3L,4L,1L,4L,2L,1L,5L,5L,2L,2L,2L,5L,4L,3L,2L,2L,2L,3L,5L,3L,3L,2L,4L,2L,1L,4L,3L,2L,3L,3L,1L,6L,3L,2L,3L,3L,4L,4L,5L,0L,0L,3L,3L,2L,2L,5L,4L,3L,1L,5L,2L,2L,2L,5L,7L,3L,0L,0L,1L,2L,7L,3L,3L,2L,4L,3L,1L,2L,4L,4L,2L,0L,3L,1L,3L,7L,3L,4L,1L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222295Inst : IEnumerable<long>
{
public static readonly long[] Value=A222295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222295.Bytes);
public long this[int i]=>Value[i];

public static A222295Inst Instance=new A222295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222296
{
public static readonly long[] Value={ 0L,1L,1L,2L,8L,3L,5L,34L,144L,13L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222296Inst : IEnumerable<long>
{
public static readonly long[] Value=A222296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222296.Bytes);
public long this[int i]=>Value[i];

public static A222296Inst Instance=new A222296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222297
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,10L,16L,6L,7L,11L,13L,17L,20L,22L,26L,34L,40L,52L,9L,14L,28L,12L,15L,23L,35L,46L,53L,70L,80L,106L,160L,18L,19L,29L,44L,58L,88L,21L,32L,64L,24L,25L,38L,76L,27L,31L,41L,47L,61L,62L,71L,82L,91L,92L,94L,103L,107L,121L,122L,124L,137L,142L,155L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222297Inst : IEnumerable<long>
{
public static readonly long[] Value=A222297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222297.Bytes);
public long this[int i]=>Value[i];

public static A222297Inst Instance=new A222297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222298
{
public static readonly long[] Value={ 12L,12L,260L,12L,236L,28L,28L,28L,28L,236L,20L,44L,44L,20L,20L,36L,76L,12L,12L,4L,12L,4L,36L,36L,36L,3276L,76L,36L,36L,3276L,84L,20L,12L,12L,20L,36L,36L,2444L,2444L,36L,44L,1356L,156L,28L,12L,220L,12L,12L,84L,12L,132L,28L,68L,36L,36L,1044L,20L,20L,28L,1044L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222298Inst : IEnumerable<long>
{
public static readonly long[] Value=A222298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222298.Bytes);
public long this[int i]=>Value[i];

public static A222298Inst Instance=new A222298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222299
{
public static readonly long[] Value={ 8L,10L,172L,12L,168L,19L,19L,21L,21L,168L,14L,37L,37L,14L,18L,30L,68L,10L,10L,4L,10L,4L,29L,29L,32L,2484L,58L,30L,32L,2484L,76L,16L,10L,10L,18L,23L,23L,1861L,1861L,30L,34L,958L,126L,22L,10L,182L,10L,10L,74L,10L,112L,26L,48L,29L,29L,774L,13L,13L,26L,774L,18L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222299Inst : IEnumerable<long>
{
public static readonly long[] Value=A222299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222299.Bytes);
public long this[int i]=>Value[i];

public static A222299Inst Instance=new A222299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222300
{
public static readonly long[] Value={ 32L,48L,1316L,72L,1536L,168L,168L,152L,152L,1536L,140L,352L,352L,132L,172L,280L,648L,132L,92L,12L,96L,32L,332L,332L,460L,30492L,652L,328L,460L,30492L,748L,236L,64L,112L,204L,336L,336L,24560L,24560L,448L,440L,13016L,1536L,316L,108L,2224L,132L,116L,864L,80L,1128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222300Inst : IEnumerable<long>
{
public static readonly long[] Value=A222300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222300.Bytes);
public long this[int i]=>Value[i];

public static A222300Inst Instance=new A222300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222301
{
public static readonly long[] Value={ 1L,8L,4L,2L,4L,8L,16L,8L,8L,4L,8L,8L,8L,2L,16L,16L,8L,16L,8L,8L,4L,16L,4L,8L,8L,8L,16L,8L,8L,16L,16L,16L,16L,2L,24L,8L,8L,8L,8L,16L,8L,8L,16L,16L,16L,24L,4L,8L,8L,16L,8L,16L,16L,8L,4L,16L,16L,16L,8L,16L,8L,8L,16L,24L,16L,8L,16L,8L,8L,2L,16L,16L,16L,16L,8L,8L,16L,16L,8L,8L,12L,16L,16L,16L,16L,8L,24L,8L,16L,16L,16L,16L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222301Inst : IEnumerable<long>
{
public static readonly long[] Value=A222301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222301.Bytes);
public long this[int i]=>Value[i];

public static A222301Inst Instance=new A222301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222302
{
public static readonly long[] Value={ 0L,1L,0L,4L,0L,4L,1L,4L,9L,0L,1L,0L,4L,16L,9L,4L,16L,1L,16L,9L,0L,1L,0L,25L,4L,16L,9L,0L,4L,16L,25L,4L,9L,36L,1L,0L,25L,16L,36L,4L,16L,36L,1L,25L,16L,9L,0L,36L,0L,25L,4L,9L,36L,49L,0L,4L,16L,1L,4L,49L,0L,36L,1L,25L,4L,16L,9L,36L,49L,64L,16L,36L,1L,25L,64L,16L,9L,49L,64L,1L,0L,16L,9L,36L,49L,0L,4L,64L,1L,25L,4L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222302Inst : IEnumerable<long>
{
public static readonly long[] Value=A222302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222302.Bytes);
public long this[int i]=>Value[i];

public static A222302Inst Instance=new A222302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222303
{
public static readonly long[] Value={ 0L,1L,2L,0L,4L,2L,5L,4L,1L,8L,9L,10L,8L,0L,5L,10L,2L,13L,4L,9L,16L,17L,18L,1L,16L,8L,13L,20L,18L,10L,5L,20L,17L,0L,25L,26L,9L,16L,2L,26L,18L,4L,29L,13L,20L,25L,32L,8L,34L,17L,32L,29L,10L,1L,36L,34L,26L,37L,36L,5L,40L,16L,41L,25L,40L,32L,37L,18L,9L,0L,34L,20L,45L,29L,2L,36L,41L,13L,4L,49L,50L,40L,45L,26L,17L,52L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222303Inst : IEnumerable<long>
{
public static readonly long[] Value=A222303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222303.Bytes);
public long this[int i]=>Value[i];

public static A222303Inst Instance=new A222303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222304
{
public static readonly long[] Value={ 0L,1L,4L,8L,13L,14L,27L,28L,32L,36L,49L,62L,63L,64L,76L,104L,108L,109L,112L,125L,140L,148L,158L,171L,172L,185L,193L,216L,224L,234L,244L,252L,256L,260L,288L,301L,302L,343L,351L,364L,365L,378L,392L,427L,433L,468L,494L,496L,500L,504L,508L,512L,532L,536L,589L,603L,608L,652L,665L,666L,676L,679L,728L,729L,734L,756L,769L,832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222304Inst : IEnumerable<long>
{
public static readonly long[] Value=A222304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222304.Bytes);
public long this[int i]=>Value[i];

public static A222304Inst Instance=new A222304Inst();

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