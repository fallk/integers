using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A153005
{
public static readonly long[] Value={ 7L,31L,127L,211L,487L,571L,643L,811L,1033L,1249L,1663L,1999L,2131L,2179L,2281L,2347L,2467L,3391L,4801L,5059L,6361L,7759L,8191L,8209L,8713L,8779L,8929L,9187L,9343L,9679L,9931L,10687L,13903L,14947L,19009L,19267L,19423L,25057L,26731L,28879L,33289L,35521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153005Inst : IEnumerable<long>
{
public static readonly long[] Value=A153005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153005.Bytes);
public long this[int i]=>Value[i];

public static A153005Inst Instance=new A153005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153006
{
public static readonly long[] Value={ 0L,1L,3L,6L,9L,13L,20L,28L,33L,37L,44L,53L,63L,78L,100L,120L,129L,133L,140L,149L,159L,174L,196L,217L,231L,246L,269L,297L,332L,384L,448L,496L,513L,517L,524L,533L,543L,558L,580L,601L,615L,630L,653L,681L,716L,768L,832L,881L,903L,918L,941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153006Inst : IEnumerable<long>
{
public static readonly long[] Value=A153006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153006.Bytes);
public long this[int i]=>Value[i];

public static A153006Inst Instance=new A153006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153007
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,1L,0L,3L,8L,11L,13L,15L,13L,5L,0L,7L,20L,31L,41L,51L,57L,57L,59L,69L,79L,82L,81L,74L,51L,17L,0L,15L,44L,71L,97L,123L,145L,161L,179L,205L,231L,250L,265L,274L,267L,249L,247L,273L,307L,334L,357L,374L,375L,364L,363L,376L,380L,364L,332L,270L,163L,49L,0L,31L,92L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153007Inst : IEnumerable<long>
{
public static readonly long[] Value=A153007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153007.Bytes);
public long this[int i]=>Value[i];

public static A153007Inst Instance=new A153007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153008
{
public static readonly long[] Value={ 0L,0L,0L,1L,5L,21L,81L,302L,1107L,4027L,14608L,52988L,192501L,701065L,2560806L,9384273L,34504203L,127288011L,471102318L,1749063906L,6513268401L,24323719461L,91081800417L,341929853235L,1286711419527L,4852902998951L,18341683253676L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153008Inst : IEnumerable<long>
{
public static readonly long[] Value=A153008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153008.Bytes);
public long this[int i]=>Value[i];

public static A153008Inst Instance=new A153008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153009
{
public static readonly long[] Value={ 3L,13L,37L,53L,149L,269L,601L,653L,881L,941L,2053L,2069L,2137L,2417L,2477L,2657L,2713L,5281L,9697L,10009L,14561L,14713L,16033L,16693L,19489L,20149L,21617L,22091L,22741L,32789L,32909L,33377L,33529L,34273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153009Inst : IEnumerable<long>
{
public static readonly long[] Value=A153009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153009.Bytes);
public long this[int i]=>Value[i];

public static A153009Inst Instance=new A153009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153010
{
public static readonly long[] Value={ 0L,1L,2L,3L,7L,15L,31L,63L,127L,255L,511L,1023L,2047L,4095L,8191L,16383L,32767L,65535L,131071L,262143L,524287L,1048575L,2097151L,4194303L,8388607L,16777215L,33554431L,67108863L,134217727L,268435455L,536870911L,1073741823L,2147483647L,4294967295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153010Inst : IEnumerable<long>
{
public static readonly long[] Value=A153010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153010.Bytes);
public long this[int i]=>Value[i];

public static A153010Inst Instance=new A153010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153011
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,4L,0L,0L,0L,4L,0L,5L,0L,6L,0L,0L,0L,14L,0L,0L,2L,8L,0L,14L,0L,11L,0L,0L,0L,24L,0L,0L,0L,20L,0L,18L,0L,12L,8L,0L,0L,36L,0L,9L,0L,14L,0L,24L,0L,26L,0L,0L,0L,54L,0L,0L,10L,26L,0L,26L,0L,18L,0L,22L,0L,65L,0L,0L,10L,20L,0L,30L,0L,50L,10L,0L,0L,70L,0L,0L,0L,38L,0L,68L,0L,24L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153011Inst : IEnumerable<long>
{
public static readonly long[] Value=A153011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153011.Bytes);
public long this[int i]=>Value[i];

public static A153011Inst Instance=new A153011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153012
{
public static readonly long[] Value={ 3L,-3L,3L,-2L,-1L,2L,2L,1L,-4L,1L,4L,-4L,-3L,9L,-4L,-5L,4L,4L,0L,-8L,1L,5L,2L,0L,-1L,-5L,2L,-2L,-2L,9L,-3L,3L,-1L,-8L,7L,1L,-3L,1L,3L,-3L,1L,-6L,7L,-1L,-2L,-2L,4L,-1L,3L,-5L,4L,-8L,7L,-4L,-2L,6L,-1L,0L,1L,2L,-2L,-4L,4L,2L,0L,-9L,7L,-4L,-1L,2L,3L,1L,-4L,2L,-4L,-1L,-1L,7L,-7L,3L,5L,0L,-3L,-5L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153012Inst : IEnumerable<long>
{
public static readonly long[] Value=A153012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153012.Bytes);
public long this[int i]=>Value[i];

public static A153012Inst Instance=new A153012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153013
{
public static readonly BigInteger[] Value={ 0L,1L,2L,3L,4L,5L,6L,9L,10L,15L,16L,11L,12L,25L,50L,147L,220L,6125L,1968750L,89142864525L,BigInteger.Parse("84252896510182189218"),BigInteger.Parse("34892570216750728458698250328871491829901861750593684043") };
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
public class A153013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153013Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153013.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153013Inst Instance=new A153013Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153014
{
public static readonly long[] Value={ 2L,3L,5L,7L,37L,127L,131L,211L,257L,421L,467L,491L,751L,761L,1307L,1321L,1367L,1567L,1861L,2081L,2087L,2137L,2287L,2381L,2647L,2707L,2837L,2897L,3221L,3851L,3911L,3947L,4957L,5087L,5501L,5711L,5857L,6011L,6217L,6221L,6361L,6637L,6911L,8707L,8941L,9127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153014Inst : IEnumerable<long>
{
public static readonly long[] Value=A153014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153014.Bytes);
public long this[int i]=>Value[i];

public static A153014Inst Instance=new A153014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153015
{
public static readonly long[] Value={ 4L,4L,2L,1L,1L,4L,1L,0L,8L,6L,9L,7L,7L,4L,0L,3L,1L,3L,6L,1L,7L,9L,1L,1L,8L,3L,7L,9L,2L,4L,2L,2L,8L,7L,9L,3L,7L,9L,0L,4L,1L,1L,3L,2L,4L,8L,0L,7L,0L,5L,3L,8L,6L,4L,0L,5L,4L,6L,0L,7L,9L,9L,3L,1L,8L,3L,4L,4L,6L,9L,8L,9L,5L,1L,9L,0L,6L,4L,8L,8L,1L,8L,3L,8L,6L,0L,5L,5L,6L,5L,2L,9L,9L,2L,7L,3L,7L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153015Inst : IEnumerable<long>
{
public static readonly long[] Value=A153015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153015.Bytes);
public long this[int i]=>Value[i];

public static A153015Inst Instance=new A153015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153016
{
public static readonly long[] Value={ 4L,2L,8L,3L,1L,7L,3L,4L,1L,0L,3L,1L,3L,9L,4L,6L,8L,0L,9L,9L,0L,7L,7L,4L,3L,7L,7L,9L,2L,0L,9L,6L,4L,5L,7L,6L,9L,0L,6L,6L,3L,0L,9L,2L,8L,3L,8L,3L,6L,8L,4L,6L,1L,6L,9L,9L,9L,8L,2L,0L,5L,6L,8L,9L,8L,9L,2L,8L,2L,1L,2L,2L,5L,2L,3L,4L,0L,3L,5L,3L,7L,1L,9L,8L,7L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153016Inst : IEnumerable<long>
{
public static readonly long[] Value=A153016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153016.Bytes);
public long this[int i]=>Value[i];

public static A153016Inst Instance=new A153016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153017
{
public static readonly long[] Value={ 4L,1L,6L,2L,8L,9L,6L,6L,3L,8L,6L,5L,7L,9L,9L,2L,1L,4L,5L,3L,6L,5L,4L,0L,6L,9L,2L,3L,4L,2L,5L,5L,1L,7L,2L,8L,9L,8L,6L,7L,9L,8L,9L,9L,3L,7L,2L,4L,4L,1L,5L,9L,1L,6L,7L,4L,6L,4L,0L,6L,2L,3L,7L,6L,6L,4L,0L,9L,9L,7L,4L,5L,1L,7L,7L,1L,0L,9L,8L,8L,3L,8L,9L,8L,2L,3L,8L,5L,8L,9L,0L,0L,1L,6L,9L,5L,4L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153017Inst : IEnumerable<long>
{
public static readonly long[] Value=A153017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153017.Bytes);
public long this[int i]=>Value[i];

public static A153017Inst Instance=new A153017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153018
{
public static readonly long[] Value={ 4L,0L,5L,6L,8L,3L,8L,7L,1L,0L,8L,2L,2L,1L,2L,8L,9L,4L,3L,8L,2L,9L,0L,4L,9L,9L,6L,6L,0L,1L,3L,9L,2L,5L,2L,9L,4L,9L,9L,8L,6L,7L,7L,7L,8L,2L,6L,6L,2L,8L,0L,4L,2L,7L,4L,2L,6L,3L,4L,7L,0L,2L,6L,1L,8L,1L,1L,7L,1L,1L,7L,3L,2L,8L,9L,0L,7L,2L,7L,9L,6L,3L,8L,0L,6L,1L,4L,7L,9L,1L,1L,1L,3L,5L,5L,4L,2L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153018Inst : IEnumerable<long>
{
public static readonly long[] Value=A153018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153018.Bytes);
public long this[int i]=>Value[i];

public static A153018Inst Instance=new A153018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153019
{
public static readonly long[] Value={ 3L,9L,6L,2L,4L,0L,6L,2L,5L,1L,8L,0L,2L,8L,9L,0L,4L,5L,3L,6L,3L,4L,3L,4L,7L,3L,5L,9L,8L,6L,9L,5L,4L,1L,2L,7L,1L,8L,9L,9L,5L,3L,6L,0L,1L,9L,2L,3L,1L,2L,0L,2L,6L,5L,1L,1L,3L,9L,3L,8L,1L,6L,3L,6L,3L,5L,2L,7L,4L,5L,5L,6L,9L,4L,8L,5L,8L,9L,6L,4L,0L,6L,3L,0L,5L,7L,0L,1L,1L,8L,7L,2L,9L,5L,2L,2L,0L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153019Inst : IEnumerable<long>
{
public static readonly long[] Value=A153019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153019.Bytes);
public long this[int i]=>Value[i];

public static A153019Inst Instance=new A153019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153020
{
public static readonly long[] Value={ 3L,8L,7L,7L,6L,1L,9L,3L,5L,0L,3L,8L,4L,9L,0L,0L,7L,5L,4L,3L,6L,1L,9L,9L,3L,6L,0L,7L,3L,4L,4L,1L,8L,6L,4L,6L,8L,3L,0L,6L,7L,3L,6L,2L,9L,4L,4L,3L,8L,7L,6L,2L,4L,2L,3L,4L,6L,7L,5L,8L,2L,1L,5L,2L,9L,0L,8L,0L,9L,3L,1L,2L,7L,9L,3L,3L,5L,3L,0L,5L,7L,0L,5L,4L,3L,9L,0L,8L,2L,7L,1L,9L,7L,8L,8L,1L,4L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153020Inst : IEnumerable<long>
{
public static readonly long[] Value=A153020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153020.Bytes);
public long this[int i]=>Value[i];

public static A153020Inst Instance=new A153020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153021
{
public static readonly long[] Value={ 3L,8L,0L,0L,9L,3L,7L,6L,6L,7L,1L,5L,9L,3L,4L,2L,7L,7L,6L,3L,2L,1L,5L,7L,9L,1L,7L,5L,4L,4L,7L,3L,8L,4L,6L,9L,1L,1L,5L,9L,1L,1L,0L,3L,4L,9L,9L,0L,4L,6L,4L,7L,1L,7L,0L,1L,0L,6L,7L,7L,5L,4L,9L,6L,4L,2L,5L,4L,3L,5L,4L,7L,1L,2L,8L,4L,0L,5L,2L,2L,7L,5L,7L,4L,6L,7L,2L,1L,7L,9L,2L,5L,9L,9L,2L,9L,4L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153021Inst : IEnumerable<long>
{
public static readonly long[] Value=A153021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153021.Bytes);
public long this[int i]=>Value[i];

public static A153021Inst Instance=new A153021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153022
{
public static readonly long[] Value={ 6L,10L,150L,238L,56824L,665460L,18468766L,193274008L,635705422L,790546908L,33256634229L,66874977806L,68066767730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153022Inst : IEnumerable<long>
{
public static readonly long[] Value=A153022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153022.Bytes);
public long this[int i]=>Value[i];

public static A153022Inst Instance=new A153022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153023
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,5L,7L,5L,3L,7L,11L,5L,13L,3L,5L,3L,17L,7L,19L,7L,7L,13L,23L,5L,5L,5L,5L,5L,29L,41L,31L,41L,3L,19L,5L,7L,37L,7L,3L,7L,41L,53L,43L,3L,41L,5L,47L,-1L,7L,53L,7L,41L,53L,7L,3L,7L,13L,31L,59L,107L,61L,3L,7L,3L,7L,7L,67L,13L,5L,73L,71L,7L,73L,3L,-1L,7L,7L,89L,79L,41L,3L,43L,83L,139L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153023Inst : IEnumerable<long>
{
public static readonly long[] Value=A153023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153023.Bytes);
public long this[int i]=>Value[i];

public static A153023Inst Instance=new A153023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153024
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,3L,2L,2L,1L,5L,1L,3L,4L,4L,1L,5L,1L,4L,3L,2L,1L,7L,2L,5L,6L,7L,1L,2L,1L,3L,4L,2L,6L,8L,1L,4L,5L,3L,1L,2L,1L,6L,4L,3L,1L,-1L,2L,3L,5L,5L,1L,7L,5L,5L,3L,2L,1L,2L,1L,5L,4L,6L,6L,7L,1L,4L,6L,2L,1L,6L,1L,6L,-1L,5L,6L,2L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153024Inst : IEnumerable<long>
{
public static readonly long[] Value=A153024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153024.Bytes);
public long this[int i]=>Value[i];

public static A153024Inst Instance=new A153024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153025
{
public static readonly long[] Value={ 5L,235L,72335L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153025Inst : IEnumerable<long>
{
public static readonly long[] Value=A153025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153025.Bytes);
public long this[int i]=>Value[i];

public static A153025Inst Instance=new A153025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153026
{
public static readonly long[] Value={ 0L,8L,19L,45L,80L,136L,207L,305L,424L,576L,755L,973L,1224L,1520L,1855L,2241L,2672L,3160L,3699L,4301L,4960L,5688L,6479L,7345L,8280L,9296L,10387L,11565L,12824L,14176L,15615L,17153L,18784L,20520L,22355L,24301L,26352L,28520L,30799L,33201L,35720L,38368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153026Inst : IEnumerable<long>
{
public static readonly long[] Value=A153026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153026.Bytes);
public long this[int i]=>Value[i];

public static A153026Inst Instance=new A153026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153027
{
public static readonly long[] Value={ 3L,7L,3L,1L,1L,4L,3L,0L,0L,0L,2L,1L,6L,3L,6L,9L,4L,8L,8L,7L,8L,2L,3L,2L,3L,6L,8L,1L,0L,5L,1L,9L,3L,0L,3L,6L,2L,2L,5L,6L,1L,6L,7L,4L,8L,2L,5L,2L,1L,3L,6L,3L,5L,7L,9L,8L,8L,8L,6L,6L,2L,4L,1L,9L,4L,6L,8L,8L,0L,1L,9L,1L,7L,2L,3L,0L,4L,7L,3L,1L,7L,0L,2L,4L,0L,3L,0L,0L,4L,9L,9L,1L,6L,6L,9L,0L,1L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153027Inst : IEnumerable<long>
{
public static readonly long[] Value=A153027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153027.Bytes);
public long this[int i]=>Value[i];

public static A153027Inst Instance=new A153027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153028
{
public static readonly long[] Value={ 1L,1L,1L,1L,7L,31L,361L,3361L,57121L,873937L,20110861L,446072221L,13230551071L,394398451591L,14556740314117L,554429787469741L,24799106347186081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153028Inst : IEnumerable<long>
{
public static readonly long[] Value=A153028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153028.Bytes);
public long this[int i]=>Value[i];

public static A153028Inst Instance=new A153028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153029
{
public static readonly ulong[] Value={ 1L,1L,1L,1L,1L,16L,91L,2679L,38641L,1787941L,49219381L,3272794719L,147764521081L,13316891432131L,897003497620231L,105118238883221315L,9899589649059976321UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153029Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A153029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153029.Bytes);
public ulong this[int i]=>Value[i];

public static A153029Inst Instance=new A153029Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153030
{
public static readonly long[] Value={ 3L,7L,8L,12L,17L,19L,20L,21L,22L,23L,24L,27L,29L,33L,34L,35L,36L,37L,42L,51L,53L,54L,55L,58L,60L,61L,64L,66L,68L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,82L,83L,84L,85L,86L,88L,89L,90L,93L,94L,98L,99L,102L,103L,105L,106L,107L,108L,109L,113L,114L,115L,117L,118L,119L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153030Inst : IEnumerable<long>
{
public static readonly long[] Value=A153030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153030.Bytes);
public long this[int i]=>Value[i];

public static A153030Inst Instance=new A153030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153031
{
public static readonly long[] Value={ 1L,5L,7L,9L,10L,11L,14L,16L,17L,18L,22L,25L,26L,28L,29L,30L,32L,34L,40L,44L,47L,48L,49L,52L,54L,57L,62L,64L,65L,67L,74L,77L,84L,87L,90L,91L,92L,94L,97L,100L,103L,110L,112L,113L,115L,116L,121L,124L,131L,132L,134L,136L,137L,138L,140L,141L,142L,143L,144L,150L,157L,159L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153031Inst : IEnumerable<long>
{
public static readonly long[] Value=A153031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153031.Bytes);
public long this[int i]=>Value[i];

public static A153031Inst Instance=new A153031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153032
{
public static readonly long[] Value={ 1L,6L,8L,10L,13L,15L,16L,18L,21L,23L,25L,26L,28L,31L,33L,39L,42L,43L,44L,45L,46L,47L,51L,55L,56L,59L,63L,65L,66L,70L,72L,73L,76L,78L,80L,81L,83L,86L,87L,92L,98L,99L,101L,107L,109L,112L,116L,117L,118L,119L,122L,123L,124L,128L,129L,130L,133L,138L,143L,145L,147L,160L,165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153032Inst : IEnumerable<long>
{
public static readonly long[] Value=A153032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153032.Bytes);
public long this[int i]=>Value[i];

public static A153032Inst Instance=new A153032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153033
{
public static readonly long[] Value={ 3L,6L,7L,11L,13L,14L,15L,22L,23L,26L,27L,29L,30L,31L,43L,45L,46L,47L,53L,54L,55L,58L,59L,61L,62L,63L,86L,87L,90L,91L,93L,94L,95L,106L,107L,109L,110L,111L,117L,118L,119L,122L,123L,125L,126L,127L,171L,173L,174L,175L,181L,182L,183L,186L,187L,189L,190L,191L,213L,214L,215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153033Inst : IEnumerable<long>
{
public static readonly long[] Value=A153033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153033.Bytes);
public long this[int i]=>Value[i];

public static A153033Inst Instance=new A153033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153034
{
public static readonly long[] Value={ 4L,8L,9L,16L,17L,18L,20L,32L,33L,34L,36L,37L,40L,41L,64L,65L,66L,68L,69L,72L,73L,74L,80L,81L,82L,84L,128L,129L,130L,132L,133L,136L,137L,138L,144L,145L,146L,148L,149L,160L,161L,162L,164L,165L,168L,169L,256L,257L,258L,260L,261L,264L,265L,266L,272L,273L,274L,276L,277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153034Inst : IEnumerable<long>
{
public static readonly long[] Value=A153034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153034.Bytes);
public long this[int i]=>Value[i];

public static A153034Inst Instance=new A153034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153035
{
public static readonly long[] Value={ 3L,6L,6L,7L,2L,5L,7L,9L,1L,3L,4L,2L,0L,8L,4L,6L,2L,8L,9L,1L,2L,8L,0L,7L,1L,4L,2L,6L,5L,9L,3L,3L,2L,6L,5L,3L,5L,9L,5L,7L,6L,8L,4L,3L,0L,9L,3L,2L,3L,3L,2L,0L,6L,8L,2L,8L,8L,9L,8L,7L,5L,7L,7L,2L,7L,4L,9L,4L,6L,6L,9L,6L,9L,3L,1L,5L,6L,9L,1L,0L,9L,3L,7L,8L,8L,0L,5L,9L,3L,7L,7L,8L,4L,4L,0L,6L,4L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153035Inst : IEnumerable<long>
{
public static readonly long[] Value=A153035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153035.Bytes);
public long this[int i]=>Value[i];

public static A153035Inst Instance=new A153035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153036
{
public static readonly long[] Value={ 1L,0L,2L,0L,0L,1L,3L,0L,0L,0L,0L,1L,1L,2L,4L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,2L,2L,3L,5L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,4L,6L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153036Inst : IEnumerable<long>
{
public static readonly long[] Value=A153036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153036.Bytes);
public long this[int i]=>Value[i];

public static A153036Inst Instance=new A153036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153037
{
public static readonly long[] Value={ 23L,41L,63L,89L,119L,153L,191L,233L,279L,329L,383L,441L,503L,569L,639L,713L,791L,873L,959L,1049L,1143L,1241L,1343L,1449L,1559L,1673L,1791L,1913L,2039L,2169L,2303L,2441L,2583L,2729L,2879L,3033L,3191L,3353L,3519L,3689L,3863L,4041L,4223L,4409L,4599L,4793L,4991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153037Inst : IEnumerable<long>
{
public static readonly long[] Value=A153037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153037.Bytes);
public long this[int i]=>Value[i];

public static A153037Inst Instance=new A153037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153038
{
public static readonly long[] Value={ 1L,-1L,-2L,3L,-4L,2L,-6L,-21L,16L,4L,-10L,-6L,-12L,6L,8L,315L,-16L,-16L,-18L,-12L,12L,10L,-22L,42L,96L,12L,-416L,-18L,-28L,-8L,-30L,-9765L,20L,16L,24L,48L,-36L,18L,24L,84L,-40L,-12L,-42L,-30L,-64L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153038Inst : IEnumerable<long>
{
public static readonly long[] Value=A153038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153038.Bytes);
public long this[int i]=>Value[i];

public static A153038Inst Instance=new A153038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153039
{
public static readonly long[] Value={ 8L,11L,14L,16L,17L,20L,21L,23L,26L,28L,29L,31L,32L,35L,36L,38L,41L,42L,44L,46L,47L,49L,50L,51L,53L,56L,59L,61L,62L,63L,64L,65L,66L,68L,70L,71L,74L,75L,76L,77L,80L,81L,83L,84L,86L,88L,89L,91L,92L,95L,96L,97L,98L,101L,104L,105L,106L,107L,108L,110L,111L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153039Inst : IEnumerable<long>
{
public static readonly long[] Value=A153039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153039.Bytes);
public long this[int i]=>Value[i];

public static A153039Inst Instance=new A153039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153040
{
public static readonly long[] Value={ 7L,10L,13L,15L,16L,19L,20L,22L,25L,27L,28L,30L,31L,34L,35L,37L,40L,41L,43L,45L,46L,48L,49L,50L,52L,55L,58L,60L,61L,62L,63L,64L,65L,67L,69L,70L,73L,74L,75L,76L,79L,80L,82L,83L,85L,87L,88L,90L,91L,94L,95L,96L,97L,100L,103L,104L,105L,106L,107L,109L,110L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153040Inst : IEnumerable<long>
{
public static readonly long[] Value=A153040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153040.Bytes);
public long this[int i]=>Value[i];

public static A153040Inst Instance=new A153040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153041
{
public static readonly long[] Value={ 10L,14L,17L,20L,22L,23L,26L,27L,29L,32L,34L,35L,37L,38L,41L,42L,44L,47L,48L,50L,52L,53L,55L,56L,57L,59L,62L,65L,67L,68L,69L,70L,71L,72L,74L,76L,77L,80L,81L,82L,83L,86L,87L,89L,90L,92L,94L,95L,97L,98L,101L,102L,103L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153041Inst : IEnumerable<long>
{
public static readonly long[] Value=A153041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153041.Bytes);
public long this[int i]=>Value[i];

public static A153041Inst Instance=new A153041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153042
{
public static readonly long[] Value={ 1L,7L,4L,8L,8L,2L,8L,6L,3L,7L,3L,6L,6L,1L,7L,8L,5L,8L,9L,7L,2L,8L,7L,7L,5L,3L,8L,3L,9L,8L,9L,8L,7L,2L,7L,1L,7L,1L,1L,6L,3L,2L,9L,2L,2L,2L,7L,7L,3L,7L,3L,0L,0L,3L,1L,8L,6L,7L,8L,4L,5L,6L,2L,5L,2L,2L,3L,0L,3L,8L,5L,9L,7L,9L,0L,3L,6L,3L,3L,8L,0L,8L,0L,0L,2L,5L,0L,1L,1L,2L,2L,6L,9L,1L,2L,2L,1L,1L,9L,1L,8L,8L,5L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153042Inst : IEnumerable<long>
{
public static readonly long[] Value=A153042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153042.Bytes);
public long this[int i]=>Value[i];

public static A153042Inst Instance=new A153042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153043
{
public static readonly long[] Value={ 2L,6L,9L,12L,14L,15L,18L,19L,21L,24L,26L,27L,29L,30L,33L,34L,36L,39L,40L,42L,44L,45L,47L,48L,49L,51L,54L,57L,59L,60L,61L,62L,63L,64L,66L,68L,69L,72L,73L,74L,75L,78L,79L,81L,82L,84L,86L,87L,89L,90L,93L,94L,95L,96L,99L,102L,103L,104L,105L,106L,108L,109L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153043Inst : IEnumerable<long>
{
public static readonly long[] Value=A153043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153043.Bytes);
public long this[int i]=>Value[i];

public static A153043Inst Instance=new A153043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153044
{
public static readonly long[] Value={ 5L,9L,12L,15L,17L,18L,21L,22L,24L,27L,29L,30L,32L,33L,36L,37L,39L,42L,43L,45L,47L,48L,50L,51L,52L,54L,57L,60L,62L,63L,64L,65L,66L,67L,69L,71L,72L,75L,76L,77L,78L,81L,82L,84L,85L,87L,89L,90L,92L,93L,96L,97L,98L,99L,102L,105L,106L,107L,108L,109L,111L,112L,113L,114L,115L,117L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153044Inst : IEnumerable<long>
{
public static readonly long[] Value=A153044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153044.Bytes);
public long this[int i]=>Value[i];

public static A153044Inst Instance=new A153044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153045
{
public static readonly long[] Value={ 10L,13L,16L,18L,19L,22L,23L,25L,28L,30L,31L,33L,34L,37L,38L,40L,43L,44L,46L,48L,49L,51L,52L,53L,55L,58L,61L,63L,64L,65L,66L,67L,68L,70L,72L,73L,76L,77L,78L,79L,82L,83L,85L,86L,88L,90L,91L,93L,94L,97L,98L,99L,100L,103L,106L,107L,108L,109L,110L,112L,113L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153045Inst : IEnumerable<long>
{
public static readonly long[] Value=A153045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153045.Bytes);
public long this[int i]=>Value[i];

public static A153045Inst Instance=new A153045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153046
{
public static readonly BigInteger[] Value={ 2L,6L,30L,3150L,6063750L,1717605545906250L,BigInteger.Parse("2623719141408662719128738281250"),BigInteger.Parse("1019408754706474658106933474548666805595768826381331909476074218750") };
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
public class A153046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153046Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153046.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153046Inst Instance=new A153046Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153047
{
public static readonly long[] Value={ 12L,15L,18L,20L,21L,24L,25L,27L,30L,32L,33L,35L,36L,39L,40L,42L,45L,46L,48L,50L,51L,53L,54L,55L,57L,60L,63L,65L,66L,67L,68L,69L,70L,72L,74L,75L,78L,79L,80L,81L,84L,85L,87L,88L,90L,92L,93L,95L,96L,99L,100L,101L,102L,105L,108L,109L,110L,111L,112L,114L,115L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153047Inst : IEnumerable<long>
{
public static readonly long[] Value=A153047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153047.Bytes);
public long this[int i]=>Value[i];

public static A153047Inst Instance=new A153047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153048
{
public static readonly long[] Value={ 319L,337L,357L,363L,371L,387L,409L,447L,591L,663L,681L,701L,801L,827L,893L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153048Inst : IEnumerable<long>
{
public static readonly long[] Value=A153048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153048.Bytes);
public long this[int i]=>Value[i];

public static A153048Inst Instance=new A153048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153049
{
public static readonly long[] Value={ 7L,11L,14L,17L,19L,20L,23L,24L,26L,29L,31L,32L,34L,35L,38L,39L,41L,44L,45L,47L,49L,50L,52L,53L,54L,56L,59L,62L,64L,65L,66L,67L,68L,69L,71L,73L,74L,77L,78L,79L,80L,83L,84L,86L,87L,89L,91L,92L,94L,95L,98L,99L,100L,101L,104L,107L,108L,109L,110L,111L,113L,114L,115L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153049Inst : IEnumerable<long>
{
public static readonly long[] Value=A153049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153049.Bytes);
public long this[int i]=>Value[i];

public static A153049Inst Instance=new A153049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153050
{
public static readonly long[] Value={ 101761L,113569L,127449L,131769L,137641L,149769L,167281L,199809L,349281L,439569L,463761L,491401L,641601L,683929L,797449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153050Inst : IEnumerable<long>
{
public static readonly long[] Value=A153050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153050.Bytes);
public long this[int i]=>Value[i];

public static A153050Inst Instance=new A153050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153051
{
public static readonly long[] Value={ 9L,13L,16L,19L,21L,22L,25L,26L,28L,31L,33L,34L,36L,37L,40L,41L,43L,46L,47L,49L,51L,52L,54L,55L,56L,58L,61L,64L,66L,67L,68L,69L,70L,71L,73L,75L,76L,79L,80L,81L,82L,85L,86L,88L,89L,91L,93L,94L,96L,97L,100L,101L,102L,103L,106L,109L,110L,111L,112L,113L,115L,116L,117L,118L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153051Inst : IEnumerable<long>
{
public static readonly long[] Value=A153051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153051.Bytes);
public long this[int i]=>Value[i];

public static A153051Inst Instance=new A153051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153052
{
public static readonly long[] Value={ 2L,5L,8L,10L,11L,14L,15L,17L,20L,22L,23L,25L,26L,29L,30L,32L,35L,36L,38L,40L,41L,43L,44L,45L,47L,50L,53L,55L,56L,57L,58L,59L,60L,62L,64L,65L,68L,69L,70L,71L,74L,75L,77L,78L,80L,82L,83L,85L,86L,89L,90L,91L,92L,95L,98L,99L,100L,101L,102L,104L,105L,106L,107L,108L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153052Inst : IEnumerable<long>
{
public static readonly long[] Value=A153052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153052.Bytes);
public long this[int i]=>Value[i];

public static A153052Inst Instance=new A153052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153053
{
public static readonly long[] Value={ 1L,4L,7L,9L,10L,13L,14L,16L,19L,21L,22L,24L,25L,28L,29L,31L,34L,35L,37L,39L,40L,42L,43L,44L,46L,49L,52L,54L,55L,56L,57L,58L,59L,61L,63L,64L,67L,68L,69L,70L,73L,74L,76L,77L,79L,81L,82L,84L,85L,88L,89L,90L,91L,94L,97L,98L,99L,100L,101L,103L,104L,105L,106L,107L,109L,112L,114L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153053Inst : IEnumerable<long>
{
public static readonly long[] Value=A153053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153053.Bytes);
public long this[int i]=>Value[i];

public static A153053Inst Instance=new A153053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153054
{
public static readonly long[] Value={ 12L,120L,16L,27L,56L,240L,112L,162L,100L,275L,891L,552L,4600L,196560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153054Inst : IEnumerable<long>
{
public static readonly long[] Value=A153054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153054.Bytes);
public long this[int i]=>Value[i];

public static A153054Inst Instance=new A153054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153055
{
public static readonly long[] Value={ 11L,13L,27L,29L,45L,53L,54L,59L,61L,79L,83L,101L,103L,106L,109L,115L,121L,125L,155L,158L,163L,166L,173L,181L,187L,199L,202L,206L,211L,212L,213L,218L,237L,251L,310L,326L,329L,345L,346L,362L,369L,377L,393L,398L,407L,409L,412L,422L,436L,441L,459L,563L,575L,581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153055Inst : IEnumerable<long>
{
public static readonly long[] Value=A153055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153055.Bytes);
public long this[int i]=>Value[i];

public static A153055Inst Instance=new A153055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153056
{
public static readonly long[] Value={ 2L,3L,7L,16L,32L,57L,93L,142L,206L,287L,387L,508L,652L,821L,1017L,1242L,1498L,1787L,2111L,2472L,2872L,3313L,3797L,4326L,4902L,5527L,6203L,6932L,7716L,8557L,9457L,10418L,11442L,12531L,13687L,14912L,16208L,17577L,19021L,20542L,22142L,23823L,25587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153056Inst : IEnumerable<long>
{
public static readonly long[] Value=A153056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153056.Bytes);
public long this[int i]=>Value[i];

public static A153056Inst Instance=new A153056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153057
{
public static readonly long[] Value={ 3L,4L,8L,17L,33L,58L,94L,143L,207L,288L,388L,509L,653L,822L,1018L,1243L,1499L,1788L,2112L,2473L,2873L,3314L,3798L,4327L,4903L,5528L,6204L,6933L,7717L,8558L,9458L,10419L,11443L,12532L,13688L,14913L,16209L,17578L,19022L,20543L,22143L,23824L,25588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153057Inst : IEnumerable<long>
{
public static readonly long[] Value=A153057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153057.Bytes);
public long this[int i]=>Value[i];

public static A153057Inst Instance=new A153057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153058
{
public static readonly long[] Value={ 4L,5L,9L,18L,34L,59L,95L,144L,208L,289L,389L,510L,654L,823L,1019L,1244L,1500L,1789L,2113L,2474L,2874L,3315L,3799L,4328L,4904L,5529L,6205L,6934L,7718L,8559L,9459L,10420L,11444L,12533L,13689L,14914L,16210L,17579L,19023L,20544L,22144L,23825L,25589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153058Inst : IEnumerable<long>
{
public static readonly long[] Value=A153058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153058.Bytes);
public long this[int i]=>Value[i];

public static A153058Inst Instance=new A153058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153059
{
public static readonly BigInteger[] Value={ 0L,-1L,-1L,-2L,0L,-5L,19L,354L,125308L,15702094855L,BigInteger.Parse("246555782835417471015"),BigInteger.Parse("60789754049585540423053668337098365130214"),BigInteger.Parse("3695394197409101611007702673065886746062029284385286815035968423367078017175685784") };
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
public class A153059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153059Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153059.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153059Inst Instance=new A153059Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153060
{
public static readonly BigInteger[] Value={ 4L,15L,223L,49726L,2472675072L,6114122011690205179L,BigInteger.Parse("37382487973834681475536573127118422035"),BigInteger.Parse("1397450407113894589170760370457882734663916414838438245542265330668373541218") };
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
public class A153060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153060Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153060.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153060Inst Instance=new A153060Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153061
{
public static readonly BigInteger[] Value={ 4L,17L,291L,84684L,7171379860L,BigInteger.Parse("51428689096413619605"),BigInteger.Parse("2644910062175573125355281735337640356031"),BigInteger.Parse("6995549236997594095768769895625713364190838574177475661857423797590740438072968") };
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
public class A153061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153061Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153061.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153061Inst Instance=new A153061Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153062
{
public static readonly BigInteger[] Value={ 1L,0L,-4L,7L,33L,1064L,1132060L,1281559843551L,BigInteger.Parse("1642395632602463596289537"),BigInteger.Parse("2697463413991646582332856337058890220473935674288"),BigInteger.Parse("7276308869823469318922107258255539214217660183827400648026742290333726278585952350082821224306844") };
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
public class A153062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153062Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153062.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153062Inst Instance=new A153062Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153063
{
public static readonly long[] Value={ 1L,0L,-1L,0L,-3L,4L,-2092L,4372582L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153063Inst : IEnumerable<long>
{
public static readonly long[] Value=A153063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153063.Bytes);
public long this[int i]=>Value[i];

public static A153063Inst Instance=new A153063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153064
{
public static readonly long[] Value={ 2L,4L,15L,-32543L,1059046848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153064Inst : IEnumerable<long>
{
public static readonly long[] Value=A153064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153064.Bytes);
public long this[int i]=>Value[i];

public static A153064Inst Instance=new A153064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153065
{
public static readonly long[] Value={ 3L,5L,11L,19L,23L,31L,43L,47L,53L,59L,61L,73L,101L,103L,149L,151L,157L,167L,173L,179L,181L,211L,223L,227L,251L,269L,307L,313L,331L,347L,359L,373L,379L,389L,401L,409L,419L,421L,431L,433L,439L,479L,487L,503L,509L,571L,577L,593L,601L,659L,691L,709L,773L,811L,839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153065Inst : IEnumerable<long>
{
public static readonly long[] Value=A153065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153065.Bytes);
public long this[int i]=>Value[i];

public static A153065Inst Instance=new A153065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153066
{
public static readonly long[] Value={ 0L,1L,3L,1L,1L,2L,1L,17L,1L,10L,1L,1L,5L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,2L,4L,1L,1L,1L,10L,1L,2L,1L,1L,1L,6L,1L,12L,2L,14L,1L,1L,1L,3L,3L,1L,1L,3L,1L,1L,12L,3L,1L,1L,1L,2L,1L,1L,6L,3L,1L,1L,4L,2L,1L,12L,140L,1L,6L,3L,3L,1L,2L,1100L,4L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153066Inst : IEnumerable<long>
{
public static readonly long[] Value=A153066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153066.Bytes);
public long this[int i]=>Value[i];

public static A153066Inst Instance=new A153066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153067
{
public static readonly long[] Value={ 0L,1L,0L,1L,3L,4L,7L,18L,25L,443L,468L,5123L,5591L,10714L,59161L,69875L,129036L,327947L,456983L,784930L,1241913L,2026843L,5295599L,12618041L,17913640L,30531681L,48445321L,78977002L,206399325L,904574302L,1110973627L,2015547929L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153067Inst : IEnumerable<long>
{
public static readonly long[] Value=A153067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153067.Bytes);
public long this[int i]=>Value[i];

public static A153067Inst Instance=new A153067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153068
{
public static readonly long[] Value={ 1L,0L,1L,1L,4L,5L,9L,23L,32L,567L,599L,6557L,7156L,13713L,75721L,89434L,165155L,419744L,584899L,1004643L,1589542L,2594185L,6777912L,16150009L,22927921L,39077930L,62005851L,101083781L,264173413L,1157777433L,1421950846L,2579728279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153068Inst : IEnumerable<long>
{
public static readonly long[] Value=A153068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153068.Bytes);
public long this[int i]=>Value[i];

public static A153068Inst Instance=new A153068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153069
{
public static readonly long[] Value={ 0L,1L,0L,1L,10L,11L,98L,109L,9690L,38869L,48559L,87428L,660555L,14619638L,15280193L,45180024L,150820265L,3966506914L,4117327179L,49257105883L,53374433062L,583001436503L,636375869565L,6310384262588L,19567528657329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153069Inst : IEnumerable<long>
{
public static readonly long[] Value=A153069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153069.Bytes);
public long this[int i]=>Value[i];

public static A153069Inst Instance=new A153069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153070
{
public static readonly long[] Value={ 1L,0L,1L,1L,11L,12L,107L,119L,10579L,42435L,53014L,95449L,721157L,15960903L,16682060L,49325023L,164657129L,4330410377L,4495067506L,53776152943L,58271220449L,636488357433L,694759577882L,6889324558371L,21362733252995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153070Inst : IEnumerable<long>
{
public static readonly long[] Value=A153070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153070.Bytes);
public long this[int i]=>Value[i];

public static A153070Inst Instance=new A153070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153071
{
public static readonly long[] Value={ 9L,6L,8L,9L,4L,6L,1L,4L,6L,2L,5L,9L,3L,6L,9L,3L,8L,0L,4L,8L,3L,6L,3L,4L,8L,4L,5L,8L,4L,6L,9L,1L,8L,6L,0L,0L,0L,6L,9L,5L,4L,0L,2L,6L,7L,6L,8L,3L,9L,0L,9L,6L,1L,5L,4L,4L,2L,0L,1L,6L,8L,1L,5L,7L,4L,3L,9L,4L,9L,8L,4L,1L,1L,7L,0L,8L,0L,3L,3L,1L,3L,6L,7L,3L,9L,5L,9L,4L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153071Inst : IEnumerable<long>
{
public static readonly long[] Value=A153071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153071.Bytes);
public long this[int i]=>Value[i];

public static A153071Inst Instance=new A153071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153072
{
public static readonly long[] Value={ 0L,1L,31L,4L,1L,18L,21L,1L,1L,2L,1L,2L,1L,3L,6L,3L,28L,1L,3L,2L,1L,2L,21L,1L,1L,32L,1L,1L,1L,5L,3L,1L,2L,1L,27L,11L,1L,2L,1L,5L,1L,3L,4L,3L,1L,4L,1L,1L,2L,1L,9L,8L,1L,2L,2L,1L,14L,2L,1L,7L,2L,2L,1L,20L,2L,1L,5L,10L,1L,4L,2L,2L,1L,2L,106L,4L,1L,1L,1L,1L,1L,10L,9L,3L,3L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153072Inst : IEnumerable<long>
{
public static readonly long[] Value=A153072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153072.Bytes);
public long this[int i]=>Value[i];

public static A153072Inst Instance=new A153072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153073
{
public static readonly long[] Value={ 0L,1L,0L,1L,31L,125L,156L,2933L,61749L,64682L,126431L,317544L,443975L,1205494L,1649469L,6153901L,38572875L,121872526L,3451003603L,3572876129L,14169631990L,31912140109L,46081772099L,124075684307L,2651671142546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153073Inst : IEnumerable<long>
{
public static readonly long[] Value=A153073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153073.Bytes);
public long this[int i]=>Value[i];

public static A153073Inst Instance=new A153073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153074
{
public static readonly long[] Value={ 1L,0L,1L,1L,32L,129L,161L,3027L,63728L,66755L,130483L,327721L,458204L,1244129L,1702333L,6351128L,39809101L,125778431L,3561605169L,3687383600L,14623755969L,32934895538L,47558651507L,128052198552L,2736654821099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153074Inst : IEnumerable<long>
{
public static readonly long[] Value=A153074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153074.Bytes);
public long this[int i]=>Value[i];

public static A153074Inst Instance=new A153074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153075
{
public static readonly long[] Value={ 3L,5L,11L,13L,29L,31L,43L,83L,97L,113L,127L,149L,157L,173L,191L,193L,223L,311L,373L,467L,487L,499L,557L,607L,647L,653L,673L,677L,739L,787L,821L,829L,881L,883L,977L,991L,1051L,1217L,1291L,1373L,1427L,1429L,1471L,1583L,1597L,1607L,1609L,1693L,1811L,1877L,1951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153075Inst : IEnumerable<long>
{
public static readonly long[] Value=A153075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153075.Bytes);
public long this[int i]=>Value[i];

public static A153075Inst Instance=new A153075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153076
{
public static readonly BigInteger[] Value={ 5L,29L,104L,1538L,13842L,188424L,3249576L,101864576L,2388809736L,59720243400L,2571228006912L,85266458294400L,6038197537693842L,227036227417289064L,12129959730964036050UL,BigInteger.Parse("606111287080086323712"),BigInteger.Parse("36186481977293685109248") };
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
public class A153076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153076Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153076.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153076Inst Instance=new A153076Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153077
{
public static readonly BigInteger[] Value={ 5L,29L,116L,2309L,30029L,272264L,6715161L,154448901L,3696967556L,126321788241L,5984466237725L,304250263527209L,7475863618097156L,495878856926202725L,17521052944725830450UL,BigInteger.Parse("1749278213298193453469"),BigInteger.Parse("65483587607609351045025") };
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
public class A153077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153077Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153077.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153077Inst Instance=new A153077Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153078
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,5L,2L,4L,5L,3L,7L,5L,10L,2L,8L,4L,5L,6L,11L,32L,42L,68L,24L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153078Inst : IEnumerable<long>
{
public static readonly long[] Value=A153078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153078.Bytes);
public long this[int i]=>Value[i];

public static A153078Inst Instance=new A153078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153079
{
public static readonly BigInteger[] Value={ 3L,15L,171L,2199L,28563L,371295L,4826811L,62748519L,815730723L,10604499375L,137858491851L,1792160394039L,23298085122483L,302875106592255L,3937376385699291L,51185893014090759L,665416609183179843L,8650415919381337935L,BigInteger.Parse("112455406951957393131") };
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
public class A153079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153079Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153079.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153079Inst Instance=new A153079Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153080
{
public static readonly long[] Value={ 2L,15L,28L,41L,54L,67L,80L,93L,106L,119L,132L,145L,158L,171L,184L,197L,210L,223L,236L,249L,262L,275L,288L,301L,314L,327L,340L,353L,366L,379L,392L,405L,418L,431L,444L,457L,470L,483L,496L,509L,522L,535L,548L,561L,574L,587L,600L,613L,626L,639L,652L,665L,678L,691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153080Inst : IEnumerable<long>
{
public static readonly long[] Value=A153080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153080.Bytes);
public long this[int i]=>Value[i];

public static A153080Inst Instance=new A153080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153081
{
public static readonly long[] Value={ 0L,2L,3L,5L,8L,9L,12L,14L,15L,17L,20L,23L,24L,27L,29L,30L,33L,35L,38L,42L,44L,45L,47L,48L,50L,57L,59L,62L,63L,68L,69L,72L,75L,77L,80L,83L,84L,89L,90L,92L,93L,99L,105L,107L,108L,110L,113L,114L,119L,122L,125L,128L,129L,132L,134L,135L,140L,147L,149L,150L,152L,159L,162L,167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153081Inst : IEnumerable<long>
{
public static readonly long[] Value=A153081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153081.Bytes);
public long this[int i]=>Value[i];

public static A153081Inst Instance=new A153081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153082
{
public static readonly long[] Value={ 1L,4L,6L,7L,10L,11L,13L,16L,18L,19L,21L,22L,25L,26L,28L,31L,32L,34L,36L,37L,39L,40L,41L,43L,46L,49L,51L,52L,53L,54L,55L,56L,58L,60L,61L,64L,65L,66L,67L,70L,71L,73L,74L,76L,78L,79L,81L,82L,85L,86L,87L,88L,91L,94L,95L,96L,97L,98L,100L,101L,102L,103L,104L,106L,109L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153082Inst : IEnumerable<long>
{
public static readonly long[] Value=A153082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153082.Bytes);
public long this[int i]=>Value[i];

public static A153082Inst Instance=new A153082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153083
{
public static readonly long[] Value={ 2L,5L,7L,8L,11L,12L,14L,17L,19L,20L,22L,23L,26L,27L,29L,32L,33L,35L,37L,38L,40L,41L,42L,44L,47L,50L,52L,53L,54L,55L,56L,57L,59L,61L,62L,65L,66L,67L,68L,71L,72L,74L,75L,77L,79L,80L,82L,83L,86L,87L,88L,89L,92L,95L,96L,97L,98L,99L,101L,102L,103L,104L,105L,107L,110L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153083Inst : IEnumerable<long>
{
public static readonly long[] Value=A153083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153083.Bytes);
public long this[int i]=>Value[i];

public static A153083Inst Instance=new A153083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153084
{
public static readonly long[] Value={ 1L,3L,9L,19L,42L,78L,146L,249L,429L,695L,1125L,1749L,2713L,4086L,6123L,8986L,13122L,18852L,26934L,38001L,53328L,74068L,102336L,140208L,191153L,258741L,348606L,466806L,622383L,825342L,1090087L,1432923L,1876542L,2447029L,3179859L,4116282L,5311204L,6829008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153084Inst : IEnumerable<long>
{
public static readonly long[] Value=A153084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153084.Bytes);
public long this[int i]=>Value[i];

public static A153084Inst Instance=new A153084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153085
{
public static readonly long[] Value={ 1L,4L,5L,7L,10L,11L,13L,15L,16L,18L,19L,20L,22L,25L,28L,29L,30L,31L,32L,34L,35L,37L,39L,40L,41L,43L,45L,46L,49L,50L,51L,52L,53L,54L,55L,58L,60L,61L,62L,64L,65L,67L,70L,71L,73L,74L,75L,76L,79L,80L,81L,82L,84L,85L,88L,89L,90L,91L,93L,94L,95L,97L,100L,102L,103L,105L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153085Inst : IEnumerable<long>
{
public static readonly long[] Value=A153085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153085.Bytes);
public long this[int i]=>Value[i];

public static A153085Inst Instance=new A153085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153086
{
public static readonly long[] Value={ 2L,5L,7L,8L,11L,12L,14L,17L,20L,21L,22L,23L,26L,27L,28L,29L,32L,34L,35L,37L,38L,41L,42L,44L,45L,47L,49L,50L,52L,53L,56L,57L,59L,60L,62L,63L,65L,67L,68L,70L,71L,72L,73L,74L,77L,78L,79L,80L,82L,83L,84L,86L,87L,89L,91L,92L,95L,96L,97L,98L,99L,100L,101L,102L,104L,105L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153086Inst : IEnumerable<long>
{
public static readonly long[] Value=A153086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153086.Bytes);
public long this[int i]=>Value[i];

public static A153086Inst Instance=new A153086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153087
{
public static readonly long[] Value={ 6L,66L,114L,162L,5466L,1026L,1926L,606L,5466L,1746L,29154L,522L,3838386L,27066L,4302L,1254L,92886L,3246L,2466L,1578L,113573466L,1026L,129474L,9402L,280201746L,66L,236646L,231006L,6808626L,122826L,545646L,1422L,9003546L,66666L,10242L,2874L,418384938L,3344058L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153087Inst : IEnumerable<long>
{
public static readonly long[] Value=A153087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153087.Bytes);
public long this[int i]=>Value[i];

public static A153087Inst Instance=new A153087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153088
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,8L,9L,10L,11L,13L,14L,15L,17L,19L,20L,21L,23L,24L,25L,26L,27L,29L,31L,32L,33L,34L,35L,37L,38L,39L,41L,42L,43L,44L,45L,47L,49L,50L,51L,52L,53L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,71L,73L,74L,75L,77L,79L,80L,81L,83L,85L,86L,87L,89L,91L,92L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153088Inst : IEnumerable<long>
{
public static readonly long[] Value=A153088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153088.Bytes);
public long this[int i]=>Value[i];

public static A153088Inst Instance=new A153088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153089
{
public static readonly long[] Value={ 2L,7L,117241L,1351781L,3703429L,243729623L,486707171L,568561471L,766634423L,883314979L,1058403331L,1520509423L,1933700891L,1997566367L,2063533819L,2632011079L,3040681037L,3591772153L,4114380107L,7870826569L,8414671219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153089Inst : IEnumerable<long>
{
public static readonly long[] Value=A153089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153089.Bytes);
public long this[int i]=>Value[i];

public static A153089Inst Instance=new A153089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153090
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,14L,5L,5L,5L,1L,7L,6L,5L,7L,12L,1L,5L,1L,6L,29L,23L,20L,8L,6L,23L,9L,2L,15L,18L,19L,13L,57L,1L,1L,9L,10L,15L,16L,22L,12L,26L,5L,5L,6L,39L,41L,6L,9L,50L,6L,32L,20L,4L,8L,2L,79L,28L,23L,33L,78L,31L,35L,19L,32L,46L,7L,6L,116L,39L,18L,20L,6L,35L,8L,25L,39L,31L,26L,117L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153090Inst : IEnumerable<long>
{
public static readonly long[] Value=A153090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153090.Bytes);
public long this[int i]=>Value[i];

public static A153090Inst Instance=new A153090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153091
{
public static readonly long[] Value={ 1L,1L,3L,1L,6L,5L,5L,1L,2L,2L,18L,12L,12L,7L,1L,1L,4L,1L,9L,2L,36L,10L,70L,1L,3L,16L,6L,3L,2L,9L,74L,4L,6L,19L,20L,8L,14L,2L,2L,62L,3L,29L,47L,11L,47L,16L,58L,1L,49L,18L,51L,3L,12L,5L,18L,23L,1L,19L,54L,7L,35L,12L,7L,1L,12L,3L,5L,121L,70L,89L,12L,61L,33L,36L,9L,17L,135L,35L,21L,23L,20L,86L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153091Inst : IEnumerable<long>
{
public static readonly long[] Value=A153091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153091.Bytes);
public long this[int i]=>Value[i];

public static A153091Inst Instance=new A153091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153092
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,3L,2L,20L,4L,5L,2L,9L,2L,27L,7L,12L,3L,3L,2L,3L,6L,6L,1L,18L,8L,2L,17L,2L,14L,55L,1L,18L,4L,59L,18L,30L,26L,32L,3L,14L,59L,42L,35L,40L,22L,7L,17L,26L,6L,28L,3L,15L,11L,6L,32L,30L,18L,14L,4L,85L,3L,1L,65L,13L,64L,7L,18L,40L,8L,68L,5L,5L,6L,107L,7L,88L,25L,6L,3L,1L,21L,8L,12L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153092Inst : IEnumerable<long>
{
public static readonly long[] Value=A153092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153092.Bytes);
public long this[int i]=>Value[i];

public static A153092Inst Instance=new A153092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153093
{
public static readonly long[] Value={ 1L,1L,1L,2L,9L,1L,2L,1L,1L,5L,13L,1L,6L,1L,6L,14L,4L,4L,7L,5L,6L,5L,12L,3L,6L,3L,9L,3L,20L,9L,14L,7L,43L,22L,5L,11L,4L,4L,48L,14L,8L,56L,36L,7L,83L,47L,47L,1L,2L,74L,15L,12L,22L,15L,17L,47L,20L,20L,5L,8L,12L,26L,6L,26L,55L,16L,32L,45L,24L,46L,19L,58L,6L,29L,19L,26L,83L,45L,17L,48L,6L,16L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153093Inst : IEnumerable<long>
{
public static readonly long[] Value=A153093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153093.Bytes);
public long this[int i]=>Value[i];

public static A153093Inst Instance=new A153093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153094
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,4L,1L,2L,1L,1L,1L,4L,1L,1L,1L,3L,5L,2L,1L,1L,3L,2L,2L,2L,9L,6L,1L,6L,4L,1L,1L,4L,1L,2L,2L,3L,6L,6L,5L,1L,5L,5L,1L,2L,1L,10L,3L,5L,1L,3L,2L,1L,4L,5L,2L,2L,3L,1L,1L,2L,3L,5L,5L,6L,1L,12L,3L,5L,6L,1L,2L,9L,3L,4L,1L,1L,5L,2L,3L,4L,7L,2L,2L,16L,8L,5L,1L,5L,5L,6L,3L,2L,11L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153094Inst : IEnumerable<long>
{
public static readonly long[] Value=A153094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153094.Bytes);
public long this[int i]=>Value[i];

public static A153094Inst Instance=new A153094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153095
{
public static readonly long[] Value={ 2L,2L,3L,2L,2L,3L,3L,5L,2L,2L,2L,3L,8L,7L,5L,4L,2L,2L,4L,3L,6L,2L,2L,5L,4L,7L,6L,4L,3L,2L,2L,2L,2L,6L,3L,3L,7L,2L,2L,2L,5L,2L,2L,3L,2L,2L,2L,5L,7L,2L,9L,5L,4L,4L,2L,2L,2L,8L,7L,4L,8L,4L,6L,5L,4L,5L,5L,4L,3L,9L,2L,2L,6L,3L,8L,8L,4L,2L,4L,8L,6L,2L,2L,4L,4L,5L,6L,4L,4L,8L,4L,6L,4L,7L,3L,4L,6L,7L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153095Inst : IEnumerable<long>
{
public static readonly long[] Value=A153095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153095.Bytes);
public long this[int i]=>Value[i];

public static A153095Inst Instance=new A153095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153096
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,-1L,1L,3L,-1L,1L,2L,-1L,1L,2L,-1L,1L,3L,-1L,1L,3L,-1L,1L,5L,1L,1L,2L,-1L,1L,2L,-1L,4L,2L,-1L,1L,3L,1L,2L,8L,1L,1L,7L,-1L,1L,5L,-1L,1L,4L,1L,4L,2L,-1L,1L,2L,-1L,1L,4L,-1L,1L,3L,-1L,3L,6L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153096Inst : IEnumerable<long>
{
public static readonly long[] Value=A153096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153096.Bytes);
public long this[int i]=>Value[i];

public static A153096Inst Instance=new A153096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153097
{
public static readonly long[] Value={ 3L,6L,0L,8L,4L,8L,8L,0L,6L,7L,1L,4L,5L,3L,0L,1L,7L,3L,2L,4L,5L,0L,8L,3L,7L,9L,6L,5L,0L,4L,3L,0L,5L,2L,6L,0L,0L,6L,4L,3L,8L,6L,4L,7L,9L,7L,4L,8L,7L,5L,7L,6L,4L,7L,6L,5L,9L,5L,8L,8L,1L,3L,7L,0L,6L,1L,4L,6L,9L,9L,4L,8L,1L,8L,1L,2L,7L,5L,9L,7L,8L,9L,0L,0L,3L,9L,3L,0L,8L,8L,8L,6L,7L,0L,9L,3L,2L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153097Inst : IEnumerable<long>
{
public static readonly long[] Value=A153097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153097.Bytes);
public long this[int i]=>Value[i];

public static A153097Inst Instance=new A153097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153098
{
public static readonly long[] Value={ 3L,5L,5L,4L,1L,8L,0L,5L,2L,4L,0L,3L,1L,6L,3L,7L,3L,2L,4L,8L,0L,2L,8L,6L,0L,7L,0L,7L,8L,2L,1L,6L,4L,3L,8L,7L,5L,2L,0L,1L,7L,8L,3L,4L,1L,8L,3L,1L,2L,1L,6L,7L,3L,6L,3L,0L,6L,2L,1L,3L,2L,2L,7L,8L,9L,0L,6L,5L,8L,7L,1L,8L,0L,3L,2L,0L,9L,3L,1L,1L,1L,3L,7L,5L,6L,0L,5L,6L,9L,1L,7L,5L,5L,1L,1L,4L,6L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153098Inst : IEnumerable<long>
{
public static readonly long[] Value=A153098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153098.Bytes);
public long this[int i]=>Value[i];

public static A153098Inst Instance=new A153098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153099
{
public static readonly long[] Value={ 3L,5L,0L,3L,7L,9L,3L,0L,6L,4L,2L,2L,2L,1L,0L,9L,7L,7L,4L,0L,6L,6L,2L,3L,4L,0L,8L,6L,4L,3L,9L,7L,1L,4L,3L,1L,8L,5L,6L,4L,9L,9L,8L,5L,2L,5L,1L,5L,1L,3L,8L,3L,4L,1L,9L,9L,4L,1L,2L,5L,6L,6L,9L,6L,3L,5L,1L,1L,8L,8L,0L,8L,8L,5L,6L,1L,7L,6L,9L,0L,8L,7L,1L,9L,4L,7L,8L,2L,6L,9L,9L,0L,6L,9L,4L,4L,6L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153099Inst : IEnumerable<long>
{
public static readonly long[] Value=A153099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153099.Bytes);
public long this[int i]=>Value[i];

public static A153099Inst Instance=new A153099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153100
{
public static readonly long[] Value={ 3L,4L,5L,6L,8L,7L,1L,2L,4L,0L,4L,3L,4L,0L,5L,3L,2L,2L,3L,1L,1L,9L,8L,6L,5L,8L,0L,6L,6L,9L,8L,3L,4L,8L,3L,4L,1L,1L,7L,0L,1L,8L,7L,2L,3L,5L,0L,1L,5L,0L,0L,6L,9L,7L,1L,5L,5L,7L,8L,5L,5L,3L,0L,6L,0L,7L,4L,4L,7L,2L,8L,5L,5L,4L,9L,7L,0L,2L,2L,9L,4L,7L,0L,6L,0L,2L,4L,6L,8L,5L,7L,4L,3L,5L,3L,3L,3L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153100Inst : IEnumerable<long>
{
public static readonly long[] Value=A153100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153100.Bytes);
public long this[int i]=>Value[i];

public static A153100Inst Instance=new A153100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153101
{
public static readonly long[] Value={ 8L,6L,1L,3L,5L,3L,1L,1L,6L,1L,4L,6L,7L,8L,6L,1L,0L,1L,3L,4L,0L,2L,1L,3L,1L,3L,7L,5L,2L,7L,9L,3L,1L,2L,6L,4L,1L,3L,9L,5L,8L,3L,8L,6L,4L,1L,5L,9L,5L,2L,0L,8L,9L,8L,6L,4L,3L,9L,5L,2L,0L,7L,5L,9L,2L,1L,3L,2L,4L,1L,6L,5L,0L,7L,5L,7L,7L,1L,0L,1L,2L,1L,6L,7L,3L,9L,6L,1L,9L,8L,8L,9L,0L,5L,3L,3L,9L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153101Inst : IEnumerable<long>
{
public static readonly long[] Value=A153101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153101.Bytes);
public long this[int i]=>Value[i];

public static A153101Inst Instance=new A153101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153102
{
public static readonly long[] Value={ 7L,7L,3L,7L,0L,5L,6L,1L,4L,4L,6L,9L,0L,8L,3L,1L,7L,3L,7L,4L,0L,4L,9L,2L,2L,7L,6L,9L,3L,5L,6L,4L,1L,7L,5L,2L,9L,3L,0L,2L,8L,3L,7L,1L,8L,9L,1L,4L,2L,0L,6L,8L,5L,6L,7L,7L,8L,9L,8L,9L,8L,5L,7L,6L,5L,3L,2L,8L,4L,0L,3L,7L,0L,8L,1L,4L,4L,5L,6L,0L,7L,6L,6L,3L,3L,0L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153102Inst : IEnumerable<long>
{
public static readonly long[] Value=A153102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153102.Bytes);
public long this[int i]=>Value[i];

public static A153102Inst Instance=new A153102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153103
{
public static readonly long[] Value={ 7L,1L,2L,4L,1L,4L,3L,7L,4L,2L,1L,6L,0L,4L,4L,3L,5L,3L,0L,2L,8L,3L,5L,4L,1L,5L,6L,0L,0L,2L,5L,8L,1L,0L,5L,8L,5L,9L,5L,5L,1L,4L,3L,2L,5L,5L,4L,5L,6L,2L,7L,4L,0L,0L,0L,7L,9L,1L,5L,2L,9L,1L,5L,5L,8L,1L,7L,3L,5L,1L,6L,0L,7L,1L,8L,5L,1L,8L,6L,8L,9L,3L,2L,7L,7L,4L,8L,1L,3L,1L,0L,9L,9L,5L,4L,5L,7L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153103Inst : IEnumerable<long>
{
public static readonly long[] Value=A153103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153103.Bytes);
public long this[int i]=>Value[i];

public static A153103Inst Instance=new A153103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153104
{
public static readonly long[] Value={ 5L,7L,8L,1L,2L,9L,6L,5L,2L,6L,3L,5L,7L,7L,5L,7L,1L,8L,5L,3L,2L,4L,2L,2L,0L,1L,5L,4L,0L,0L,5L,2L,7L,1L,3L,2L,3L,8L,2L,5L,8L,9L,2L,3L,1L,9L,7L,1L,3L,9L,2L,0L,0L,7L,2L,5L,2L,6L,8L,3L,1L,3L,5L,5L,9L,7L,0L,6L,3L,1L,6L,7L,1L,1L,3L,8L,3L,1L,5L,4L,3L,8L,6L,5L,9L,5L,4L,1L,8L,3L,0L,7L,8L,3L,9L,5L,6L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153104Inst : IEnumerable<long>
{
public static readonly long[] Value=A153104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153104.Bytes);
public long this[int i]=>Value[i];

public static A153104Inst Instance=new A153104Inst();

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