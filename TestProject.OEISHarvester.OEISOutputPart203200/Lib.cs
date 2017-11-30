using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A283243
{
public static readonly long[] Value={ 1L,-10L,25L,53L,-270L,-77L,1057L,610L,-2031L,-5438L,-1953L,17236L,34121L,3351L,-103369L,-195850L,-55471L,468448L,1067785L,764094L,-1430780L,-4974559L,-6242563L,334620L,16946199L,34459888L,29243953L,-24503978L,-124514921L,-205795663L,-140256312L,191109263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283243Inst : IEnumerable<long>
{
public static readonly long[] Value=A283243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283243.Bytes);
public long this[int i]=>Value[i];

public static A283243Inst Instance=new A283243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283244
{
public static readonly long[] Value={ 1L,28L,518L,7439L,90517L,972398L,9472190L,85145743L,715281840L,5668682493L,42691867112L,307312234334L,2124355701646L,14157081285263L,91250293831492L,570441761053192L,3466874635995098L,20526329624103412L,118608374492197651L,669949478060261642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283244Inst : IEnumerable<long>
{
public static readonly long[] Value=A283244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283244.Bytes);
public long this[int i]=>Value[i];

public static A283244Inst Instance=new A283244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283245
{
public static readonly long[] Value={ 3L,7L,3L,3L,3L,3L,3L,7L,11L,3L,3L,31L,3L,3L,3L,3L,7L,3L,23L,3L,7L,3L,31L,3L,3L,3L,7L,3L,3L,7L,3L,3L,3L,3L,31L,3L,7L,23L,3L,3L,3L,3L,3L,43L,3L,7L,3L,3L,7L,3L,3L,3L,3L,23L,3L,11L,7L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283245Inst : IEnumerable<long>
{
public static readonly long[] Value=A283245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283245.Bytes);
public long this[int i]=>Value[i];

public static A283245Inst Instance=new A283245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283246
{
public static readonly long[] Value={ 4L,5L,10L,13L,16L,106L,130L,148L,880L,1261L,2560L,2629L,3730L,5284L,7411L,8255L,9091L,9490L,10171L,14033L,25618L,39382L,47452L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283246Inst : IEnumerable<long>
{
public static readonly long[] Value=A283246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283246.Bytes);
public long this[int i]=>Value[i];

public static A283246Inst Instance=new A283246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283247
{
public static readonly BigInteger[] Value={ 3L,31L,13147L,73141L,314159L,314159L,131415923L,1314159269L,23141592653L,23141592653L,314159265359L,3141592653581L,213141592653589L,1131415926535897L,9314159265358979L,173141592653589793L,3141592653589793239L,3141592653589793239L,BigInteger.Parse("314159265358979323861") };
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
public class A283247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283247Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283247.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283247Inst Instance=new A283247Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283248
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,12L,14L,17L,22L,28L,33L,38L,43L,62L,68L,78L,83L,98L,104L,134L,146L,158L,174L,179L,182L,188L,200L,218L,230L,248L,260L,266L,272L,278L,302L,308L,314L,328L,332L,338L,356L,374L,398L,404L,416L,428L,440L,458L,464L,482L,488L,494L,506L,518L,524L,530L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283248Inst : IEnumerable<long>
{
public static readonly long[] Value=A283248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283248.Bytes);
public long this[int i]=>Value[i];

public static A283248Inst Instance=new A283248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283249
{
public static readonly ulong[] Value={ 1L,10L,100L,1010L,10100L,101010L,1000100L,10111010L,100100100L,1011111010L,10010100100L,101111111010L,1001111100100L,10111111111010L,100101010100100L,1011101111111010L,10010001111100100L,101111101111111010L,1001110001010100100L,10101011111111111010UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283249Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A283249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283249.Bytes);
public ulong this[int i]=>Value[i];

public static A283249Inst Instance=new A283249Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283298
{
public static readonly BigInteger[] Value={ 1L,3L,26L,305L,4120L,60398L,934064L,15000903L,247766620L,4182015080L,71816825856L,1250772245698L,22039796891026L,392213323252200L,7038863826811100L,127248841020380105L,2315130641074743540L,BigInteger.Parse("42358284517663463380"),BigInteger.Parse("778876539384226875800") };
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
public class A283298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283298Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283298.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283298Inst Instance=new A283298Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283299
{
public static readonly long[] Value={ 1L,4L,3L,1L,6L,3L,1L,7L,1L,2L,8L,4L,4L,4L,3L,5L,4L,1L,4L,9L,3L,3L,9L,1L,4L,10L,3L,3L,11L,7L,4L,8L,5L,6L,7L,6L,2L,10L,3L,3L,14L,1L,2L,5L,3L,6L,12L,2L,4L,11L,3L,2L,5L,5L,7L,14L,6L,4L,6L,7L,4L,5L,4L,3L,13L,3L,3L,12L,3L,2L,15L,2L,2L,12L,3L,7L,4L,5L,4L,11L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283299Inst : IEnumerable<long>
{
public static readonly long[] Value=A283299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283299.Bytes);
public long this[int i]=>Value[i];

public static A283299Inst Instance=new A283299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283300
{
public static readonly long[] Value={ 2L,5L,11L,109L,509L,4099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283300Inst : IEnumerable<long>
{
public static readonly long[] Value=A283300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283300.Bytes);
public long this[int i]=>Value[i];

public static A283300Inst Instance=new A283300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283301
{
public static readonly BigInteger[] Value={ 0L,1L,1L,1L,1L,1L,691L,2L,3617L,43867L,174611L,155366L,236364091L,1315862L,3392780147L,6892673020804L,7709321041217L,151628697551L,BigInteger.Parse("26315271553053477373"),308420411983322L,BigInteger.Parse("261082718496449122051"),BigInteger.Parse("3040195287836141605382"),BigInteger.Parse("2530297234481911294093") };
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
public class A283301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283301Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283301.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283301Inst Instance=new A283301Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283302
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,6L,6L,6L,6L,6L,7L,8L,9L,9L,9L,9L,9L,10L,11L,12L,12L,12L,12L,12L,12L,12L,12L,13L,13L,14L,14L,15L,16L,17L,18L,19L,19L,19L,19L,19L,19L,19L,19L,19L,19L,19L,19L,19L,19L,19L,20L,21L,21L,22L,23L,24L,24L,24L,24L,24L,24L,24L,24L,25L,26L,27L,27L,28L,29L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283302Inst : IEnumerable<long>
{
public static readonly long[] Value=A283302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283302.Bytes);
public long this[int i]=>Value[i];

public static A283302Inst Instance=new A283302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283303
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,3L,4L,4L,5L,5L,5L,4L,5L,6L,6L,6L,5L,6L,7L,5L,7L,6L,7L,7L,6L,8L,7L,8L,8L,6L,8L,7L,8L,9L,9L,7L,9L,8L,9L,9L,7L,8L,10L,10L,10L,9L,10L,8L,10L,9L,11L,11L,10L,11L,8L,9L,11L,10L,11L,12L,9L,12L,11L,12L,10L,12L,11L,12L,9L,10L,12L,13L,11L,13L,13L,13L,12L,10L,11L,13L,12L,13L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283303Inst : IEnumerable<long>
{
public static readonly long[] Value=A283303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283303.Bytes);
public long this[int i]=>Value[i];

public static A283303Inst Instance=new A283303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283304
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,0L,1L,2L,0L,1L,3L,2L,3L,0L,1L,2L,4L,3L,0L,1L,2L,4L,3L,0L,5L,1L,4L,2L,3L,5L,0L,4L,1L,2L,6L,3L,5L,4L,0L,1L,6L,2L,5L,3L,4L,7L,6L,0L,1L,2L,5L,3L,7L,4L,6L,0L,1L,5L,2L,8L,7L,3L,6L,4L,0L,8L,1L,5L,2L,7L,3L,6L,4L,9L,8L,5L,0L,7L,1L,2L,3L,6L,9L,8L,4L,7L,5L,0L,1L,10L,2L,9L,6L,3L,8L,4L,7L,10L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283304Inst : IEnumerable<long>
{
public static readonly long[] Value=A283304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283304.Bytes);
public long this[int i]=>Value[i];

public static A283304Inst Instance=new A283304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283305
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,2L,1L,2L,2L,0L,3L,1L,3L,2L,3L,0L,4L,1L,4L,3L,2L,4L,0L,3L,4L,5L,1L,5L,2L,5L,4L,3L,5L,0L,6L,1L,6L,2L,6L,4L,5L,3L,6L,0L,7L,1L,5L,7L,4L,6L,2L,7L,3L,7L,5L,6L,0L,8L,1L,4L,7L,8L,2L,8L,6L,3L,8L,5L,7L,4L,8L,0L,9L,1L,9L,2L,6L,7L,9L,5L,8L,3L,9L,4L,9L,7L,0L,6L,8L,10L,1L,10L,2L,10L,5L,9L,3L,10L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283305Inst : IEnumerable<long>
{
public static readonly long[] Value=A283305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283305.Bytes);
public long this[int i]=>Value[i];

public static A283305Inst Instance=new A283305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283306
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,0L,2L,1L,2L,3L,0L,3L,1L,3L,2L,4L,0L,4L,1L,3L,4L,2L,5L,4L,3L,0L,5L,1L,5L,2L,4L,5L,3L,6L,0L,6L,1L,6L,2L,5L,4L,6L,3L,7L,0L,7L,5L,1L,6L,4L,7L,2L,7L,3L,6L,5L,8L,0L,8L,7L,4L,1L,8L,2L,6L,8L,3L,7L,5L,8L,4L,9L,0L,9L,1L,9L,7L,6L,2L,8L,5L,9L,3L,9L,4L,7L,10L,8L,6L,0L,10L,1L,10L,2L,9L,5L,10L,3L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283306Inst : IEnumerable<long>
{
public static readonly long[] Value=A283306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283306.Bytes);
public long this[int i]=>Value[i];

public static A283306Inst Instance=new A283306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283307
{
public static readonly long[] Value={ 0L,-1L,0L,0L,1L,-1L,-1L,1L,1L,-2L,0L,0L,2L,-2L,-2L,-1L,-1L,1L,1L,2L,2L,-2L,-2L,2L,2L,-3L,0L,0L,3L,-3L,-3L,-1L,-1L,1L,1L,3L,3L,-3L,-3L,-2L,-2L,2L,2L,3L,3L,-4L,0L,0L,4L,-4L,-4L,-1L,-1L,1L,1L,4L,4L,-3L,-3L,3L,3L,-4L,-4L,-2L,-2L,2L,2L,4L,4L,-5L,-4L,-4L,-3L,-3L,0L,0L,3L,3L,4L,4L,5L,-5L,-5L,-1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283307Inst : IEnumerable<long>
{
public static readonly long[] Value=A283307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283307.Bytes);
public long this[int i]=>Value[i];

public static A283307Inst Instance=new A283307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283308
{
public static readonly long[] Value={ 0L,0L,-1L,1L,0L,-1L,1L,-1L,1L,0L,-2L,2L,0L,-1L,1L,-2L,2L,-2L,2L,-1L,1L,-2L,2L,-2L,2L,0L,-3L,3L,0L,-1L,1L,-3L,3L,-3L,3L,-1L,1L,-2L,2L,-3L,3L,-3L,3L,-2L,2L,0L,-4L,4L,0L,-1L,1L,-4L,4L,-4L,4L,-1L,1L,-3L,3L,-3L,3L,-2L,2L,-4L,4L,-4L,4L,-2L,2L,0L,-3L,3L,-4L,4L,-5L,5L,-4L,4L,-3L,3L,0L,-1L,1L,-5L,5L,-5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283308Inst : IEnumerable<long>
{
public static readonly long[] Value=A283308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283308.Bytes);
public long this[int i]=>Value[i];

public static A283308Inst Instance=new A283308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283309
{
public static readonly long[] Value={ 0L,1L,2L,1L,4L,6L,8L,13L,18L,22L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283309Inst : IEnumerable<long>
{
public static readonly long[] Value=A283309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283309.Bytes);
public long this[int i]=>Value[i];

public static A283309Inst Instance=new A283309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283310
{
public static readonly long[] Value={ 0L,1L,2L,0L,1L,2L,0L,2L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283310Inst : IEnumerable<long>
{
public static readonly long[] Value=A283310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283310.Bytes);
public long this[int i]=>Value[i];

public static A283310Inst Instance=new A283310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283311
{
public static readonly BigInteger[] Value={ 0L,1L,50L,1307L,61513956L,1458205461L,BigInteger.Parse("235845043987769122519632535030") };
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
public class A283311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283311Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283311.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283311Inst Instance=new A283311Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283312
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,5L,10L,7L,14L,8L,9L,11L,22L,12L,13L,26L,15L,16L,17L,34L,18L,19L,38L,20L,21L,23L,46L,24L,25L,27L,28L,29L,58L,30L,31L,62L,32L,33L,35L,36L,37L,74L,39L,40L,41L,82L,42L,43L,86L,44L,45L,47L,94L,48L,49L,50L,51L,52L,53L,106L,54L,55L,56L,57L,59L,118L,60L,61L,122L,63L,64L,65L,66L,67L,134L,68L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283312Inst : IEnumerable<long>
{
public static readonly long[] Value=A283312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283312.Bytes);
public long this[int i]=>Value[i];

public static A283312Inst Instance=new A283312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283313
{
public static readonly long[] Value={ 2L,3L,3L,5L,5L,7L,7L,8L,8L,9L,11L,12L,12L,13L,15L,15L,16L,17L,18L,18L,19L,20L,20L,21L,23L,24L,24L,25L,27L,28L,29L,30L,30L,31L,32L,32L,33L,35L,36L,37L,39L,39L,40L,41L,42L,42L,43L,44L,44L,45L,47L,48L,48L,49L,50L,51L,52L,53L,54L,54L,55L,56L,57L,59L,60L,60L,61L,63L,63L,64L,65L,66L,67L,68L,68L,69L,70L,71L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283313Inst : IEnumerable<long>
{
public static readonly long[] Value=A283313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283313.Bytes);
public long this[int i]=>Value[i];

public static A283313Inst Instance=new A283313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283378
{
public static readonly long[] Value={ 1L,1L,1L,7L,3L,25L,7L,115L,37L,445L,25L,1991L,923L,6497L,1951L,29487L,9319L,113931L,6649L,508147L,237413L,1658389L,513269L,7577189L,2428301L,29220977L,1626031L,130492199L,59943611L,427469713L,129415479L,1929418051L,620672989L,7474086825L,431520063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283378Inst : IEnumerable<long>
{
public static readonly long[] Value=A283378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283378.Bytes);
public long this[int i]=>Value[i];

public static A283378Inst Instance=new A283378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283379
{
public static readonly long[] Value={ 1L,2L,4L,14L,24L,38L,112L,206L,328L,758L,1216L,3646L,6968L,8614L,31984L,62670L,117832L,213750L,326848L,847934L,1367864L,2759846L,5740016L,10910158L,23290184L,37232374L,128948416L,240012862L,464169272L,578115494L,1984870128L,3265855694L,6305807944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283379Inst : IEnumerable<long>
{
public static readonly long[] Value=A283379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283379.Bytes);
public long this[int i]=>Value[i];

public static A283379Inst Instance=new A283379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283380
{
public static readonly long[] Value={ 0L,1L,3L,19L,91L,399L,1734L,7257L,29754L,120018L,477678L,1880898L,7339875L,28425538L,109368210L,418413378L,1592767290L,6036395895L,22786979315L,85714057229L,321381104832L,1201482684424L,4479736531496L,16661729383449L,61830609817953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283380Inst : IEnumerable<long>
{
public static readonly long[] Value=A283380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283380.Bytes);
public long this[int i]=>Value[i];

public static A283380Inst Instance=new A283380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283381
{
public static readonly long[] Value={ 0L,3L,60L,532L,4420L,34531L,257416L,1862717L,13180270L,91663499L,628776285L,4264929188L,28658352573L,191042638980L,1264824631815L,8324053254833L,54494796078919L,355096961618473L,2304221229952838L,14895901458999710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283381Inst : IEnumerable<long>
{
public static readonly long[] Value=A283381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283381.Bytes);
public long this[int i]=>Value[i];

public static A283381Inst Instance=new A283381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283382
{
public static readonly long[] Value={ 0L,19L,532L,8087L,116624L,1592250L,20788531L,264040297L,3282238215L,40118887549L,483764807520L,5768246109027L,68131353675622L,798246637065836L,9287150583313283L,107389081231009891L,1235032262230121990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283382Inst : IEnumerable<long>
{
public static readonly long[] Value=A283382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283382.Bytes);
public long this[int i]=>Value[i];

public static A283382Inst Instance=new A283382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283383
{
public static readonly BigInteger[] Value={ 0L,91L,4420L,116624L,2993934L,71707838L,1644385909L,36631580212L,797807876394L,17071093013959L,360093050350939L,7506214481935722L,154911588816764077L,3169754325029230295L,BigInteger.Parse("64378159448861378436"),BigInteger.Parse("1299032728948862185980") };
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
public class A283383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283383Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283383.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283383Inst Instance=new A283383Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283384
{
public static readonly BigInteger[] Value={ 0L,399L,34531L,1592250L,71707838L,3007934404L,120672330232L,4702791428260L,179057922328623L,6695014133297498L,246668281038206742L,8977573150142192566L,BigInteger.Parse("323379332405824735003"),BigInteger.Parse("11545468737993581686038"),BigInteger.Parse("409038243289396611366132") };
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
public class A283384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283384Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283384.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283384Inst Instance=new A283384Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283385
{
public static readonly BigInteger[] Value={ 0L,1734L,257416L,20788531L,1644385909L,120672330232L,8473366210380L,577497122717510L,38429377558548084L,2510034447031636894L,BigInteger.Parse("161474518006208921112"),BigInteger.Parse("10257528561081995711619"),BigInteger.Parse("644676948221905320696958") };
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
public class A283385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283385Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283385.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283385Inst Instance=new A283385Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283386
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,3L,3L,0L,0L,19L,60L,19L,0L,0L,91L,532L,532L,91L,0L,0L,399L,4420L,8087L,4420L,399L,0L,0L,1734L,34531L,116624L,116624L,34531L,1734L,0L,0L,7257L,257416L,1592250L,2993934L,1592250L,257416L,7257L,0L,0L,29754L,1862717L,20788531L,71707838L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283386Inst : IEnumerable<long>
{
public static readonly long[] Value=A283386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283386.Bytes);
public long this[int i]=>Value[i];

public static A283386Inst Instance=new A283386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283387
{
public static readonly ulong[] Value={ 1L,10L,100L,1011L,10001L,101110L,1000100L,10111011L,100010001L,1011111110L,10001111100L,101110111011L,1000100010001L,10111111101110L,100011111000100L,1011101110111111L,10001000100011111L,101111111011101111L,1000111110001000111L,10111011101111111011UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283387Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A283387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283387.Bytes);
public ulong this[int i]=>Value[i];

public static A283387Inst Instance=new A283387Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283388
{
public static readonly ulong[] Value={ 1L,1L,1L,1101L,10001L,11101L,10001L,11011101L,100010001L,111111101L,111110001L,110111011101L,1000100010001L,1110111111101L,1000111110001L,1111110111011101L,11111000100010001L,111101110111111101L,1110001000111110001L,11011111110111011101UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283388Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A283388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283388.Bytes);
public ulong this[int i]=>Value[i];

public static A283388Inst Instance=new A283388Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283389
{
public static readonly long[] Value={ 1L,2L,4L,11L,17L,46L,68L,187L,273L,766L,1148L,3003L,4369L,12270L,18372L,48063L,69919L,196335L,293959L,769019L,1118705L,3141358L,4703300L,12303291L,17895697L,50266094L,75268036L,196853691L,286334737L,804187886L,1204044868L,3149905851L,4582219537L,12867006190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283389Inst : IEnumerable<long>
{
public static readonly long[] Value=A283389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283389.Bytes);
public long this[int i]=>Value[i];

public static A283389Inst Instance=new A283389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283390
{
public static readonly long[] Value={ 1L,1L,1L,13L,17L,29L,17L,221L,273L,509L,497L,3549L,4369L,7677L,4593L,64989L,127249L,253437L,463345L,916957L,1175825L,1957373L,1118705L,14540253L,17895697L,31456765L,18870769L,232775133L,287248657L,501079549L,286331377L,3724410333L,4596035857L,8017272317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283390Inst : IEnumerable<long>
{
public static readonly long[] Value=A283390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283390.Bytes);
public long this[int i]=>Value[i];

public static A283390Inst Instance=new A283390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283391
{
public static readonly long[] Value={ 5L,13L,17L,29L,37L,53L,61L,73L,97L,109L,113L,137L,149L,181L,193L,197L,229L,233L,277L,293L,313L,317L,337L,349L,401L,421L,449L,457L,461L,521L,541L,569L,613L,641L,653L,673L,677L,701L,709L,757L,809L,821L,853L,877L,929L,941L,977L,997L,1009L,1021L,1049L,1061L,1069L,1093L,1117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283391Inst : IEnumerable<long>
{
public static readonly long[] Value=A283391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283391.Bytes);
public long this[int i]=>Value[i];

public static A283391Inst Instance=new A283391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283392
{
public static readonly long[] Value={ 50L,146L,866L,2162L,4178L,8362L,14372L,17138L,19094L,22504L,25346L,26764L,27544L,35074L,42634L,45218L,54184L,59554L,63484L,69812L,70562L,90904L,107252L,111004L,121106L,121682L,125138L,126764L,127454L,131596L,132464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283392Inst : IEnumerable<long>
{
public static readonly long[] Value=A283392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283392.Bytes);
public long this[int i]=>Value[i];

public static A283392Inst Instance=new A283392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283393
{
public static readonly long[] Value={ 1L,10L,1L,2L,5L,2L,5L,2L,1L,10L,1L,10L,1L,2L,5L,2L,5L,2L,1L,10L,1L,10L,1L,2L,5L,2L,5L,2L,1L,10L,1L,10L,1L,2L,5L,2L,5L,2L,1L,10L,1L,10L,1L,2L,5L,2L,5L,2L,1L,10L,1L,10L,1L,2L,5L,2L,5L,2L,1L,10L,1L,10L,1L,2L,5L,2L,5L,2L,1L,10L,1L,10L,1L,2L,5L,2L,5L,2L,1L,10L,1L,10L,1L,2L,5L,2L,5L,2L,1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283393Inst : IEnumerable<long>
{
public static readonly long[] Value=A283393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283393.Bytes);
public long this[int i]=>Value[i];

public static A283393Inst Instance=new A283393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283426
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,4L,4L,4L,4L,4L,6L,8L,8L,6L,8L,8L,8L,8L,8L,10L,14L,14L,12L,12L,12L,12L,14L,14L,14L,16L,16L,16L,16L,16L,16L,16L,18L,24L,24L,22L,22L,16L,18L,24L,26L,28L,24L,22L,26L,24L,24L,28L,26L,26L,28L,26L,28L,32L,30L,30L,32L,30L,32L,32L,32L,32L,32L,32L,32L,34L,42L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283426Inst : IEnumerable<long>
{
public static readonly long[] Value=A283426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283426.Bytes);
public long this[int i]=>Value[i];

public static A283426Inst Instance=new A283426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283427
{
public static readonly long[] Value={ 0L,1L,7L,26L,34L,55L,65L,91L,137L,152L,208L,251L,270L,315L,394L,471L,502L,591L,656L,685L,790L,864L,977L,1139L,1227L,1268L,1354L,1395L,1494L,1847L,1945L,2109L,2157L,2455L,2512L,2693L,2878L,3005L,3202L,3396L,3471L,3826L,3902L,4045L,4119L,4581L,5059L,5226L,5307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283427Inst : IEnumerable<long>
{
public static readonly long[] Value=A283427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283427.Bytes);
public long this[int i]=>Value[i];

public static A283427Inst Instance=new A283427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283428
{
public static readonly long[] Value={ 3L,4L,7L,11L,9L,11L,11L,4L,6L,10L,7L,8L,15L,14L,11L,7L,9L,16L,16L,14L,12L,8L,11L,10L,3L,4L,7L,11L,9L,11L,11L,4L,6L,10L,7L,8L,15L,14L,11L,7L,9L,16L,16L,14L,12L,8L,11L,10L,3L,4L,7L,11L,9L,11L,11L,4L,6L,10L,7L,8L,15L,14L,11L,7L,9L,16L,16L,14L,12L,8L,11L,10L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283428Inst : IEnumerable<long>
{
public static readonly long[] Value=A283428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283428.Bytes);
public long this[int i]=>Value[i];

public static A283428Inst Instance=new A283428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283429
{
public static readonly BigInteger[] Value={ 1L,10L,0L,1100L,1L,111000L,0L,11110011L,110L,1111100000L,0L,111111000001L,10000L,11111110000000L,1L,1111111100111000L,1101000L,111111111000000011L,10L,11111111110000011110UL,100000110L,BigInteger.Parse("1111111111100000000100"),100L,BigInteger.Parse("111111111111001111100001"),11010010000L };
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
public class A283429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283429Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283429.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283429Inst Instance=new A283429Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283430
{
public static readonly long[] Value={ 1L,10L,12L,2L,11L,3L,13L,14L,4L,22L,5L,15L,16L,6L,26L,20L,21L,17L,7L,27L,23L,24L,25L,28L,8L,18L,19L,9L,29L,32L,30L,31L,34L,35L,36L,37L,38L,39L,43L,40L,33L,41L,42L,45L,46L,47L,48L,49L,54L,50L,44L,51L,52L,53L,56L,57L,58L,59L,65L,60L,55L,61L,62L,63L,64L,67L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283430Inst : IEnumerable<long>
{
public static readonly long[] Value=A283430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283430.Bytes);
public long this[int i]=>Value[i];

public static A283430Inst Instance=new A283430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283431
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,3L,2L,3L,2L,3L,2L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,9L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283431Inst : IEnumerable<long>
{
public static readonly long[] Value=A283431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283431.Bytes);
public long this[int i]=>Value[i];

public static A283431Inst Instance=new A283431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283432
{
public static readonly BigInteger[] Value={ 1L,1L,3L,1L,6L,27L,1L,18L,216L,5346L,1L,45L,1701L,134865L,10766601L,1L,135L,15066L,3608550L,871858485L,211829725395L,1L,378L,133407L,96997824L,70607782701L,51472887053238L,37523659114815147L,1L,1134L,1198476L,2616461190L,5719211266905L,12507889858389450L,BigInteger.Parse("27354747358715650524"),BigInteger.Parse("59824832319304600777362") };
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
public class A283432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283432Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283432.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283432Inst Instance=new A283432Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283433
{
public static readonly BigInteger[] Value={ 1L,1L,4L,1L,10L,76L,1L,40L,1120L,67840L,1L,136L,16576L,4212736L,1073790976L,1L,544L,263680L,268779520L,274882625536L,281475530358784L,1L,2080L,4197376L,17184194560L,70368756760576L,288230393868451840L,BigInteger.Parse("1180591620768950910976") };
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
public class A283433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283433Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283433.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283433Inst Instance=new A283433Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283434
{
public static readonly BigInteger[] Value={ 1L,1L,5L,1L,15L,175L,1L,75L,4125L,496875L,1L,325L,98125L,61140625L,38147265625L,1L,1625L,2446875L,7632421875L,23841923828125L,74505821533203125L,1L,7875L,61046875L,953736328125L,14901161376953125L,BigInteger.Parse("232830644622802734375"),BigInteger.Parse("3637978807094573974609375") };
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
public class A283434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283434Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283434.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283434Inst Instance=new A283434Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283435
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,2L,6L,39L,1L,4L,22L,252L,3270L,1L,6L,66L,1675L,46448L,1302196L,1L,10L,246L,12300L,676732L,38786376L,2268820290L,1L,19L,868L,88900L,10032648L,1134474924L,134564842984L,15801337532526L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283435Inst : IEnumerable<long>
{
public static readonly long[] Value=A283435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283435.Bytes);
public long this[int i]=>Value[i];

public static A283435Inst Instance=new A283435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283436
{
public static readonly long[] Value={ 1L,1L,1L,1L,-2L,-3L,-10L,-10L,-17L,-20L,-27L,-31L,-45L,-45L,-59L,-65L,-76L,-83L,-104L,-104L,-125L,-134L,-149L,-159L,-187L,-187L,-215L,-227L,-246L,-259L,-294L,-294L,-329L,-344L,-367L,-383L,-425L,-425L,-467L,-485L,-512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283436Inst : IEnumerable<long>
{
public static readonly long[] Value=A283436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283436.Bytes);
public long this[int i]=>Value[i];

public static A283436Inst Instance=new A283436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283437
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283437Inst : IEnumerable<long>
{
public static readonly long[] Value=A283437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283437.Bytes);
public long this[int i]=>Value[i];

public static A283437Inst Instance=new A283437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283438
{
public static readonly long[] Value={ 1L,2L,6L,14L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283438Inst : IEnumerable<long>
{
public static readonly long[] Value=A283438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283438.Bytes);
public long this[int i]=>Value[i];

public static A283438Inst Instance=new A283438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283439
{
public static readonly long[] Value={ 1L,-3L,-9L,-6L,10L,25L,15L,-21L,-49L,-28L,36L,81L,45L,-55L,-121L,-66L,78L,169L,91L,-105L,-225L,-120L,136L,289L,153L,-171L,-361L,-190L,210L,441L,231L,-253L,-529L,-276L,300L,625L,325L,-351L,-729L,-378L,406L,841L,435L,-465L,-961L,-496L,528L,1089L,561L,-595L,-1225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283439Inst : IEnumerable<long>
{
public static readonly long[] Value=A283439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283439.Bytes);
public long this[int i]=>Value[i];

public static A283439Inst Instance=new A283439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283440
{
public static readonly long[] Value={ 0L,-1L,1L,2L,1L,-1L,2L,3L,1L,0L,-1L,1L,0L,-1L,3L,4L,1L,-1L,0L,1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,-1L,4L,5L,1L,-2L,1L,3L,2L,-1L,1L,2L,1L,1L,-2L,1L,1L,0L,-1L,1L,0L,-1L,1L,2L,1L,-1L,2L,-1L,-1L,-2L,3L,-1L,-2L,-1L,5L,6L,1L,-3L,2L,5L,3L,-2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283440Inst : IEnumerable<long>
{
public static readonly long[] Value=A283440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283440.Bytes);
public long this[int i]=>Value[i];

public static A283440Inst Instance=new A283440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283441
{
public static readonly long[] Value={ -1L,-2L,1L,5L,-4L,-5L,1L,10L,-9L,-9L,8L,9L,-9L,-10L,1L,17L,-16L,-17L,17L,18L,-17L,-17L,16L,17L,-17L,-18L,17L,17L,-16L,-17L,1L,26L,-25L,-29L,28L,37L,-33L,-34L,33L,37L,-36L,-37L,33L,34L,-33L,-33L,32L,33L,-33L,-34L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283441Inst : IEnumerable<long>
{
public static readonly long[] Value=A283441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283441.Bytes);
public long this[int i]=>Value[i];

public static A283441Inst Instance=new A283441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283442
{
public static readonly long[] Value={ 0L,5L,10L,15L,20L,1L,30L,35L,40L,45L,2L,55L,60L,65L,70L,3L,80L,85L,90L,95L,4L,105L,110L,115L,120L,5L,130L,135L,140L,145L,6L,155L,160L,165L,170L,7L,180L,185L,190L,195L,8L,205L,210L,215L,220L,9L,230L,235L,240L,245L,10L,255L,260L,265L,270L,11L,280L,285L,290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283442Inst : IEnumerable<long>
{
public static readonly long[] Value=A283442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283442.Bytes);
public long this[int i]=>Value[i];

public static A283442Inst Instance=new A283442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283443
{
public static readonly long[] Value={ 0L,6L,3L,2L,6L,30L,1L,42L,12L,6L,15L,66L,2L,78L,21L,10L,24L,102L,3L,114L,30L,14L,33L,138L,4L,150L,39L,18L,42L,174L,5L,186L,48L,22L,51L,210L,6L,222L,57L,26L,60L,246L,7L,258L,66L,30L,69L,282L,8L,294L,75L,34L,78L,318L,9L,330L,84L,38L,87L,354L,10L,366L,93L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283443Inst : IEnumerable<long>
{
public static readonly long[] Value=A283443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283443.Bytes);
public long this[int i]=>Value[i];

public static A283443Inst Instance=new A283443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283444
{
public static readonly long[] Value={ 0L,7L,14L,21L,28L,35L,42L,1L,56L,63L,70L,77L,84L,91L,2L,105L,112L,119L,126L,133L,140L,3L,154L,161L,168L,175L,182L,189L,4L,203L,210L,217L,224L,231L,238L,5L,252L,259L,266L,273L,280L,287L,6L,301L,308L,315L,322L,329L,336L,7L,350L,357L,364L,371L,378L,385L,8L,399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283444Inst : IEnumerable<long>
{
public static readonly long[] Value=A283444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283444.Bytes);
public long this[int i]=>Value[i];

public static A283444Inst Instance=new A283444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283445
{
public static readonly long[] Value={ 5731298L,7349884L,7526182L,7772498L,8345504L,9049864L,10077392L,11434504L,15956464L,20068348L,22998428L,31394306L,32122444L,32700026L,36011098L,36094144L,37905968L,38641706L,40793414L,40835534L,41437094L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283445Inst : IEnumerable<long>
{
public static readonly long[] Value=A283445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283445.Bytes);
public long this[int i]=>Value[i];

public static A283445Inst Instance=new A283445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283446
{
public static readonly long[] Value={ 24L,96L,120L,144L,168L,216L,240L,264L,336L,360L,384L,432L,456L,480L,504L,528L,576L,600L,624L,672L,720L,792L,816L,840L,864L,936L,960L,1008L,1056L,1080L,1176L,1200L,1224L,1296L,1320L,1344L,1440L,1512L,1536L,1560L,1584L,1680L,1728L,1824L,1848L,1920L,1944L,2016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283446Inst : IEnumerable<long>
{
public static readonly long[] Value=A283446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283446.Bytes);
public long this[int i]=>Value[i];

public static A283446Inst Instance=new A283446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283447
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,9L,12L,36L,42L,46L,75L,97L,153L,174L,204L,1078L,1306L,1380L,2096L,2401L,3393L,9547L,16650L,41404L,64014L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283447Inst : IEnumerable<long>
{
public static readonly long[] Value=A283447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283447.Bytes);
public long this[int i]=>Value[i];

public static A283447Inst Instance=new A283447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283448
{
public static readonly long[] Value={ 1L,2L,3L,5L,14L,18L,38L,65L,217L,218L,342L,560L,648L,962L,1151L,2043L,2113L,2641L,5738L,13295L,15793L,20424L,35729L,48474L,62298L,88077L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283448Inst : IEnumerable<long>
{
public static readonly long[] Value=A283448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283448.Bytes);
public long this[int i]=>Value[i];

public static A283448Inst Instance=new A283448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283449
{
public static readonly long[] Value={ 870L,378L,107827277891825604L,178101L,594839010L,275223438741L,26584448904822018L,40373802L,420707243066850L,952809806744100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283449Inst : IEnumerable<long>
{
public static readonly long[] Value=A283449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283449.Bytes);
public long this[int i]=>Value[i];

public static A283449Inst Instance=new A283449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283450
{
public static readonly long[] Value={ 2L,2L,3L,2L,19L,2L,5L,17L,13L,7L,1129L,59L,47L,7L,19L,7L,31L,79L,11L,37L,199L,5L,907L,43L,5L,43L,3L,13L,919L,2L,13L,2L,263L,127L,241L,3L,131L,71L,11L,421L,223L,2L,31L,3L,7L,89L,3673L,61L,293L,5L,131L,919L,3L,3L,349L,457L,1091L,461L,67L,7L,331L,7177L,571L,43L,1621L,109L,2521L,3L,1061L,5L,967L,1093L,1423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283450Inst : IEnumerable<long>
{
public static readonly long[] Value=A283450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283450.Bytes);
public long this[int i]=>Value[i];

public static A283450Inst Instance=new A283450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283451
{
public static readonly long[] Value={ -1L,0L,-2L,1L,-2L,2L,-3L,2L,-4L,2L,-4L,4L,-4L,4L,-6L,3L,-7L,4L,-7L,5L,-7L,5L,-7L,9L,-5L,9L,-7L,9L,-7L,9L,-11L,6L,-11L,9L,-12L,7L,-13L,9L,-12L,10L,-13L,10L,-14L,10L,-14L,10L,-14L,18L,-6L,19L,-11L,17L,-9L,21L,-9L,19L,-13L,17L,-15L,17L,-15L,17L,-23L,10L,-21L,17L,-18L,15L,-24L,16L,-21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283451Inst : IEnumerable<long>
{
public static readonly long[] Value=A283451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283451.Bytes);
public long this[int i]=>Value[i];

public static A283451Inst Instance=new A283451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283452
{
public static readonly long[] Value={ 4L,25L,9L,289L,4L,25L,4L,289L,9L,25L,4L,289L,4L,25L,9L,591361L,4L,25L,4L,289L,9L,25L,4L,289L,4L,169L,9L,289L,4L,25L,4L,37249L,9L,289L,4L,289L,4L,25L,9L,289L,4L,25L,4L,289L,9L,25L,4L,9409L,4L,25L,9L,289L,4L,25L,121L,289L,9L,25L,4L,289L,4L,25L,9L,66049L,4L,25L,4L,289L,9L,25L,4L,289L,4L,1369L,9L,289L,4L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283452Inst : IEnumerable<long>
{
public static readonly long[] Value=A283452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283452.Bytes);
public long this[int i]=>Value[i];

public static A283452Inst Instance=new A283452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283453
{
public static readonly long[] Value={ 4L,4L,121L,4L,4L,4L,4L,4L,121L,4L,4L,4L,4L,4L,121L,4L,4L,4L,4L,4L,121L,4L,4L,169L,4L,4L,4L,121L,4L,4L,4L,4L,4L,121L,4L,4L,4L,4L,4L,121L,4L,4L,4L,4L,4L,121L,4L,4L,4L,4L,4L,121L,4L,4L,4L,4L,4L,121L,4L,4L,4L,4L,4L,121L,4L,4L,4L,4L,4L,121L,4L,169L,4L,4L,4L,4L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283453Inst : IEnumerable<long>
{
public static readonly long[] Value=A283453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283453.Bytes);
public long this[int i]=>Value[i];

public static A283453Inst Instance=new A283453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283454
{
public static readonly long[] Value={ 2L,2L,11L,2L,2L,2L,2L,2L,11L,2L,2L,2L,2L,2L,11L,2L,2L,2L,2L,2L,11L,2L,2L,13L,2L,2L,2L,11L,2L,2L,2L,2L,2L,11L,2L,2L,2L,2L,2L,11L,2L,2L,2L,2L,2L,11L,2L,2L,2L,2L,2L,11L,2L,2L,2L,2L,2L,11L,2L,2L,2L,2L,2L,11L,2L,2L,2L,2L,2L,11L,2L,13L,2L,2L,2L,2L,11L,2L,2L,2L,2L,2L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283454Inst : IEnumerable<long>
{
public static readonly long[] Value=A283454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283454.Bytes);
public long this[int i]=>Value[i];

public static A283454Inst Instance=new A283454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283455
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,9L,11L,13L,17L,19L,23L,31L,37L,41L,49L,59L,61L,67L,83L,89L,97L,101L,103L,107L,109L,127L,131L,137L,139L,149L,167L,197L,199L,227L,241L,269L,271L,281L,293L,347L,373L,379L,421L,457L,487L,521L,523L,607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283455Inst : IEnumerable<long>
{
public static readonly long[] Value=A283455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283455.Bytes);
public long this[int i]=>Value[i];

public static A283455Inst Instance=new A283455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283456
{
public static readonly long[] Value={ 5L,13L,40L,136L,490L,1828L,6970L,26956L,105250L,413668L,1633450L,6471676L,25703410L,102269908L,407460730L,1625010796L,6485595970L,25899140548L,103467028810L,413479908316L,1652755798930L,6607533265588L,26419666417690L,105647272028236L,422494919768290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283456Inst : IEnumerable<long>
{
public static readonly long[] Value=A283456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283456.Bytes);
public long this[int i]=>Value[i];

public static A283456Inst Instance=new A283456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283457
{
public static readonly long[] Value={ 7L,24L,101L,477L,2411L,12729L,69251L,385017L,2175491L,12444489L,71865251L,418096857L,2446626371L,14383667049L,84875140451L,502327573497L,2980183394051L,17715498038409L,105478120962851L,628846706246937L,3753178627502531L,22420395331846569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283457Inst : IEnumerable<long>
{
public static readonly long[] Value=A283457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283457.Bytes);
public long this[int i]=>Value[i];

public static A283457Inst Instance=new A283457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283474
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,8L,14L,20L,40L,48L,68L,82L,150L,190L,272L,354L,708L,858L,1130L,1280L,2138L,2328L,3186L,3894L,7080L,8210L,10538L,11818L,20028L,23214L,33752L,44290L,88580L,100398L,123612L,134150L,222730L,233268L,277558L,300772L,534040L,567792L,691404L,725156L,1025928L,1126326L,1427098L,1704656L,3131754L,3665794L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283474Inst : IEnumerable<long>
{
public static readonly long[] Value=A283474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283474.Bytes);
public long this[int i]=>Value[i];

public static A283474Inst Instance=new A283474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283475
{
public static readonly long[] Value={ 1L,2L,6L,5L,30L,7L,21L,42L,210L,11L,33L,66L,165L,330L,154L,231L,2310L,13L,39L,78L,195L,390L,182L,273L,1365L,2730L,286L,429L,1430L,2145L,1001L,2002L,30030L,17L,51L,102L,255L,510L,238L,357L,1785L,3570L,374L,561L,1870L,2805L,1309L,2618L,19635L,39270L,442L,663L,2210L,3315L,1547L,3094L,15470L,23205L,2431L,4862L,12155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283475Inst : IEnumerable<long>
{
public static readonly long[] Value=A283475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283475.Bytes);
public long this[int i]=>Value[i];

public static A283475Inst Instance=new A283475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283476
{
public static readonly long[] Value={ 1L,2L,5L,6L,7L,11L,13L,17L,19L,21L,23L,29L,30L,31L,33L,37L,39L,41L,42L,43L,47L,51L,53L,57L,59L,61L,66L,67L,69L,71L,73L,78L,79L,83L,87L,89L,93L,97L,101L,102L,103L,107L,109L,111L,113L,114L,123L,127L,129L,131L,137L,138L,139L,141L,149L,151L,154L,157L,159L,163L,165L,167L,173L,174L,177L,179L,181L,182L,183L,186L,191L,193L,195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283476Inst : IEnumerable<long>
{
public static readonly long[] Value=A283476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283476.Bytes);
public long this[int i]=>Value[i];

public static A283476Inst Instance=new A283476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283477
{
public static readonly long[] Value={ 1L,2L,6L,12L,30L,60L,180L,360L,210L,420L,1260L,2520L,6300L,12600L,37800L,75600L,2310L,4620L,13860L,27720L,69300L,138600L,415800L,831600L,485100L,970200L,2910600L,5821200L,14553000L,29106000L,87318000L,174636000L,30030L,60060L,180180L,360360L,900900L,1801800L,5405400L,10810800L,6306300L,12612600L,37837800L,75675600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283477Inst : IEnumerable<long>
{
public static readonly long[] Value=A283477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283477.Bytes);
public long this[int i]=>Value[i];

public static A283477Inst Instance=new A283477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283478
{
public static readonly BigInteger[] Value={ 1L,2L,6L,3L,30L,5L,210L,6L,15L,7L,2310L,10L,30030L,11L,21L,5L,510510L,30L,9699690L,14L,33L,13L,223092870L,15L,105L,17L,14L,22L,6469693230L,42L,200560490130L,10L,39L,19L,165L,7L,7420738134810L,23L,51L,21L,304250263527210L,66L,13082761331670030L,26L,70L,29L,614889782588491410L,30L,1155L,210L,57L,34L,BigInteger.Parse("32589158477190044730"),21L,195L,33L,69L,31L };
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
public class A283478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283478Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283478.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283478Inst Instance=new A283478Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283479
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,6L,6L,20L,8L,20L,14L,68L,40L,82L,82L,354L,150L,272L,150L,858L,190L,858L,708L,3186L,1130L,2328L,1280L,8210L,3186L,10538L,10538L,44290L,11818L,23214L,10538L,88580L,10538L,44290L,23214L,233268L,33752L,123612L,33752L,300772L,100398L,300772L,277558L,1427098L,534040L,725156L,300772L,1704656L,534040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283479Inst : IEnumerable<long>
{
public static readonly long[] Value=A283479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283479.Bytes);
public long this[int i]=>Value[i];

public static A283479Inst Instance=new A283479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283480
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,3L,3L,3L,4L,4L,5L,6L,6L,6L,6L,6L,7L,7L,8L,8L,8L,9L,9L,9L,10L,11L,12L,12L,12L,12L,12L,12L,13L,13L,14L,14L,15L,16L,16L,17L,17L,17L,18L,18L,18L,19L,20L,21L,21L,22L,23L,23L,23L,23L,24L,25L,26L,27L,27L,27L,27L,27L,27L,27L,28L,28L,29L,29L,30L,30L,30L,31L,31L,32L,32L,32L,33L,33L,34L,35L,35L,36L,37L,37L,37L,37L,38L,38L,39L,40L,40L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283480Inst : IEnumerable<long>
{
public static readonly long[] Value=A283480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283480.Bytes);
public long this[int i]=>Value[i];

public static A283480Inst Instance=new A283480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283481
{
public static readonly long[] Value={ 1L,2L,5L,9L,11L,12L,17L,19L,22L,25L,26L,27L,33L,35L,37L,38L,40L,43L,46L,47L,48L,50L,51L,55L,56L,57L,58L,65L,67L,69L,72L,74L,77L,79L,80L,82L,83L,87L,89L,90L,92L,93L,97L,100L,101L,102L,107L,110L,111L,112L,117L,118L,119L,120L,121L,129L,131L,133L,135L,136L,138L,140L,143L,145L,148L,150L,151L,153L,154L,158L,160L,163L,165L,166L,168L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283481Inst : IEnumerable<long>
{
public static readonly long[] Value=A283481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283481.Bytes);
public long this[int i]=>Value[i];

public static A283481Inst Instance=new A283481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283482
{
public static readonly long[] Value={ 3L,4L,6L,7L,8L,10L,13L,14L,15L,16L,18L,20L,21L,23L,24L,28L,29L,30L,31L,32L,34L,36L,39L,41L,42L,44L,45L,49L,52L,53L,54L,59L,60L,61L,62L,63L,64L,66L,68L,70L,71L,73L,75L,76L,78L,81L,84L,85L,86L,88L,91L,94L,95L,96L,98L,99L,103L,104L,105L,106L,108L,109L,113L,114L,115L,116L,122L,123L,124L,125L,126L,127L,128L,130L,132L,134L,137L,139L,141L,142L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283482Inst : IEnumerable<long>
{
public static readonly long[] Value=A283482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283482.Bytes);
public long this[int i]=>Value[i];

public static A283482Inst Instance=new A283482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283483
{
public static readonly long[] Value={ 0L,1L,4L,5L,13L,14L,17L,18L,40L,41L,44L,45L,53L,54L,57L,58L,121L,122L,125L,126L,134L,135L,138L,139L,161L,162L,165L,166L,174L,175L,178L,179L,364L,365L,368L,369L,377L,378L,381L,382L,404L,405L,408L,409L,417L,418L,421L,422L,485L,486L,489L,490L,498L,499L,502L,503L,525L,526L,529L,530L,538L,539L,542L,543L,1093L,1094L,1097L,1098L,1106L,1107L,1110L,1111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283483Inst : IEnumerable<long>
{
public static readonly long[] Value=A283483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283483.Bytes);
public long this[int i]=>Value[i];

public static A283483Inst Instance=new A283483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283484
{
public static readonly long[] Value={ 1L,1L,3L,1L,3L,3L,15L,1L,3L,15L,45L,15L,15L,15L,105L,1L,3L,105L,225L,525L,1575L,1125L,1575L,105L,105L,525L,1575L,525L,105L,105L,1155L,1L,3L,1155L,1575L,3675L,7875L,275625L,55125L,5775L,17325L,275625L,4134375L,55125L,55125L,275625L,121275L,1155L,1155L,40425L,385875L,202125L,606375L,1929375L,606375L,5775L,8085L,40425L,121275L,40425L,1155L,1155L,15015L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283484Inst : IEnumerable<long>
{
public static readonly long[] Value=A283484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283484.Bytes);
public long this[int i]=>Value[i];

public static A283484Inst Instance=new A283484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283485
{
public static readonly long[] Value={ 4L,5L,7L,11L,13L,23L,25L,31L,33L,37L,59L,63L,91L,157L,265L,267L,327L,539L,555L,621L,715L,921L,979L,1633L,1821L,2259L,2697L,2809L,2863L,2935L,4213L,4351L,5937L,6885L,8743L,10761L,15159L,17685L,52075L,55147L,68677L,99655L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283485Inst : IEnumerable<long>
{
public static readonly long[] Value=A283485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283485.Bytes);
public long this[int i]=>Value[i];

public static A283485Inst Instance=new A283485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283486
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,2L,1L,0L,2L,1L,0L,3L,0L,1L,1L,2L,0L,1L,1L,1L,3L,1L,0L,3L,0L,0L,2L,2L,0L,3L,1L,0L,0L,1L,0L,5L,1L,0L,1L,2L,0L,3L,0L,0L,3L,0L,0L,4L,2L,0L,1L,2L,0L,2L,1L,1L,2L,0L,0L,4L,0L,2L,2L,2L,0L,2L,0L,0L,1L,2L,0L,5L,0L,0L,1L,2L,0L,2L,1L,1L,1L,1L,0L,6L,0L,0L,1L,1L,0L,4L,2L,0L,2L,0L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283486Inst : IEnumerable<long>
{
public static readonly long[] Value=A283486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283486.Bytes);
public long this[int i]=>Value[i];

public static A283486Inst Instance=new A283486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283487
{
public static readonly long[] Value={ 1L,2L,6L,12L,60L,66L,582L,605L,782L,881L,56052L,56059L,416333L,416591L,425552L,425554L,41247583L,41247675L,303126093L,303126138L,304477309L,304482240L,30081553433L,30081553435L,30710954157L,30711032607L,30712767417L,30712767879L,22692482319857L,22692482320447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283487Inst : IEnumerable<long>
{
public static readonly long[] Value=A283487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283487.Bytes);
public long this[int i]=>Value[i];

public static A283487Inst Instance=new A283487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283488
{
public static readonly long[] Value={ 0L,0L,2L,12L,64L,312L,1460L,6624L,29394L,128264L,552384L,2353888L,9943896L,41703328L,173822258L,720671156L,2974187392L,12224902712L,50069348140L,204417445696L,832198630882L,3379257614032L,13690075484800L,55344113101440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283488Inst : IEnumerable<long>
{
public static readonly long[] Value=A283488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283488.Bytes);
public long this[int i]=>Value[i];

public static A283488Inst Instance=new A283488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283489
{
public static readonly long[] Value={ 0L,2L,59L,576L,5444L,47712L,402588L,3304736L,26585976L,210604104L,1648084920L,12770161232L,98143291572L,749097112304L,5684201101568L,42914522732568L,322570735588252L,2415252852914064L,18022243345734636L,134067764826183784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283489Inst : IEnumerable<long>
{
public static readonly long[] Value=A283489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283489.Bytes);
public long this[int i]=>Value[i];

public static A283489Inst Instance=new A283489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283506
{
public static readonly long[] Value={ 1L,0L,5L,12L,29L,60L,125L,252L,509L,1020L,2045L,4092L,8189L,16380L,32765L,65532L,131069L,262140L,524285L,1048572L,2097149L,4194300L,8388605L,16777212L,33554429L,67108860L,134217725L,268435452L,536870909L,1073741820L,2147483645L,4294967292L,8589934589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283506Inst : IEnumerable<long>
{
public static readonly long[] Value=A283506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283506.Bytes);
public long this[int i]=>Value[i];

public static A283506Inst Instance=new A283506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283507
{
public static readonly long[] Value={ 1L,0L,5L,3L,23L,15L,95L,63L,383L,255L,1535L,1023L,6143L,4095L,24575L,16383L,98303L,65535L,393215L,262143L,1572863L,1048575L,6291455L,4194303L,25165823L,16777215L,100663295L,67108863L,402653183L,268435455L,1610612735L,1073741823L,6442450943L,4294967295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283507Inst : IEnumerable<long>
{
public static readonly long[] Value=A283507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283507.Bytes);
public long this[int i]=>Value[i];

public static A283507Inst Instance=new A283507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283508
{
public static readonly ulong[] Value={ 1L,10L,101L,1011L,10111L,101111L,1011111L,10111111L,101111111L,1011111111L,10111111111L,101111111111L,1011111111111L,10111111111111L,101111111111111L,1011111111111111L,10111111111111111L,101111111111111111L,1011111111111111111L,10111111111111111111UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283508Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A283508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283508.Bytes);
public ulong this[int i]=>Value[i];

public static A283508Inst Instance=new A283508Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283509
{
public static readonly long[] Value={ 1L,2L,4L,7L,0L,2L,5L,8L,12L,16L,20L,2L,6L,10L,16L,21L,27L,34L,3L,9L,15L,21L,27L,37L,45L,1L,9L,17L,25L,33L,45L,54L,63L,7L,18L,27L,37L,49L,60L,72L,3L,14L,26L,38L,50L,62L,74L,94L,8L,19L,35L,49L,61L,77L,93L,107L,11L,25L,41L,57L,73L,89L,113L,2L,15L,35L,52L,67L,88L,110L,129L,5L,25L,44L,64L,83L,105L,125L,146L,9L,31L,52L,73L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283509Inst : IEnumerable<long>
{
public static readonly long[] Value=A283509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283509.Bytes);
public long this[int i]=>Value[i];

public static A283509Inst Instance=new A283509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283510
{
public static readonly BigInteger[] Value={ 1L,1L,257L,531698L,4295531890L,95371863221411L,4738477950914329100L,BigInteger.Parse("459991301719292572342573"),BigInteger.Parse("79228623778497392212453912974"),BigInteger.Parse("22528478894247280128054776211273960"),BigInteger.Parse("10000022549030658394108744658459680045250") };
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
public class A283510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283510Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283510.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283510Inst Instance=new A283510Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283511
{
public static readonly long[] Value={ 2L,5L,8L,22L,23L,25L,156L,157L,158L,159L,306L,356L,357L,358L,359L,360L,503L,690L,1432L,1433L,1434L,1435L,1436L,1437L,1438L,3014L,4507L,6280L,7726L,7727L,7728L,7729L,7730L,7731L,7732L,7733L,7734L,7735L,16857L,16858L,16859L,30365L,30366L,30367L,30368L,30369L,30370L,30371L,30372L,30373L,30374L,30375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283511Inst : IEnumerable<long>
{
public static readonly long[] Value=A283511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283511.Bytes);
public long this[int i]=>Value[i];

public static A283511Inst Instance=new A283511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283512
{
public static readonly BigInteger[] Value={ 2L,11L,212L,2121L,21211L,121121L,2212212L,22122121L,221221211L,2212212112L,22122121122L,112212211211L,1122122112112L,11221221121121L,112212211211212L,1122122112112122L,11211212212211211L,112212211211212211L,1211212212112212212L,12112122121122122121UL,BigInteger.Parse("121121221211221221211") };
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
public class A283512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283512Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283512.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283512Inst Instance=new A283512Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283513
{
public static readonly long[] Value={ 2L,3L,5L,6L,8L,9L,32L,56L,63L,80L,117L,185L,590L,777L,1962L,2654L,3341L,5484L,10256L,11051L,11816L,20622L,44750L,94802L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283513Inst : IEnumerable<long>
{
public static readonly long[] Value=A283513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283513.Bytes);
public long this[int i]=>Value[i];

public static A283513Inst Instance=new A283513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283514
{
public static readonly BigInteger[] Value={ 3L,43L,543L,6543L,76543L,876543L,9876543L,109876543L,11109876543L,1211109876543L,131211109876543L,14131211109876543L,1514131211109876543L,BigInteger.Parse("161514131211109876543"),BigInteger.Parse("17161514131211109876543"),BigInteger.Parse("1817161514131211109876543"),BigInteger.Parse("191817161514131211109876543") };
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
public class A283514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283514Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283514.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283514Inst Instance=new A283514Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283515
{
public static readonly long[] Value={ 2L,3L,4L,16L,19L,31L,7547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283515Inst : IEnumerable<long>
{
public static readonly long[] Value=A283515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283515.Bytes);
public long this[int i]=>Value[i];

public static A283515Inst Instance=new A283515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283516
{
public static readonly long[] Value={ 0L,0L,1L,5L,28L,145L,703L,3288L,14980L,66958L,294864L,1283142L,5529698L,23637592L,100350059L,423511851L,1778210188L,7432635711L,30943479193L,128365649488L,530810149910L,2188638842860L,9000532494016L,36925016172060L,151153394192532L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283516Inst : IEnumerable<long>
{
public static readonly long[] Value=A283516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283516.Bytes);
public long this[int i]=>Value[i];

public static A283516Inst Instance=new A283516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283517
{
public static readonly long[] Value={ 0L,1L,20L,270L,2763L,26662L,241796L,2115564L,18020972L,150431216L,1235860816L,10022560088L,80412418752L,639331124272L,5043680344120L,39521427506168L,307850445104320L,2385411084242780L,18397022091700304L,141285768645661084L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A283517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283517Inst : IEnumerable<long>
{
public static readonly long[] Value=A283517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283517.Bytes);
public long this[int i]=>Value[i];

public static A283517Inst Instance=new A283517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A283518
{
public static readonly BigInteger[] Value={ 0L,5L,270L,5988L,113984L,2032993L,34279720L,558718061L,8877675769L,138361189406L,2123703646624L,32194034680888L,483025956805625L,7184039753675004L,106048960050497877L,1555282253332563953L,BigInteger.Parse("22678862678133637034") };
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
public class A283518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A283518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A283518Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A283518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A283518.Bytes);
public BigInteger this[int i]=>Value[i];

public static A283518Inst Instance=new A283518Inst();

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