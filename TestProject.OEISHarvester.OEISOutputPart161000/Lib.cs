using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A276265
{
public static readonly long[] Value={ 1L,8L,42L,204L,972L,4608L,21816L,103248L,488592L,2312064L,10940832L,51772608L,244990656L,1159308288L,5485905792L,25959585024L,122842075392L,581294942208L,2750717200896L,13016533552128L,61594898107392L,291470187331584L,1379251735345152L,6526689288081408L,30884625316417536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276265Inst : IEnumerable<long>
{
public static readonly long[] Value=A276265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276265.Bytes);
public long this[int i]=>Value[i];

public static A276265Inst Instance=new A276265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276266
{
public static readonly BigInteger[] Value={ 1L,1L,1L,4L,25L,10201L,16259565169L,BigInteger.Parse("1100432328310492581042546436"),BigInteger.Parse("31383529740086705883339675381564403354342372463018335778292540655564225") };
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
public class A276266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276266Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276266.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276266Inst Instance=new A276266Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276267
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,2L,5L,101L,1020101L,132690278976255013L,BigInteger.Parse("37379828474243017116309068570169440106423243719554") };
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
public class A276267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276267Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276267.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276267Inst Instance=new A276267Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276268
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,4L,25L,10201L,1040606050201L,BigInteger.Parse("17606710134796383100801078407630169"),BigInteger.Parse("1397251576763829044923817239566095383950667477080314561212188721224520791793149263311589905001958916") };
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
public class A276268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276268Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276268.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276268Inst Instance=new A276268Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276269
{
public static readonly long[] Value={ 1L,4L,6L,6L,10L,9L,14L,10L,12L,15L,22L,15L,26L,21L,18L,18L,34L,21L,38L,25L,24L,33L,46L,27L,30L,39L,30L,35L,58L,35L,62L,34L,36L,51L,40L,39L,74L,57L,42L,45L,82L,49L,86L,55L,48L,69L,94L,51L,56L,55L,54L,65L,106L,57L,60L,63L,60L,87L,118L,65L,122L,93L,66L,66L,70L,77L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276269Inst : IEnumerable<long>
{
public static readonly long[] Value=A276269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276269.Bytes);
public long this[int i]=>Value[i];

public static A276269Inst Instance=new A276269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276270
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,6L,3L,4L,15L,10L,11L,6L,11L,6L,15L,8L,17L,30L,27L,10L,9L,22L,23L,12L,25L,22L,45L,6L,29L,30L,27L,16L,33L,34L,15L,30L,47L,54L,33L,20L,41L,18L,51L,22L,75L,46L,47L,24L,21L,50L,51L,22L,53L,90L,55L,12L,81L,58L,59L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276270Inst : IEnumerable<long>
{
public static readonly long[] Value=A276270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276270.Bytes);
public long this[int i]=>Value[i];

public static A276270Inst Instance=new A276270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276271
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,6L,46L,2206L,4870846L,3954191749561L,BigInteger.Parse("339905052007042640998641"),BigInteger.Parse("52373274877565894156748130733610185904753361"),BigInteger.Parse("563138297002425210235477817802336090254190075906443582099838858026136728896536841") };
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
public class A276271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276271Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276271.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276271Inst Instance=new A276271Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276272
{
public static readonly long[] Value={ 1L,1L,1L,4L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276272Inst : IEnumerable<long>
{
public static readonly long[] Value=A276272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276272.Bytes);
public long this[int i]=>Value[i];

public static A276272Inst Instance=new A276272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276273
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,2L,4L,3L,3L,4L,2L,3L,5L,4L,4L,3L,3L,4L,4L,5L,3L,2L,4L,3L,5L,6L,4L,5L,5L,4L,4L,3L,3L,4L,4L,5L,5L,4L,6L,5L,3L,4L,2L,3L,5L,4L,4L,3L,5L,6L,6L,7L,5L,4L,6L,5L,5L,6L,4L,5L,5L,4L,4L,3L,3L,4L,4L,5L,5L,4L,6L,5L,5L,6L,4L,5L,7L,6L,6L,5L,3L,4L,4L,5L,3L,2L,4L,3L,5L,6L,4L,5L,5L,4L,4L,3L,5L,6L,6L,7L,7L,6L,8L,7L,5L,6L,4L,5L,7L,6L,6L,5L,5L,6L,6L,7L,5L,4L,6L,5L,5L,6L,4L,5L,5L,4L,4L,3L,3L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276273Inst : IEnumerable<long>
{
public static readonly long[] Value=A276273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276273.Bytes);
public long this[int i]=>Value[i];

public static A276273Inst Instance=new A276273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276274
{
public static readonly BigInteger[] Value={ 1L,387420489L,BigInteger.Parse("88817841970012523233890533447265625"),BigInteger.Parse("66009724686219550843768321818371771650147004059278069406814190436565131829325062449") };
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
public class A276274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276274Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276274.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276274Inst Instance=new A276274Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276275
{
public static readonly long[] Value={ 2L,2L,0L,4L,2L,4L,6L,6L,10L,12L,16L,22L,28L,38L,50L,66L,88L,116L,154L,204L,270L,358L,474L,628L,832L,1102L,1460L,1934L,2562L,3394L,4496L,5956L,7890L,10452L,13846L,18342L,24298L,32188L,42640L,56486L,74828L,99126L,131314L,173954L,230440L,305268L,404394L,535708L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276275Inst : IEnumerable<long>
{
public static readonly long[] Value=A276275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276275.Bytes);
public long this[int i]=>Value[i];

public static A276275Inst Instance=new A276275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276324
{
public static readonly long[] Value={ 1L,4L,5L,7L,8L,14L,15L,17L,18L,19L,20L,23L,24L,30L,31L,34L,35L,40L,41L,43L,44L,45L,46L,49L,50L,54L,56L,59L,60L,62L,63L,65L,68L,69L,72L,77L,78L,81L,82L,85L,86L,89L,90L,93L,94L,95L,96L,101L,103L,106L,108L,111L,113L,114L,116L,119L,120L,122L,123L,125L,127L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276324Inst : IEnumerable<long>
{
public static readonly long[] Value=A276324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276324.Bytes);
public long this[int i]=>Value[i];

public static A276324Inst Instance=new A276324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276325
{
public static readonly long[] Value={ 0L,-1L,2L,-2L,1L,-3L,4L,-4L,3L,6L,-5L,-6L,5L,-7L,8L,7L,-8L,-9L,10L,-10L,9L,12L,-11L,-12L,11L,13L,-13L,-14L,15L,-15L,16L,-16L,17L,14L,-17L,-18L,19L,18L,-19L,-20L,21L,22L,-21L,-22L,23L,20L,-23L,-24L,24L,-25L,25L,26L,-26L,27L,-27L,-28L,29L,-29L,30L,-30L,28L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276325Inst : IEnumerable<long>
{
public static readonly long[] Value=A276325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276325.Bytes);
public long this[int i]=>Value[i];

public static A276325Inst Instance=new A276325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276326
{
public static readonly long[] Value={ 0L,1L,2L,3L,10L,11L,12L,13L,20L,21L,22L,23L,30L,31L,32L,33L,40L,41L,100L,101L,102L,103L,110L,111L,112L,113L,120L,121L,122L,123L,130L,131L,132L,133L,140L,141L,200L,201L,202L,203L,210L,211L,212L,213L,220L,221L,222L,223L,230L,231L,232L,233L,240L,241L,300L,301L,302L,303L,310L,311L,312L,313L,320L,321L,322L,323L,330L,331L,332L,333L,340L,341L,400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276326Inst : IEnumerable<long>
{
public static readonly long[] Value=A276326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276326.Bytes);
public long this[int i]=>Value[i];

public static A276326Inst Instance=new A276326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276327
{
public static readonly long[] Value={ 0L,1L,2L,3L,1L,1L,2L,3L,2L,1L,2L,3L,3L,1L,2L,3L,4L,1L,1L,1L,2L,3L,1L,1L,2L,3L,2L,1L,2L,3L,3L,1L,2L,3L,4L,1L,2L,1L,2L,3L,1L,1L,2L,3L,2L,1L,2L,3L,3L,1L,2L,3L,4L,1L,3L,1L,2L,3L,1L,1L,2L,3L,2L,1L,2L,3L,3L,1L,2L,3L,4L,1L,4L,1L,2L,3L,1L,1L,2L,3L,2L,1L,2L,3L,3L,1L,2L,3L,4L,1L,5L,1L,2L,3L,1L,1L,1L,1L,2L,3L,1L,1L,2L,3L,2L,1L,2L,3L,3L,1L,2L,3L,4L,1L,1L,1L,2L,3L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276327Inst : IEnumerable<long>
{
public static readonly long[] Value=A276327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276327.Bytes);
public long this[int i]=>Value[i];

public static A276327Inst Instance=new A276327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276328
{
public static readonly long[] Value={ 0L,1L,2L,3L,1L,2L,3L,4L,2L,3L,4L,5L,3L,4L,5L,6L,4L,5L,1L,2L,3L,4L,2L,3L,4L,5L,3L,4L,5L,6L,4L,5L,6L,7L,5L,6L,2L,3L,4L,5L,3L,4L,5L,6L,4L,5L,6L,7L,5L,6L,7L,8L,6L,7L,3L,4L,5L,6L,4L,5L,6L,7L,5L,6L,7L,8L,6L,7L,8L,9L,7L,8L,4L,5L,6L,7L,5L,6L,7L,8L,6L,7L,8L,9L,7L,8L,9L,10L,8L,9L,5L,6L,7L,8L,6L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276328Inst : IEnumerable<long>
{
public static readonly long[] Value=A276328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276328.Bytes);
public long this[int i]=>Value[i];

public static A276328Inst Instance=new A276328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276329
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,3L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,3L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,3L,1L,2L,1L,1L,1L,4L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,3L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276329Inst : IEnumerable<long>
{
public static readonly long[] Value=A276329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276329.Bytes);
public long this[int i]=>Value[i];

public static A276329Inst Instance=new A276329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276330
{
public static readonly long[] Value={ 0L,1L,1L,1L,4L,1L,1L,1L,4L,1L,1L,1L,4L,1L,1L,1L,4L,1L,18L,1L,4L,1L,1L,1L,4L,1L,1L,1L,4L,1L,1L,1L,4L,1L,1L,1L,18L,1L,1L,1L,4L,1L,1L,1L,4L,1L,1L,1L,4L,1L,1L,1L,4L,1L,18L,1L,4L,1L,1L,1L,4L,1L,1L,1L,4L,1L,1L,1L,4L,1L,1L,1L,18L,1L,1L,1L,4L,1L,1L,1L,4L,1L,1L,1L,4L,1L,1L,1L,4L,1L,18L,1L,4L,1L,1L,1L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276330Inst : IEnumerable<long>
{
public static readonly long[] Value=A276330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276330.Bytes);
public long this[int i]=>Value[i];

public static A276330Inst Instance=new A276330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276331
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,4L,5L,6L,4L,8L,9L,10L,8L,12L,13L,14L,12L,16L,0L,18L,16L,20L,21L,22L,20L,24L,25L,26L,24L,28L,29L,30L,28L,32L,33L,34L,18L,36L,37L,38L,36L,40L,41L,42L,40L,44L,45L,46L,44L,48L,49L,50L,48L,52L,36L,54L,52L,56L,57L,58L,56L,60L,61L,62L,60L,64L,65L,66L,64L,68L,69L,70L,54L,72L,73L,74L,72L,76L,77L,78L,76L,80L,81L,82L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276331Inst : IEnumerable<long>
{
public static readonly long[] Value=A276331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276331.Bytes);
public long this[int i]=>Value[i];

public static A276331Inst Instance=new A276331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276332
{
public static readonly long[] Value={ 0L,1L,2L,3L,1L,2L,3L,4L,2L,3L,4L,5L,3L,4L,5L,6L,4L,5L,1L,2L,5L,6L,7L,8L,6L,7L,8L,9L,7L,8L,9L,10L,8L,9L,10L,11L,2L,3L,4L,5L,3L,4L,5L,6L,4L,5L,6L,7L,5L,6L,7L,8L,6L,7L,3L,4L,7L,8L,9L,10L,8L,9L,10L,11L,9L,10L,11L,12L,10L,11L,12L,13L,4L,5L,6L,7L,5L,6L,7L,8L,6L,7L,8L,9L,7L,8L,9L,10L,8L,9L,5L,6L,9L,10L,11L,12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276332Inst : IEnumerable<long>
{
public static readonly long[] Value=A276332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276332.Bytes);
public long this[int i]=>Value[i];

public static A276332Inst Instance=new A276332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276333
{
public static readonly long[] Value={ 0L,1L,2L,3L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,3L,3L,4L,4L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276333Inst : IEnumerable<long>
{
public static readonly long[] Value=A276333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276333.Bytes);
public long this[int i]=>Value[i];

public static A276333Inst Instance=new A276333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276334
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,4L,4L,4L,8L,8L,8L,8L,12L,12L,12L,12L,16L,16L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,72L,72L,72L,72L,72L,72L,72L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276334Inst : IEnumerable<long>
{
public static readonly long[] Value=A276334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276334.Bytes);
public long this[int i]=>Value[i];

public static A276334Inst Instance=new A276334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276335
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,2L,3L,0L,1L,2L,3L,0L,1L,2L,3L,0L,1L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,0L,1L,2L,3L,4L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276335Inst : IEnumerable<long>
{
public static readonly long[] Value=A276335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276335.Bytes);
public long this[int i]=>Value[i];

public static A276335Inst Instance=new A276335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276336
{
public static readonly long[] Value={ 0L,1L,2L,3L,1L,1L,2L,3L,2L,2L,2L,3L,3L,3L,3L,3L,4L,4L,1L,1L,2L,3L,1L,1L,2L,3L,2L,2L,2L,3L,3L,3L,3L,3L,4L,4L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,3L,3L,3L,3L,4L,4L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,1L,1L,2L,3L,1L,1L,2L,3L,2L,2L,2L,3L,3L,3L,3L,3L,4L,4L,1L,1L,2L,3L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276336Inst : IEnumerable<long>
{
public static readonly long[] Value=A276336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276336.Bytes);
public long this[int i]=>Value[i];

public static A276336Inst Instance=new A276336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276337
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,2L,2L,1L,2L,2L,2L,1L,2L,2L,2L,1L,2L,1L,2L,2L,2L,2L,3L,3L,3L,2L,3L,3L,3L,2L,3L,3L,3L,2L,3L,1L,2L,2L,2L,2L,3L,3L,3L,2L,3L,3L,3L,2L,3L,3L,3L,2L,3L,1L,2L,2L,2L,2L,3L,3L,3L,2L,3L,3L,3L,2L,3L,3L,3L,2L,3L,1L,2L,2L,2L,2L,3L,3L,3L,2L,3L,3L,3L,2L,3L,3L,3L,2L,3L,1L,2L,2L,2L,2L,3L,1L,2L,2L,2L,2L,3L,3L,3L,2L,3L,3L,3L,2L,3L,3L,3L,2L,3L,2L,3L,3L,3L,3L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276337Inst : IEnumerable<long>
{
public static readonly long[] Value=A276337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276337.Bytes);
public long this[int i]=>Value[i];

public static A276337Inst Instance=new A276337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276338
{
public static readonly long[] Value={ 0L,4L,8L,12L,18L,18L,18L,18L,36L,36L,36L,36L,54L,54L,54L,54L,72L,72L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,96L,192L,192L,192L,192L,192L,192L,192L,192L,192L,192L,192L,192L,192L,192L,192L,192L,192L,192L,288L,288L,288L,288L,288L,288L,288L,288L,288L,288L,288L,288L,288L,288L,288L,288L,288L,288L,384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276338Inst : IEnumerable<long>
{
public static readonly long[] Value=A276338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276338.Bytes);
public long this[int i]=>Value[i];

public static A276338Inst Instance=new A276338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276339
{
public static readonly long[] Value={ 0L,0L,4L,4L,0L,0L,22L,22L,24L,24L,22L,22L,18L,18L,22L,22L,18L,18L,0L,0L,4L,4L,0L,0L,118L,118L,120L,120L,118L,118L,138L,138L,142L,142L,138L,138L,120L,120L,124L,124L,120L,120L,118L,118L,120L,120L,118L,118L,114L,114L,118L,118L,114L,114L,120L,120L,124L,124L,120L,120L,118L,118L,120L,120L,118L,118L,114L,114L,118L,118L,114L,114L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276339Inst : IEnumerable<long>
{
public static readonly long[] Value=A276339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276339.Bytes);
public long this[int i]=>Value[i];

public static A276339Inst Instance=new A276339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276372
{
public static readonly long[] Value={ 1L,4L,27L,72L,108L,800L,3125L,6272L,12500L,30375L,36000L,48600L,84375L,247808L,337500L,395136L,750141L,823543L,857304L,1384448L,3294172L,22235661L,24532992L,37879808L,53782400L,88942644L,122500000L,161980416L,171478296L,189267968L,235782657L,600112800L,1313046875L,2155524696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276372Inst : IEnumerable<long>
{
public static readonly long[] Value=A276372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276372.Bytes);
public long this[int i]=>Value[i];

public static A276372Inst Instance=new A276372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276373
{
public static readonly long[] Value={ 5L,4L,3L,2L,1L,106L,21L,1L,1L,39282L,1L,53L,135L,65014L,5L,9489L,171L,361L,27L,19641L,7L,13133L,141L,6326L,3L,6978L,1L,32507L,375L,13094L,165L,93186L,1L,1359L,9L,12588L,15L,171L,45L,35253L,3L,35794L,9L,16796L,7L,1689L,69L,3163L,3L,13653L,57L,3489L,12L,249L,45L,58497L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276373Inst : IEnumerable<long>
{
public static readonly long[] Value=A276373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276373.Bytes);
public long this[int i]=>Value[i];

public static A276373Inst Instance=new A276373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276374
{
public static readonly long[] Value={ 5L,6L,8L,13L,14L,24L,26L,31L,32L,34L,51L,54L,57L,62L,69L,82L,83L,93L,99L,113L,114L,119L,125L,132L,133L,139L,143L,145L,151L,161L,165L,181L,182L,192L,195L,212L,217L,219L,224L,233L,266L,282L,293L,295L,304L,311L,312L,318L,325L,338L,354L,364L,369L,375L,376L,382L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276374Inst : IEnumerable<long>
{
public static readonly long[] Value=A276374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276374.Bytes);
public long this[int i]=>Value[i];

public static A276374Inst Instance=new A276374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276375
{
public static readonly long[] Value={ 1L,2L,3L,11L,22L,29L,47L,49L,52L,67L,78L,79L,80L,91L,103L,104L,109L,111L,121L,130L,137L,148L,152L,159L,179L,184L,190L,200L,207L,215L,222L,241L,264L,278L,291L,307L,309L,316L,331L,336L,343L,347L,350L,361L,373L,380L,400L,409L,415L,430L,435L,445L,450L,453L,468L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276375Inst : IEnumerable<long>
{
public static readonly long[] Value=A276375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276375.Bytes);
public long this[int i]=>Value[i];

public static A276375Inst Instance=new A276375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276376
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,1L,2L,1L,4L,1L,3L,1L,1L,2L,2L,4L,1L,3L,1L,2L,2L,4L,2L,4L,2L,1L,1L,3L,1L,7L,1L,4L,1L,4L,1L,3L,5L,1L,3L,2L,2L,5L,1L,1L,2L,5L,6L,2L,1L,1L,3L,1L,7L,3L,3L,2L,3L,2L,2L,1L,4L,8L,1L,1L,2L,8L,3L,4L,1L,3L,2L,4L,3L,4L,1L,3L,4L,1L,6L,4L,1L,4L,3L,2L,2L,2L,4L,3L,1L,1L,6L,7L,1L,4L,1L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276376Inst : IEnumerable<long>
{
public static readonly long[] Value=A276376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276376.Bytes);
public long this[int i]=>Value[i];

public static A276376Inst Instance=new A276376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276377
{
public static readonly BigInteger[] Value={ 0L,1L,1152921504606846976L,BigInteger.Parse("42391158275216203514294433201"),BigInteger.Parse("1329227995784915872903807060280344576"),BigInteger.Parse("867361737988403547205962240695953369140625"),BigInteger.Parse("48873677980689257489322752273774603865660850176") };
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
public class A276377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276377Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276377.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276377Inst Instance=new A276377Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276378
{
public static readonly long[] Value={ 1L,5L,7L,11L,13L,17L,19L,23L,29L,31L,35L,37L,41L,43L,47L,53L,55L,59L,61L,65L,67L,71L,73L,77L,79L,83L,85L,89L,91L,95L,97L,101L,103L,107L,109L,113L,115L,119L,127L,131L,133L,137L,139L,143L,145L,149L,151L,155L,157L,161L,163L,167L,173L,179L,181L,185L,187L,191L,193L,197L,199L,203L,205L,209L,211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276378Inst : IEnumerable<long>
{
public static readonly long[] Value=A276378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276378.Bytes);
public long this[int i]=>Value[i];

public static A276378Inst Instance=new A276378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276379
{
public static readonly long[] Value={ 0L,1L,10L,1L,100L,11L,1000L,1L,10L,101L,10000L,11L,100000L,1001L,110L,1L,1000000L,11L,10000000L,101L,1010L,10001L,100000000L,11L,100L,100001L,10L,1001L,1000000000L,111L,10000000000L,1L,10010L,1000001L,1100L,11L,100000000000L,10000001L,100010L,101L,1000000000000L,1011L,10000000000000L,10001L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276379Inst : IEnumerable<long>
{
public static readonly long[] Value=A276379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276379.Bytes);
public long this[int i]=>Value[i];

public static A276379Inst Instance=new A276379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276380
{
public static readonly long[] Value={ 1L,2L,3L,4L,1L,4L,6L,1L,6L,8L,9L,1L,9L,2L,9L,12L,1L,12L,2L,12L,3L,12L,16L,1L,16L,18L,1L,18L,2L,18L,3L,18L,4L,18L,1L,4L,18L,24L,1L,24L,2L,24L,27L,1L,27L,2L,27L,3L,27L,4L,27L,32L,1L,32L,2L,32L,3L,32L,36L,1L,36L,2L,36L,3L,36L,4L,36L,1L,4L,36L,6L,36L,1L,6L,36L,8L,36L,9L,36L,1L,9L,36L,2L,9L,36L,48L,1L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276380Inst : IEnumerable<long>
{
public static readonly long[] Value=A276380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276380.Bytes);
public long this[int i]=>Value[i];

public static A276380Inst Instance=new A276380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276381
{
public static readonly long[] Value={ 3L,6L,9L,15L,18L,27L,30L,33L,36L,39L,45L,48L,51L,54L,57L,60L,63L,66L,69L,72L,75L,78L,81L,84L,87L,90L,93L,96L,99L,105L,108L,117L,126L,129L,135L,138L,144L,147L,150L,153L,156L,159L,162L,165L,168L,171L,174L,177L,180L,183L,186L,189L,192L,195L,198L,207L,216L,219L,225L,228L,234L,243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276381Inst : IEnumerable<long>
{
public static readonly long[] Value=A276381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276381.Bytes);
public long this[int i]=>Value[i];

public static A276381Inst Instance=new A276381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276382
{
public static readonly long[] Value={ 1L,5L,10L,17L,25L,35L,46L,59L,73L,89L,106L,125L,145L,167L,190L,215L,241L,269L,298L,329L,361L,395L,430L,467L,505L,545L,586L,629L,673L,719L,766L,815L,865L,917L,970L,1025L,1081L,1139L,1198L,1259L,1321L,1385L,1450L,1517L,1585L,1655L,1726L,1799L,1873L,1949L,2026L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276382Inst : IEnumerable<long>
{
public static readonly long[] Value=A276382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276382.Bytes);
public long this[int i]=>Value[i];

public static A276382Inst Instance=new A276382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276383
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,13L,15L,17L,19L,21L,24L,26L,28L,30L,32L,35L,37L,39L,41L,43L,46L,48L,50L,52L,54L,56L,59L,61L,63L,65L,67L,70L,72L,74L,76L,78L,81L,83L,85L,87L,89L,92L,94L,96L,98L,100L,102L,105L,107L,109L,111L,113L,116L,118L,120L,122L,124L,127L,129L,131L,133L,135L,138L,140L,142L,144L,146L,149L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276383Inst : IEnumerable<long>
{
public static readonly long[] Value=A276383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276383.Bytes);
public long this[int i]=>Value[i];

public static A276383Inst Instance=new A276383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276384
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,9L,11L,12L,14L,16L,18L,20L,22L,23L,25L,27L,29L,31L,33L,34L,36L,38L,40L,42L,44L,45L,47L,49L,51L,53L,55L,57L,58L,60L,62L,64L,66L,68L,69L,71L,73L,75L,77L,79L,80L,82L,84L,86L,88L,90L,91L,93L,95L,97L,99L,101L,103L,104L,106L,108L,110L,112L,114L,115L,117L,119L,121L,123L,125L,126L,128L,130L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276384Inst : IEnumerable<long>
{
public static readonly long[] Value=A276384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276384.Bytes);
public long this[int i]=>Value[i];

public static A276384Inst Instance=new A276384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276385
{
public static readonly long[] Value={ 2L,5L,8L,11L,14L,17L,19L,22L,25L,28L,31L,34L,36L,39L,42L,45L,48L,51L,53L,56L,59L,62L,65L,68L,70L,73L,76L,79L,82L,85L,88L,90L,93L,96L,99L,102L,105L,107L,110L,113L,116L,119L,122L,124L,127L,130L,133L,136L,139L,141L,144L,147L,150L,153L,156L,159L,161L,164L,167L,170L,173L,176L,178L,181L,184L,187L,190L,193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276385Inst : IEnumerable<long>
{
public static readonly long[] Value=A276385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276385.Bytes);
public long this[int i]=>Value[i];

public static A276385Inst Instance=new A276385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276386
{
public static readonly long[] Value={ 1L,2L,100L,101L,102L,200L,201L,202L,1001L,1002L,10000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276386Inst : IEnumerable<long>
{
public static readonly long[] Value=A276386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276386.Bytes);
public long this[int i]=>Value[i];

public static A276386Inst Instance=new A276386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276387
{
public static readonly long[] Value={ 10L,110L,1000L,1010L,10010L,10110L,11000L,11010L,20010L,20110L,100000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276387Inst : IEnumerable<long>
{
public static readonly long[] Value=A276387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276387.Bytes);
public long this[int i]=>Value[i];

public static A276387Inst Instance=new A276387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276420
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,2L,2L,2L,2L,4L,4L,5L,6L,8L,7L,12L,14L,16L,17L,26L,27L,36L,40L,55L,56L,81L,88L,118L,124L,177L,189L,257L,275L,384L,404L,564L,605L,833L,880L,1233L,1314L,1813L,1929L,2685L,2850L,3956L,4215L,5845L,6203L,8629L,9185L,12731L,13531L,18807L,19994L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276420Inst : IEnumerable<long>
{
public static readonly long[] Value=A276420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276420.Bytes);
public long this[int i]=>Value[i];

public static A276420Inst Instance=new A276420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276421
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,3L,1L,5L,3L,7L,4L,11L,6L,16L,9L,25L,14L,38L,21L,59L,34L,89L,50L,137L,77L,208L,117L,319L,180L,486L,273L,744L,420L,1134L,639L,1735L,977L,2648L,1491L,4048L,2281L,6180L,3480L,9444L,5321L,14421L,8122L,22035L,12412L,33655L,18957L,51417L,28966L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276421Inst : IEnumerable<long>
{
public static readonly long[] Value=A276421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276421.Bytes);
public long this[int i]=>Value[i];

public static A276421Inst Instance=new A276421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276422
{
public static readonly long[] Value={ 1L,0L,1L,2L,0L,0L,1L,1L,0L,1L,4L,0L,0L,0L,1L,2L,2L,0L,2L,0L,1L,8L,0L,0L,1L,1L,0L,1L,4L,4L,0L,4L,0L,2L,0L,1L,14L,0L,0L,2L,2L,1L,1L,0L,2L,9L,6L,0L,7L,0L,4L,0L,2L,0L,2L,24L,1L,0L,4L,3L,2L,2L,1L,3L,0L,2L,16L,10L,0L,12L,0L,8L,0L,4L,1L,3L,0L,2L,41L,1L,0L,7L,5L,4L,4L,2L,6L,1L,3L,0L,3L,28L,16L,0L,20L,0L,14L,0L,8L,2L,6L,1L,3L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276422Inst : IEnumerable<long>
{
public static readonly long[] Value=A276422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276422.Bytes);
public long this[int i]=>Value[i];

public static A276422Inst Instance=new A276422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276423
{
public static readonly long[] Value={ 0L,1L,0L,4L,4L,13L,13L,33L,41L,79L,98L,171L,223L,354L,458L,692L,905L,1306L,1694L,2375L,3077L,4202L,5401L,7238L,9260L,12200L,15495L,20145L,25446L,32686L,41020L,52170L,65117L,82071L,101852L,127374L,157277L,195289L,239915L,296023L,362000L,444063L,540595L,659662L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276423Inst : IEnumerable<long>
{
public static readonly long[] Value=A276423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276423.Bytes);
public long this[int i]=>Value[i];

public static A276423Inst Instance=new A276423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276424
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,2L,0L,1L,0L,3L,0L,1L,0L,1L,4L,0L,2L,0L,1L,0L,6L,0L,2L,0L,1L,0L,2L,8L,0L,3L,0L,2L,0L,2L,0L,11L,0L,4L,0L,3L,0L,2L,0L,2L,15L,0L,5L,0L,4L,0L,4L,0L,2L,0L,19L,0L,7L,0L,6L,0L,5L,0L,2L,0L,3L,25L,0L,9L,0L,8L,0L,7L,0L,4L,0L,3L,0L,34L,0L,11L,0L,10L,0L,10L,0L,5L,0L,3L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276424Inst : IEnumerable<long>
{
public static readonly long[] Value=A276424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276424.Bytes);
public long this[int i]=>Value[i];

public static A276424Inst Instance=new A276424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276425
{
public static readonly long[] Value={ 0L,0L,2L,2L,6L,8L,20L,26L,48L,66L,114L,154L,240L,326L,490L,656L,940L,1252L,1752L,2306L,3142L,4104L,5500L,7114L,9372L,12030L,15656L,19932L,25628L,32402L,41270L,51816L,65400L,81608L,102226L,126800L,157698L,194550L,240454L,295110L,362600L,442902L,541342L,658230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276425Inst : IEnumerable<long>
{
public static readonly long[] Value=A276425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276425.Bytes);
public long this[int i]=>Value[i];

public static A276425Inst Instance=new A276425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276426
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,0L,3L,2L,2L,1L,0L,6L,1L,3L,5L,3L,0L,11L,4L,5L,8L,9L,0L,20L,9L,1L,7L,15L,19L,1L,0L,32L,21L,3L,11L,24L,38L,4L,0L,51L,41L,9L,15L,39L,69L,12L,0L,80L,73L,23L,22L,58L,123L,27L,1L,0L,119L,128L,49L,1L,30L,90L,202L,60L,3L,0L,175L,213L,98L,4L,42L,130L,328L,118L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276426Inst : IEnumerable<long>
{
public static readonly long[] Value=A276426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276426.Bytes);
public long this[int i]=>Value[i];

public static A276426Inst Instance=new A276426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276427
{
public static readonly long[] Value={ 1L,0L,1L,2L,2L,1L,3L,2L,5L,1L,1L,8L,3L,9L,6L,16L,5L,1L,19L,10L,1L,29L,11L,2L,36L,18L,2L,53L,21L,3L,65L,32L,4L,92L,38L,4L,1L,115L,54L,7L,154L,67L,10L,195L,88L,14L,257L,112L,15L,1L,318L,152L,19L,1L,419L,178L,29L,1L,516L,243L,31L,2L,663L,293L,44L,2L,821L,376L,56L,2L,1039L,465L,67L,4L,1277L,589L,89L,3L,1606L,715L,108L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276427Inst : IEnumerable<long>
{
public static readonly long[] Value=A276427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276427.Bytes);
public long this[int i]=>Value[i];

public static A276427Inst Instance=new A276427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276428
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,3L,3L,6L,7L,12L,15L,22L,27L,40L,49L,68L,87L,116L,145L,193L,239L,311L,387L,494L,611L,776L,952L,1193L,1464L,1817L,2214L,2733L,3315L,4060L,4911L,5974L,7195L,8713L,10448L,12585L,15048L,18039L,21486L,25660L,30462L,36231L,42888L,50820L,59972L,70843L,83354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276428Inst : IEnumerable<long>
{
public static readonly long[] Value=A276428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276428.Bytes);
public long this[int i]=>Value[i];

public static A276428Inst Instance=new A276428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276429
{
public static readonly long[] Value={ 1L,0L,2L,2L,3L,5L,8L,9L,16L,19L,29L,36L,53L,65L,92L,115L,154L,195L,257L,318L,419L,516L,663L,821L,1039L,1277L,1606L,1963L,2441L,2978L,3675L,4454L,5469L,6603L,8043L,9688L,11732L,14066L,16963L,20260L,24310L,28953L,34586L,41047L,48857L,57802L,68528L,80862L,95534L,112388L,132391L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276429Inst : IEnumerable<long>
{
public static readonly long[] Value=A276429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276429.Bytes);
public long this[int i]=>Value[i];

public static A276429Inst Instance=new A276429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276430
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,2L,1L,3L,3L,1L,5L,3L,2L,1L,6L,5L,3L,1L,7L,8L,4L,2L,1L,10L,10L,6L,3L,1L,13L,13L,9L,4L,2L,1L,16L,18L,12L,6L,3L,1L,22L,22L,16L,10L,4L,2L,1L,27L,29L,22L,13L,6L,3L,1L,33L,40L,28L,17L,10L,4L,2L,1L,43L,49L,37L,24L,13L,6L,3L,1L,52L,63L,50L,31L,18L,10L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276430Inst : IEnumerable<long>
{
public static readonly long[] Value=A276430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276430.Bytes);
public long this[int i]=>Value[i];

public static A276430Inst Instance=new A276430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276431
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,5L,6L,7L,10L,13L,16L,22L,27L,33L,43L,52L,64L,81L,98L,120L,148L,178L,215L,263L,315L,377L,455L,541L,644L,771L,912L,1078L,1279L,1506L,1772L,2089L,2447L,2864L,3356L,3916L,4563L,5320L,6180L,7171L,8324L,9633L,11136L,12874L,14845L,17102L,19696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276431Inst : IEnumerable<long>
{
public static readonly long[] Value=A276431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276431.Bytes);
public long this[int i]=>Value[i];

public static A276431Inst Instance=new A276431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276432
{
public static readonly long[] Value={ 1L,4L,10L,26L,56L,126L,252L,512L,980L,1866L,3427L,6258L,11121L,19618L,33975L,58328L,98732L,165804L,275246L,453544L,740338L,1200088L,1929897L,3083898L,4893775L,7720826L,12106814L,18883104L,29291740L,45215386L,69451631L,106197524L,161656759L,245050410L,369935066L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276432Inst : IEnumerable<long>
{
public static readonly long[] Value=A276432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276432.Bytes);
public long this[int i]=>Value[i];

public static A276432Inst Instance=new A276432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276433
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,4L,1L,6L,1L,8L,3L,12L,3L,18L,3L,1L,24L,6L,32L,10L,45L,10L,1L,59L,17L,1L,79L,21L,1L,104L,28L,3L,137L,37L,2L,177L,50L,4L,229L,64L,4L,295L,82L,8L,377L,105L,8L,477L,139L,10L,1L,605L,174L,13L,761L,220L,21L,956L,275L,24L,1193L,350L,31L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276433Inst : IEnumerable<long>
{
public static readonly long[] Value=A276433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276433.Bytes);
public long this[int i]=>Value[i];

public static A276433Inst Instance=new A276433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276434
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,3L,3L,5L,6L,10L,12L,19L,23L,34L,41L,58L,72L,98L,121L,162L,200L,262L,323L,415L,511L,650L,796L,1000L,1222L,1522L,1851L,2287L,2771L,3399L,4103L,5000L,6015L,7289L,8735L,10530L,12579L,15094L,17968L,21468L,25477L,30319L,35873L,42531L,50177L,59291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276434Inst : IEnumerable<long>
{
public static readonly long[] Value=A276434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276434.Bytes);
public long this[int i]=>Value[i];

public static A276434Inst Instance=new A276434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276435
{
public static readonly long[] Value={ 23L,31L,47L,53L,13L,23L,89L,113L,11L,139L,31L,37L,47L,53L,181L,199L,211L,53L,241L,11L,17L,23L,31L,283L,293L,317L,31L,337L,53L,359L,7L,13L,23L,389L,401L,409L,421L,13L,23L,29L,467L,59L,71L,23L,509L,523L,547L,17L,23L,31L,577L,47L,53L,7L,619L,631L,47L,53L,661L,17L,263L,691L,281L,709L,299L,7L,13L,323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276435Inst : IEnumerable<long>
{
public static readonly long[] Value=A276435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276435.Bytes);
public long this[int i]=>Value[i];

public static A276435Inst Instance=new A276435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276452
{
public static readonly BigInteger[] Value={ 0L,1L,20L,448L,13266L,486744L,21474640L,1106532352L,65221935740L,4327576834420L,319187489891256L,25904823417117120L,2294089575084464472L,BigInteger.Parse("220132629092378694832"),BigInteger.Parse("22751391952785312551232"),BigInteger.Parse("2519687900505221042995200"),BigInteger.Parse("297684761086121821704009432"),BigInteger.Parse("37370623083548749203599933004") };
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
public class A276452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276452Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276452.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276452Inst Instance=new A276452Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276453
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,42L,903L,136052L,881442036L,2581196224947732L,BigInteger.Parse("342795531574625708871288171"),BigInteger.Parse("5732512385084161208637718426682572229606557631"),BigInteger.Parse("5754497648510061274107897581706624823818534711463525598519384262130236399970112") };
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
public class A276453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276453Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276453.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276453Inst Instance=new A276453Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276454
{
public static readonly BigInteger[] Value={ 1L,2L,22L,464L,13302L,487152L,21475652L,1106550392L,65221981530L,4327577893800L,319187492622012L,25904823495240144L,2294089575287710984L,BigInteger.Parse("220132629099295901408"),BigInteger.Parse("22751391952803426496488"),BigInteger.Parse("2519687900505935894639088"),BigInteger.Parse("297684761086123702744203918") };
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
public class A276454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276454Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276454.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276454Inst Instance=new A276454Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276455
{
public static readonly long[] Value={ 3L,701L,45269999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276455Inst : IEnumerable<long>
{
public static readonly long[] Value=A276455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276455.Bytes);
public long this[int i]=>Value[i];

public static A276455Inst Instance=new A276455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276456
{
public static readonly long[] Value={ 1L,3L,7L,11L,19L,27L,43L,67L,163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276456Inst : IEnumerable<long>
{
public static readonly long[] Value=A276456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276456.Bytes);
public long this[int i]=>Value[i];

public static A276456Inst Instance=new A276456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276457
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,0L,3L,0L,4L,0L,5L,0L,6L,0L,7L,0L,8L,0L,9L,0L,10L,1L,2L,1L,3L,1L,4L,1L,5L,1L,6L,1L,7L,1L,8L,1L,9L,1L,10L,2L,2L,3L,2L,4L,2L,5L,2L,6L,2L,7L,2L,8L,2L,9L,2L,10L,3L,3L,4L,3L,5L,3L,6L,3L,7L,3L,8L,3L,9L,3L,10L,4L,4L,5L,4L,6L,4L,7L,4L,8L,4L,9L,4L,10L,5L,5L,6L,5L,7L,5L,8L,5L,9L,5L,10L,6L,6L,7L,6L,8L,6L,9L,6L,10L,7L,7L,8L,7L,9L,7L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276457Inst : IEnumerable<long>
{
public static readonly long[] Value=A276457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276457.Bytes);
public long this[int i]=>Value[i];

public static A276457Inst Instance=new A276457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276458
{
public static readonly long[] Value={ 1719L,905L,959L,1199L,1807L,1207L,2983L,1541L,2465L,1271L,5143L,1271L,2279L,1927L,2279L,1829L,5917L,1541L,1207L,2263L,3239L,7387L,4717L,1649L,6161L,4841L,7169L,1199L,1243L,127L,10873L,959L,1529L,149L,11023L,2669L,12877L,2171L,1211L,1969L,905L,1719L,7913L,7289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276458Inst : IEnumerable<long>
{
public static readonly long[] Value=A276458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276458.Bytes);
public long this[int i]=>Value[i];

public static A276458Inst Instance=new A276458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276459
{
public static readonly long[] Value={ 7L,6L,2L,6L,6L,5L,5L,2L,4L,6L,3L,4L,2L,4L,6L,3L,6L,3L,3L,5L,4L,3L,6L,3L,3L,3L,4L,3L,6L,6L,4L,3L,3L,4L,5L,5L,2L,6L,2L,5L,4L,3L,4L,6L,6L,2L,3L,5L,2L,3L,5L,4L,2L,3L,2L,4L,2L,6L,4L,6L,3L,3L,4L,3L,4L,6L,3L,4L,6L,5L,2L,2L,2L,3L,4L,5L,5L,5L,2L,4L,3L,6L,4L,3L,6L,3L,2L,6L,2L,4L,5L,6L,2L,3L,2L,5L,2L,3L,2L,3L,3L,5L,4L,4L,6L,4L,2L,4L,5L,4L,6L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276459Inst : IEnumerable<long>
{
public static readonly long[] Value=A276459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276459.Bytes);
public long this[int i]=>Value[i];

public static A276459Inst Instance=new A276459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276460
{
public static readonly long[] Value={ 0L,1L,2L,5L,17L,37L,101L,197L,257L,401L,577L,677L,901L,1297L,1601L,2917L,3137L,4357L,5477L,7057L,8101L,8837L,10001L,12101L,13457L,14401L,15377L,15877L,16901L,17957L,20737L,21317L,22501L,24337L,25601L,28901L,30977L,32401L,33857L,41617L,42437L,44101L,50177L,52901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276460Inst : IEnumerable<long>
{
public static readonly long[] Value=A276460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276460.Bytes);
public long this[int i]=>Value[i];

public static A276460Inst Instance=new A276460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276461
{
public static readonly long[] Value={ 211L,12211L,21121L,21211L,22111L,1121221L,1212121L,2121121L,2211211L,2221111L,111221221L,112212211L,112221211L,121211221L,211122211L,211212121L,211222111L,221112121L,221212111L,11122121221L,11122221211L,11211221221L,11212211221L,11212221121L,11222112211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276461Inst : IEnumerable<long>
{
public static readonly long[] Value=A276461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276461.Bytes);
public long this[int i]=>Value[i];

public static A276461Inst Instance=new A276461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276462
{
public static readonly BigInteger[] Value={ 211L,22111L,2221111L,BigInteger.Parse("22222222222222222222222222111111111111111111111111111"),BigInteger.Parse("2222222222222222222222222222222221111111111111111111111111111111111") };
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
public class A276462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276462Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276462.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276462Inst Instance=new A276462Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276463
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,10L,12L,14L,16L,18L,20L,120L,160L,158L,140L,337L,171L,189L,207L,165L,248L,230L,263L,122L,124L,126L,128L,130L,132L,134L,136L,138L,244L,757L,142L,144L,146L,148L,150L,152L,154L,156L,374L,725L,399L,279L,291L,556L,295L,423L,167L,169L,502L,429L,173L,175L,177L,179L,181L,183L,185L,187L,496L,508L,191L,193L,195L,197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276463Inst : IEnumerable<long>
{
public static readonly long[] Value=A276463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276463.Bytes);
public long this[int i]=>Value[i];

public static A276463Inst Instance=new A276463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276464
{
public static readonly long[] Value={ 0L,1L,2L,5L,8L,21L,34L,144L,4181L,75025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276464Inst : IEnumerable<long>
{
public static readonly long[] Value=A276464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276464.Bytes);
public long this[int i]=>Value[i];

public static A276464Inst Instance=new A276464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276465
{
public static readonly long[] Value={ 1L,2L,5L,7L,10L,14L,25L,35L,47L,50L,70L,94L,175L,235L,329L,350L,470L,658L,1175L,1645L,2350L,3290L,8225L,16450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276465Inst : IEnumerable<long>
{
public static readonly long[] Value=A276465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276465.Bytes);
public long this[int i]=>Value[i];

public static A276465Inst Instance=new A276465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276466
{
public static readonly long[] Value={ 1L,3L,2L,7L,3L,6L,4L,3L,13L,9L,21L,43L,23L,57L,21L,83L,27L,57L,29L,3L,131L,63L,33L,69L,17L,69L,157L,91L,39L,9L,41L,99L,21L,81L,33L,79L,47L,87L,23L,27L,51L,267L,53L,147L,12L,99L,57L,17L,129L,33L,27L,161L,63L,309L,63L,159L,29L,117L,69L,357L,71L,123L,71L,131L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276466Inst : IEnumerable<long>
{
public static readonly long[] Value=A276466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276466.Bytes);
public long this[int i]=>Value[i];

public static A276466Inst Instance=new A276466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276467
{
public static readonly long[] Value={ 10L,10L,5L,10L,5L,5L,5L,2L,10L,10L,100L,25L,100L,50L,20L,50L,100L,25L,100L,2L,100L,100L,100L,25L,20L,100L,100L,50L,100L,4L,100L,50L,25L,100L,20L,25L,100L,100L,25L,10L,100L,100L,100L,100L,5L,100L,100L,5L,100L,20L,25L,100L,100L,100L,50L,50L,25L,100L,100L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276467Inst : IEnumerable<long>
{
public static readonly long[] Value=A276467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276467.Bytes);
public long this[int i]=>Value[i];

public static A276467Inst Instance=new A276467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276500
{
public static readonly long[] Value={ 5L,4L,5L,4L,5L,1L,7L,2L,4L,4L,5L,4L,5L,5L,8L,5L,7L,5L,6L,9L,6L,6L,0L,5L,7L,7L,2L,4L,9L,9L,4L,3L,8L,1L,0L,1L,6L,9L,7L,3L,2L,7L,2L,4L,1L,6L,2L,5L,1L,3L,4L,7L,0L,4L,5L,3L,9L,8L,0L,3L,5L,2L,0L,4L,1L,5L,9L,8L,4L,8L,1L,4L,9L,2L,2L,4L,5L,3L,4L,4L,5L,7L,0L,4L,6L,5L,5L,1L,8L,9L,2L,4L,2L,8L,2L,3L,6L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276500Inst : IEnumerable<long>
{
public static readonly long[] Value=A276500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276500.Bytes);
public long this[int i]=>Value[i];

public static A276500Inst Instance=new A276500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276501
{
public static readonly long[] Value={ 0L,3L,5L,5L,7L,8L,9L,9L,9L,11L,11L,14L,14L,14L,14L,14L,15L,17L,18L,18L,18L,18L,18L,20L,20L,20L,20L,20L,21L,21L,21L,22L,22L,26L,26L,26L,26L,26L,26L,26L,28L,28L,31L,31L,32L,32L,32L,34L,34L,34L,34L,34L,34L,35L,35L,35L,36L,38L,38L,38L,38L,38L,38L,38L,41L,41L,41L,41L,43L,43L,43L,43L,47L,47L,47L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276501Inst : IEnumerable<long>
{
public static readonly long[] Value=A276501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276501.Bytes);
public long this[int i]=>Value[i];

public static A276501Inst Instance=new A276501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276502
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276502Inst : IEnumerable<long>
{
public static readonly long[] Value=A276502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276502.Bytes);
public long this[int i]=>Value[i];

public static A276502Inst Instance=new A276502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276503
{
public static readonly long[] Value={ 20L,26L,35L,100L,130L,160L,370L,400L,610L,730L,793L,1000L,1570L,1843L,1930L,2500L,2560L,2770L,2860L,3130L,3970L,4000L,4171L,4210L,4570L,5410L,5767L,6130L,6400L,6610L,6730L,7330L,7570L,8770L,9106L,9640L,9970L,9991L,10498L,10660L,10930L,11248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276503Inst : IEnumerable<long>
{
public static readonly long[] Value=A276503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276503.Bytes);
public long this[int i]=>Value[i];

public static A276503Inst Instance=new A276503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276504
{
public static readonly long[] Value={ 7L,11L,27L,33L,45L,63L,135L,165L,285L,304L,345L,765L,855L,964L,1144L,1575L,1744L,2134L,2295L,2805L,6424L,6604L,10725L,23584L,24244L,27645L,28875L,31174L,31354L,35445L,40755L,44164L,46672L,57046L,57057L,61444L,64005L,78975L,82095L,90195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276504Inst : IEnumerable<long>
{
public static readonly long[] Value=A276504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276504.Bytes);
public long this[int i]=>Value[i];

public static A276504Inst Instance=new A276504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276505
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,1L,5L,2L,5L,3L,7L,2L,9L,3L,6L,6L,11L,1L,11L,4L,9L,7L,11L,4L,13L,5L,9L,6L,15L,3L,17L,6L,10L,7L,12L,6L,19L,7L,9L,7L,19L,4L,17L,8L,11L,11L,17L,3L,21L,5L,14L,10L,17L,5L,19L,11L,17L,9L,17L,4L,21L,9L,10L,12L,21L,7L,23L,8L,16L,7L,25L,7L,25L,7L,7L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276505Inst : IEnumerable<long>
{
public static readonly long[] Value=A276505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276505.Bytes);
public long this[int i]=>Value[i];

public static A276505Inst Instance=new A276505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276506
{
public static readonly BigInteger[] Value={ 1L,9L,90L,981L,11511L,144108L,1911771L,26730981L,392209380L,6016681467L,96202473183L,1599000785730L,27563715220509L,491777630207037L,9064781481234546L,172346601006842337L,3375007346801025099L,BigInteger.Parse("67983454804021156548"),BigInteger.Parse("1406921223577401454239"),BigInteger.Parse("29881379179971835132761") };
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
public class A276506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276506Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276506.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276506Inst Instance=new A276506Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276507
{
public static readonly BigInteger[] Value={ 1L,10L,110L,1310L,16710L,226510L,3243110L,48807310L,768988710L,12641850510L,216229931110L,3838516103310L,70569453740710L,1341065189434510L,26298323383739110L,531365183231239310L,11047184452086972710UL,BigInteger.Parse("236029124143560378510"),BigInteger.Parse("5176602413033115467110") };
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
public class A276507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276507Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276507.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276507Inst Instance=new A276507Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276508
{
public static readonly long[] Value={ 0L,2L,9L,42L,208L,1041L,5208L,26042L,130209L,651042L,3255208L,16276041L,81380208L,406901042L,2034505209L,10172526042L,50862630208L,254313151041L,1271565755208L,6357828776042L,31789143880209L,158945719401042L,794728597005208L,3973642985026041L,19868214925130208L,99341074625651042L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276508Inst : IEnumerable<long>
{
public static readonly long[] Value=A276508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276508.Bytes);
public long this[int i]=>Value[i];

public static A276508Inst Instance=new A276508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276509
{
public static readonly BigInteger[] Value={ 2L,47L,497L,4997L,49997L,499997L,4999997L,49999997L,499999997L,4999999997L,49999999997L,499999999997L,4999999999997L,49999999999997L,499999999999997L,4999999999999997L,49999999999999997L,499999999999999997L,4999999999999999997L,BigInteger.Parse("49999999999999999997"),BigInteger.Parse("499999999999999999997") };
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
public class A276509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276509Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276509.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276509Inst Instance=new A276509Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276510
{
public static readonly long[] Value={ 10234567L,10234576L,10234579L,10234597L,10234657L,10234675L,10234678L,10234687L,10234756L,10234759L,10234765L,10234768L,10234786L,10234795L,10234867L,10234876L,10234957L,10234975L,10235467L,10235476L,10235479L,10235497L,10235647L,10235674L,10235746L,10235749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276510Inst : IEnumerable<long>
{
public static readonly long[] Value=A276510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276510.Bytes);
public long this[int i]=>Value[i];

public static A276510Inst Instance=new A276510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276511
{
public static readonly BigInteger[] Value={ 5L,11L,139L,BigInteger.Parse("170141183460469231731687303715884105979") };
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
public class A276511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276511Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276511.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276511Inst Instance=new A276511Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276512
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,22L,20L,13L,14L,24L,23L,15L,16L,26L,25L,17L,18L,28L,27L,19L,30L,32L,12L,40L,33L,21L,29L,34L,31L,50L,42L,36L,35L,41L,44L,37L,38L,45L,46L,39L,51L,47L,43L,52L,55L,48L,49L,53L,56L,60L,70L,54L,58L,61L,62L,57L,59L,63L,64L,71L,72L,65L,66L,73L,74L,68L,69L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276512Inst : IEnumerable<long>
{
public static readonly long[] Value=A276512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276512.Bytes);
public long this[int i]=>Value[i];

public static A276512Inst Instance=new A276512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276513
{
public static readonly long[] Value={ 21L,16102L,281785L,275867515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276513Inst : IEnumerable<long>
{
public static readonly long[] Value=A276513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276513.Bytes);
public long this[int i]=>Value[i];

public static A276513Inst Instance=new A276513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276514
{
public static readonly long[] Value={ 5L,10L,15L,25L,31L,36L,38L,41L,47L,53L,58L,66L,70L,75L,85L,93L,94L,96L,99L,101L,111L,126L,134L,140L,146L,154L,165L,177L,192L,199L,206L,209L,211L,222L,225L,232L,234L,236L,239L,241L,248L,253L,259L,266L,271L,282L,287L,296L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276514Inst : IEnumerable<long>
{
public static readonly long[] Value=A276514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276514.Bytes);
public long this[int i]=>Value[i];

public static A276514Inst Instance=new A276514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276515
{
public static readonly long[] Value={ 6L,1L,6L,4L,4L,5L,9L,8L,1L,6L,5L,2L,1L,7L,9L,8L,9L,1L,7L,0L,6L,2L,5L,1L,2L,7L,7L,3L,7L,4L,7L,1L,2L,4L,8L,8L,4L,7L,7L,5L,2L,9L,0L,6L,1L,7L,3L,0L,4L,0L,5L,2L,9L,5L,9L,1L,8L,8L,8L,3L,1L,2L,6L,5L,6L,3L,0L,1L,6L,3L,3L,8L,1L,5L,3L,8L,9L,0L,4L,6L,7L,8L,3L,4L,3L,8L,8L,4L,5L,4L,4L,6L,5L,2L,0L,3L,0L,1L,5L,5L,2L,2L,1L,7L,6L,6L,0L,8L,1L,2L,5L,3L,0L,0L,9L,4L,5L,7L,1L,4L,7L,3L,7L,7L,9L,5L,2L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276515Inst : IEnumerable<long>
{
public static readonly long[] Value=A276515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276515.Bytes);
public long this[int i]=>Value[i];

public static A276515Inst Instance=new A276515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276740
{
public static readonly long[] Value={ 1L,2L,4L,76L,418L,1102L,4687L,7637L,139183L,2543923L,1614895738L,9083990938L,23149317409L,497240757797L,4447730232523L,16000967516764L,65262766108619L,141644055557882L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276740Inst : IEnumerable<long>
{
public static readonly long[] Value=A276740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276740.Bytes);
public long this[int i]=>Value[i];

public static A276740Inst Instance=new A276740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276741
{
public static readonly long[] Value={ 0L,1L,7L,31L,37L,71L,235L,515L,1199L,1815L,6587L,30429L,35589L,42147L,58571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276741Inst : IEnumerable<long>
{
public static readonly long[] Value=A276741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276741.Bytes);
public long this[int i]=>Value[i];

public static A276741Inst Instance=new A276741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276742
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,9L,76L,980L,17304L,393463L,11072376L,375015501L,14973327740L,693507063942L,36782159095080L,2210369895001450L,149163550608705780L,11218246110724502325UL,BigInteger.Parse("934089674706365890832"),BigInteger.Parse("85613718583699681233208"),BigInteger.Parse("8593417105404547807210554"),BigInteger.Parse("940306481313403267058365853"),BigInteger.Parse("111703159299047925885976523740"),BigInteger.Parse("14352698749278209896668891217608"),BigInteger.Parse("1987913848425789150258188910598408"),BigInteger.Parse("295873533681557805541331625248339120") };
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
public class A276742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276742Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276742.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276742Inst Instance=new A276742Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276743
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,63L,447L,4286L,56185L,1008317L,24917676L,849963761L,40142633815L,2633061525012L,240207555735097L,30578843349537575L,5434894746337720676L,BigInteger.Parse("1352812180415380719387"),BigInteger.Parse("471689727423751377883607"),BigInteger.Parse("230943183470327388401886858"),BigInteger.Parse("158839247095790148049487792081"),BigInteger.Parse("153694547774391577758847456894905") };
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
public class A276743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276743Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276743.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276743Inst Instance=new A276743Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276744
{
public static readonly BigInteger[] Value={ 1L,-2L,13L,-248L,12526L,-1568368L,466802541L,-321051272000L,500039245711658L,-1737306124802148608L,BigInteger.Parse("13308275973878544047746"),BigInteger.Parse("-222688458529322994469714944"),BigInteger.Parse("8077969377058605224894763722940"),BigInteger.Parse("-631225844487016628864332741755017216"),BigInteger.Parse("105685667980009079816649620724931814050429") };
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
public class A276744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276744Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276744.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276744Inst Instance=new A276744Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276745
{
public static readonly BigInteger[] Value={ 1L,-3L,28L,-707L,44576L,-6695766L,2324916672L,-1827405843363L,3201960457239040L,BigInteger.Parse("-12360766887879809858"),BigInteger.Parse("104155804285010077051904"),BigInteger.Parse("-1901288103716422362163490318"),BigInteger.Parse("74716157012390526276910403768320"),BigInteger.Parse("-6287554722733254962685763077329845772"),BigInteger.Parse("1127914878748595440161120152354758317867008") };
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
public class A276745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276745Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276745.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276745Inst Instance=new A276745Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276746
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,11L,59L,439L,4472L,62935L,1209430L,32051191L,1166861194L,58721422238L,4088067759572L,394939948283555L,53103347018217191L,9947926726521152127UL,BigInteger.Parse("2605793744856238449900"),BigInteger.Parse("954325686563453398851948"),BigInteger.Parse("490307345827423220333318823"),BigInteger.Parse("353233139353798743949103145806"),BigInteger.Parse("357764578484543977966398255436596"),BigInteger.Parse("509302875450935550273793437784438990"),BigInteger.Parse("1020636223630190179625684042390508142277") };
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
public class A276746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276746Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276746.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276746Inst Instance=new A276746Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276747
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,14L,96L,989L,14264L,293081L,8291372L,326486284L,17606371379L,1311003529532L,133789640100606L,18842361596022104L,3651812223033372781L,BigInteger.Parse("979595054829206809506"),BigInteger.Parse("363619011980801177687068"),BigInteger.Parse("187594865162514096249150130"),BigInteger.Parse("134684579087971548803896902904"),BigInteger.Parse("134956937109764143572996094860839"),BigInteger.Parse("189135846049140695927044178145555683"),BigInteger.Parse("371258683769470709816610430835777163052") };
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
public class A276747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276747Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276747.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276747Inst Instance=new A276747Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276748
{
public static readonly BigInteger[] Value={ 1L,1L,3L,6L,20L,31L,278L,337L,17412L,24798L,6772374L,6838020L,11484638201L,11505059694L,80455953355044L,80659880546429L,2306084675313241000L,2306326405122809872L,BigInteger.Parse("268657126294137376567236"),BigInteger.Parse("268664044710902946519968"),BigInteger.Parse("126765866019584067600135507174"),BigInteger.Parse("126766706181193131138562011916"),BigInteger.Parse("241678197716027150352300025709078423"),BigInteger.Parse("241678578014230878979840920532089312"),BigInteger.Parse("1858396158247302094721803368957703312268486"),BigInteger.Parse("1858396883282148773045801834086535278817434") };
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
public class A276748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276748Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276748.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276748Inst Instance=new A276748Inst();

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