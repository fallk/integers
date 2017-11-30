using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A153105
{
public static readonly long[] Value={ 5L,5L,7L,8L,8L,5L,8L,9L,1L,3L,0L,2L,2L,5L,9L,6L,8L,6L,3L,8L,2L,0L,8L,8L,1L,6L,2L,0L,7L,5L,7L,7L,1L,2L,0L,6L,2L,0L,9L,5L,8L,8L,6L,7L,5L,1L,9L,2L,9L,4L,6L,1L,3L,5L,9L,4L,5L,3L,9L,2L,0L,0L,6L,8L,1L,6L,5L,5L,3L,0L,1L,0L,4L,8L,0L,9L,3L,5L,1L,1L,8L,1L,6L,1L,3L,9L,4L,4L,3L,4L,7L,0L,0L,7L,2L,6L,2L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153105Inst : IEnumerable<long>
{
public static readonly long[] Value=A153105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153105.Bytes);
public long this[int i]=>Value[i];

public static A153105Inst Instance=new A153105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153106
{
public static readonly long[] Value={ 5L,4L,0L,4L,7L,6L,3L,0L,8L,8L,5L,4L,6L,3L,9L,4L,8L,2L,5L,8L,8L,2L,1L,6L,0L,0L,6L,9L,0L,1L,2L,8L,4L,5L,8L,8L,7L,9L,7L,2L,8L,8L,4L,0L,4L,6L,2L,7L,3L,6L,2L,2L,9L,8L,8L,0L,5L,5L,6L,4L,9L,6L,1L,3L,4L,7L,3L,5L,1L,3L,8L,7L,4L,6L,8L,9L,0L,6L,2L,4L,0L,6L,0L,6L,1L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153106Inst : IEnumerable<long>
{
public static readonly long[] Value=A153106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153106.Bytes);
public long this[int i]=>Value[i];

public static A153106Inst Instance=new A153106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153107
{
public static readonly long[] Value={ 5L,2L,5L,2L,9L,9L,0L,7L,0L,0L,7L,4L,3L,8L,7L,0L,9L,5L,9L,5L,7L,8L,1L,3L,7L,3L,7L,1L,3L,0L,1L,6L,1L,4L,4L,1L,2L,0L,1L,3L,2L,3L,1L,8L,9L,4L,1L,3L,8L,3L,9L,6L,1L,9L,7L,8L,4L,0L,8L,5L,1L,3L,2L,2L,1L,5L,3L,9L,2L,0L,9L,9L,9L,9L,5L,0L,3L,5L,0L,9L,2L,5L,7L,5L,0L,3L,1L,7L,1L,8L,0L,3L,6L,3L,1L,6L,8L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153107Inst : IEnumerable<long>
{
public static readonly long[] Value=A153107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153107.Bytes);
public long this[int i]=>Value[i];

public static A153107Inst Instance=new A153107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153108
{
public static readonly long[] Value={ 5L,1L,1L,9L,1L,6L,0L,4L,9L,6L,1L,9L,6L,3L,0L,9L,7L,8L,7L,7L,5L,3L,5L,5L,3L,5L,7L,7L,2L,9L,6L,0L,4L,5L,4L,0L,8L,0L,9L,8L,8L,3L,7L,5L,9L,5L,1L,7L,8L,0L,2L,2L,8L,4L,5L,3L,7L,0L,3L,0L,8L,6L,1L,8L,5L,9L,2L,3L,8L,4L,3L,9L,5L,4L,4L,3L,4L,4L,9L,8L,9L,0L,2L,9L,4L,5L,5L,1L,6L,7L,7L,0L,5L,9L,0L,5L,5L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153108Inst : IEnumerable<long>
{
public static readonly long[] Value=A153108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153108.Bytes);
public long this[int i]=>Value[i];

public static A153108Inst Instance=new A153108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153109
{
public static readonly long[] Value={ 4L,8L,9L,3L,0L,1L,0L,8L,4L,2L,3L,6L,4L,5L,2L,0L,6L,0L,7L,7L,9L,5L,2L,2L,9L,8L,2L,4L,6L,3L,9L,5L,5L,6L,1L,4L,7L,8L,8L,5L,2L,1L,9L,3L,1L,2L,1L,6L,7L,2L,7L,3L,9L,5L,5L,7L,2L,7L,0L,0L,7L,8L,5L,0L,5L,4L,3L,9L,4L,6L,2L,2L,3L,1L,4L,1L,0L,5L,3L,7L,1L,8L,9L,8L,5L,5L,3L,0L,3L,7L,6L,0L,9L,6L,0L,0L,6L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153109Inst : IEnumerable<long>
{
public static readonly long[] Value=A153109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153109.Bytes);
public long this[int i]=>Value[i];

public static A153109Inst Instance=new A153109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153110
{
public static readonly long[] Value={ 1L,5L,7L,2L,4L,8L,1L,5L,7L,2L,4L,8L,1L,5L,7L,2L,4L,8L,1L,5L,7L,2L,4L,8L,1L,5L,7L,2L,4L,8L,1L,5L,7L,2L,4L,8L,1L,5L,7L,2L,4L,8L,1L,5L,7L,2L,4L,8L,1L,5L,7L,2L,4L,8L,1L,5L,7L,2L,4L,8L,1L,5L,7L,2L,4L,8L,1L,5L,7L,2L,4L,8L,1L,5L,7L,2L,4L,8L,1L,5L,7L,2L,4L,8L,1L,5L,7L,2L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153110Inst : IEnumerable<long>
{
public static readonly long[] Value=A153110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153110.Bytes);
public long this[int i]=>Value[i];

public static A153110Inst Instance=new A153110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153111
{
public static readonly BigInteger[] Value={ 1L,25L,649L,16849L,437425L,11356201L,294823801L,7654062625L,198710804449L,5158826853049L,133930787374825L,3477041644892401L,90269151979827601L,2343520909830625225L,BigInteger.Parse("60841274503616428249"),BigInteger.Parse("1579529616184196509249"),BigInteger.Parse("41006928746285492812225") };
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
public class A153111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153111Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153111.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153111Inst Instance=new A153111Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153112
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,3L,3L,3L,4L,5L,5L,5L,5L,6L,7L,7L,8L,8L,8L,8L,8L,9L,10L,11L,2L,12L,12L,12L,13L,13L,2L,14L,14L,14L,14L,15L,16L,16L,17L,18L,18L,19L,19L,10L,19L,20L,20L,20L,21L,21L,21L,10L,24L,24L,13L,24L,25L,16L,26L,26L,26L,27L,27L,28L,28L,1L,2L,2L,3L,3L,3L,4L,5L,5L,5L,2L,6L,7L,7L,8L,8L,8L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153112Inst : IEnumerable<long>
{
public static readonly long[] Value=A153112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153112.Bytes);
public long this[int i]=>Value[i];

public static A153112Inst Instance=new A153112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153113
{
public static readonly long[] Value={ 4L,7L,9L,6L,2L,4L,9L,3L,3L,1L,3L,6L,2L,6L,2L,8L,8L,9L,4L,7L,1L,3L,6L,8L,3L,2L,9L,8L,2L,1L,0L,4L,6L,1L,2L,3L,5L,3L,6L,3L,5L,5L,8L,6L,0L,0L,3L,8L,1L,4L,1L,1L,3L,1L,9L,5L,7L,2L,8L,9L,8L,0L,1L,4L,2L,9L,8L,2L,5L,8L,1L,1L,4L,8L,6L,3L,7L,9L,0L,8L,9L,7L,0L,1L,3L,1L,1L,2L,8L,2L,9L,6L,0L,2L,8L,2L,2L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153113Inst : IEnumerable<long>
{
public static readonly long[] Value=A153113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153113.Bytes);
public long this[int i]=>Value[i];

public static A153113Inst Instance=new A153113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153114
{
public static readonly long[] Value={ 0L,1L,3L,7L,15L,30L,31L,63L,127L,255L,503L,507L,509L,510L,511L,1003L,1005L,1006L,1015L,1019L,1020L,1021L,1022L,2007L,2015L,2030L,2031L,2039L,2043L,2045L,2046L,3007L,3070L,3071L,4030L,4031L,4063L,4079L,4087L,4090L,4091L,4093L,4094L,8063L,8190L,8191L,16383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153114Inst : IEnumerable<long>
{
public static readonly long[] Value=A153114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153114.Bytes);
public long this[int i]=>Value[i];

public static A153114Inst Instance=new A153114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153115
{
public static readonly long[] Value={ 1L,16L,128L,512L,1024L,1152L,2112L,4112L,8192L,16384L,16416L,16512L,131073L,131074L,131076L,131080L,131081L,131088L,131105L,131106L,131108L,131110L,131111L,131113L,131114L,131116L,131120L,131121L,131137L,131138L,131140L,131141L,131144L,131152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153115Inst : IEnumerable<long>
{
public static readonly long[] Value=A153115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153115.Bytes);
public long this[int i]=>Value[i];

public static A153115Inst Instance=new A153115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153116
{
public static readonly long[] Value={ 5L,7L,13L,19L,29L,41L,61L,97L,113L,139L,191L,379L,383L,401L,491L,719L,953L,1051L,1367L,1553L,1609L,1657L,1667L,1801L,1933L,2129L,2207L,2351L,2473L,3001L,3023L,3061L,3449L,3571L,3863L,3943L,3967L,4073L,4219L,5167L,5209L,5683L,5783L,6257L,6329L,6827L,7187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153116Inst : IEnumerable<long>
{
public static readonly long[] Value=A153116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153116.Bytes);
public long this[int i]=>Value[i];

public static A153116Inst Instance=new A153116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153117
{
public static readonly long[] Value={ 4L,7L,0L,8L,1L,7L,8L,2L,6L,7L,3L,3L,2L,7L,6L,4L,7L,2L,8L,9L,3L,9L,3L,0L,9L,2L,0L,0L,7L,3L,6L,8L,3L,7L,0L,7L,6L,7L,0L,8L,1L,3L,5L,5L,3L,2L,5L,5L,6L,3L,2L,0L,9L,4L,5L,7L,6L,2L,6L,4L,7L,3L,7L,0L,0L,5L,7L,1L,4L,6L,0L,4L,2L,6L,4L,1L,0L,8L,9L,6L,3L,5L,0L,4L,8L,8L,0L,0L,9L,1L,7L,4L,9L,5L,6L,7L,2L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153117Inst : IEnumerable<long>
{
public static readonly long[] Value=A153117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153117.Bytes);
public long this[int i]=>Value[i];

public static A153117Inst Instance=new A153117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153118
{
public static readonly long[] Value={ 5L,7L,11L,17L,29L,41L,43L,59L,71L,83L,223L,283L,311L,347L,389L,433L,479L,601L,619L,881L,907L,967L,983L,991L,1039L,1093L,1151L,1471L,1567L,1723L,1873L,1877L,1907L,1931L,1933L,1987L,2309L,2531L,2953L,3037L,3461L,3539L,3853L,4001L,4003L,4007L,4073L,4091L,4253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153118Inst : IEnumerable<long>
{
public static readonly long[] Value=A153118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153118.Bytes);
public long this[int i]=>Value[i];

public static A153118Inst Instance=new A153118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153119
{
public static readonly long[] Value={ 7L,13L,47L,79L,113L,251L,317L,397L,547L,719L,1013L,1153L,2113L,2141L,2179L,2267L,2309L,2749L,3271L,3557L,3631L,3739L,4243L,4783L,4919L,5399L,5563L,5881L,5927L,6389L,6701L,7229L,7351L,7547L,7691L,7741L,7817L,8191L,8269L,8779L,8807L,9067L,9133L,9277L,10067L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153119Inst : IEnumerable<long>
{
public static readonly long[] Value=A153119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153119.Bytes);
public long this[int i]=>Value[i];

public static A153119Inst Instance=new A153119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153120
{
public static readonly long[] Value={ 5L,11L,13L,23L,53L,89L,101L,103L,109L,181L,197L,307L,313L,457L,467L,571L,691L,769L,863L,907L,1061L,1087L,1223L,1453L,1487L,1607L,1913L,2129L,2161L,2311L,2729L,2741L,2767L,2917L,3313L,3343L,3359L,3433L,4363L,4373L,4547L,4703L,4783L,4787L,4877L,5119L,5237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153120Inst : IEnumerable<long>
{
public static readonly long[] Value=A153120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153120.Bytes);
public long this[int i]=>Value[i];

public static A153120Inst Instance=new A153120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153121
{
public static readonly long[] Value={ 5L,7L,29L,41L,1933L,4073L,43049L,46439L,60353L,72031L,150989L,153929L,158551L,158591L,190051L,199247L,226267L,438479L,545749L,613451L,696737L,714841L,734663L,754627L,788353L,793843L,825259L,948457L,1053191L,1057699L,1154159L,1241827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153121Inst : IEnumerable<long>
{
public static readonly long[] Value=A153121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153121.Bytes);
public long this[int i]=>Value[i];

public static A153121Inst Instance=new A153121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153122
{
public static readonly long[] Value={ 1L,-2L,6L,-15L,38L,-95L,237L,-590L,1468L,-3651L,9079L,-22575L,56131L,-139563L,347004L,-862774L,2145156L,-5333599L,13261165L,-32971820L,81979285L,-203828691L,506788203L,-1260049698L,3132916721L,-7789507968L,19367394583L,-48154000782L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153122Inst : IEnumerable<long>
{
public static readonly long[] Value=A153122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153122.Bytes);
public long this[int i]=>Value[i];

public static A153122Inst Instance=new A153122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153123
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,9L,10L,12L,14L,17L,20L,22L,23L,31L,53L,56L,57L,683L,2983L,2984L,2985L,149411L,811160L,811162L,811163L,75426842L,476823319L,476823329L,476823330L,73727027930L,530824147003L,530824147008L,530824147009L,126824134344110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153123Inst : IEnumerable<long>
{
public static readonly long[] Value=A153123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153123.Bytes);
public long this[int i]=>Value[i];

public static A153123Inst Instance=new A153123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153124
{
public static readonly long[] Value={ 4L,6L,2L,7L,5L,6L,4L,2L,6L,3L,1L,9L,5L,1L,8L,3L,4L,8L,5L,2L,7L,3L,9L,5L,4L,0L,2L,1L,9L,5L,2L,8L,0L,9L,9L,1L,7L,8L,1L,9L,3L,1L,0L,1L,4L,7L,4L,7L,1L,3L,1L,7L,2L,3L,6L,7L,9L,2L,3L,5L,5L,8L,8L,2L,2L,7L,0L,4L,9L,1L,0L,8L,0L,6L,0L,3L,1L,6L,7L,6L,9L,4L,2L,7L,9L,3L,1L,1L,6L,8L,0L,8L,9L,5L,0L,7L,8L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153124Inst : IEnumerable<long>
{
public static readonly long[] Value=A153124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153124.Bytes);
public long this[int i]=>Value[i];

public static A153124Inst Instance=new A153124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153125
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,9L,4L,7L,10L,12L,5L,8L,11L,14L,17L,6L,9L,12L,15L,18L,20L,7L,10L,13L,16L,19L,22L,25L,8L,11L,14L,17L,20L,23L,26L,28L,9L,12L,15L,18L,21L,24L,27L,30L,33L,10L,13L,16L,19L,22L,25L,28L,31L,34L,36L,11L,14L,17L,20L,23L,26L,29L,32L,35L,38L,41L,12L,15L,18L,21L,24L,27L,30L,33L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153125Inst : IEnumerable<long>
{
public static readonly long[] Value=A153125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153125.Bytes);
public long this[int i]=>Value[i];

public static A153125Inst Instance=new A153125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153126
{
public static readonly long[] Value={ 1L,6L,18L,33L,55L,80L,112L,147L,189L,234L,286L,341L,403L,468L,540L,615L,697L,782L,874L,969L,1071L,1176L,1288L,1403L,1525L,1650L,1782L,1917L,2059L,2204L,2356L,2511L,2673L,2838L,3010L,3185L,3367L,3552L,3744L,3939L,4141L,4346L,4558L,4773L,4995L,5220L,5452L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153126Inst : IEnumerable<long>
{
public static readonly long[] Value=A153126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153126.Bytes);
public long this[int i]=>Value[i];

public static A153126Inst Instance=new A153126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153127
{
public static readonly long[] Value={ 6L,33L,80L,147L,234L,341L,468L,615L,782L,969L,1176L,1403L,1650L,1917L,2204L,2511L,2838L,3185L,3552L,3939L,4346L,4773L,5220L,5687L,6174L,6681L,7208L,7755L,8322L,8909L,9516L,10143L,10790L,11457L,12144L,12851L,13578L,14325L,15092L,15879L,16686L,17513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153127Inst : IEnumerable<long>
{
public static readonly long[] Value=A153127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153127.Bytes);
public long this[int i]=>Value[i];

public static A153127Inst Instance=new A153127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153128
{
public static readonly long[] Value={ 11L,31L,41L,67L,131L,3121L,4229L,13159L,14081L,24631L,49877L,64921L,71789L,127051L,154871L,178621L,249677L,260011L,350729L,401473L,487397L,537883L,567767L,718423L,724499L,763621L,1004987L,1016611L,1043951L,1053529L,1090949L,1295113L,1309907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153128Inst : IEnumerable<long>
{
public static readonly long[] Value=A153128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153128.Bytes);
public long this[int i]=>Value[i];

public static A153128Inst Instance=new A153128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153129
{
public static readonly long[] Value={ 2L,5L,8L,9L,10L,11L,14L,15L,16L,17L,20L,23L,25L,26L,27L,29L,30L,31L,32L,35L,37L,38L,40L,41L,42L,44L,45L,47L,50L,51L,53L,54L,55L,56L,58L,59L,60L,61L,62L,64L,65L,66L,68L,70L,71L,72L,73L,74L,75L,77L,78L,79L,80L,83L,85L,86L,89L,90L,92L,93L,95L,97L,98L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153129Inst : IEnumerable<long>
{
public static readonly long[] Value=A153129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153129.Bytes);
public long this[int i]=>Value[i];

public static A153129Inst Instance=new A153129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153130
{
public static readonly long[] Value={ 1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153130Inst : IEnumerable<long>
{
public static readonly long[] Value=A153130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153130.Bytes);
public long this[int i]=>Value[i];

public static A153130Inst Instance=new A153130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153131
{
public static readonly long[] Value={ 4L,5L,5L,3L,4L,0L,4L,9L,7L,3L,9L,3L,9L,0L,5L,9L,9L,5L,9L,6L,4L,1L,5L,1L,9L,4L,4L,2L,0L,1L,7L,8L,1L,9L,9L,1L,2L,8L,2L,1L,3L,1L,1L,8L,2L,4L,8L,2L,6L,4L,6L,5L,9L,2L,3L,3L,4L,1L,4L,9L,9L,1L,3L,4L,3L,1L,2L,1L,7L,3L,6L,8L,5L,1L,3L,7L,0L,9L,5L,3L,5L,1L,6L,5L,7L,6L,8L,9L,6L,3L,0L,5L,3L,4L,6L,8L,1L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153131Inst : IEnumerable<long>
{
public static readonly long[] Value=A153131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153131.Bytes);
public long this[int i]=>Value[i];

public static A153131Inst Instance=new A153131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153132
{
public static readonly long[] Value={ 4L,4L,8L,4L,8L,7L,6L,4L,8L,4L,3L,5L,1L,5L,0L,8L,7L,8L,9L,5L,5L,1L,2L,4L,6L,7L,6L,8L,0L,6L,9L,6L,0L,9L,4L,1L,7L,9L,5L,8L,2L,5L,7L,6L,4L,8L,8L,4L,4L,4L,4L,0L,1L,9L,4L,5L,1L,5L,2L,3L,4L,2L,2L,1L,3L,0L,2L,2L,9L,0L,6L,0L,0L,1L,2L,8L,0L,2L,8L,4L,7L,8L,3L,5L,1L,5L,8L,9L,5L,3L,8L,6L,1L,4L,0L,7L,7L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153132Inst : IEnumerable<long>
{
public static readonly long[] Value=A153132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153132.Bytes);
public long this[int i]=>Value[i];

public static A153132Inst Instance=new A153132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153133
{
public static readonly BigInteger[] Value={ 3L,7L,17L,43L,113L,307L,857L,20707L,181243L,539633L,14414443L,129402307L,31389448217L,1853028778786433L,5559077746424707L,50031613818476443L,150094772735952593L,BigInteger.Parse("8862938260389989451257"),BigInteger.Parse("26588814640432479998443") };
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
public class A153133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153133Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153133.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153133Inst Instance=new A153133Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153134
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,8L,9L,10L,11L,13L,15L,16L,18L,19L,20L,23L,24L,26L,29L,30L,31L,33L,34L,39L,40L,41L,43L,44L,45L,46L,48L,50L,53L,54L,59L,60L,61L,65L,66L,68L,71L,73L,75L,76L,78L,79L,81L,83L,85L,86L,88L,94L,95L,96L,99L,100L,101L,104L,108L,109L,110L,111L,114L,115L,118L,121L,125L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153134Inst : IEnumerable<long>
{
public static readonly long[] Value=A153134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153134.Bytes);
public long this[int i]=>Value[i];

public static A153134Inst Instance=new A153134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153135
{
public static readonly long[] Value={ 2L,3L,5L,11L,13L,19L,23L,29L,31L,41L,43L,53L,59L,61L,71L,73L,79L,83L,101L,109L,139L,149L,163L,173L,193L,199L,211L,229L,239L,241L,251L,263L,269L,271L,313L,331L,349L,353L,379L,401L,409L,431L,433L,449L,491L,503L,521L,563L,569L,613L,631L,643L,653L,659L,683L,691L,733L,743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153135Inst : IEnumerable<long>
{
public static readonly long[] Value=A153135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153135.Bytes);
public long this[int i]=>Value[i];

public static A153135Inst Instance=new A153135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153136
{
public static readonly long[] Value={ 2L,7L,13L,43L,103L,1627L,25349L,315743L,7338823L,42939980423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153136Inst : IEnumerable<long>
{
public static readonly long[] Value=A153136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153136.Bytes);
public long this[int i]=>Value[i];

public static A153136Inst Instance=new A153136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153137
{
public static readonly long[] Value={ 1L,3L,5L,113L,181L,661L,10891L,927149L,88070399L,15288362671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153137Inst : IEnumerable<long>
{
public static readonly long[] Value=A153137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153137.Bytes);
public long this[int i]=>Value[i];

public static A153137Inst Instance=new A153137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153138
{
public static readonly long[] Value={ 3L,5L,7L,83L,317L,383L,29567L,423509L,118661483L,52542428123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153138Inst : IEnumerable<long>
{
public static readonly long[] Value=A153138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153138.Bytes);
public long this[int i]=>Value[i];

public static A153138Inst Instance=new A153138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153139
{
public static readonly long[] Value={ 10171L,10371L,10447L,10449L,10451L,11303L,11801L,11827L,12319L,12553L,13387L,13829L,13847L,13903L,13913L,14141L,14549L,15087L,15097L,15153L,15847L,16431L,16841L,16847L,17549L,18363L,18379L,18637L,18697L,18701L,19319L,19337L,19579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153139Inst : IEnumerable<long>
{
public static readonly long[] Value=A153139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153139.Bytes);
public long this[int i]=>Value[i];

public static A153139Inst Instance=new A153139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153140
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,14L,20L,28L,40L,54L,72L,98L,129L,168L,220L,282L,360L,460L,580L,728L,912L,1134L,1404L,1734L,2129L,2604L,3180L,3864L,4680L,5658L,6812L,8182L,9808L,11718L,13968L,16618L,19720L,23350L,27600L,32550L,38313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153140Inst : IEnumerable<long>
{
public static readonly long[] Value=A153140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153140.Bytes);
public long this[int i]=>Value[i];

public static A153140Inst Instance=new A153140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153141
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,6L,4L,5L,15L,14L,12L,13L,8L,9L,10L,11L,31L,30L,28L,29L,24L,25L,26L,27L,16L,17L,18L,19L,20L,21L,22L,23L,63L,62L,60L,61L,56L,57L,58L,59L,48L,49L,50L,51L,52L,53L,54L,55L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,127L,126L,124L,125L,120L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153141Inst : IEnumerable<long>
{
public static readonly long[] Value=A153141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153141.Bytes);
public long this[int i]=>Value[i];

public static A153141Inst Instance=new A153141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153142
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,7L,5L,4L,12L,13L,14L,15L,10L,11L,9L,8L,24L,25L,26L,27L,28L,29L,30L,31L,20L,21L,22L,23L,18L,19L,17L,16L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,40L,41L,42L,43L,44L,45L,46L,47L,36L,37L,38L,39L,34L,35L,33L,32L,96L,97L,98L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153142Inst : IEnumerable<long>
{
public static readonly long[] Value=A153142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153142.Bytes);
public long this[int i]=>Value[i];

public static A153142Inst Instance=new A153142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153143
{
public static readonly long[] Value={ 0L,2L,5L,6L,9L,11L,12L,14L,17L,20L,21L,24L,26L,27L,30L,32L,35L,39L,41L,42L,44L,45L,47L,54L,56L,59L,60L,65L,66L,69L,72L,74L,77L,80L,81L,86L,87L,89L,90L,96L,102L,104L,105L,107L,110L,111L,116L,119L,122L,125L,126L,129L,131L,132L,137L,144L,146L,147L,149L,156L,159L,164L,165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153143Inst : IEnumerable<long>
{
public static readonly long[] Value=A153143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153143.Bytes);
public long this[int i]=>Value[i];

public static A153143Inst Instance=new A153143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153144
{
public static readonly long[] Value={ 1L,3L,4L,7L,8L,10L,13L,15L,16L,18L,19L,22L,23L,25L,28L,29L,31L,33L,34L,36L,37L,38L,40L,43L,46L,48L,49L,50L,51L,52L,53L,55L,57L,58L,61L,62L,63L,64L,67L,68L,70L,71L,73L,75L,76L,78L,79L,82L,83L,84L,85L,88L,91L,92L,93L,94L,95L,97L,98L,99L,100L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153144Inst : IEnumerable<long>
{
public static readonly long[] Value=A153144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153144.Bytes);
public long this[int i]=>Value[i];

public static A153144Inst Instance=new A153144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153145
{
public static readonly long[] Value={ 2L,5L,11L,17L,41L,47L,59L,89L,107L,131L,137L,149L,167L,191L,251L,269L,311L,317L,389L,401L,419L,431L,461L,467L,479L,521L,587L,599L,641L,677L,797L,809L,839L,857L,929L,941L,947L,977L,1031L,1061L,1097L,1109L,1181L,1187L,1229L,1301L,1307L,1319L,1361L,1367L,1409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153145Inst : IEnumerable<long>
{
public static readonly long[] Value=A153145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153145.Bytes);
public long this[int i]=>Value[i];

public static A153145Inst Instance=new A153145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153146
{
public static readonly long[] Value={ 11L,12L,21L,24L,30L,39L,45L,54L,60L,66L,96L,105L,126L,129L,144L,156L,165L,189L,201L,210L,219L,234L,240L,261L,264L,291L,294L,306L,336L,360L,369L,396L,420L,429L,450L,474L,486L,495L,501L,516L,525L,534L,555L,591L,606L,639L,651L,654L,690L,714L,726L,735L,756L,765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153146Inst : IEnumerable<long>
{
public static readonly long[] Value=A153146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153146.Bytes);
public long this[int i]=>Value[i];

public static A153146Inst Instance=new A153146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153147
{
public static readonly long[] Value={ 8L,27L,125L,216L,343L,1000L,1331L,1728L,2197L,2744L,3375L,4913L,5832L,6859L,8000L,9261L,10648L,12167L,13824L,17576L,21952L,24389L,27000L,29791L,35937L,39304L,42875L,50653L,54872L,59319L,64000L,68921L,74088L,79507L,85184L,91125L,97336L,103823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153147Inst : IEnumerable<long>
{
public static readonly long[] Value=A153147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153147.Bytes);
public long this[int i]=>Value[i];

public static A153147Inst Instance=new A153147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153148
{
public static readonly long[] Value={ 1L,1L,1L,-1L,0L,2L,0L,-1L,0L,1L,1L,-2L,0L,3L,0L,-2L,-1L,3L,1L,-4L,0L,4L,1L,-4L,-1L,5L,2L,-6L,-2L,7L,0L,-6L,-1L,7L,3L,-9L,-1L,10L,1L,-10L,-2L,11L,3L,-14L,-3L,15L,2L,-14L,-3L,17L,5L,-19L,-4L,21L,3L,-22L,-5L,23L,7L,-28L,-5L,30L,5L,-30L,-7L,34L,8L,-38L,-7L,41L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153148Inst : IEnumerable<long>
{
public static readonly long[] Value=A153148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153148.Bytes);
public long this[int i]=>Value[i];

public static A153148Inst Instance=new A153148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153149
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,-1L,-1L,1L,2L,0L,-2L,1L,2L,-2L,-2L,2L,3L,-1L,-2L,2L,2L,-3L,-4L,3L,5L,-2L,-4L,3L,5L,-4L,-6L,4L,7L,-4L,-7L,5L,7L,-6L,-9L,7L,11L,-6L,-10L,7L,11L,-9L,-14L,9L,15L,-9L,-14L,11L,16L,-13L,-19L,13L,21L,-12L,-22L,15L,23L,-18L,-26L,19L,30L,-19L,-30L,21L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153149Inst : IEnumerable<long>
{
public static readonly long[] Value=A153149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153149.Bytes);
public long this[int i]=>Value[i];

public static A153149Inst Instance=new A153149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153150
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,4L,6L,7L,11L,9L,10L,8L,12L,14L,13L,15L,23L,19L,21L,17L,22L,18L,20L,16L,24L,28L,26L,30L,25L,29L,27L,31L,47L,39L,43L,35L,45L,37L,41L,33L,46L,38L,42L,34L,44L,36L,40L,32L,48L,56L,52L,60L,50L,58L,54L,62L,49L,57L,53L,61L,51L,59L,55L,63L,95L,79L,87L,71L,91L,75L,83L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153150Inst : IEnumerable<long>
{
public static readonly long[] Value=A153150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153150.Bytes);
public long this[int i]=>Value[i];

public static A153150Inst Instance=new A153150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153151
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,4L,5L,6L,15L,8L,9L,10L,11L,12L,13L,14L,31L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,63L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,127L,64L,65L,66L,67L,68L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153151Inst : IEnumerable<long>
{
public static readonly long[] Value=A153151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153151.Bytes);
public long this[int i]=>Value[i];

public static A153151Inst Instance=new A153151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153152
{
public static readonly long[] Value={ 0L,1L,3L,2L,5L,6L,7L,4L,9L,10L,11L,12L,13L,14L,15L,8L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,16L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,32L,65L,66L,67L,68L,69L,70L,71L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153152Inst : IEnumerable<long>
{
public static readonly long[] Value=A153152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153152.Bytes);
public long this[int i]=>Value[i];

public static A153152Inst Instance=new A153152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153153
{
public static readonly long[] Value={ 0L,1L,3L,2L,5L,6L,7L,4L,9L,10L,15L,12L,13L,14L,11L,8L,17L,18L,23L,20L,29L,30L,27L,24L,25L,26L,31L,28L,21L,22L,19L,16L,33L,34L,39L,36L,45L,46L,43L,40L,57L,58L,63L,60L,53L,54L,51L,48L,49L,50L,55L,52L,61L,62L,59L,56L,41L,42L,47L,44L,37L,38L,35L,32L,65L,66L,71L,68L,77L,78L,75L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153153Inst : IEnumerable<long>
{
public static readonly long[] Value=A153153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153153.Bytes);
public long this[int i]=>Value[i];

public static A153153Inst Instance=new A153153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153154
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,4L,5L,6L,15L,8L,9L,14L,11L,12L,13L,10L,31L,16L,17L,30L,19L,28L,29L,18L,23L,24L,25L,22L,27L,20L,21L,26L,63L,32L,33L,62L,35L,60L,61L,34L,39L,56L,57L,38L,59L,36L,37L,58L,47L,48L,49L,46L,51L,44L,45L,50L,55L,40L,41L,54L,43L,52L,53L,42L,127L,64L,65L,126L,67L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153154Inst : IEnumerable<long>
{
public static readonly long[] Value=A153154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153154.Bytes);
public long this[int i]=>Value[i];

public static A153154Inst Instance=new A153154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153155
{
public static readonly long[] Value={ 0L,0L,1L,-1L,1L,-1L,2L,-2L,3L,-4L,4L,-5L,7L,-7L,9L,-11L,12L,-15L,18L,-20L,24L,-28L,32L,-37L,43L,-48L,56L,-65L,72L,-83L,95L,-106L,122L,-138L,154L,-174L,197L,-220L,247L,-278L,309L,-346L,388L,-430L,480L,-535L,592L,-659L,732L,-808L,896L,-992L,1094L,-1209L,1335L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153155Inst : IEnumerable<long>
{
public static readonly long[] Value=A153155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153155.Bytes);
public long this[int i]=>Value[i];

public static A153155Inst Instance=new A153155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153156
{
public static readonly long[] Value={ 1L,-1L,2L,-2L,3L,-4L,5L,-6L,8L,-9L,11L,-14L,17L,-20L,24L,-28L,33L,-39L,46L,-53L,62L,-72L,83L,-96L,110L,-126L,145L,-165L,188L,-214L,243L,-275L,312L,-352L,396L,-447L,502L,-563L,632L,-707L,791L,-884L,986L,-1098L,1223L,-1359L,1509L,-1676L,1857L,-2056L,2276L,-2515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153156Inst : IEnumerable<long>
{
public static readonly long[] Value=A153156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153156.Bytes);
public long this[int i]=>Value[i];

public static A153156Inst Instance=new A153156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153157
{
public static readonly long[] Value={ 16L,81L,625L,1296L,2401L,10000L,14641L,20736L,28561L,38416L,50625L,83521L,104976L,130321L,160000L,194481L,234256L,279841L,331776L,456976L,614656L,707281L,810000L,923521L,1185921L,1336336L,1500625L,1874161L,2085136L,2313441L,2560000L,2825761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153157Inst : IEnumerable<long>
{
public static readonly long[] Value=A153157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153157.Bytes);
public long this[int i]=>Value[i];

public static A153157Inst Instance=new A153157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153158
{
public static readonly long[] Value={ 4L,9L,25L,36L,49L,100L,121L,144L,169L,196L,225L,289L,324L,361L,400L,441L,484L,529L,576L,676L,784L,841L,900L,961L,1089L,1156L,1225L,1369L,1444L,1521L,1600L,1681L,1764L,1849L,1936L,2025L,2116L,2209L,2304L,2500L,2601L,2704L,2809L,2916L,3025L,3136L,3249L,3364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153158Inst : IEnumerable<long>
{
public static readonly long[] Value=A153158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153158.Bytes);
public long this[int i]=>Value[i];

public static A153158Inst Instance=new A153158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153159
{
public static readonly long[] Value={ 32L,243L,3125L,7776L,16807L,100000L,161051L,248832L,371293L,537824L,759375L,1419857L,1889568L,2476099L,3200000L,4084101L,5153632L,6436343L,7962624L,11881376L,17210368L,20511149L,24300000L,28629151L,39135393L,45435424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153159Inst : IEnumerable<long>
{
public static readonly long[] Value=A153159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153159.Bytes);
public long this[int i]=>Value[i];

public static A153159Inst Instance=new A153159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153160
{
public static readonly long[] Value={ 64L,729L,15625L,46656L,117649L,1000000L,1771561L,2985984L,4826809L,7529536L,11390625L,24137569L,34012224L,47045881L,64000000L,85766121L,113379904L,148035889L,191102976L,308915776L,481890304L,594823321L,729000000L,887503681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153160Inst : IEnumerable<long>
{
public static readonly long[] Value=A153160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153160.Bytes);
public long this[int i]=>Value[i];

public static A153160Inst Instance=new A153160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153161
{
public static readonly long[] Value={ 1L,2L,3L,3L,3L,4L,5L,4L,5L,5L,4L,5L,7L,8L,7L,5L,7L,8L,7L,7L,8L,7L,5L,6L,9L,11L,10L,11L,13L,12L,9L,6L,9L,11L,10L,11L,13L,12L,9L,9L,12L,13L,11L,10L,11L,9L,6L,7L,11L,14L,13L,15L,18L,17L,13L,14L,19L,21L,18L,17L,19L,16L,11L,7L,11L,14L,13L,15L,18L,17L,13L,14L,19L,21L,18L,17L,19L,16L,11L,11L,16L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153161Inst : IEnumerable<long>
{
public static readonly long[] Value=A153161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153161.Bytes);
public long this[int i]=>Value[i];

public static A153161Inst Instance=new A153161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153162
{
public static readonly long[] Value={ 2L,5L,5L,8L,7L,7L,8L,11L,13L,12L,9L,9L,12L,13L,11L,14L,19L,21L,18L,17L,19L,16L,11L,11L,16L,19L,17L,18L,21L,19L,14L,17L,25L,30L,27L,29L,34L,31L,23L,22L,29L,31L,26L,23L,25L,20L,13L,13L,20L,25L,23L,26L,31L,29L,22L,23L,31L,34L,29L,27L,30L,25L,17L,20L,31L,39L,36L,41L,49L,46L,35L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153162Inst : IEnumerable<long>
{
public static readonly long[] Value=A153162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153162.Bytes);
public long this[int i]=>Value[i];

public static A153162Inst Instance=new A153162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153163
{
public static readonly long[] Value={ 4L,4L,2L,1L,2L,9L,4L,5L,8L,9L,1L,5L,0L,0L,7L,4L,9L,2L,2L,9L,9L,5L,9L,2L,1L,0L,8L,1L,9L,0L,8L,6L,7L,0L,2L,9L,6L,9L,3L,4L,7L,8L,2L,0L,7L,3L,5L,3L,1L,1L,3L,3L,0L,8L,0L,5L,6L,1L,1L,8L,4L,6L,9L,3L,2L,9L,1L,1L,5L,6L,4L,5L,5L,2L,0L,4L,4L,4L,8L,5L,8L,6L,7L,6L,6L,3L,5L,0L,0L,1L,1L,3L,3L,6L,9L,6L,5L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153163Inst : IEnumerable<long>
{
public static readonly long[] Value=A153163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153163.Bytes);
public long this[int i]=>Value[i];

public static A153163Inst Instance=new A153163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153164
{
public static readonly long[] Value={ 337L,409L,701L,827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153164Inst : IEnumerable<long>
{
public static readonly long[] Value=A153164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153164.Bytes);
public long this[int i]=>Value[i];

public static A153164Inst Instance=new A153164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153165
{
public static readonly long[] Value={ 223L,32233L,32323L,33223L,232333L,233323L,323233L,2332333L,2333323L,3222223L,3223333L,3233323L,3332233L,22223323L,22232233L,22232323L,23222233L,23223223L,23322223L,32322223L,33222223L,223323223L,223333333L,232232233L,232233223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153165Inst : IEnumerable<long>
{
public static readonly long[] Value=A153165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153165.Bytes);
public long this[int i]=>Value[i];

public static A153165Inst Instance=new A153165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153166
{
public static readonly long[] Value={ 37L,5372L,5387L,5537L,38722L,38887L,53872L,388722L,388887L,537037L,537222L,538887L,555372L,3703887L,3705372L,3705387L,3870372L,3870537L,3887037L,5387037L,5537037L,37220537L,37222222L,38705372L,38705537L,38870372L,38870537L,53703887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153166Inst : IEnumerable<long>
{
public static readonly long[] Value=A153166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153166.Bytes);
public long this[int i]=>Value[i];

public static A153166Inst Instance=new A153166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153167
{
public static readonly long[] Value={ 2L,4L,6L,7L,8L,10L,12L,13L,14L,16L,18L,19L,20L,22L,23L,24L,25L,26L,28L,30L,31L,32L,33L,34L,36L,37L,38L,40L,41L,42L,43L,44L,46L,47L,48L,49L,50L,52L,53L,54L,55L,56L,58L,59L,60L,61L,62L,63L,64L,66L,67L,68L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,82L,83L,84L,85L,86L,88L,89L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153167Inst : IEnumerable<long>
{
public static readonly long[] Value=A153167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153167.Bytes);
public long this[int i]=>Value[i];

public static A153167Inst Instance=new A153167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153168
{
public static readonly long[] Value={ 37L,5387L,537037L,37220537L,38870537L,3703870537L,5555555387L,55538720387L,370553872037L,370555370387L,372203887037L,387037038887L,387203705387L,388887053887L,537203703887L,538705553887L,538722205537L,538870538887L,553703722037L,553720538887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153168Inst : IEnumerable<long>
{
public static readonly long[] Value=A153168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153168.Bytes);
public long this[int i]=>Value[i];

public static A153168Inst Instance=new A153168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153169
{
public static readonly long[] Value={ 19L,43L,75L,115L,163L,219L,283L,355L,435L,523L,619L,723L,835L,955L,1083L,1219L,1363L,1515L,1675L,1843L,2019L,2203L,2395L,2595L,2803L,3019L,3243L,3475L,3715L,3963L,4219L,4483L,4755L,5035L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153169Inst : IEnumerable<long>
{
public static readonly long[] Value=A153169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153169.Bytes);
public long this[int i]=>Value[i];

public static A153169Inst Instance=new A153169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153170
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,11L,12L,14L,16L,18L,20L,21L,22L,24L,25L,26L,28L,30L,31L,32L,34L,36L,38L,39L,40L,41L,42L,44L,46L,47L,48L,50L,51L,52L,53L,54L,56L,58L,60L,61L,62L,64L,66L,67L,68L,69L,70L,71L,72L,73L,74L,76L,78L,80L,81L,82L,84L,86L,88L,90L,91L,92L,94L,95L,96L,98L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153170Inst : IEnumerable<long>
{
public static readonly long[] Value=A153170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153170.Bytes);
public long this[int i]=>Value[i];

public static A153170Inst Instance=new A153170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153171
{
public static readonly long[] Value={ 6L,6L,-6L,24L,12L,-24L,54L,18L,-54L,96L,24L,-96L,150L,30L,-150L,216L,36L,-216L,294L,42L,-294L,384L,48L,-384L,486L,54L,-486L,600L,60L,-600L,726L,66L,-726L,864L,72L,-864L,1014L,78L,-1014L,1176L,84L,-1176L,1350L,90L,-1350L,1536L,96L,-1536L,1734L,102L,-1734L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153171Inst : IEnumerable<long>
{
public static readonly long[] Value=A153171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153171.Bytes);
public long this[int i]=>Value[i];

public static A153171Inst Instance=new A153171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153172
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,0L,-1L,1L,0L,1L,2L,-1L,0L,-1L,-1L,1L,0L,2L,1L,0L,1L,-2L,-2L,1L,0L,2L,3L,-2L,0L,-2L,-2L,2L,-1L,3L,3L,-1L,1L,-2L,-4L,2L,0L,2L,4L,-3L,1L,-4L,-4L,3L,-1L,5L,5L,-2L,2L,-4L,-6L,3L,-2L,5L,7L,-4L,0L,-6L,-6L,4L,-1L,7L,7L,-4L,3L,-7L,-9L,5L,-1L,7L,10L,-6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153172Inst : IEnumerable<long>
{
public static readonly long[] Value=A153172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153172.Bytes);
public long this[int i]=>Value[i];

public static A153172Inst Instance=new A153172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153173
{
public static readonly long[] Value={ 11L,41L,341L,2161L,15251L,103361L,711491L,4868641L,33391061L,228811001L,1568437211L,10749853441L,73681573691L,505018447961L,3461454668501L,23725145626561L,162614613425891L,1114577020834241L,7639424866266611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153173Inst : IEnumerable<long>
{
public static readonly long[] Value=A153173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153173.Bytes);
public long this[int i]=>Value[i];

public static A153173Inst Instance=new A153173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153174
{
public static readonly long[] Value={ 0L,1L,0L,-1L,1L,2L,-1L,-2L,1L,3L,-1L,-4L,2L,5L,-2L,-6L,3L,8L,-4L,-9L,4L,11L,-5L,-14L,7L,17L,-7L,-20L,9L,24L,-11L,-28L,12L,33L,-15L,-39L,18L,46L,-20L,-53L,24L,62L,-28L,-72L,32L,83L,-37L,-96L,43L,110L,-48L,-126L,56L,145L,-65L,-165L,72L,188L,-83L,-214L,95L,243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153174Inst : IEnumerable<long>
{
public static readonly long[] Value=A153174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153174.Bytes);
public long this[int i]=>Value[i];

public static A153174Inst Instance=new A153174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153175
{
public static readonly BigInteger[] Value={ 29L,281L,6119L,101521L,1875749L,33281921L,599786069L,10745088481L,192933544679L,3461223997001L,62114818827629L,1114566304366081L,20000347407134669L,358889844987430121L,6440029487834912999L,BigInteger.Parse("115561554399692896321") };
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
public class A153175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153175Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153175.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153175Inst Instance=new A153175Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153176
{
public static readonly long[] Value={ 1L,2L,4L,4L,6L,8L,8L,12L,16L,18L,24L,28L,32L,40L,48L,56L,66L,80L,92L,108L,128L,144L,168L,196L,224L,258L,296L,336L,384L,440L,496L,564L,640L,720L,816L,920L,1030L,1160L,1304L,1456L,1632L,1824L,2032L,2268L,2528L,2808L,3120L,3468L,3840L,4258L,4716L,5208L,5760L,6360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153176Inst : IEnumerable<long>
{
public static readonly long[] Value=A153176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153176.Bytes);
public long this[int i]=>Value[i];

public static A153176Inst Instance=new A153176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153177
{
public static readonly BigInteger[] Value={ 76L,1926L,109801L,4769326L,230701876L,10716675201L,505618944676L,23714405408926L,1114769987764201L,52357935173823126L,2459933168462154076L,BigInteger.Parse("115560463558534156801"),BigInteger.Parse("5428954301161174383676"),BigInteger.Parse("255043991670277234750326") };
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
public class A153177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153177Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153177.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153177Inst Instance=new A153177Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153178
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,3L,3L,4L,5L,6L,8L,9L,11L,14L,16L,19L,23L,27L,31L,37L,43L,49L,58L,66L,76L,89L,101L,115L,132L,150L,170L,194L,219L,247L,280L,315L,354L,399L,447L,500L,562L,627L,699L,781L,869L,967L,1076L,1194L,1323L,1468L,1625L,1796L,1987L,2193L,2418L,2668L,2937L,3231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153178Inst : IEnumerable<long>
{
public static readonly long[] Value=A153178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153178.Bytes);
public long this[int i]=>Value[i];

public static A153178Inst Instance=new A153178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153179
{
public static readonly BigInteger[] Value={ 199L,13201L,1970299L,224056801L,28374454999L,3450736132801L,426236170575799L,52337681992411201L,6441140796368008699L,BigInteger.Parse("792018481913198430001"),BigInteger.Parse("97420733208491869044199"),BigInteger.Parse("11981539981561372141075201") };
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
public class A153179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153179Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153179.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153179Inst Instance=new A153179Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153180
{
public static readonly BigInteger[] Value={ 521L,90481L,35355581L,10525900321L,3489827263001L,1111126318086721L,359316586176453881L,BigInteger.Parse("115509240442846111681"),BigInteger.Parse("37216910406644366498621"),BigInteger.Parse("11980863523543017476802001"),BigInteger.Parse("3858153294795970321295258921") };
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
public class A153180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153180Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153180.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153180Inst Instance=new A153180Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153181
{
public static readonly long[] Value={ 1L,2L,-4L,8L,-10L,8L,-8L,16L,-20L,10L,-8L,24L,-24L,8L,-16L,32L,-26L,16L,-12L,24L,-40L,16L,-8L,48L,-40L,10L,-24L,32L,-32L,24L,-16L,48L,-52L,16L,-16L,48L,-50L,8L,-24L,64L,-40L,32L,-16L,24L,-72L,24L,-16L,80L,-56L,18L,-28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153181Inst : IEnumerable<long>
{
public static readonly long[] Value=A153181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153181.Bytes);
public long this[int i]=>Value[i];

public static A153181Inst Instance=new A153181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153182
{
public static readonly long[] Value={ 1L,2L,4L,0L,-2L,8L,8L,-8L,-4L,10L,8L,0L,-8L,8L,16L,-16L,-10L,16L,12L,0L,-8L,16L,8L,-24L,-8L,10L,24L,0L,-16L,24L,16L,-24L,-20L,16L,16L,0L,-10L,8L,24L,-32L,-8L,32L,16L,0L,-24L,24L,16L,-40L,-24L,18L,28L,0L,-8L,24L,32L,-32L,-16L,16L,8L,0L,-32L,24L,32L,-40L,-26L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153182Inst : IEnumerable<long>
{
public static readonly long[] Value=A153182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153182.Bytes);
public long this[int i]=>Value[i];

public static A153182Inst Instance=new A153182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153183
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,15L,21L,23L,25L,27L,33L,35L,37L,43L,47L,51L,53L,55L,61L,65L,67L,71L,75L,77L,81L,91L,93L,95L,103L,105L,111L,113L,117L,123L,125L,127L,133L,137L,141L,145L,147L,153L,155L,163L,167L,175L,181L,183L,191L,193L,201L,203L,205L,207L,211L,215L,221L,225L,231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153183Inst : IEnumerable<long>
{
public static readonly long[] Value=A153183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153183.Bytes);
public long this[int i]=>Value[i];

public static A153183Inst Instance=new A153183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153184
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,9L,10L,12L,14L,16L,17L,18L,19L,20L,22L,24L,26L,28L,29L,30L,31L,32L,34L,36L,38L,39L,40L,41L,42L,44L,45L,46L,48L,49L,50L,52L,54L,56L,57L,58L,59L,60L,62L,63L,64L,66L,68L,69L,70L,72L,73L,74L,76L,78L,79L,80L,82L,83L,84L,85L,86L,87L,88L,89L,90L,92L,94L,96L,97L,98L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153184Inst : IEnumerable<long>
{
public static readonly long[] Value=A153184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153184.Bytes);
public long this[int i]=>Value[i];

public static A153184Inst Instance=new A153184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153185
{
public static readonly long[] Value={ 9L,18L,45L,90L,171L,180L,207L,279L,297L,396L,414L,450L,459L,486L,567L,576L,693L,702L,729L,738L,747L,900L,918L,954L,981L,1062L,1134L,1161L,1197L,1206L,1215L,1233L,1323L,1332L,1341L,1431L,1449L,1467L,1485L,1494L,1503L,1656L,1710L,1737L,1755L,1800L,1908L,2007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153185Inst : IEnumerable<long>
{
public static readonly long[] Value=A153185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153185.Bytes);
public long this[int i]=>Value[i];

public static A153185Inst Instance=new A153185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153186
{
public static readonly long[] Value={ 1L,7L,4L,7L,4L,7L,1L,1L,1L,1L,7L,4L,7L,4L,7L,1L,1L,1L,1L,7L,4L,7L,4L,7L,1L,1L,1L,1L,7L,4L,7L,4L,7L,1L,1L,1L,1L,7L,4L,7L,4L,7L,1L,1L,1L,1L,7L,4L,7L,4L,7L,1L,1L,1L,1L,7L,4L,7L,4L,7L,1L,1L,1L,1L,7L,4L,7L,4L,7L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153186Inst : IEnumerable<long>
{
public static readonly long[] Value=A153186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153186.Bytes);
public long this[int i]=>Value[i];

public static A153186Inst Instance=new A153186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153187
{
public static readonly long[] Value={ 0L,1L,3L,2L,10L,80L,3L,21L,231L,3465L,4L,36L,504L,9576L,229824L,5L,55L,935L,21505L,623645L,21827575L,6L,78L,1560L,42120L,1432080L,58715280L,2818333440L,7L,105L,2415L,74865L,2919735L,137227545L,7547514975L,475493443425L,8L,136L,3536L,123760L,5445440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153187Inst : IEnumerable<long>
{
public static readonly long[] Value=A153187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153187.Bytes);
public long this[int i]=>Value[i];

public static A153187Inst Instance=new A153187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153188
{
public static readonly long[] Value={ 1L,2L,8L,3L,18L,162L,4L,32L,384L,6144L,5L,50L,750L,15000L,375000L,6L,72L,1296L,31104L,933120L,33592320L,7L,98L,2058L,57624L,2016840L,84707280L,4150656720L,8L,128L,3072L,98304L,3932160L,188743680L,10569646080L,676457349120L,9L,162L,4374L,157464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153188Inst : IEnumerable<long>
{
public static readonly long[] Value=A153188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153188.Bytes);
public long this[int i]=>Value[i];

public static A153188Inst Instance=new A153188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153189
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,15L,1L,4L,28L,280L,1L,5L,45L,585L,9945L,1L,6L,66L,1056L,22176L,576576L,1L,7L,91L,1729L,43225L,1339975L,49579075L,1L,8L,120L,2640L,76560L,2756160L,118514880L,5925744000L,1L,9L,153L,3825L,126225L,5175225L,253586025L,14454403425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153189Inst : IEnumerable<long>
{
public static readonly long[] Value=A153189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153189.Bytes);
public long this[int i]=>Value[i];

public static A153189Inst Instance=new A153189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153190
{
public static readonly long[] Value={ 1L,2L,6L,2L,8L,48L,2L,10L,80L,880L,2L,12L,120L,1680L,30240L,2L,14L,168L,2856L,62832L,1696464L,2L,16L,224L,4480L,116480L,3727360L,141639680L,2L,18L,288L,6624L,198720L,7352640L,323516160L,16499324160L,2L,20L,360L,9360L,318240L,13366080L,668304000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153190Inst : IEnumerable<long>
{
public static readonly long[] Value=A153190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153190.Bytes);
public long this[int i]=>Value[i];

public static A153190Inst Instance=new A153190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153191
{
public static readonly long[] Value={ 0L,1L,9L,87L,837L,8055L,77517L,745983L,7178949L,69086439L,664851645L,6398183439L,61572760821L,592543948023L,5702332097133L,54876252562335L,528100265643813L,5082159906168327L,48908040749377821L,470665326181410351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153191Inst : IEnumerable<long>
{
public static readonly long[] Value=A153191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153191.Bytes);
public long this[int i]=>Value[i];

public static A153191Inst Instance=new A153191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153192
{
public static readonly long[] Value={ 5L,7L,18L,22L,39L,45L,68L,76L,105L,115L,150L,162L,203L,217L,264L,280L,333L,351L,410L,430L,495L,517L,588L,612L,689L,715L,798L,826L,915L,945L,1040L,1072L,1173L,1207L,1314L,1350L,1463L,1501L,1620L,1660L,1785L,1827L,1958L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153192Inst : IEnumerable<long>
{
public static readonly long[] Value=A153192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153192.Bytes);
public long this[int i]=>Value[i];

public static A153192Inst Instance=new A153192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153193
{
public static readonly long[] Value={ 4L,13L,22L,22L,40L,40L,31L,52L,67L,40L,67L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153193Inst : IEnumerable<long>
{
public static readonly long[] Value=A153193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153193.Bytes);
public long this[int i]=>Value[i];

public static A153193Inst Instance=new A153193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153194
{
public static readonly long[] Value={ 10L,11L,13L,14L,38L,40L,44L,46L,84L,87L,93L,96L,148L,152L,160L,164L,230L,235L,245L,250L,330L,336L,348L,354L,448L,455L,469L,476L,584L,592L,608L,616L,738L,747L,765L,774L,910L,920L,940L,950L,1100L,1111L,1133L,1144L,1308L,1320L,1344L,1356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153194Inst : IEnumerable<long>
{
public static readonly long[] Value=A153194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153194.Bytes);
public long this[int i]=>Value[i];

public static A153194Inst Instance=new A153194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153195
{
public static readonly long[] Value={ 0L,0L,2L,4L,8L,11L,16L,23L,30L,38L,47L,61L,72L,87L,102L,123L,141L,163L,189L,217L,242L,274L,306L,342L,378L,422L,462L,510L,560L,610L,663L,721L,782L,844L,914L,985L,1055L,1133L,1218L,1300L,1383L,1473L,1574L,1669L,1772L,1883L,1988L,2109L,2223L,2344L,2477L,2608L,2743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153195Inst : IEnumerable<long>
{
public static readonly long[] Value=A153195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153195.Bytes);
public long this[int i]=>Value[i];

public static A153195Inst Instance=new A153195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153196
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,9L,11L,16L,17L,22L,24L,29L,31L,32L,37L,39L,44L,46L,51L,57L,69L,71L,76L,86L,94L,99L,102L,106L,109L,134L,136L,137L,142L,146L,169L,171L,174L,176L,181L,191L,204L,212L,214L,216L,219L,237L,241L,246L,247L,267L,269L,277L,282L,286L,297L,311L,312L,321L,324L,332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153196Inst : IEnumerable<long>
{
public static readonly long[] Value=A153196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153196.Bytes);
public long this[int i]=>Value[i];

public static A153196Inst Instance=new A153196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153197
{
public static readonly long[] Value={ 1L,2L,5L,15L,51L,189L,748L,3128L,13731L,62969L,300552L,1488704L,7634723L,40464741L,221311617L,1247444859L,7238458309L,43196661875L,264878725516L,1667564565616L,10770316016557L,71314258947903L,483765644021787L,3359905164274725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153197Inst : IEnumerable<long>
{
public static readonly long[] Value=A153197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153197.Bytes);
public long this[int i]=>Value[i];

public static A153197Inst Instance=new A153197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153198
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,2L,0L,0L,0L,5L,0L,0L,0L,0L,14L,0L,0L,0L,0L,0L,43L,0L,0L,0L,0L,0L,0L,143L,0L,0L,0L,0L,0L,0L,0L,509L,0L,0L,0L,0L,0L,0L,0L,0L,1922L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153198Inst : IEnumerable<long>
{
public static readonly long[] Value=A153198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153198.Bytes);
public long this[int i]=>Value[i];

public static A153198Inst Instance=new A153198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153199
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,3L,6L,5L,1L,4L,12L,20L,14L,1L,5L,20L,50L,70L,43L,1L,6L,30L,100L,210L,258L,143L,1L,7L,42L,175L,490L,903L,1001L,509L,1L,8L,56L,280L,980L,2408L,4004L,4072L,1922L,1L,9L,72L,420L,1764L,5418L,12012L,18324L,17298L,7651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153199Inst : IEnumerable<long>
{
public static readonly long[] Value=A153199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153199.Bytes);
public long this[int i]=>Value[i];

public static A153199Inst Instance=new A153199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153200
{
public static readonly long[] Value={ 4L,3L,6L,2L,0L,8L,5L,8L,3L,9L,7L,1L,0L,6L,3L,1L,1L,8L,4L,5L,8L,6L,7L,5L,6L,1L,2L,8L,8L,6L,7L,7L,6L,7L,7L,7L,2L,5L,5L,3L,2L,0L,8L,5L,0L,9L,9L,8L,9L,9L,9L,5L,3L,5L,2L,2L,9L,4L,7L,6L,3L,1L,2L,9L,2L,8L,3L,6L,8L,4L,7L,6L,3L,0L,0L,1L,9L,8L,4L,7L,0L,1L,9L,5L,9L,8L,3L,5L,4L,2L,8L,3L,7L,6L,4L,4L,4L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153200Inst : IEnumerable<long>
{
public static readonly long[] Value=A153200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153200.Bytes);
public long this[int i]=>Value[i];

public static A153200Inst Instance=new A153200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153201
{
public static readonly long[] Value={ 1L,1L,6L,0L,9L,6L,4L,0L,4L,7L,4L,4L,3L,6L,8L,1L,1L,7L,3L,9L,3L,5L,1L,5L,9L,7L,1L,4L,7L,4L,4L,6L,9L,5L,0L,8L,7L,9L,3L,2L,4L,1L,5L,6L,9L,6L,5L,1L,2L,2L,9L,0L,3L,0L,6L,0L,2L,7L,3L,7L,8L,1L,9L,7L,9L,0L,7L,9L,6L,7L,3L,8L,8L,3L,0L,4L,3L,1L,2L,6L,0L,7L,9L,2L,5L,0L,6L,9L,8L,7L,1L,6L,7L,9L,6L,8L,5L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153201Inst : IEnumerable<long>
{
public static readonly long[] Value=A153201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153201.Bytes);
public long this[int i]=>Value[i];

public static A153201Inst Instance=new A153201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153202
{
public static readonly long[] Value={ 8L,9L,8L,2L,4L,4L,4L,0L,1L,7L,0L,3L,9L,2L,7L,1L,7L,3L,0L,7L,3L,2L,3L,2L,9L,5L,8L,0L,8L,6L,4L,6L,8L,6L,7L,2L,2L,5L,0L,5L,9L,1L,3L,5L,3L,8L,2L,4L,6L,4L,7L,7L,9L,9L,4L,8L,0L,6L,9L,8L,9L,8L,9L,2L,4L,3L,3L,5L,1L,1L,7L,5L,0L,7L,6L,1L,3L,9L,6L,3L,0L,3L,1L,4L,6L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153202Inst : IEnumerable<long>
{
public static readonly long[] Value=A153202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153202.Bytes);
public long this[int i]=>Value[i];

public static A153202Inst Instance=new A153202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153203
{
public static readonly long[] Value={ 8L,2L,7L,0L,8L,7L,4L,7L,5L,3L,4L,6L,9L,1L,6L,1L,5L,0L,3L,0L,3L,7L,5L,1L,4L,8L,3L,6L,4L,5L,5L,6L,8L,6L,1L,8L,8L,6L,7L,6L,8L,7L,3L,6L,0L,1L,6L,9L,5L,8L,1L,0L,2L,3L,3L,1L,6L,7L,6L,4L,4L,5L,2L,6L,6L,5L,0L,4L,4L,2L,9L,6L,1L,8L,9L,2L,0L,0L,7L,5L,7L,3L,0L,9L,6L,2L,4L,0L,9L,6L,2L,5L,2L,5L,0L,8L,4L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153203Inst : IEnumerable<long>
{
public static readonly long[] Value=A153203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153203.Bytes);
public long this[int i]=>Value[i];

public static A153203Inst Instance=new A153203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153204
{
public static readonly long[] Value={ 7L,7L,3L,9L,7L,6L,0L,3L,1L,6L,2L,9L,1L,2L,0L,7L,8L,2L,6L,2L,3L,4L,3L,9L,8L,0L,9L,8L,2L,9L,7L,9L,6L,7L,2L,5L,2L,8L,8L,2L,7L,7L,1L,3L,1L,0L,0L,8L,1L,9L,3L,5L,3L,7L,3L,5L,1L,5L,8L,5L,4L,6L,5L,2L,7L,1L,9L,7L,8L,2L,5L,8L,8L,6L,9L,5L,4L,1L,7L,3L,8L,6L,1L,6L,7L,1L,3L,2L,4L,7L,7L,8L,6L,4L,5L,6L,7L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153204Inst : IEnumerable<long>
{
public static readonly long[] Value=A153204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153204.Bytes);
public long this[int i]=>Value[i];

public static A153204Inst Instance=new A153204Inst();

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