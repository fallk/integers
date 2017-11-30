using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A122941
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,3L,7L,7L,1L,4L,15L,34L,34L,1L,5L,26L,94L,214L,214L,1L,6L,40L,200L,726L,1652L,1652L,1L,7L,57L,365L,1831L,6645L,15121L,15121L,1L,8L,77L,602L,3865L,19388L,70361L,160110L,160110L,1L,9L,100L,924L,7239L,46481L,233154L,846144L,1925442L,1925442L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122941Inst : IEnumerable<long>
{
public static readonly long[] Value=A122941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122941.Bytes);
public long this[int i]=>Value[i];

public static A122941Inst Instance=new A122941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122942
{
public static readonly BigInteger[] Value={ 1L,2L,7L,41L,403L,6960L,196527L,13405218L,1566662070L,304256578608L,113065670502087L,78229220671714544L,BigInteger.Parse("101598769325059903837"),BigInteger.Parse("293965406612712860369329"),BigInteger.Parse("1613982664799943153033715558") };
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
public class A122942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122942Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A122942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122942.Bytes);
public BigInteger this[int i]=>Value[i];

public static A122942Inst Instance=new A122942Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122943
{
public static readonly long[] Value={ 1L,3L,9L,5L,27L,7L,15L,81L,21L,11L,45L,25L,13L,243L,63L,33L,135L,17L,35L,75L,19L,39L,729L,23L,189L,49L,99L,405L,51L,105L,55L,225L,57L,29L,117L,31L,125L,65L,2187L,69L,567L,147L,37L,297L,1215L,153L,77L,315L,41L,165L,675L,85L,171L,43L,87L,175L,351L,91L,93L,375L,47L,95L,195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122943Inst : IEnumerable<long>
{
public static readonly long[] Value=A122943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122943.Bytes);
public long this[int i]=>Value[i];

public static A122943Inst Instance=new A122943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122944
{
public static readonly long[] Value={ 1L,1L,-1L,-1L,-1L,1L,0L,2L,1L,-1L,1L,-1L,-4L,-1L,1L,0L,-2L,2L,6L,1L,-1L,0L,0L,4L,-2L,-7L,-1L,1L,0L,2L,-1L,-9L,3L,9L,1L,-1L,1L,1L,-13L,8L,20L,-8L,-13L,-1L,1L,0L,-2L,-2L,24L,-15L,-31L,13L,17L,1L,-1L,0L,0L,4L,4L,-40L,20L,44L,-14L,-19L,-1L,1L,0L,0L,0L,-8L,-4L,56L,-24L,-54L,14L,20L,1L,-1L,0L,0L,0L,0L,16L,8L,-88L,30L,71L,-15L,-22L,-1L,1L,0L,0L,0L,16L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122944Inst : IEnumerable<long>
{
public static readonly long[] Value=A122944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122944.Bytes);
public long this[int i]=>Value[i];

public static A122944Inst Instance=new A122944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122945
{
public static readonly long[] Value={ 1L,1L,-1L,-1L,1L,1L,1L,-1L,0L,-1L,-1L,1L,1L,-2L,1L,1L,-1L,-2L,3L,-1L,-1L,-1L,1L,3L,-4L,0L,3L,1L,1L,-1L,-4L,5L,2L,-6L,2L,-1L,-1L,1L,5L,-6L,-5L,10L,-2L,-4L,1L,1L,-1L,-6L,7L,9L,-15L,0L,10L,-3L,-1L,-1L,1L,7L,-8L,-14L,21L,5L,-20L,5L,5L,1L,1L,-1L,-8L,9L,20L,-28L,-14L,35L,-5L,-15L,4L,-1L,-1L,1L,9L,-10L,-27L,36L,28L,-56L,0L,35L,-9L,-6L,1L,1L,-1L,-10L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122945Inst : IEnumerable<long>
{
public static readonly long[] Value=A122945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122945.Bytes);
public long this[int i]=>Value[i];

public static A122945Inst Instance=new A122945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122946
{
public static readonly long[] Value={ 0L,0L,2L,2L,2L,10L,18L,26L,66L,138L,242L,506L,1058L,2026L,4050L,8282L,16386L,32586L,65714L,131258L,261602L,524458L,1049490L,2095898L,4193730L,8391690L,16775282L,33550202L,67116962L,134218090L,268418898L,536886746L,1073759106L,2147434698L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122946Inst : IEnumerable<long>
{
public static readonly long[] Value=A122946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122946.Bytes);
public long this[int i]=>Value[i];

public static A122946Inst Instance=new A122946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122947
{
public static readonly long[] Value={ 1L,1L,-1L,-1L,-1L,1L,1L,3L,1L,-1L,1L,-1L,-4L,-1L,1L,-1L,-1L,6L,8L,1L,-1L,-1L,3L,6L,-7L,-10L,-1L,1L,-1L,7L,-6L,-14L,8L,12L,1L,-1L,1L,1L,-13L,8L,20L,-8L,-13L,-1L,1L,-1L,-3L,11L,17L,-36L,-26L,27L,21L,1L,-1L,-1L,1L,19L,-26L,-53L,63L,53L,-32L,-25L,-1L,1L,-1L,5L,15L,-89L,54L,144L,-102L,-92L,37L,29L,1L,-1L,1L,3L,-27L,-10L,169L,-89L,-226L,127L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122947Inst : IEnumerable<long>
{
public static readonly long[] Value=A122947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122947.Bytes);
public long this[int i]=>Value[i];

public static A122947Inst Instance=new A122947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122948
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,1L,0L,4L,10L,33L,93L,264L,729L,1999L,5437L,14726L,39757L,107118L,288201L,774672L,2080936L,5587388L,14997840L,40249449L,108001720L,289774494L,777430359L,2085660586L,5595162045L,15009725921L,40264911876L,108013136968L,289750079191L,777264097335L,2085030095791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122948Inst : IEnumerable<long>
{
public static readonly long[] Value=A122948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122948.Bytes);
public long this[int i]=>Value[i];

public static A122948Inst Instance=new A122948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122949
{
public static readonly BigInteger[] Value={ 1L,3L,26L,426L,11064L,413640L,20946960L,1377648720L,114078384000L,11611761920640L,1425189271161600L,207609729886944000L,BigInteger.Parse("35419018603306060800"),BigInteger.Parse("6996657393055480550400"),BigInteger.Parse("1584616114318716544665600") };
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
public class A122949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122949Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A122949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122949.Bytes);
public BigInteger this[int i]=>Value[i];

public static A122949Inst Instance=new A122949Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122950
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,2L,0L,0L,1L,3L,0L,0L,0L,3L,5L,0L,0L,0L,1L,7L,8L,0L,0L,0L,0L,4L,15L,13L,0L,0L,0L,0L,1L,12L,30L,21L,0L,0L,0L,0L,0L,5L,31L,58L,34L,0L,0L,0L,0L,0L,1L,18L,73L,109L,55L,0L,0L,0L,0L,0L,0L,6L,54L,162L,201L,89L,0L,0L,0L,0L,0L,0L,1L,25L,145L,344L,365L,144L,0L,0L,0L,0L,0L,0L,0L,7L,85L,361L,707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122950Inst : IEnumerable<long>
{
public static readonly long[] Value=A122950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122950.Bytes);
public long this[int i]=>Value[i];

public static A122950Inst Instance=new A122950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122951
{
public static readonly long[] Value={ 1L,1L,5L,22L,117L,654L,3843L,23323L,145172L,921508L,5942737L,38825546L,256431172L,1709356836L,11485249995L,77703736926L,528893901963L,3619228605738L,24884558358426L,171828674445330L,1191050708958096L,8284698825305832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122951Inst : IEnumerable<long>
{
public static readonly long[] Value=A122951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122951.Bytes);
public long this[int i]=>Value[i];

public static A122951Inst Instance=new A122951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122952
{
public static readonly long[] Value={ 9L,4L,2L,4L,7L,7L,7L,9L,6L,0L,7L,6L,9L,3L,7L,9L,7L,1L,5L,3L,8L,7L,9L,3L,0L,1L,4L,9L,8L,3L,8L,5L,0L,8L,6L,5L,2L,5L,9L,1L,5L,0L,8L,1L,9L,8L,1L,2L,5L,3L,1L,7L,4L,6L,2L,9L,2L,4L,8L,3L,3L,7L,7L,6L,9L,2L,3L,4L,4L,9L,2L,1L,8L,8L,5L,8L,6L,2L,6L,9L,9L,5L,8L,8L,4L,1L,0L,4L,4L,7L,6L,0L,2L,6L,3L,5L,1L,2L,0L,3L,9L,4L,6L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122952Inst : IEnumerable<long>
{
public static readonly long[] Value=A122952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122952.Bytes);
public long this[int i]=>Value[i];

public static A122952Inst Instance=new A122952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122953
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,4L,3L,4L,4L,4L,5L,6L,6L,6L,4L,5L,5L,5L,6L,6L,5L,7L,7L,8L,8L,8L,8L,9L,9L,8L,5L,6L,6L,6L,7L,6L,7L,8L,8L,8L,8L,6L,8L,10L,9L,10L,9L,10L,10L,10L,10L,11L,10L,10L,11L,12L,12L,12L,12L,12L,12L,10L,6L,7L,7L,7L,8L,7L,8L,9L,9L,8L,7L,9L,10L,10L,11L,11L,10L,10L,10L,10L,11L,9L,7L,11L,11L,13L,13L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122953Inst : IEnumerable<long>
{
public static readonly long[] Value=A122953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122953.Bytes);
public long this[int i]=>Value[i];

public static A122953Inst Instance=new A122953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122954
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,5L,4L,4L,5L,5L,8L,7L,8L,6L,5L,7L,7L,5L,7L,10L,9L,11L,15L,10L,9L,13L,13L,12L,17L,11L,9L,7L,7L,8L,11L,8L,13L,11L,16L,16L,15L,10L,17L,18L,18L,21L,22L,15L,15L,14L,12L,19L,18L,19L,24L,22L,20L,24L,25L,21L,25L,17L,14L,11L,11L,11L,13L,12L,17L,16L,21L,15L,11L,19L,26L,17L,23L,22L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122954Inst : IEnumerable<long>
{
public static readonly long[] Value=A122954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122954.Bytes);
public long this[int i]=>Value[i];

public static A122954Inst Instance=new A122954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122955
{
public static readonly long[] Value={ 5L,11L,12L,13L,19L,25L,28L,29L,33L,35L,45L,46L,52L,53L,58L,59L,61L,62L,63L,65L,76L,78L,79L,81L,85L,88L,89L,91L,92L,95L,98L,101L,104L,108L,109L,114L,115L,116L,119L,125L,131L,136L,139L,144L,145L,158L,161L,162L,168L,169L,178L,179L,181L,184L,185L,189L,195L,197L,199L,207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122955Inst : IEnumerable<long>
{
public static readonly long[] Value=A122955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122955.Bytes);
public long this[int i]=>Value[i];

public static A122955Inst Instance=new A122955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122956
{
public static readonly long[] Value={ 4L,9L,65L,11665L,27289L,3030569L,6808609L,1632201497L,10553247449L,843404126561L,2101614761177L,62537392166201L,100301302204489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122956Inst : IEnumerable<long>
{
public static readonly long[] Value=A122956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122956.Bytes);
public long this[int i]=>Value[i];

public static A122956Inst Instance=new A122956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122957
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,10L,12L,14L,18L,20L,24L,30L,36L,42L,48L,60L,66L,70L,72L,78L,84L,90L,96L,102L,120L,126L,132L,150L,156L,168L,180L,210L,240L,252L,270L,300L,330L,336L,360L,390L,420L,450L,462L,480L,510L,540L,546L,570L,630L,660L,690L,714L,720L,780L,840L,870L,900L,924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122957Inst : IEnumerable<long>
{
public static readonly long[] Value=A122957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122957.Bytes);
public long this[int i]=>Value[i];

public static A122957Inst Instance=new A122957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122958
{
public static readonly long[] Value={ 1L,1L,0L,-2L,-6L,-14L,-30L,-62L,-126L,-254L,-510L,-1022L,-2046L,-4094L,-8190L,-16382L,-32766L,-65534L,-131070L,-262142L,-524286L,-1048574L,-2097150L,-4194302L,-8388606L,-16777214L,-33554430L,-67108862L,-134217726L,-268435454L,-536870910L,-1073741822L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122958Inst : IEnumerable<long>
{
public static readonly long[] Value=A122958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122958.Bytes);
public long this[int i]=>Value[i];

public static A122958Inst Instance=new A122958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122959
{
public static readonly long[] Value={ 1L,-1L,0L,2L,-6L,14L,-30L,62L,-126L,254L,-510L,1022L,-2046L,4094L,-8190L,16382L,-32766L,65534L,-131070L,262142L,-524286L,1048574L,-2097150L,4194302L,-8388606L,16777214L,-33554430L,67108862L,-134217726L,268435454L,-536870910L,1073741822L,-2147483646L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122959Inst : IEnumerable<long>
{
public static readonly long[] Value=A122959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122959.Bytes);
public long this[int i]=>Value[i];

public static A122959Inst Instance=new A122959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122960
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,0L,3L,1L,0L,1L,9L,6L,1L,0L,0L,5L,0L,10L,1L,0L,1L,0L,15L,0L,15L,1L,0L,0L,7L,0L,35L,0L,21L,1L,0L,1L,0L,28L,0L,70L,0L,28L,1L,0L,0L,9L,0L,84L,0L,126L,0L,36L,1L,0L,1L,0L,45L,0L,210L,0L,210L,0L,45L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122960Inst : IEnumerable<long>
{
public static readonly long[] Value=A122960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122960.Bytes);
public long this[int i]=>Value[i];

public static A122960Inst Instance=new A122960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122961
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,3L,9L,81L,99L,649539L,649737L,274124633198656977L,274124633199956451L,BigInteger.Parse("20598907656583661830059012023854018733151994905840579"),BigInteger.Parse("20598907656583661830059012023854019281401261305753481") };
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
public class A122961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122961Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A122961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122961.Bytes);
public BigInteger this[int i]=>Value[i];

public static A122961Inst Instance=new A122961Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122962
{
public static readonly long[] Value={ 2L,2L,24L,1L,1L,2L,240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122962Inst : IEnumerable<long>
{
public static readonly long[] Value=A122962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122962.Bytes);
public long this[int i]=>Value[i];

public static A122962Inst Instance=new A122962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122963
{
public static readonly long[] Value={ 10L,21L,45L,55L,105L,120L,231L,253L,325L,351L,561L,595L,630L,741L,780L,1081L,1225L,1326L,1540L,1653L,1711L,1953L,2145L,2415L,2775L,3003L,3403L,3655L,3741L,3828L,4186L,4371L,4465L,4560L,5671L,6216L,6670L,7021L,7140L,7381L,7503L,7626L,8385L,8911L,9045L,10011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122963Inst : IEnumerable<long>
{
public static readonly long[] Value=A122963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122963.Bytes);
public long this[int i]=>Value[i];

public static A122963Inst Instance=new A122963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122964
{
public static readonly long[] Value={ 4L,9L,15L,26L,39L,58L,85L,111L,134L,166L,205L,237L,291L,327L,382L,445L,497L,545L,623L,697L,766L,841L,921L,1003L,1114L,1195L,1285L,1379L,1486L,1622L,1718L,1837L,1943L,2071L,2195L,2329L,2483L,2605L,2787L,2935L,3073L,3214L,3379L,3554L,3742L,3909L,4105L,4286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122964Inst : IEnumerable<long>
{
public static readonly long[] Value=A122964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122964.Bytes);
public long this[int i]=>Value[i];

public static A122964Inst Instance=new A122964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122965
{
public static readonly long[] Value={ 0L,1L,2L,5L,6L,9L,15L,29L,35L,43L,53L,76L,82L,105L,120L,123L,153L,191L,197L,235L,245L,253L,283L,321L,327L,345L,375L,383L,413L,451L,481L,548L,607L,644L,703L,750L,820L,922L,1016L,1088L,1127L,1229L,1264L,1366L,1503L,1578L,1715L,1860L,1973L,2083L,2165L,2280L,2417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122965Inst : IEnumerable<long>
{
public static readonly long[] Value=A122965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122965.Bytes);
public long this[int i]=>Value[i];

public static A122965Inst Instance=new A122965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122966
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,10006181886601L,106018800186811L,1101166116061861L,10061808618988111L,100160900018898991L,1000608991191088891L,10000161689690916661UL,BigInteger.Parse("100006066111081680961") };
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
public class A122966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122966Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A122966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122966.Bytes);
public BigInteger this[int i]=>Value[i];

public static A122966Inst Instance=new A122966Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122967
{
public static readonly long[] Value={ 71L,37L,131L,251L,199L,79L,139L,1151L,827L,89L,71L,107L,467L,89L,239L,239L,467L,359L,467L,479L,431L,263L,853L,2267L,433L,251L,1439L,2393L,1367L,47L,863L,449L,1217L,701L,4799L,89L,1879L,433L,1063L,2609L,269L,5669L,239L,2099L,6803L,251L,3923L,199L,929L,227L,5119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122967Inst : IEnumerable<long>
{
public static readonly long[] Value=A122967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122967.Bytes);
public long this[int i]=>Value[i];

public static A122967Inst Instance=new A122967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122968
{
public static readonly BigInteger[] Value={ 0L,1L,134217728L,7625597484987L,18014398509481984L,7450580596923828125L,BigInteger.Parse("1023490369077469249536"),BigInteger.Parse("65712362363534280139543"),BigInteger.Parse("2417851639229258349412352"),BigInteger.Parse("58149737003040059690390169") };
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
public class A122968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122968Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A122968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122968.Bytes);
public BigInteger this[int i]=>Value[i];

public static A122968Inst Instance=new A122968Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122969
{
public static readonly BigInteger[] Value={ 0L,1L,268435456L,22876792454961L,72057594037927936L,BigInteger.Parse("37252902984619140625"),BigInteger.Parse("6140942214464815497216"),BigInteger.Parse("459986536544739960976801"),BigInteger.Parse("19342813113834066795298816"),BigInteger.Parse("523347633027360537213511521") };
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
public class A122969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122969Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A122969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122969.Bytes);
public BigInteger this[int i]=>Value[i];

public static A122969Inst Instance=new A122969Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122970
{
public static readonly BigInteger[] Value={ 0L,1L,536870912L,68630377364883L,288230376151711744L,BigInteger.Parse("186264514923095703125"),BigInteger.Parse("36845653286788892983296"),BigInteger.Parse("3219905755813179726837607"),BigInteger.Parse("154742504910672534362390528"),BigInteger.Parse("4710128697246244834921603689"),BigInteger.Parse("100000000000000000000000000000"),BigInteger.Parse("1586309297171491574414436704891") };
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
public class A122970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122970Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A122970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122970.Bytes);
public BigInteger this[int i]=>Value[i];

public static A122970Inst Instance=new A122970Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122971
{
public static readonly BigInteger[] Value={ 0L,1L,1073741824L,205891132094649L,1152921504606846976L,BigInteger.Parse("931322574615478515625"),BigInteger.Parse("221073919720733357899776"),BigInteger.Parse("22539340290692258087863249"),BigInteger.Parse("1237940039285380274899124224") };
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
public class A122971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122971Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A122971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122971.Bytes);
public BigInteger this[int i]=>Value[i];

public static A122971Inst Instance=new A122971Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122972
{
public static readonly long[] Value={ 1L,2L,4L,14L,58L,302L,1858L,13262L,107698L,980942L,9905458L,109844942L,1327159858L,17353902542L,244180971058L,3678842132942L,59089527531058L,1007972756756942L,18199148360427058L,346736152866068942L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122972Inst : IEnumerable<long>
{
public static readonly long[] Value=A122972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122972.Bytes);
public long this[int i]=>Value[i];

public static A122972Inst Instance=new A122972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122973
{
public static readonly long[] Value={ 1L,12L,42L,162L,642L,2562L,10242L,40962L,163842L,655362L,2621442L,10485762L,41943042L,167772162L,671088642L,2684354562L,10737418242L,42949672962L,171798691842L,687194767362L,2748779069442L,10995116277762L,43980465111042L,175921860444162L,703687441776642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122973Inst : IEnumerable<long>
{
public static readonly long[] Value=A122973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122973.Bytes);
public long this[int i]=>Value[i];

public static A122973Inst Instance=new A122973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122974
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,4L,9L,15L,16L,18L,44L,75L,80L,90L,96L,265L,435L,520L,540L,576L,600L,1854L,3045L,3640L,3780L,4032L,4200L,4320L,14833L,24465L,29120L,31500L,32256L,33600L,34560L,35280L,133496L,220185L,259840L,283500L,290304L,302400L,311040L,317520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122974Inst : IEnumerable<long>
{
public static readonly long[] Value=A122974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122974.Bytes);
public long this[int i]=>Value[i];

public static A122974Inst Instance=new A122974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122975
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,10L,12L,13L,14L,16L,21L,22L,23L,30L,31L,32L,37L,39L,40L,41L,43L,48L,49L,50L,64L,66L,67L,68L,70L,91L,93L,94L,95L,97L,111L,112L,113L,118L,120L,121L,122L,124L,129L,130L,131L,145L,147L,148L,149L,151L,192L,193L,194L,199L,201L,202L,203L,205L,210L,211L,212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122975Inst : IEnumerable<long>
{
public static readonly long[] Value=A122975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122975.Bytes);
public long this[int i]=>Value[i];

public static A122975Inst Instance=new A122975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122976
{
public static readonly long[] Value={ 227L,32321L,214007L,401627L,499481L,521789L,535859L,708857L,1011587L,1016879L,1090469L,1224029L,1513739L,1559609L,1642049L,1979897L,1995107L,2018249L,2610821L,2810579L,2933681L,2936159L,3191261L,3203147L,3302567L,3614207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122976Inst : IEnumerable<long>
{
public static readonly long[] Value=A122976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122976.Bytes);
public long this[int i]=>Value[i];

public static A122976Inst Instance=new A122976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122977
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,7L,2L,8L,4L,7L,2L,21L,2L,7L,7L,16L,2L,21L,2L,21L,7L,7L,2L,58L,4L,7L,8L,21L,2L,45L,2L,32L,7L,7L,7L,84L,2L,7L,7L,58L,2L,45L,2L,21L,21L,7L,2L,152L,4L,21L,7L,21L,2L,58L,7L,58L,7L,7L,2L,200L,2L,7L,21L,64L,7L,45L,2L,21L,7L,45L,2L,293L,2L,7L,21L,21L,7L,45L,2L,152L,16L,7L,2L,200L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122977Inst : IEnumerable<long>
{
public static readonly long[] Value=A122977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122977.Bytes);
public long this[int i]=>Value[i];

public static A122977Inst Instance=new A122977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122978
{
public static readonly long[] Value={ 1L,3L,3L,7L,3L,12L,3L,15L,7L,12L,3L,37L,3L,12L,12L,31L,3L,37L,3L,37L,12L,12L,3L,103L,7L,12L,15L,37L,3L,73L,3L,63L,12L,12L,12L,146L,3L,12L,12L,103L,3L,73L,3L,37L,37L,12L,3L,271L,7L,37L,12L,37L,3L,103L,12L,103L,12L,12L,3L,319L,3L,12L,37L,127L,12L,73L,3L,37L,12L,73L,3L,505L,3L,12L,37L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122978Inst : IEnumerable<long>
{
public static readonly long[] Value=A122978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122978.Bytes);
public long this[int i]=>Value[i];

public static A122978Inst Instance=new A122978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122979
{
public static readonly long[] Value={ 2L,4L,7L,8L,21L,45L,16L,58L,84L,200L,500L,32L,152L,293L,748L,1184L,3220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122979Inst : IEnumerable<long>
{
public static readonly long[] Value=A122979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122979.Bytes);
public long this[int i]=>Value[i];

public static A122979Inst Instance=new A122979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122980
{
public static readonly long[] Value={ 2L,4L,7L,8L,21L,45L,16L,58L,84L,200L,500L,32L,152L,293L,748L,1184L,3220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122980Inst : IEnumerable<long>
{
public static readonly long[] Value=A122980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122980.Bytes);
public long this[int i]=>Value[i];

public static A122980Inst Instance=new A122980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122981
{
public static readonly long[] Value={ 3L,7L,12L,15L,37L,73L,31L,103L,146L,319L,731L,63L,271L,505L,1191L,1833L,4618L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122981Inst : IEnumerable<long>
{
public static readonly long[] Value=A122981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122981.Bytes);
public long this[int i]=>Value[i];

public static A122981Inst Instance=new A122981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122982
{
public static readonly long[] Value={ 3L,7L,12L,15L,37L,73L,31L,103L,146L,319L,731L,63L,271L,505L,1191L,1833L,4618L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122982Inst : IEnumerable<long>
{
public static readonly long[] Value=A122982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122982.Bytes);
public long this[int i]=>Value[i];

public static A122982Inst Instance=new A122982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122983
{
public static readonly long[] Value={ 1L,1L,3L,7L,21L,61L,183L,547L,1641L,4921L,14763L,44287L,132861L,398581L,1195743L,3587227L,10761681L,32285041L,96855123L,290565367L,871696101L,2615088301L,7845264903L,23535794707L,70607384121L,211822152361L,635466457083L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122983Inst : IEnumerable<long>
{
public static readonly long[] Value=A122983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122983.Bytes);
public long this[int i]=>Value[i];

public static A122983Inst Instance=new A122983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122984
{
public static readonly long[] Value={ 8L,25L,22L,21L,4L,49L,8L,25L,16L,39L,4L,65L,8L,25L,34L,9L,4L,77L,6L,49L,4L,27L,4L,25L,8L,9L,8L,27L,4L,91L,4L,25L,16L,15L,4L,49L,8L,25L,10L,9L,4L,143L,6L,21L,4L,9L,4L,77L,6L,27L,4L,25L,4L,65L,8L,9L,8L,27L,4L,143L,4L,15L,22L,21L,4L,25L,8L,9L,8L,51L,4L,49L,4L,21L,16L,9L,4L,55L,6L,39L,4L,9L,4L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122984Inst : IEnumerable<long>
{
public static readonly long[] Value=A122984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122984.Bytes);
public long this[int i]=>Value[i];

public static A122984Inst Instance=new A122984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122985
{
public static readonly long[] Value={ 9L,27L,25L,25L,9L,55L,15L,33L,25L,49L,15L,77L,21L,39L,49L,25L,21L,95L,25L,69L,25L,49L,27L,49L,33L,35L,35L,55L,33L,121L,35L,57L,49L,49L,39L,85L,45L,63L,49L,49L,45L,185L,49L,65L,49L,55L,51L,125L,55L,77L,55L,77L,57L,119L,63L,65L,65L,85L,63L,203L,65L,77L,85L,85L,69L,91L,75L,77L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122985Inst : IEnumerable<long>
{
public static readonly long[] Value=A122985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122985.Bytes);
public long this[int i]=>Value[i];

public static A122985Inst Instance=new A122985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122986
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,24L,25L,36L,41L,44L,49L,56L,64L,76L,81L,84L,89L,96L,100L,104L,116L,121L,124L,129L,136L,144L,156L,161L,164L,169L,176L,184L,196L,201L,204L,209L,216L,224L,225L,236L,241L,244L,249L,256L,264L,276L,281L,284L,289L,296L,304L,316L,321L,324L,329L,336L,344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122986Inst : IEnumerable<long>
{
public static readonly long[] Value=A122986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122986.Bytes);
public long this[int i]=>Value[i];

public static A122986Inst Instance=new A122986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122987
{
public static readonly long[] Value={ 0L,1L,3L,7L,8L,9L,11L,13L,16L,17L,19L,21L,23L,24L,27L,29L,31L,32L,33L,37L,39L,41L,43L,47L,48L,49L,51L,53L,56L,57L,59L,61L,63L,64L,67L,69L,71L,72L,73L,77L,79L,81L,83L,87L,88L,89L,91L,93L,96L,97L,99L,101L,103L,104L,107L,109L,111L,112L,113L,117L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122987Inst : IEnumerable<long>
{
public static readonly long[] Value=A122987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122987.Bytes);
public long this[int i]=>Value[i];

public static A122987Inst Instance=new A122987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122988
{
public static readonly long[] Value={ 1L,1000L,159L,505L,52L,105L,102L,505L,52L,505L,22L,505L,52L,505L,102L,105L,52L,505L,102L,505L,12L,505L,102L,505L,52L,25L,102L,505L,52L,505L,22L,505L,52L,505L,102L,105L,52L,505L,102L,505L,12L,505L,102L,505L,52L,105L,102L,505L,52L,505L,6L,505L,52L,505L,102L,105L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122988Inst : IEnumerable<long>
{
public static readonly long[] Value=A122988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122988.Bytes);
public long this[int i]=>Value[i];

public static A122988Inst Instance=new A122988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122989
{
public static readonly long[] Value={ 1L,0L,2L,3L,4L,7L,6L,3L,2L,3L,9L,2L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122989Inst : IEnumerable<long>
{
public static readonly long[] Value=A122989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122989.Bytes);
public long this[int i]=>Value[i];

public static A122989Inst Instance=new A122989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122990
{
public static readonly long[] Value={ 8L,10L,11L,16L,22L,30L,34L,40L,42L,47L,49L,68L,74L,79L,168L,202L,245L,280L,463L,534L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122990Inst : IEnumerable<long>
{
public static readonly long[] Value=A122990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122990.Bytes);
public long this[int i]=>Value[i];

public static A122990Inst Instance=new A122990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122991
{
public static readonly long[] Value={ 2L,4L,5L,9L,85L,96L,213L,800L,4200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122991Inst : IEnumerable<long>
{
public static readonly long[] Value=A122991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122991.Bytes);
public long this[int i]=>Value[i];

public static A122991Inst Instance=new A122991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122992
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,-2L,-5L,-3L,27L,145L,382L,-24L,-6796L,-44972L,-167234L,-105302L,4182671L,41042943L,232150003L,618910867L,-4104725087L,-76739338173L,-670022786184L,-3614373261686L,-3033843119112L,208905541624840L,3094995814651910L,27593428414596086L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122992Inst : IEnumerable<long>
{
public static readonly long[] Value=A122992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122992.Bytes);
public long this[int i]=>Value[i];

public static A122992Inst Instance=new A122992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122993
{
public static readonly long[] Value={ 1L,1L,2L,5L,14L,43L,145L,538L,2194L,9796L,47635L,250811L,1421509L,8623112L,55693506L,381175374L,2753122695L,20909082797L,166448275680L,1385010594903L,12016912542681L,108481226052096L,1016937780320981L,9882191461530141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122993Inst : IEnumerable<long>
{
public static readonly long[] Value=A122993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122993.Bytes);
public long this[int i]=>Value[i];

public static A122993Inst Instance=new A122993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122994
{
public static readonly long[] Value={ 1L,3L,12L,39L,147L,498L,1821L,6303L,22692L,79419L,283647L,998418L,3551241L,12537003L,44498172L,157331199L,557814747L,1973795538L,6994128261L,24758288103L,87705442452L,310530035379L,1099879017447L,3894649335858L,13793560492881L,48845404515603L,172987448951532L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122994Inst : IEnumerable<long>
{
public static readonly long[] Value=A122994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122994.Bytes);
public long this[int i]=>Value[i];

public static A122994Inst Instance=new A122994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122995
{
public static readonly long[] Value={ 1L,5L,30L,155L,905L,4780L,27405L,146905L,832030L,4504655L,25305405L,137921780L,770556905L,4218601405L,23482524030L,128947559155L,716010659905L,3939699638780L,21839966136405L,120332457105905L,666331610516030L,3674643038163655L,20332933301064405L,112199009255155780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122995Inst : IEnumerable<long>
{
public static readonly long[] Value=A122995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122995.Bytes);
public long this[int i]=>Value[i];

public static A122995Inst Instance=new A122995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122996
{
public static readonly long[] Value={ 1L,7L,56L,399L,3143L,22694L,176701L,1288707L,9947056L,73093699L,560499443L,4142090694L,31606563401L,234569007407L,1783290614056L,13277171976999L,100658412065743L,751239838938694L,5683502030160101L,42494254138156107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122996Inst : IEnumerable<long>
{
public static readonly long[] Value=A122996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122996.Bytes);
public long this[int i]=>Value[i];

public static A122996Inst Instance=new A122996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122997
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,1L,1L,1L,3L,5L,11L,21L,41L,81L,159L,313L,615L,1209L,2377L,4673L,9187L,18061L,35507L,69805L,137233L,269793L,530399L,1042737L,2049967L,4030129L,7923025L,15576257L,30622115L,60201493L,118353019L,232675909L,457428793L,899281329L,1767940543L,3475679593L,6833006167L,13433336425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122997Inst : IEnumerable<long>
{
public static readonly long[] Value=A122997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122997.Bytes);
public long this[int i]=>Value[i];

public static A122997Inst Instance=new A122997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122998
{
public static readonly long[] Value={ 1L,5L,8L,1L,9L,3L,4L,8L,2L,2L,5L,4L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122998Inst : IEnumerable<long>
{
public static readonly long[] Value=A122998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122998.Bytes);
public long this[int i]=>Value[i];

public static A122998Inst Instance=new A122998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122999
{
public static readonly long[] Value={ 1L,1L,26L,51L,701L,1976L,19501L,68901L,556426L,2278951L,16189601L,73163376L,477903401L,2306987801L,14254572826L,71929267851L,428293588501L,2226525284776L,12933864997301L,68596997116701L,391943622049226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122999Inst : IEnumerable<long>
{
public static readonly long[] Value=A122999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122999.Bytes);
public long this[int i]=>Value[i];

public static A122999Inst Instance=new A122999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123000
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,14L,15L,20L,35L,63L,80L,99L,104L,195L,224L,384L,440L,560L,935L,1224L,1539L,2015L,2079L,5264L,5984L,12375L,21735L,41040L,78624L,123200L,126224L,156519L,176175L,201824L,313599L,338624L,395199L,453375L,638000L,1154439L,1890944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123000Inst : IEnumerable<long>
{
public static readonly long[] Value=A123000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123000.Bytes);
public long this[int i]=>Value[i];

public static A123000Inst Instance=new A123000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123001
{
public static readonly long[] Value={ 10L,100L,101L,1000L,1001L,1010L,1011L,10000L,10001L,10010L,10011L,10100L,10101L,10110L,10111L,100000L,100001L,100010L,100011L,100100L,100101L,100110L,100111L,101000L,101001L,101010L,101011L,101100L,101101L,101110L,101111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123001Inst : IEnumerable<long>
{
public static readonly long[] Value=A123001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123001.Bytes);
public long this[int i]=>Value[i];

public static A123001Inst Instance=new A123001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123002
{
public static readonly long[] Value={ 0L,-1L,0L,-1L,2L,0L,1L,10L,12L,0L,7L,30L,44L,40L,0L,21L,74L,116L,136L,112L,0L,51L,166L,268L,344L,368L,288L,0L,113L,354L,580L,776L,912L,928L,704L,0L,239L,734L,1212L,1656L,2032L,2272L,2240L,1664L,0L,493L,1498L,2484L,3432L,4304L,5024L,5440L,5248L,3840L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123002Inst : IEnumerable<long>
{
public static readonly long[] Value=A123002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123002.Bytes);
public long this[int i]=>Value[i];

public static A123002Inst Instance=new A123002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123003
{
public static readonly long[] Value={ 8L,75L,463L,2394L,11274L,50265L,216581L,912648L,3788560L,15565095L,63484779L,257591862L,1041276566L,4197718965L,16888451857L,67845945636L,272258886492L,1091657974275L,4374492890615L,17521540911570L,70156842333538L,280839342481425L,1123993155149853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123003Inst : IEnumerable<long>
{
public static readonly long[] Value=A123003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123003.Bytes);
public long this[int i]=>Value[i];

public static A123003Inst Instance=new A123003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123004
{
public static readonly long[] Value={ 0L,1L,2L,29L,108L,941L,4582L,32689L,179928L,1177081L,6852362L,43131749L,257572548L,1593438821L,9626191342L,59088353209L,358831489968L,2194871810161L,13360530869522L,81592856993069L,497198985724188L,3034219396275101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123004Inst : IEnumerable<long>
{
public static readonly long[] Value=A123004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123004.Bytes);
public long this[int i]=>Value[i];

public static A123004Inst Instance=new A123004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123005
{
public static readonly long[] Value={ 0L,1L,2L,53L,204L,3005L,16006L,179257L,1142808L,11069209L,78136010L,698663261L,5225991012L,44686481813L,345446523214L,2880530655265L,22687940948016L,186521884004017L,1484752874460818L,12109078065118469L,96971046978817020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123005Inst : IEnumerable<long>
{
public static readonly long[] Value=A123005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123005.Bytes);
public long this[int i]=>Value[i];

public static A123005Inst Instance=new A123005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123006
{
public static readonly long[] Value={ 0L,1L,2L,125L,492L,16109L,91750L,2132689L,15367128L,288789625L,2437001738L,39817548101L,374512306500L,5566947933221L,56449884952942L,786500469825625L,8403437018957232L,111973430886815089L,1240762741067455250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123006Inst : IEnumerable<long>
{
public static readonly long[] Value=A123006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123006.Bytes);
public long this[int i]=>Value[i];

public static A123006Inst Instance=new A123006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123007
{
public static readonly long[] Value={ 1L,3L,15L,57L,249L,1011L,4263L,17625L,73617L,305859L,1274271L,5301273L,22070985L,91853427L,382345719L,1591372281L,6623856033L,27570062595L,114754829487L,477640222329L,1988073910041L,8274909821043L,34442484832455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123007Inst : IEnumerable<long>
{
public static readonly long[] Value=A123007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123007.Bytes);
public long this[int i]=>Value[i];

public static A123007Inst Instance=new A123007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123008
{
public static readonly long[] Value={ 1L,5L,35L,195L,1265L,7405L,46435L,277995L,1716865L,10383605L,63688835L,386967795L,2366156465L,14406507805L,87966927235L,536096549595L,3271366280065L,19945146300005L,121674449601635L,741977556703395L,4525816353447665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123008Inst : IEnumerable<long>
{
public static readonly long[] Value=A123008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123008.Bytes);
public long this[int i]=>Value[i];

public static A123008Inst Instance=new A123008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123009
{
public static readonly long[] Value={ 1L,7L,63L,469L,4025L,31031L,259287L,2039093L,16783249L,133482055L,1089343311L,8719307317L,70816436873L,568878932279L,4607763271335L,37090594224341L,299961588744097L,2417362294480903L,19532842437422559L,157516437304409365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123009Inst : IEnumerable<long>
{
public static readonly long[] Value=A123009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123009.Bytes);
public long this[int i]=>Value[i];

public static A123009Inst Instance=new A123009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123010
{
public static readonly long[] Value={ 1L,0L,4L,16L,84L,416L,2084L,10416L,52084L,260416L,1302084L,6510416L,32552084L,162760416L,813802084L,4069010416L,20345052084L,101725260416L,508626302084L,2543131510416L,12715657552084L,63578287760416L,317891438802084L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123010Inst : IEnumerable<long>
{
public static readonly long[] Value=A123010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123010.Bytes);
public long this[int i]=>Value[i];

public static A123010Inst Instance=new A123010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123011
{
public static readonly long[] Value={ 1L,5L,15L,55L,185L,645L,2215L,7655L,26385L,91045L,314015L,1083255L,3736585L,12889445L,44461815L,153370855L,529050785L,1824955845L,6295165615L,21715110455L,74906048985L,258387650245L,891305545415L,3074549342055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123011Inst : IEnumerable<long>
{
public static readonly long[] Value=A123011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123011.Bytes);
public long this[int i]=>Value[i];

public static A123011Inst Instance=new A123011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123012
{
public static readonly long[] Value={ 1L,2L,25L,92L,709L,3350L,21589L,113528L,680425L,3744938L,21778801L,122201300L,701757421L,3969742142L,22676390125L,128717365232L,733638923089L,4170342516050L,23747102416969L,135071397670988L,768831946098325L,4374163243287398L,24893797354639621L,141645022818314600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123012Inst : IEnumerable<long>
{
public static readonly long[] Value=A123012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123012.Bytes);
public long this[int i]=>Value[i];

public static A123012Inst Instance=new A123012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123013
{
public static readonly BigInteger[] Value={ 1L,0L,-253L,-1288L,191521L,1629320L,-141854525L,-1729034384L,103325091969L,1676517701264L,-73862084838333L,-1537330036703384L,51664189190888737L,1355829753195189272L,BigInteger.Parse("-35196896202269431421"),BigInteger.Parse("-1160994902209537876768"),BigInteger.Parse("23182613727557891170817"),BigInteger.Parse("970833262148740191853344") };
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
public class A123013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123013Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A123013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123013.Bytes);
public BigInteger this[int i]=>Value[i];

public static A123013Inst Instance=new A123013Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123014
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,25L,145L,1225L,7105L,28945L,165025L,4675825L,62610625L,961986025L,10237051825L,76785333625L,824649450625L,30519166302625L,643373556450625L,14253164811510625L,221377260570090625L,2460131161228365625L,BigInteger.Parse("39063024216812220625"),BigInteger.Parse("1791544805630470515625") };
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
public class A123014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123014Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A123014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123014.Bytes);
public BigInteger this[int i]=>Value[i];

public static A123014Inst Instance=new A123014Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123015
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,10L,13L,17L,21L,26L,33L,41L,50L,62L,77L,94L,115L,142L,174L,212L,260L,319L,389L,475L,582L,711L,867L,1060L,1296L,1581L,1930L,2359L,2880L,3514L,4292L,5242L,6397L,7809L,9537L,11642L,14209L,17349L,21182L,25854L,31561L,38534L,47039L,57418L,70098L,85576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123015Inst : IEnumerable<long>
{
public static readonly long[] Value=A123015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123015.Bytes);
public long this[int i]=>Value[i];

public static A123015Inst Instance=new A123015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123016
{
public static readonly long[] Value={ 1L,1L,4L,0L,32L,-64L,384L,-1280L,5632L,-21504L,88064L,-348160L,1400832L,-5586944L,22380544L,-89456640L,357957632L,-1431568384L,5726797824L,-22906142720L,91626668032L,-366502477824L,1466018299904L,-5864056422400L,23456259244032L,-93824969867264L,375300013686784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123016Inst : IEnumerable<long>
{
public static readonly long[] Value=A123016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123016.Bytes);
public long this[int i]=>Value[i];

public static A123016Inst Instance=new A123016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123017
{
public static readonly long[] Value={ 6L,22L,35L,46L,55L,62L,74L,82L,91L,115L,118L,119L,142L,143L,155L,158L,166L,202L,203L,206L,214L,215L,218L,259L,262L,295L,298L,299L,302L,323L,326L,355L,358L,362L,391L,395L,451L,466L,478L,482L,502L,511L,514L,526L,535L,542L,551L,559L,562L,583L,586L,611L,623L,626L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123017Inst : IEnumerable<long>
{
public static readonly long[] Value=A123017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123017.Bytes);
public long this[int i]=>Value[i];

public static A123017Inst Instance=new A123017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123018
{
public static readonly long[] Value={ 1L,1L,-2L,1L,-2L,2L,1L,-2L,1L,-1L,1L,-2L,0L,2L,0L,1L,-2L,-1L,5L,-4L,0L,1L,-2L,-2L,8L,-7L,2L,1L,1L,-2L,-3L,11L,-9L,0L,3L,-2L,1L,-2L,-4L,14L,-10L,-6L,12L,-6L,2L,1L,-2L,-5L,17L,-10L,-16L,27L,-15L,3L,-1L,1L,-2L,-6L,20L,-9L,-30L,47L,-24L,0L,4L,0L,1L,-2L,-7L,23L,-7L,-48L,71L,-28L,-18L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123018Inst : IEnumerable<long>
{
public static readonly long[] Value=A123018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123018.Bytes);
public long this[int i]=>Value[i];

public static A123018Inst Instance=new A123018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123019
{
public static readonly long[] Value={ 1L,1L,1L,1L,-1L,1L,3L,-4L,1L,1L,6L,-9L,3L,1L,10L,-15L,3L,3L,-1L,1L,15L,-20L,-6L,18L,-8L,1L,1L,21L,-21L,-35L,60L,-30L,5L,1L,28L,-14L,-98L,145L,-70L,5L,5L,-1L,1L,36L,6L,-210L,279L,-100L,-45L,45L,-12L,1L,1L,45L,45L,-384L,441L,-21L,-280L,210L,-63L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123019Inst : IEnumerable<long>
{
public static readonly long[] Value=A123019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123019.Bytes);
public long this[int i]=>Value[i];

public static A123019Inst Instance=new A123019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123020
{
public static readonly long[] Value={ 1L,1L,2L,5L,14L,43L,142L,493L,1766L,6443L,23750L,88045L,327406L,1219531L,4546622L,16958765L,63272054L,236096683L,881049142L,3287968813L,12270563966L,45793762763L,170903438510L,637817894125L,2380363943686L,8883629492011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123020Inst : IEnumerable<long>
{
public static readonly long[] Value=A123020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123020.Bytes);
public long this[int i]=>Value[i];

public static A123020Inst Instance=new A123020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123021
{
public static readonly long[] Value={ 1L,2L,-1L,3L,-2L,4L,-2L,-2L,1L,5L,0L,-9L,6L,-1L,6L,5L,-24L,18L,-4L,7L,14L,-49L,36L,-4L,-4L,1L,8L,28L,-84L,50L,20L,-30L,10L,-1L,9L,48L,-126L,36L,115L,-120L,45L,-6L,10L,75L,-168L,-48L,358L,-335L,120L,-6L,-6L,1L,11L,110L,-198L,-264L,847L,-714L,175L,84L,-63L,14L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123021Inst : IEnumerable<long>
{
public static readonly long[] Value=A123021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123021.Bytes);
public long this[int i]=>Value[i];

public static A123021Inst Instance=new A123021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123022
{
public static readonly long[] Value={ 1L,1L,-2L,-1L,0L,-1L,0L,-3L,0L,-15L,0L,-105L,0L,-945L,0L,-10395L,0L,-135135L,0L,-2027025L,0L,-34459425L,0L,-654729075L,0L,-13749310575L,0L,-316234143225L,0L,-7905853580625L,0L,-213458046676875L,0L,-6190283353629375L,0L,-191898783962510625L,0L,-6332659870762850625L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123022Inst : IEnumerable<long>
{
public static readonly long[] Value=A123022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123022.Bytes);
public long this[int i]=>Value[i];

public static A123022Inst Instance=new A123022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123023
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,3L,0L,15L,0L,105L,0L,945L,0L,10395L,0L,135135L,0L,2027025L,0L,34459425L,0L,654729075L,0L,13749310575L,0L,316234143225L,0L,7905853580625L,0L,213458046676875L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123023Inst : IEnumerable<long>
{
public static readonly long[] Value=A123023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123023.Bytes);
public long this[int i]=>Value[i];

public static A123023Inst Instance=new A123023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123024
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,8L,12L,28L,60L,112L,284L,652L,1404L,3776L,9228L,22028L,62092L,160448L,414540L,1216012L,3302604L,9092272L,27622844L,78446956L,227652828L,713772368L,2110379772L,6405093068L,20668461340L,63385346912L,200011067244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123024Inst : IEnumerable<long>
{
public static readonly long[] Value=A123024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123024.Bytes);
public long this[int i]=>Value[i];

public static A123024Inst Instance=new A123024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123025
{
public static readonly BigInteger[] Value={ 1L,1L,-1L,-5L,11L,95L,-319L,-3895L,17545L,276545L,-1561505L,-30143405L,204557155L,4672227775L,-37024845055L,-976495604975L,8848937968145L,264630308948225L,-2698926080284225L,-90238935351344725L,1022892984427721275L,BigInteger.Parse("37810113912213439775"),BigInteger.Parse("-471553665821179507775") };
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
public class A123025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123025Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A123025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123025.Bytes);
public BigInteger this[int i]=>Value[i];

public static A123025Inst Instance=new A123025Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123026
{
public static readonly BigInteger[] Value={ 1L,1L,-1L,2L,-7L,28L,-161L,952L,-7567L,59024L,-597793L,5784352L,-71137367L,821377984L,-11879940289L,159347328896L,-2649226684447L,40474221539584L,-760328058436289L,13032699335746048L,-272957772978627751L,5187014335626927104L,BigInteger.Parse("-119828462337617582689"),BigInteger.Parse("2500140909772178864128") };
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
public class A123026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123026Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A123026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123026.Bytes);
public BigInteger this[int i]=>Value[i];

public static A123026Inst Instance=new A123026Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123027
{
public static readonly long[] Value={ 1L,-2L,3L,3L,-10L,8L,-4L,22L,-38L,21L,5L,-40L,111L,-130L,55L,-6L,65L,-256L,474L,-420L,144L,7L,-98L,511L,-1324L,1836L,-1308L,377L,-8L,140L,-924L,3130L,-6020L,6666L,-3970L,987L,9L,-192L,1554L,-6588L,16435L,-25088L,23109L,-11822L,2584L,-10L,255L,-2472L,12720L,-39430L,77645L,-98160L,77378L,-34690L,6765L,11L,-330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123027Inst : IEnumerable<long>
{
public static readonly long[] Value=A123027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123027.Bytes);
public long this[int i]=>Value[i];

public static A123027Inst Instance=new A123027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123028
{
public static readonly BigInteger[] Value={ 1L,1L,19L,37L,1159L,3367L,147193L,569023L,31940881L,154205233L,10572431611L,61219477501L,4958470425559L,33487054193047L,3128794838527729L,24144166073186887L,2556225383077154593L,BigInteger.Parse("22188488621258749153") };
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
public class A123028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123028Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A123028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123028.Bytes);
public BigInteger this[int i]=>Value[i];

public static A123028Inst Instance=new A123028Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123029
{
public static readonly BigInteger[] Value={ 1L,1L,2L,3L,10L,24L,130L,504L,4420L,27720L,393380L,3991680L,91657540L,1504863360L,55911099400L,1485300136320L,89290025741800L,3838015552250880L,373321597626465800L,BigInteger.Parse("25964175210977203200"),BigInteger.Parse("4086378207619294646800") };
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
public class A123029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123029Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A123029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123029.Bytes);
public BigInteger this[int i]=>Value[i];

public static A123029Inst Instance=new A123029Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123030
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,8L,11L,13L,14L,15L,17L,18L,19L,20L,26L,27L,29L,30L,32L,33L,34L,35L,38L,40L,41L,44L,46L,47L,48L,49L,57L,58L,59L,60L,64L,65L,66L,67L,70L,71L,72L,73L,75L,77L,78L,79L,85L,87L,89L,90L,92L,93L,96L,97L,100L,101L,102L,103L,105L,106L,107L,109L,122L,123L,124L,125L,127L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123030Inst : IEnumerable<long>
{
public static readonly long[] Value=A123030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123030.Bytes);
public long this[int i]=>Value[i];

public static A123030Inst Instance=new A123030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123031
{
public static readonly long[] Value={ 2L,3L,3L,5L,4L,5L,7L,6L,6L,7L,9L,8L,7L,8L,11L,11L,10L,9L,9L,12L,13L,13L,12L,11L,10L,13L,14L,17L,15L,14L,13L,12L,12L,15L,18L,19L,17L,16L,15L,14L,13L,14L,19L,20L,23L,19L,18L,17L,16L,15L,15L,16L,21L,24L,29L,21L,20L,19L,18L,17L,16L,17L,20L,25L,30L,31L,23L,22L,21L,20L,19L,18L,18L,21L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123031Inst : IEnumerable<long>
{
public static readonly long[] Value=A123031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123031.Bytes);
public long this[int i]=>Value[i];

public static A123031Inst Instance=new A123031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123032
{
public static readonly long[] Value={ 3L,307L,487L,9043L,16871L,17293L,17863L,23057L,32359L,32801L,33857L,36739L,40787L,43669L,50599L,59051L,59113L,62417L,65537L,76099L,101267L,104149L,107777L,135893L,160073L,161053L,164419L,249107L,249857L,256609L,259733L,266663L,338909L,340649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123032Inst : IEnumerable<long>
{
public static readonly long[] Value=A123032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123032.Bytes);
public long this[int i]=>Value[i];

public static A123032Inst Instance=new A123032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123033
{
public static readonly long[] Value={ 97L,277L,761L,1511L,1753L,2081L,3221L,3643L,6197L,7517L,7841L,8263L,10067L,10399L,10903L,16903L,25639L,32771L,32833L,33013L,33647L,33889L,35059L,36137L,39019L,40577L,40819L,48563L,49639L,57383L,59083L,59567L,60317L,61129L,62207L,63199L,66383L,66889L,100003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123033Inst : IEnumerable<long>
{
public static readonly long[] Value=A123033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123033.Bytes);
public long this[int i]=>Value[i];

public static A123033Inst Instance=new A123033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123034
{
public static readonly long[] Value={ 5L,67L,1301L,1543L,2113L,2293L,2777L,3191L,3253L,3347L,3371L,3433L,3613L,4339L,5237L,5417L,5659L,6229L,6737L,7307L,7549L,7873L,8053L,8537L,8803L,9377L,9439L,9619L,9857L,10099L,11177L,11423L,11927L,12743L,15797L,15859L,16811L,17053L,17183L,18679L,18919L,19163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123034Inst : IEnumerable<long>
{
public static readonly long[] Value=A123034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123034.Bytes);
public long this[int i]=>Value[i];

public static A123034Inst Instance=new A123034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123035
{
public static readonly long[] Value={ 37L,521L,1091L,1153L,1997L,2083L,2239L,3137L,3559L,4129L,4153L,4457L,4637L,5449L,6199L,7253L,8147L,8573L,9319L,9323L,10069L,10463L,11959L,14029L,15083L,15649L,16649L,16843L,16883L,17327L,17389L,17569L,17959L,18077L,18773L,18803L,19373L,20029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123035Inst : IEnumerable<long>
{
public static readonly long[] Value=A123035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123035.Bytes);
public long this[int i]=>Value[i];

public static A123035Inst Instance=new A123035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123036
{
public static readonly long[] Value={ 7L,131L,193L,311L,373L,491L,733L,857L,1061L,1123L,1217L,1279L,1303L,1427L,1459L,1607L,1787L,2029L,2053L,2357L,3169L,3373L,3677L,3739L,3833L,3919L,4099L,4583L,5153L,5419L,5903L,6317L,6379L,6473L,7043L,7309L,7793L,7937L,8117L,8179L,8297L,8363L,8539L,8543L,8867L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123036Inst : IEnumerable<long>
{
public static readonly long[] Value=A123036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123036.Bytes);
public long this[int i]=>Value[i];

public static A123036Inst Instance=new A123036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123037
{
public static readonly long[] Value={ 101L,163L,281L,467L,523L,647L,827L,1031L,1069L,1093L,1217L,1249L,1459L,1733L,1999L,2389L,3163L,3319L,3467L,3529L,3623L,3709L,3803L,3889L,4217L,4373L,4397L,4639L,4943L,5209L,5333L,5693L,5849L,6263L,6287L,6529L,6653L,6833L,7013L,7411L,7583L,7907L,8087L,8329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123037Inst : IEnumerable<long>
{
public static readonly long[] Value=A123037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123037.Bytes);
public long this[int i]=>Value[i];

public static A123037Inst Instance=new A123037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123038
{
public static readonly long[] Value={ 71L,251L,257L,313L,499L,617L,797L,859L,977L,1039L,1063L,1187L,1249L,1367L,1429L,1523L,1609L,1789L,1913L,2179L,2273L,2297L,2539L,2663L,2843L,3023L,3109L,3257L,3319L,3413L,3499L,3593L,3617L,3803L,4373L,4733L,4889L,5179L,5303L,5483L,5639L,5881L,6257L,6389L,6451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123038Inst : IEnumerable<long>
{
public static readonly long[] Value=A123038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123038.Bytes);
public long this[int i]=>Value[i];

public static A123038Inst Instance=new A123038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123039
{
public static readonly long[] Value={ 11L,73L,197L,439L,557L,563L,619L,743L,1103L,1283L,1307L,1493L,1549L,2243L,2251L,2399L,2423L,2579L,2969L,3001L,3259L,3329L,3391L,3539L,3571L,3719L,3923L,4079L,4289L,4493L,4649L,4673L,5039L,5281L,5399L,5641L,5851L,6211L,6359L,6367L,6421L,6563L,6719L,6781L,6961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123039Inst : IEnumerable<long>
{
public static readonly long[] Value=A123039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123039.Bytes);
public long this[int i]=>Value[i];

public static A123039Inst Instance=new A123039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A123040
{
public static readonly long[] Value={ 43L,167L,229L,347L,353L,409L,769L,1097L,1277L,1283L,1439L,1619L,1823L,1861L,1979L,2003L,2089L,2213L,2221L,2393L,2549L,2579L,2729L,2791L,2939L,2971L,3001L,3119L,3167L,3181L,3229L,3299L,3323L,3329L,3361L,3533L,3541L,3571L,3697L,3931L,4049L,4079L,4111L,4159L,4259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A123040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A123040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A123040Inst : IEnumerable<long>
{
public static readonly long[] Value=A123040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A123040.Bytes);
public long this[int i]=>Value[i];

public static A123040Inst Instance=new A123040Inst();

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