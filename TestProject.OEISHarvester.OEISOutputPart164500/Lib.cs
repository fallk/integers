using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A194957
{
public static readonly BigInteger[] Value={ 1L,1L,3L,24L,265L,3880L,71099L,1568896L,40538065L,1201214592L,40167734579L,1496537977088L,61482321148249L,2761475028475904L,134626530031186283L,7080317004476928000L,BigInteger.Parse("399585298475488156321"),BigInteger.Parse("24087998749960900673536"),BigInteger.Parse("1544790381323645227703651") };
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
public class A194957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194957Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194957.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194957Inst Instance=new A194957Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194958
{
public static readonly BigInteger[] Value={ 1L,1L,5L,36L,409L,6280L,121501L,2839424L,77834737L,2449360512L,87040440181L,3447798906112L,150645874207753L,7197909122453504L,373365727806824845L,BigInteger.Parse("20895734364795187200"),BigInteger.Parse("1255062315134651501281"),BigInteger.Parse("80528111291313595580416"),BigInteger.Parse("5497183726333878664852453") };
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
public class A194958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194958Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194958.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194958Inst Instance=new A194958Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194959
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,1L,3L,4L,2L,1L,3L,5L,4L,2L,1L,3L,5L,6L,4L,2L,1L,3L,5L,7L,6L,4L,2L,1L,3L,5L,7L,8L,6L,4L,2L,1L,3L,5L,7L,9L,8L,6L,4L,2L,1L,3L,5L,7L,9L,10L,8L,6L,4L,2L,1L,3L,5L,7L,9L,11L,10L,8L,6L,4L,2L,1L,3L,5L,7L,9L,11L,12L,10L,8L,6L,4L,2L,1L,3L,5L,7L,9L,11L,13L,12L,10L,8L,6L,4L,2L,1L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194959Inst : IEnumerable<long>
{
public static readonly long[] Value=A194959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194959.Bytes);
public long this[int i]=>Value[i];

public static A194959Inst Instance=new A194959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194960
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,4L,3L,4L,5L,4L,5L,6L,5L,6L,7L,6L,7L,8L,7L,8L,9L,8L,9L,10L,9L,10L,11L,10L,11L,12L,11L,12L,13L,12L,13L,14L,13L,14L,15L,14L,15L,16L,15L,16L,17L,16L,17L,18L,17L,18L,19L,18L,19L,20L,19L,20L,21L,20L,21L,22L,21L,22L,23L,22L,23L,24L,23L,24L,25L,24L,25L,26L,25L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194960Inst : IEnumerable<long>
{
public static readonly long[] Value=A194960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194960.Bytes);
public long this[int i]=>Value[i];

public static A194960Inst Instance=new A194960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194961
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,4L,2L,3L,1L,4L,5L,2L,3L,1L,4L,5L,6L,2L,3L,1L,4L,7L,5L,6L,2L,3L,1L,4L,7L,8L,5L,6L,2L,3L,1L,4L,7L,8L,9L,5L,6L,2L,3L,1L,4L,7L,10L,8L,9L,5L,6L,2L,3L,1L,4L,7L,10L,11L,8L,9L,5L,6L,2L,3L,1L,4L,7L,10L,11L,12L,8L,9L,5L,6L,2L,3L,1L,4L,7L,10L,13L,11L,12L,8L,9L,5L,6L,2L,3L,1L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194961Inst : IEnumerable<long>
{
public static readonly long[] Value=A194961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194961.Bytes);
public long this[int i]=>Value[i];

public static A194961Inst Instance=new A194961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194962
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,9L,10L,8L,11L,14L,15L,12L,13L,16L,20L,21L,17L,18L,19L,22L,27L,28L,23L,25L,26L,24L,29L,35L,36L,30L,33L,34L,31L,32L,37L,44L,45L,38L,42L,43L,39L,40L,41L,46L,54L,55L,47L,52L,53L,48L,50L,51L,49L,56L,65L,66L,57L,63L,64L,58L,61L,62L,59L,60L,67L,77L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194962Inst : IEnumerable<long>
{
public static readonly long[] Value=A194962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194962.Bytes);
public long this[int i]=>Value[i];

public static A194962Inst Instance=new A194962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194963
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,10L,8L,9L,11L,14L,15L,12L,13L,16L,19L,20L,21L,17L,18L,22L,25L,28L,26L,27L,23L,24L,29L,32L,35L,36L,33L,34L,30L,31L,37L,40L,43L,44L,45L,41L,42L,38L,39L,46L,49L,52L,55L,53L,54L,50L,51L,47L,48L,56L,59L,62L,65L,66L,63L,64L,60L,61L,57L,58L,67L,70L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194963Inst : IEnumerable<long>
{
public static readonly long[] Value=A194963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194963.Bytes);
public long this[int i]=>Value[i];

public static A194963Inst Instance=new A194963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194964
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,5L,6L,6L,7L,7L,8L,8L,9L,9L,9L,10L,10L,11L,11L,12L,12L,13L,13L,13L,14L,14L,15L,15L,16L,16L,17L,17L,17L,18L,18L,19L,19L,20L,20L,21L,21L,22L,22L,22L,23L,23L,24L,24L,25L,25L,26L,26L,26L,27L,27L,28L,28L,29L,29L,30L,30L,30L,31L,31L,32L,32L,33L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194964Inst : IEnumerable<long>
{
public static readonly long[] Value=A194964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194964.Bytes);
public long this[int i]=>Value[i];

public static A194964Inst Instance=new A194964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194965
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,1L,2L,3L,4L,5L,1L,6L,2L,3L,4L,5L,1L,6L,7L,2L,3L,4L,5L,1L,6L,7L,8L,2L,3L,4L,5L,1L,6L,7L,8L,9L,2L,3L,4L,5L,1L,6L,7L,8L,9L,10L,2L,3L,4L,5L,1L,6L,11L,7L,8L,9L,10L,2L,3L,4L,5L,1L,6L,11L,12L,7L,8L,9L,10L,2L,3L,4L,5L,1L,6L,11L,12L,13L,7L,8L,9L,10L,2L,3L,4L,5L,1L,6L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194965Inst : IEnumerable<long>
{
public static readonly long[] Value=A194965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194965.Bytes);
public long this[int i]=>Value[i];

public static A194965Inst Instance=new A194965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194966
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,18L,19L,20L,21L,17L,22L,25L,26L,27L,28L,23L,24L,29L,33L,34L,35L,36L,30L,31L,32L,37L,42L,43L,44L,45L,38L,39L,40L,41L,46L,52L,53L,54L,55L,47L,48L,49L,50L,51L,56L,63L,64L,65L,66L,57L,59L,60L,61L,62L,58L,67L,75L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194966Inst : IEnumerable<long>
{
public static readonly long[] Value=A194966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194966.Bytes);
public long this[int i]=>Value[i];

public static A194966Inst Instance=new A194966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194967
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,21L,17L,18L,19L,20L,22L,27L,28L,23L,24L,25L,26L,29L,34L,35L,36L,30L,31L,32L,33L,37L,42L,43L,44L,45L,38L,39L,40L,41L,46L,51L,52L,53L,54L,55L,47L,48L,49L,50L,56L,61L,66L,62L,63L,64L,65L,57L,58L,59L,60L,67L,72L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194967Inst : IEnumerable<long>
{
public static readonly long[] Value=A194967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194967.Bytes);
public long this[int i]=>Value[i];

public static A194967Inst Instance=new A194967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194968
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,1L,3L,4L,2L,1L,3L,4L,5L,2L,1L,3L,4L,6L,5L,2L,1L,3L,4L,6L,7L,5L,2L,1L,3L,4L,6L,8L,7L,5L,2L,1L,3L,4L,6L,8L,9L,7L,5L,2L,1L,3L,4L,6L,8L,9L,10L,7L,5L,2L,1L,3L,4L,6L,8L,9L,11L,10L,7L,5L,2L,1L,3L,4L,6L,8L,9L,11L,12L,10L,7L,5L,2L,1L,3L,4L,6L,8L,9L,11L,12L,13L,10L,7L,5L,2L,1L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194968Inst : IEnumerable<long>
{
public static readonly long[] Value=A194968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194968.Bytes);
public long this[int i]=>Value[i];

public static A194968Inst Instance=new A194968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194969
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,5L,7L,10L,8L,9L,11L,15L,12L,13L,14L,16L,21L,17L,18L,20L,19L,22L,28L,23L,24L,27L,25L,26L,29L,36L,30L,31L,35L,32L,34L,33L,37L,45L,38L,39L,44L,40L,43L,41L,42L,46L,55L,47L,48L,54L,49L,53L,50L,51L,52L,56L,66L,57L,58L,65L,59L,64L,60L,61L,63L,62L,67L,78L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194969Inst : IEnumerable<long>
{
public static readonly long[] Value=A194969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194969.Bytes);
public long this[int i]=>Value[i];

public static A194969Inst Instance=new A194969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194970
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,5L,7L,9L,10L,8L,11L,13L,14L,15L,12L,16L,18L,19L,21L,20L,17L,22L,24L,25L,27L,28L,26L,23L,29L,31L,32L,34L,36L,35L,33L,30L,37L,39L,40L,42L,44L,45L,43L,41L,38L,46L,48L,49L,51L,53L,54L,55L,52L,50L,47L,56L,58L,59L,61L,63L,64L,66L,65L,62L,60L,57L,67L,69L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194970Inst : IEnumerable<long>
{
public static readonly long[] Value=A194970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194970.Bytes);
public long this[int i]=>Value[i];

public static A194970Inst Instance=new A194970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194971
{
public static readonly BigInteger[] Value={ 1L,2L,10L,188L,8994L,832680L,127104492L,28951041456L,9201410927608L,3889680139527920L,2109876998624179100L,BigInteger.Parse("1428197506614652750656"),BigInteger.Parse("1179911974067256647171268"),BigInteger.Parse("1168294604146384807206421176"),BigInteger.Parse("1365624160842343461171218423880") };
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
public class A194971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194971Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194971.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194971Inst Instance=new A194971Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194972
{
public static readonly BigInteger[] Value={ 1L,3L,20L,231L,3864L,85140L,2332616L,76485227L,2921536088L,127421864328L,6248486040840L,340321635330534L,20383240346962440L,1331538898625750100L,BigInteger.Parse("94216429100347571448"),BigInteger.Parse("7178425650032302557691"),BigInteger.Parse("585936966156456139931584"),BigInteger.Parse("51011156414845408925712816") };
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
public class A194972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194972Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194972.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194972Inst Instance=new A194972Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194973
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,1L,5L,2L,3L,4L,1L,5L,6L,2L,3L,4L,1L,5L,6L,7L,2L,3L,4L,1L,5L,6L,7L,8L,2L,3L,4L,1L,5L,9L,6L,7L,8L,2L,3L,4L,1L,5L,9L,10L,6L,7L,8L,2L,3L,4L,1L,5L,9L,10L,11L,6L,7L,8L,2L,3L,4L,1L,5L,9L,10L,11L,12L,6L,7L,8L,2L,3L,4L,1L,5L,9L,13L,10L,11L,12L,6L,7L,8L,2L,3L,4L,1L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194973Inst : IEnumerable<long>
{
public static readonly long[] Value=A194973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194973.Bytes);
public long this[int i]=>Value[i];

public static A194973Inst Instance=new A194973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194974
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,13L,14L,15L,12L,16L,19L,20L,21L,17L,18L,22L,26L,27L,28L,23L,24L,25L,29L,34L,35L,36L,30L,31L,32L,33L,37L,43L,44L,45L,38L,40L,41L,42L,39L,46L,53L,54L,55L,47L,50L,51L,52L,48L,49L,56L,64L,65L,66L,57L,61L,62L,63L,58L,59L,60L,67L,76L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194974Inst : IEnumerable<long>
{
public static readonly long[] Value=A194974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194974.Bytes);
public long this[int i]=>Value[i];

public static A194974Inst Instance=new A194974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194975
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,15L,12L,13L,14L,16L,20L,21L,17L,18L,19L,22L,26L,27L,28L,23L,24L,25L,29L,33L,34L,35L,36L,30L,31L,32L,37L,41L,45L,42L,43L,44L,38L,39L,40L,46L,50L,54L,55L,51L,52L,53L,47L,48L,49L,56L,60L,64L,65L,66L,61L,62L,63L,57L,58L,59L,67L,71L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194975Inst : IEnumerable<long>
{
public static readonly long[] Value=A194975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194975.Bytes);
public long this[int i]=>Value[i];

public static A194975Inst Instance=new A194975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194976
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,4L,3L,1L,2L,4L,5L,3L,1L,2L,4L,5L,6L,3L,1L,2L,4L,5L,7L,6L,3L,1L,2L,4L,5L,7L,8L,6L,3L,1L,2L,4L,5L,7L,8L,9L,6L,3L,1L,2L,4L,5L,7L,8L,9L,10L,6L,3L,1L,2L,4L,5L,7L,8L,9L,11L,10L,6L,3L,1L,2L,4L,5L,7L,8L,9L,11L,12L,10L,6L,3L,1L,2L,4L,5L,7L,8L,9L,11L,12L,13L,10L,6L,3L,1L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194976Inst : IEnumerable<long>
{
public static readonly long[] Value=A194976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194976.Bytes);
public long this[int i]=>Value[i];

public static A194976Inst Instance=new A194976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194977
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,10L,9L,11L,12L,15L,13L,14L,16L,17L,21L,18L,19L,20L,22L,23L,28L,24L,25L,27L,26L,29L,30L,36L,31L,32L,35L,33L,34L,37L,38L,45L,39L,40L,44L,41L,42L,43L,46L,47L,55L,48L,49L,54L,50L,51L,52L,53L,56L,57L,66L,58L,59L,65L,60L,61L,62L,64L,63L,67L,68L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194977Inst : IEnumerable<long>
{
public static readonly long[] Value=A194977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194977.Bytes);
public long this[int i]=>Value[i];

public static A194977Inst Instance=new A194977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194978
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,10L,9L,11L,12L,14L,15L,13L,16L,17L,19L,20L,21L,18L,22L,23L,25L,26L,28L,27L,24L,29L,30L,32L,33L,35L,36L,34L,31L,37L,38L,40L,41L,43L,44L,45L,42L,39L,46L,47L,49L,50L,52L,53L,54L,55L,51L,48L,56L,57L,59L,60L,62L,63L,64L,66L,65L,61L,58L,67L,68L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194978Inst : IEnumerable<long>
{
public static readonly long[] Value=A194978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194978.Bytes);
public long this[int i]=>Value[i];

public static A194978Inst Instance=new A194978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194979
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,4L,5L,5L,6L,6L,7L,7L,8L,9L,9L,10L,10L,11L,11L,12L,13L,13L,14L,14L,15L,16L,16L,17L,17L,18L,18L,19L,20L,20L,21L,21L,22L,22L,23L,24L,24L,25L,25L,26L,26L,27L,28L,28L,29L,29L,30L,31L,31L,32L,32L,33L,33L,34L,35L,35L,36L,36L,37L,37L,38L,39L,39L,40L,40L,41L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194979Inst : IEnumerable<long>
{
public static readonly long[] Value=A194979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194979.Bytes);
public long this[int i]=>Value[i];

public static A194979Inst Instance=new A194979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194980
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,1L,3L,4L,2L,1L,3L,5L,4L,2L,1L,3L,5L,6L,4L,2L,1L,3L,5L,6L,7L,4L,2L,1L,3L,5L,6L,8L,7L,4L,2L,1L,3L,5L,6L,8L,9L,7L,4L,2L,1L,3L,5L,6L,8L,10L,9L,7L,4L,2L,1L,3L,5L,6L,8L,10L,11L,9L,7L,4L,2L,1L,3L,5L,6L,8L,10L,12L,11L,9L,7L,4L,2L,1L,3L,5L,6L,8L,10L,12L,13L,11L,9L,7L,4L,2L,1L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194980Inst : IEnumerable<long>
{
public static readonly long[] Value=A194980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194980.Bytes);
public long this[int i]=>Value[i];

public static A194980Inst Instance=new A194980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194981
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,5L,7L,10L,8L,9L,11L,15L,12L,14L,13L,16L,21L,17L,20L,18L,19L,22L,28L,23L,27L,24L,25L,26L,29L,36L,30L,35L,31L,32L,34L,33L,37L,45L,38L,44L,39L,40L,43L,41L,42L,46L,55L,47L,54L,48L,49L,53L,50L,52L,51L,56L,66L,57L,65L,58L,59L,64L,60L,63L,61L,62L,67L,78L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194981Inst : IEnumerable<long>
{
public static readonly long[] Value=A194981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194981.Bytes);
public long this[int i]=>Value[i];

public static A194981Inst Instance=new A194981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194982
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,5L,7L,9L,10L,8L,11L,13L,15L,14L,12L,16L,18L,20L,21L,19L,17L,22L,24L,26L,27L,28L,25L,23L,29L,31L,33L,34L,36L,35L,32L,30L,37L,39L,41L,42L,44L,45L,43L,40L,38L,46L,48L,50L,51L,53L,55L,54L,52L,49L,47L,56L,58L,60L,61L,63L,65L,66L,64L,62L,59L,57L,67L,69L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194982Inst : IEnumerable<long>
{
public static readonly long[] Value=A194982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194982.Bytes);
public long this[int i]=>Value[i];

public static A194982Inst Instance=new A194982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194983
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,1L,2L,4L,3L,1L,2L,4L,5L,3L,1L,2L,4L,6L,5L,3L,1L,2L,4L,6L,7L,5L,3L,1L,2L,4L,6L,8L,7L,5L,3L,1L,2L,4L,6L,8L,9L,7L,5L,3L,1L,2L,4L,6L,8L,10L,9L,7L,5L,3L,1L,2L,4L,6L,8L,11L,10L,9L,7L,5L,3L,1L,2L,4L,6L,8L,11L,12L,10L,9L,7L,5L,3L,1L,2L,4L,6L,8L,11L,13L,12L,10L,9L,7L,5L,3L,1L,2L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194983Inst : IEnumerable<long>
{
public static readonly long[] Value=A194983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194983.Bytes);
public long this[int i]=>Value[i];

public static A194983Inst Instance=new A194983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194984
{
public static readonly long[] Value={ 1L,3L,2L,6L,4L,5L,10L,7L,9L,8L,15L,11L,14L,12L,13L,21L,16L,20L,17L,19L,18L,28L,22L,27L,23L,26L,24L,25L,36L,29L,35L,30L,34L,31L,33L,32L,45L,37L,44L,38L,43L,39L,42L,40L,41L,55L,46L,54L,47L,53L,48L,52L,49L,51L,50L,66L,56L,65L,57L,64L,58L,63L,59L,62L,61L,60L,78L,67L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194984Inst : IEnumerable<long>
{
public static readonly long[] Value=A194984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194984.Bytes);
public long this[int i]=>Value[i];

public static A194984Inst Instance=new A194984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194985
{
public static readonly long[] Value={ 1L,3L,2L,5L,6L,4L,8L,10L,9L,7L,12L,14L,15L,13L,11L,17L,19L,21L,20L,18L,16L,23L,25L,27L,28L,26L,24L,22L,30L,32L,34L,36L,35L,33L,31L,29L,38L,40L,42L,44L,45L,43L,41L,39L,37L,47L,49L,51L,53L,55L,54L,52L,50L,48L,46L,57L,59L,61L,63L,66L,65L,64L,62L,60L,58L,56L,68L,70L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194985Inst : IEnumerable<long>
{
public static readonly long[] Value=A194985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194985.Bytes);
public long this[int i]=>Value[i];

public static A194985Inst Instance=new A194985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194986
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,3L,4L,4L,5L,5L,5L,6L,6L,7L,7L,7L,8L,8L,9L,9L,9L,10L,10L,11L,11L,12L,12L,12L,13L,13L,14L,14L,14L,15L,15L,16L,16L,16L,17L,17L,18L,18L,18L,19L,19L,20L,20L,21L,21L,21L,22L,22L,23L,23L,23L,24L,24L,25L,25L,25L,26L,26L,27L,27L,27L,28L,28L,29L,29L,29L,30L,30L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194986Inst : IEnumerable<long>
{
public static readonly long[] Value=A194986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194986.Bytes);
public long this[int i]=>Value[i];

public static A194986Inst Instance=new A194986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194987
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,1L,2L,4L,3L,1L,2L,4L,5L,3L,1L,2L,4L,6L,5L,3L,1L,2L,4L,7L,6L,5L,3L,1L,2L,4L,7L,8L,6L,5L,3L,1L,2L,4L,7L,9L,8L,6L,5L,3L,1L,2L,4L,7L,9L,10L,8L,6L,5L,3L,1L,2L,4L,7L,9L,11L,10L,8L,6L,5L,3L,1L,2L,4L,7L,9L,12L,11L,10L,8L,6L,5L,3L,1L,2L,4L,7L,9L,12L,13L,11L,10L,8L,6L,5L,3L,1L,2L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194987Inst : IEnumerable<long>
{
public static readonly long[] Value=A194987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194987.Bytes);
public long this[int i]=>Value[i];

public static A194987Inst Instance=new A194987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194988
{
public static readonly long[] Value={ 1L,3L,2L,6L,4L,5L,10L,7L,9L,8L,15L,11L,14L,12L,13L,21L,16L,20L,17L,19L,18L,28L,22L,27L,23L,26L,25L,24L,36L,29L,35L,30L,34L,33L,31L,32L,45L,37L,44L,38L,43L,42L,39L,41L,40L,55L,46L,54L,47L,53L,52L,48L,51L,49L,50L,66L,56L,65L,57L,64L,63L,58L,62L,59L,61L,60L,78L,67L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194988Inst : IEnumerable<long>
{
public static readonly long[] Value=A194988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194988.Bytes);
public long this[int i]=>Value[i];

public static A194988Inst Instance=new A194988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194989
{
public static readonly long[] Value={ 1L,3L,2L,5L,6L,4L,8L,10L,9L,7L,12L,14L,15L,13L,11L,17L,19L,21L,20L,18L,16L,23L,25L,28L,27L,26L,24L,22L,30L,32L,35L,36L,34L,33L,31L,29L,38L,40L,43L,45L,44L,42L,41L,39L,37L,47L,49L,52L,54L,55L,53L,51L,50L,48L,46L,57L,59L,62L,64L,66L,65L,63L,61L,60L,58L,56L,68L,70L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194989Inst : IEnumerable<long>
{
public static readonly long[] Value=A194989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194989.Bytes);
public long this[int i]=>Value[i];

public static A194989Inst Instance=new A194989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194990
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,7L,7L,7L,8L,8L,8L,9L,9L,9L,10L,10L,10L,11L,11L,11L,12L,12L,13L,13L,13L,14L,14L,14L,15L,15L,15L,16L,16L,16L,17L,17L,17L,18L,18L,19L,19L,19L,20L,20L,20L,21L,21L,21L,22L,22L,22L,23L,23L,23L,24L,24L,25L,25L,25L,26L,26L,26L,27L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194990Inst : IEnumerable<long>
{
public static readonly long[] Value=A194990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194990.Bytes);
public long this[int i]=>Value[i];

public static A194990Inst Instance=new A194990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194991
{
public static readonly long[] Value={ 2L,5L,7L,11L,17L,19L,23L,29L,31L,41L,43L,59L,67L,71L,79L,89L,97L,101L,103L,113L,127L,131L,139L,149L,157L,163L,167L,173L,179L,181L,193L,197L,223L,227L,229L,239L,251L,257L,263L,271L,283L,307L,313L,349L,353L,373L,379L,383L,389L,401L,409L,421L,431L,433L,439L,449L,457L,467L,479L,487L,509L,523L,547L,563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194991Inst : IEnumerable<long>
{
public static readonly long[] Value=A194991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194991.Bytes);
public long this[int i]=>Value[i];

public static A194991Inst Instance=new A194991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194992
{
public static readonly BigInteger[] Value={ 3L,6L,20L,80L,576L,4608L,69632L,1114112L,34603008L,1107296256L,69793218560L,4466765987840L,567347999932416L,72620543991349248L,BigInteger.Parse("18518801667747479552"),BigInteger.Parse("4740813226943354765312"),BigInteger.Parse("2422574005712127994626048") };
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
public class A194992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194992Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194992.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194992Inst Instance=new A194992Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194993
{
public static readonly BigInteger[] Value={ 4L,10L,42L,248L,2290L,31042L,641376L,19753266L,918924546L,64065187024L,6724991990090L,1059952700132050L,251257954485037072L,BigInteger.Parse("89488725743024413554"),BigInteger.Parse("47916300899545924260762"),BigInteger.Parse("38558096411377540692559456") };
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
public class A194993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194993Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194993.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194993Inst Instance=new A194993Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194994
{
public static readonly BigInteger[] Value={ 5L,14L,66L,458L,4990L,81014L,2059822L,78060014L,4641074078L,410310652370L,57068977108754L,11768868532345686L,3829513291002131546L,BigInteger.Parse("1842092248483706146126"),BigInteger.Parse("1402261360946084657783246") };
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
public class A194994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194994Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194994.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194994Inst Instance=new A194994Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194995
{
public static readonly BigInteger[] Value={ 6L,18L,90L,672L,7858L,138956L,3816148L,159427052L,10305467946L,1016480307410L,154783529107972L,36032460970618398L,12930394865167766832UL,BigInteger.Parse("7102572782942842968972"),BigInteger.Parse("6007897214058607933844528") };
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
public class A194995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194995Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194995.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194995Inst Instance=new A194995Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194996
{
public static readonly BigInteger[] Value={ 7L,22L,114L,888L,10804L,199988L,5740166L,251606900L,17066691742L,1770282323740L,283975401794580L,69694377176377328L,BigInteger.Parse("26447798453646675184"),BigInteger.Parse("15357128901797793996652"),BigInteger.Parse("13788844798416302935620998") };
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
public class A194996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194996Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194996.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194996Inst Instance=new A194996Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194997
{
public static readonly BigInteger[] Value={ 8L,26L,138L,1104L,13754L,261324L,7686580L,346018484L,24069199390L,2566345975600L,422456182660436L,106689940668487188L,BigInteger.Parse("41576384767924321080"),BigInteger.Parse("24871115264481653525780"),BigInteger.Parse("22948996533081051784100632") };
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
public class A194997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194997Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194997.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194997Inst Instance=new A194997Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194998
{
public static readonly long[] Value={ 2L,3L,2L,4L,6L,2L,5L,10L,20L,2L,6L,14L,42L,80L,2L,7L,18L,66L,248L,576L,2L,8L,22L,90L,458L,2290L,4608L,2L,9L,26L,114L,672L,4990L,31042L,69632L,2L,10L,30L,138L,888L,7858L,81014L,641376L,1114112L,2L,11L,34L,162L,1104L,10804L,138956L,2059822L,19753266L,34603008L,2L,12L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194998Inst : IEnumerable<long>
{
public static readonly long[] Value=A194998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194998.Bytes);
public long this[int i]=>Value[i];

public static A194998Inst Instance=new A194998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194999
{
public static readonly long[] Value={ 2L,20L,42L,66L,90L,114L,138L,162L,186L,210L,234L,258L,282L,306L,330L,354L,378L,402L,426L,450L,474L,498L,522L,546L,570L,594L,618L,642L,666L,690L,714L,738L,762L,786L,810L,834L,858L,882L,906L,930L,954L,978L,1002L,1026L,1050L,1074L,1098L,1122L,1146L,1170L,1194L,1218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194999Inst : IEnumerable<long>
{
public static readonly long[] Value=A194999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194999.Bytes);
public long this[int i]=>Value[i];

public static A194999Inst Instance=new A194999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195000
{
public static readonly long[] Value={ 2L,80L,248L,458L,672L,888L,1104L,1320L,1536L,1752L,1968L,2184L,2400L,2616L,2832L,3048L,3264L,3480L,3696L,3912L,4128L,4344L,4560L,4776L,4992L,5208L,5424L,5640L,5856L,6072L,6288L,6504L,6720L,6936L,7152L,7368L,7584L,7800L,8016L,8232L,8448L,8664L,8880L,9096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195000Inst : IEnumerable<long>
{
public static readonly long[] Value=A195000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195000.Bytes);
public long this[int i]=>Value[i];

public static A195000Inst Instance=new A195000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195001
{
public static readonly long[] Value={ 2L,576L,2290L,4990L,7858L,10804L,13754L,16706L,19658L,22610L,25562L,28514L,31466L,34418L,37370L,40322L,43274L,46226L,49178L,52130L,55082L,58034L,60986L,63938L,66890L,69842L,72794L,75746L,78698L,81650L,84602L,87554L,90506L,93458L,96410L,99362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195001Inst : IEnumerable<long>
{
public static readonly long[] Value=A195001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195001.Bytes);
public long this[int i]=>Value[i];

public static A195001Inst Instance=new A195001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195002
{
public static readonly long[] Value={ 2L,4608L,31042L,81014L,138956L,199988L,261324L,322806L,384292L,445780L,507268L,568756L,630244L,691732L,753220L,814708L,876196L,937684L,999172L,1060660L,1122148L,1183636L,1245124L,1306612L,1368100L,1429588L,1491076L,1552564L,1614052L,1675540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195002Inst : IEnumerable<long>
{
public static readonly long[] Value=A195002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195002.Bytes);
public long this[int i]=>Value[i];

public static A195002Inst Instance=new A195002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195003
{
public static readonly long[] Value={ 2L,69632L,641376L,2059822L,3816148L,5740166L,7686580L,9643120L,11600228L,13557614L,15515004L,17472396L,19429788L,21387180L,23344572L,25301964L,27259356L,29216748L,31174140L,33131532L,35088924L,37046316L,39003708L,40961100L,42918492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195003Inst : IEnumerable<long>
{
public static readonly long[] Value=A195003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195003.Bytes);
public long this[int i]=>Value[i];

public static A195003Inst Instance=new A195003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195004
{
public static readonly long[] Value={ 1024L,4100L,19648L,103508L,580664L,3419648L,20984924L,133538996L,877751236L,5937279840L,41180193352L,291859775552L,2106967145904L,15448890481568L,114765555945488L,861942483797204L,6533144250310688L,49899718750389380L,383593821097441412L,2964842429047018248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195004Inst : IEnumerable<long>
{
public static readonly long[] Value=A195004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195004.Bytes);
public long this[int i]=>Value[i];

public static A195004Inst Instance=new A195004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195005
{
public static readonly BigInteger[] Value={ 1L,2L,34L,1490L,122530L,16227602L,3155309794L,846406200530L,299510392317730L,135163342884412562L,BigInteger.Parse("75760096553546176354"),BigInteger.Parse("51633670624622762956370"),BigInteger.Parse("42049600429338786951232930"),BigInteger.Parse("40326932840083815683430101522"),BigInteger.Parse("44984263429111569097120217311714") };
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
public class A195005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195005Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195005.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195005Inst Instance=new A195005Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195006
{
public static readonly long[] Value={ 1247L,1462L,1588L,2246L,2822L,3307L,3335L,3641L,4990L,5188L,5279L,5620L,5629L,6707L,6980L,7097L,7177L,7323L,7519L,7853L,8114L,8380L,8572L,8644L,8887L,9274L,9589L,9850L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195006Inst : IEnumerable<long>
{
public static readonly long[] Value=A195006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195006.Bytes);
public long this[int i]=>Value[i];

public static A195006Inst Instance=new A195006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195007
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,1L,1L,3L,2L,0L,1L,2L,1L,2L,1L,2L,1L,2L,2L,2L,1L,0L,3L,2L,1L,2L,1L,3L,2L,1L,1L,3L,0L,2L,2L,2L,1L,2L,2L,2L,1L,2L,2L,3L,1L,3L,1L,2L,2L,1L,2L,1L,1L,2L,3L,2L,2L,4L,1L,2L,2L,2L,3L,1L,2L,1L,2L,3L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195007Inst : IEnumerable<long>
{
public static readonly long[] Value=A195007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195007.Bytes);
public long this[int i]=>Value[i];

public static A195007Inst Instance=new A195007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195008
{
public static readonly long[] Value={ 1L,24L,36L,47L,93L,105L,109L,117L,122L,207L,627L,996L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195008Inst : IEnumerable<long>
{
public static readonly long[] Value=A195008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195008.Bytes);
public long this[int i]=>Value[i];

public static A195008Inst Instance=new A195008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195009
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,8L,0L,6L,48L,162L,0L,6L,96L,486L,1536L,0L,30L,960L,7290L,30720L,93750L,0L,20L,1280L,14580L,81920L,312500L,933120L,0L,140L,17920L,306180L,2293760L,10937500L,39191040L,115296020L,0L,70L,17920L,459270L,4587520L,27343750L,117573120L,403536070L,1174405120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195009Inst : IEnumerable<long>
{
public static readonly long[] Value=A195009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195009.Bytes);
public long this[int i]=>Value[i];

public static A195009Inst Instance=new A195009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195010
{
public static readonly BigInteger[] Value={ 1L,3L,42L,1560L,115500L,14471730L,2766499428L,751812526080L,276002969271480L,131728355039531250L,BigInteger.Parse("79330842080915572290"),BigInteger.Parse("58863322491995284623360"),BigInteger.Parse("52775356148028535483743372"),BigInteger.Parse("56256397611702084409727330580"),BigInteger.Parse("70329029468732097018514453125000") };
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
public class A195010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195010Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195010.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195010Inst Instance=new A195010Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195011
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,2L,2L,1L,1L,0L,2L,2L,2L,1L,1L,0L,4L,4L,3L,2L,1L,1L,0L,5L,4L,4L,3L,2L,1L,1L,0L,7L,7L,6L,5L,3L,2L,1L,1L,0L,10L,9L,8L,6L,5L,3L,2L,1L,1L,0L,13L,13L,11L,10L,7L,5L,3L,2L,1L,1L,0L,17L,16L,15L,12L,10L,7L,5L,3L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195011Inst : IEnumerable<long>
{
public static readonly long[] Value=A195011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195011.Bytes);
public long this[int i]=>Value[i];

public static A195011Inst Instance=new A195011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195012
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,5L,7L,10L,13L,17L,24L,31L,40L,53L,69L,88L,113L,144L,183L,231L,290L,362L,453L,563L,696L,859L,1058L,1296L,1587L,1935L,2354L,2856L,3458L,4175L,5033L,6051L,7259L,8692L,10390L,12391L,14756L,17537L,20808L,24648L,29151L,34417L,40581L,47773L,56158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195012Inst : IEnumerable<long>
{
public static readonly long[] Value=A195012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195012.Bytes);
public long this[int i]=>Value[i];

public static A195012Inst Instance=new A195012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195013
{
public static readonly long[] Value={ 2L,3L,4L,6L,6L,9L,8L,12L,10L,15L,12L,18L,14L,21L,16L,24L,18L,27L,20L,30L,22L,33L,24L,36L,26L,39L,28L,42L,30L,45L,32L,48L,34L,51L,36L,54L,38L,57L,40L,60L,42L,63L,44L,66L,46L,69L,48L,72L,50L,75L,52L,78L,54L,81L,56L,84L,58L,87L,60L,90L,62L,93L,64L,96L,66L,99L,68L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195013Inst : IEnumerable<long>
{
public static readonly long[] Value=A195013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195013.Bytes);
public long this[int i]=>Value[i];

public static A195013Inst Instance=new A195013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195014
{
public static readonly long[] Value={ 0L,2L,5L,9L,15L,21L,30L,38L,50L,60L,75L,87L,105L,119L,140L,156L,180L,198L,225L,245L,275L,297L,330L,354L,390L,416L,455L,483L,525L,555L,600L,632L,680L,714L,765L,801L,855L,893L,950L,990L,1050L,1092L,1155L,1199L,1265L,1311L,1380L,1428L,1500L,1550L,1625L,1677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195014Inst : IEnumerable<long>
{
public static readonly long[] Value=A195014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195014.Bytes);
public long this[int i]=>Value[i];

public static A195014Inst Instance=new A195014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195015
{
public static readonly long[] Value={ 0L,2L,12L,24L,44L,66L,96L,128L,168L,210L,260L,312L,372L,434L,504L,576L,656L,738L,828L,920L,1020L,1122L,1232L,1344L,1464L,1586L,1716L,1848L,1988L,2130L,2280L,2432L,2592L,2754L,2924L,3096L,3276L,3458L,3648L,3840L,4040L,4242L,4452L,4664L,4884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195015Inst : IEnumerable<long>
{
public static readonly long[] Value=A195015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195015.Bytes);
public long this[int i]=>Value[i];

public static A195015Inst Instance=new A195015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195016
{
public static readonly long[] Value={ 0L,7L,17L,34L,54L,81L,111L,148L,188L,235L,285L,342L,402L,469L,539L,616L,696L,783L,873L,970L,1070L,1177L,1287L,1404L,1524L,1651L,1781L,1918L,2058L,2205L,2355L,2512L,2672L,2839L,3009L,3186L,3366L,3553L,3743L,3940L,4140L,4347L,4557L,4774L,4994L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195016Inst : IEnumerable<long>
{
public static readonly long[] Value=A195016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195016.Bytes);
public long this[int i]=>Value[i];

public static A195016Inst Instance=new A195016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195017
{
public static readonly long[] Value={ 0L,1L,-1L,2L,1L,0L,-1L,3L,-2L,2L,1L,1L,-1L,0L,0L,4L,1L,-1L,-1L,3L,-2L,2L,1L,2L,2L,0L,-3L,1L,-1L,1L,1L,5L,0L,2L,0L,0L,-1L,0L,-2L,4L,1L,-1L,-1L,3L,-1L,2L,1L,3L,-2L,3L,0L,1L,-1L,-2L,2L,2L,-2L,0L,1L,2L,-1L,2L,-3L,6L,0L,1L,1L,3L,0L,1L,-1L,1L,1L,0L,1L,1L,0L,-1L,-1L,5L,-4L,2L,1L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195017Inst : IEnumerable<long>
{
public static readonly long[] Value=A195017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195017.Bytes);
public long this[int i]=>Value[i];

public static A195017Inst Instance=new A195017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195018
{
public static readonly long[] Value={ 0L,7L,34L,81L,148L,235L,342L,469L,616L,783L,970L,1177L,1404L,1651L,1918L,2205L,2512L,2839L,3186L,3553L,3940L,4347L,4774L,5221L,5688L,6175L,6682L,7209L,7756L,8323L,8910L,9517L,10144L,10791L,11458L,12145L,12852L,13579L,14326L,15093L,15880L,16687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195018Inst : IEnumerable<long>
{
public static readonly long[] Value=A195018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195018.Bytes);
public long this[int i]=>Value[i];

public static A195018Inst Instance=new A195018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195019
{
public static readonly long[] Value={ 3L,4L,6L,8L,9L,12L,12L,16L,15L,20L,18L,24L,21L,28L,24L,32L,27L,36L,30L,40L,33L,44L,36L,48L,39L,52L,42L,56L,45L,60L,48L,64L,51L,68L,54L,72L,57L,76L,60L,80L,63L,84L,66L,88L,69L,92L,72L,96L,75L,100L,78L,104L,81L,108L,84L,112L,87L,116L,90L,120L,93L,124L,96L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195019Inst : IEnumerable<long>
{
public static readonly long[] Value=A195019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195019.Bytes);
public long this[int i]=>Value[i];

public static A195019Inst Instance=new A195019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195020
{
public static readonly long[] Value={ 0L,3L,7L,13L,21L,30L,42L,54L,70L,85L,105L,123L,147L,168L,196L,220L,252L,279L,315L,345L,385L,418L,462L,498L,546L,585L,637L,679L,735L,780L,840L,888L,952L,1003L,1071L,1125L,1197L,1254L,1330L,1390L,1470L,1533L,1617L,1683L,1771L,1840L,1932L,2004L,2100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195020Inst : IEnumerable<long>
{
public static readonly long[] Value=A195020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195020.Bytes);
public long this[int i]=>Value[i];

public static A195020Inst Instance=new A195020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195021
{
public static readonly long[] Value={ 0L,3L,34L,93L,180L,295L,438L,609L,808L,1035L,1290L,1573L,1884L,2223L,2590L,2985L,3408L,3859L,4338L,4845L,5380L,5943L,6534L,7153L,7800L,8475L,9178L,9909L,10668L,11455L,12270L,13113L,13984L,14883L,15810L,16765L,17748L,18759L,19798L,20865L,21960L,23083L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195021Inst : IEnumerable<long>
{
public static readonly long[] Value=A195021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195021.Bytes);
public long this[int i]=>Value[i];

public static A195021Inst Instance=new A195021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195022
{
public static readonly long[] Value={ 2L,0L,0L,2L,3L,1L,9L,3L,0L,4L,3L,6L,1L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195022Inst : IEnumerable<long>
{
public static readonly long[] Value=A195022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195022.Bytes);
public long this[int i]=>Value[i];

public static A195022Inst Instance=new A195022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195023
{
public static readonly long[] Value={ 0L,10L,48L,114L,208L,330L,480L,658L,864L,1098L,1360L,1650L,1968L,2314L,2688L,3090L,3520L,3978L,4464L,4978L,5520L,6090L,6688L,7314L,7968L,8650L,9360L,10098L,10864L,11658L,12480L,13330L,14208L,15114L,16048L,17010L,18000L,19018L,20064L,21138L,22240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195023Inst : IEnumerable<long>
{
public static readonly long[] Value=A195023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195023.Bytes);
public long this[int i]=>Value[i];

public static A195023Inst Instance=new A195023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195024
{
public static readonly long[] Value={ 0L,13L,54L,123L,220L,345L,498L,679L,888L,1125L,1390L,1683L,2004L,2353L,2730L,3135L,3568L,4029L,4518L,5035L,5580L,6153L,6754L,7383L,8040L,8725L,9438L,10179L,10948L,11745L,12570L,13423L,14304L,15213L,16150L,17115L,18108L,19129L,20178L,21255L,22360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195024Inst : IEnumerable<long>
{
public static readonly long[] Value=A195024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195024.Bytes);
public long this[int i]=>Value[i];

public static A195024Inst Instance=new A195024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195025
{
public static readonly long[] Value={ 0L,17L,62L,135L,236L,365L,522L,707L,920L,1161L,1430L,1727L,2052L,2405L,2786L,3195L,3632L,4097L,4590L,5111L,5660L,6237L,6842L,7475L,8136L,8825L,9542L,10287L,11060L,11861L,12690L,13547L,14432L,15345L,16286L,17255L,18252L,19277L,20330L,21411L,22520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195025Inst : IEnumerable<long>
{
public static readonly long[] Value=A195025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195025.Bytes);
public long this[int i]=>Value[i];

public static A195025Inst Instance=new A195025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195026
{
public static readonly long[] Value={ 0L,21L,70L,147L,252L,385L,546L,735L,952L,1197L,1470L,1771L,2100L,2457L,2842L,3255L,3696L,4165L,4662L,5187L,5740L,6321L,6930L,7567L,8232L,8925L,9646L,10395L,11172L,11977L,12810L,13671L,14560L,15477L,16422L,17395L,18396L,19425L,20482L,21567L,22680L,23821L,24990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195026Inst : IEnumerable<long>
{
public static readonly long[] Value=A195026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195026.Bytes);
public long this[int i]=>Value[i];

public static A195026Inst Instance=new A195026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195027
{
public static readonly long[] Value={ 0L,24L,76L,156L,264L,400L,564L,756L,976L,1224L,1500L,1804L,2136L,2496L,2884L,3300L,3744L,4216L,4716L,5244L,5800L,6384L,6996L,7636L,8304L,9000L,9724L,10476L,11256L,12064L,12900L,13764L,14656L,15576L,16524L,17500L,18504L,19536L,20596L,21684L,22800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195027Inst : IEnumerable<long>
{
public static readonly long[] Value=A195027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195027.Bytes);
public long this[int i]=>Value[i];

public static A195027Inst Instance=new A195027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195028
{
public static readonly long[] Value={ 0L,27L,82L,165L,276L,415L,582L,777L,1000L,1251L,1530L,1837L,2172L,2535L,2926L,3345L,3792L,4267L,4770L,5301L,5860L,6447L,7062L,7705L,8376L,9075L,9802L,10557L,11340L,12151L,12990L,13857L,14752L,15675L,16626L,17605L,18612L,19647L,20710L,21801L,22920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195028Inst : IEnumerable<long>
{
public static readonly long[] Value=A195028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195028.Bytes);
public long this[int i]=>Value[i];

public static A195028Inst Instance=new A195028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195029
{
public static readonly long[] Value={ 3L,30L,85L,168L,279L,418L,585L,780L,1003L,1254L,1533L,1840L,2175L,2538L,2929L,3348L,3795L,4270L,4773L,5304L,5863L,6450L,7065L,7708L,8379L,9078L,9805L,10560L,11343L,12154L,12993L,13860L,14755L,15678L,16629L,17608L,18615L,19650L,20713L,21804L,22923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195029Inst : IEnumerable<long>
{
public static readonly long[] Value=A195029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195029.Bytes);
public long this[int i]=>Value[i];

public static A195029Inst Instance=new A195029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195030
{
public static readonly long[] Value={ 0L,1L,2L,3L,34L,93L,180L,295L,438L,609L,808L,1035L,1290L,1573L,1884L,2223L,2590L,2985L,3408L,3859L,4338L,4845L,5380L,5943L,6534L,7153L,7800L,8475L,9178L,9909L,10668L,11455L,12270L,13113L,13984L,14883L,15810L,16765L,17748L,18759L,19798L,20865L,21960L,23083L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195030Inst : IEnumerable<long>
{
public static readonly long[] Value=A195030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195030.Bytes);
public long this[int i]=>Value[i];

public static A195030Inst Instance=new A195030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195031
{
public static readonly long[] Value={ 5L,12L,10L,24L,15L,36L,20L,48L,25L,60L,30L,72L,35L,84L,40L,96L,45L,108L,50L,120L,55L,132L,60L,144L,65L,156L,70L,168L,75L,180L,80L,192L,85L,204L,90L,216L,95L,228L,100L,240L,105L,252L,110L,264L,115L,276L,120L,288L,125L,300L,130L,312L,135L,324L,140L,336L,145L,348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195031Inst : IEnumerable<long>
{
public static readonly long[] Value=A195031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195031.Bytes);
public long this[int i]=>Value[i];

public static A195031Inst Instance=new A195031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195032
{
public static readonly long[] Value={ 0L,5L,17L,27L,51L,66L,102L,122L,170L,195L,255L,285L,357L,392L,476L,516L,612L,657L,765L,815L,935L,990L,1122L,1182L,1326L,1391L,1547L,1617L,1785L,1860L,2040L,2120L,2312L,2397L,2601L,2691L,2907L,3002L,3230L,3330L,3570L,3675L,3927L,4037L,4301L,4416L,4692L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195032Inst : IEnumerable<long>
{
public static readonly long[] Value=A195032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195032.Bytes);
public long this[int i]=>Value[i];

public static A195032Inst Instance=new A195032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195033
{
public static readonly long[] Value={ 21L,20L,42L,40L,63L,60L,84L,80L,105L,100L,126L,120L,147L,140L,168L,160L,189L,180L,210L,200L,231L,220L,252L,240L,273L,260L,294L,280L,315L,300L,336L,320L,357L,340L,378L,360L,399L,380L,420L,400L,441L,420L,462L,440L,483L,460L,504L,480L,525L,500L,546L,520L,567L,540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195033Inst : IEnumerable<long>
{
public static readonly long[] Value=A195033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195033.Bytes);
public long this[int i]=>Value[i];

public static A195033Inst Instance=new A195033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195034
{
public static readonly long[] Value={ 0L,21L,41L,83L,123L,186L,246L,330L,410L,515L,615L,741L,861L,1008L,1148L,1316L,1476L,1665L,1845L,2055L,2255L,2486L,2706L,2958L,3198L,3471L,3731L,4025L,4305L,4620L,4920L,5256L,5576L,5933L,6273L,6651L,7011L,7410L,7790L,8210L,8610L,9051L,9471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195034Inst : IEnumerable<long>
{
public static readonly long[] Value=A195034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195034.Bytes);
public long this[int i]=>Value[i];

public static A195034Inst Instance=new A195034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195035
{
public static readonly long[] Value={ 15L,8L,30L,16L,45L,24L,60L,32L,75L,40L,90L,48L,105L,56L,120L,64L,135L,72L,150L,80L,165L,88L,180L,96L,195L,104L,210L,112L,225L,120L,240L,128L,255L,136L,270L,144L,285L,152L,300L,160L,315L,168L,330L,176L,345L,184L,360L,192L,375L,200L,390L,208L,405L,216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195035Inst : IEnumerable<long>
{
public static readonly long[] Value=A195035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195035.Bytes);
public long this[int i]=>Value[i];

public static A195035Inst Instance=new A195035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195036
{
public static readonly long[] Value={ 0L,15L,23L,53L,69L,114L,138L,198L,230L,305L,345L,435L,483L,588L,644L,764L,828L,963L,1035L,1185L,1265L,1430L,1518L,1698L,1794L,1989L,2093L,2303L,2415L,2640L,2760L,3000L,3128L,3383L,3519L,3789L,3933L,4218L,4370L,4670L,4830L,5145L,5313L,5643L,5819L,6164L,6348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195036Inst : IEnumerable<long>
{
public static readonly long[] Value=A195036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195036.Bytes);
public long this[int i]=>Value[i];

public static A195036Inst Instance=new A195036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195037
{
public static readonly long[] Value={ 0L,17L,51L,102L,170L,255L,357L,476L,612L,765L,935L,1122L,1326L,1547L,1785L,2040L,2312L,2601L,2907L,3230L,3570L,3927L,4301L,4692L,5100L,5525L,5967L,6426L,6902L,7395L,7905L,8432L,8976L,9537L,10115L,10710L,11322L,11951L,12597L,13260L,13940L,14637L,15351L,16082L,16830L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195037Inst : IEnumerable<long>
{
public static readonly long[] Value=A195037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195037.Bytes);
public long this[int i]=>Value[i];

public static A195037Inst Instance=new A195037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195038
{
public static readonly long[] Value={ 0L,41L,123L,246L,410L,615L,861L,1148L,1476L,1845L,2255L,2706L,3198L,3731L,4305L,4920L,5576L,6273L,7011L,7790L,8610L,9471L,10373L,11316L,12300L,13325L,14391L,15498L,16646L,17835L,19065L,20336L,21648L,23001L,24395L,25830L,27306L,28823L,30381L,31980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195038Inst : IEnumerable<long>
{
public static readonly long[] Value=A195038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195038.Bytes);
public long this[int i]=>Value[i];

public static A195038Inst Instance=new A195038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195039
{
public static readonly long[] Value={ 0L,23L,69L,138L,230L,345L,483L,644L,828L,1035L,1265L,1518L,1794L,2093L,2415L,2760L,3128L,3519L,3933L,4370L,4830L,5313L,5819L,6348L,6900L,7475L,8073L,8694L,9338L,10005L,10695L,11408L,12144L,12903L,13685L,14490L,15318L,16169L,17043L,17940L,18860L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195039Inst : IEnumerable<long>
{
public static readonly long[] Value=A195039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195039.Bytes);
public long this[int i]=>Value[i];

public static A195039Inst Instance=new A195039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195040
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,3L,2L,1L,0L,1L,4L,5L,3L,1L,0L,0L,7L,8L,7L,4L,1L,0L,1L,9L,13L,12L,9L,5L,1L,0L,0L,13L,18L,19L,16L,11L,6L,1L,0L,1L,16L,25L,27L,25L,20L,13L,7L,1L,0L,0L,21L,32L,37L,36L,31L,24L,15L,8L,1L,0L,1L,25L,41L,48L,49L,45L,37L,28L,17L,9L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195040Inst : IEnumerable<long>
{
public static readonly long[] Value=A195040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195040.Bytes);
public long this[int i]=>Value[i];

public static A195040Inst Instance=new A195040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195041
{
public static readonly long[] Value={ 0L,1L,7L,15L,28L,43L,63L,85L,112L,141L,175L,211L,252L,295L,343L,393L,448L,505L,567L,631L,700L,771L,847L,925L,1008L,1093L,1183L,1275L,1372L,1471L,1575L,1681L,1792L,1905L,2023L,2143L,2268L,2395L,2527L,2661L,2800L,2941L,3087L,3235L,3388L,3543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195041Inst : IEnumerable<long>
{
public static readonly long[] Value=A195041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195041.Bytes);
public long this[int i]=>Value[i];

public static A195041Inst Instance=new A195041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195042
{
public static readonly long[] Value={ 0L,1L,9L,19L,36L,55L,81L,109L,144L,181L,225L,271L,324L,379L,441L,505L,576L,649L,729L,811L,900L,991L,1089L,1189L,1296L,1405L,1521L,1639L,1764L,1891L,2025L,2161L,2304L,2449L,2601L,2755L,2916L,3079L,3249L,3421L,3600L,3781L,3969L,4159L,4356L,4555L,4761L,4969L,5184L,5401L,5625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195042Inst : IEnumerable<long>
{
public static readonly long[] Value=A195042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195042.Bytes);
public long this[int i]=>Value[i];

public static A195042Inst Instance=new A195042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195043
{
public static readonly long[] Value={ 0L,1L,11L,23L,44L,67L,99L,133L,176L,221L,275L,331L,396L,463L,539L,617L,704L,793L,891L,991L,1100L,1211L,1331L,1453L,1584L,1717L,1859L,2003L,2156L,2311L,2475L,2641L,2816L,2993L,3179L,3367L,3564L,3763L,3971L,4181L,4400L,4621L,4851L,5083L,5324L,5567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195043Inst : IEnumerable<long>
{
public static readonly long[] Value=A195043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195043.Bytes);
public long this[int i]=>Value[i];

public static A195043Inst Instance=new A195043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195044
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,13L,14L,16L,17L,18L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,45L,46L,47L,48L,49L,50L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195044Inst : IEnumerable<long>
{
public static readonly long[] Value=A195044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195044.Bytes);
public long this[int i]=>Value[i];

public static A195044Inst Instance=new A195044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195045
{
public static readonly long[] Value={ 0L,1L,13L,27L,52L,79L,117L,157L,208L,261L,325L,391L,468L,547L,637L,729L,832L,937L,1053L,1171L,1300L,1431L,1573L,1717L,1872L,2029L,2197L,2367L,2548L,2731L,2925L,3121L,3328L,3537L,3757L,3979L,4212L,4447L,4693L,4941L,5200L,5461L,5733L,6007L,6292L,6579L,6877L,7177L,7488L,7801L,8125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195045Inst : IEnumerable<long>
{
public static readonly long[] Value=A195045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195045.Bytes);
public long this[int i]=>Value[i];

public static A195045Inst Instance=new A195045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195046
{
public static readonly long[] Value={ 0L,1L,15L,31L,60L,91L,135L,181L,240L,301L,375L,451L,540L,631L,735L,841L,960L,1081L,1215L,1351L,1500L,1651L,1815L,1981L,2160L,2341L,2535L,2731L,2940L,3151L,3375L,3601L,3840L,4081L,4335L,4591L,4860L,5131L,5415L,5701L,6000L,6301L,6615L,6931L,7260L,7591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195046Inst : IEnumerable<long>
{
public static readonly long[] Value=A195046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195046.Bytes);
public long this[int i]=>Value[i];

public static A195046Inst Instance=new A195046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195047
{
public static readonly long[] Value={ 0L,1L,17L,35L,68L,103L,153L,205L,272L,341L,425L,511L,612L,715L,833L,953L,1088L,1225L,1377L,1531L,1700L,1871L,2057L,2245L,2448L,2653L,2873L,3095L,3332L,3571L,3825L,4081L,4352L,4625L,4913L,5203L,5508L,5815L,6137L,6461L,6800L,7141L,7497L,7855L,8228L,8603L,8993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195047Inst : IEnumerable<long>
{
public static readonly long[] Value=A195047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195047.Bytes);
public long this[int i]=>Value[i];

public static A195047Inst Instance=new A195047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195048
{
public static readonly long[] Value={ 0L,1L,19L,39L,76L,115L,171L,229L,304L,381L,475L,571L,684L,799L,931L,1065L,1216L,1369L,1539L,1711L,1900L,2091L,2299L,2509L,2736L,2965L,3211L,3459L,3724L,3991L,4275L,4561L,4864L,5169L,5491L,5815L,6156L,6499L,6859L,7221L,7600L,7981L,8379L,8779L,9196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195048Inst : IEnumerable<long>
{
public static readonly long[] Value=A195048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195048.Bytes);
public long this[int i]=>Value[i];

public static A195048Inst Instance=new A195048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195049
{
public static readonly long[] Value={ 0L,1L,21L,43L,84L,127L,189L,253L,336L,421L,525L,631L,756L,883L,1029L,1177L,1344L,1513L,1701L,1891L,2100L,2311L,2541L,2773L,3024L,3277L,3549L,3823L,4116L,4411L,4725L,5041L,5376L,5713L,6069L,6427L,6804L,7183L,7581L,7981L,8400L,8821L,9261L,9703L,10164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195049Inst : IEnumerable<long>
{
public static readonly long[] Value=A195049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195049.Bytes);
public long this[int i]=>Value[i];

public static A195049Inst Instance=new A195049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195050
{
public static readonly long[] Value={ 1L,2L,0L,2L,1L,0L,3L,0L,0L,0L,2L,2L,1L,0L,0L,4L,0L,0L,0L,0L,0L,2L,2L,0L,1L,0L,0L,0L,4L,0L,2L,0L,0L,0L,0L,0L,3L,3L,0L,0L,1L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,2L,2L,2L,0L,1L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,4L,0L,0L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195050Inst : IEnumerable<long>
{
public static readonly long[] Value=A195050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195050.Bytes);
public long this[int i]=>Value[i];

public static A195050Inst Instance=new A195050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195051
{
public static readonly long[] Value={ 2L,2L,2L,4L,4L,4L,2L,2L,4L,2L,2L,4L,2L,4L,2L,2L,4L,2L,8L,2L,2L,4L,4L,6L,2L,4L,2L,4L,4L,2L,2L,4L,4L,4L,2L,2L,2L,2L,8L,4L,2L,4L,2L,4L,4L,2L,6L,2L,6L,4L,2L,4L,4L,8L,2L,4L,2L,4L,4L,2L,8L,2L,2L,4L,2L,2L,2L,4L,4L,4L,4L,4L,4L,6L,4L,2L,2L,2L,4L,4L,4L,4L,4L,8L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195051Inst : IEnumerable<long>
{
public static readonly long[] Value=A195051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195051.Bytes);
public long this[int i]=>Value[i];

public static A195051Inst Instance=new A195051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195052
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,4L,1L,1L,2L,2L,3L,1L,2L,1L,2L,2L,1L,1L,2L,2L,2L,1L,1L,1L,1L,4L,2L,1L,2L,1L,2L,2L,1L,3L,1L,3L,2L,1L,2L,2L,4L,1L,2L,1L,2L,2L,1L,4L,1L,1L,2L,1L,1L,1L,2L,2L,2L,2L,2L,2L,3L,2L,1L,1L,1L,2L,2L,2L,2L,2L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195052Inst : IEnumerable<long>
{
public static readonly long[] Value=A195052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195052.Bytes);
public long this[int i]=>Value[i];

public static A195052Inst Instance=new A195052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195053
{
public static readonly long[] Value={ 1L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195053Inst : IEnumerable<long>
{
public static readonly long[] Value=A195053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195053.Bytes);
public long this[int i]=>Value[i];

public static A195053Inst Instance=new A195053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195054
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,-1L,-1L,-2L,-3L,-5L,-6L,-10L,-13L,-18L,-24L,-33L,-42L,-57L,-72L,-94L,-120L,-154L,-192L,-245L,-305L,-382L,-473L,-588L,-721L,-891L,-1087L,-1330L,-1617L,-1966L,-2374L,-2874L,-3456L,-4157L,-4979L,-5963L,-7110L,-8481L,-10075L,-11964L,-14168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195054Inst : IEnumerable<long>
{
public static readonly long[] Value=A195054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195054.Bytes);
public long this[int i]=>Value[i];

public static A195054Inst Instance=new A195054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195055
{
public static readonly long[] Value={ 3L,2L,8L,9L,8L,6L,8L,1L,3L,3L,6L,9L,6L,4L,5L,2L,8L,7L,2L,9L,4L,4L,8L,3L,0L,3L,3L,3L,2L,9L,2L,0L,5L,0L,3L,7L,8L,4L,3L,7L,8L,9L,9L,8L,0L,2L,4L,1L,3L,5L,9L,6L,8L,7L,5L,4L,7L,1L,1L,1L,6L,4L,5L,8L,7L,4L,0L,0L,1L,4L,9L,4L,0L,8L,0L,6L,4L,0L,1L,7L,4L,7L,6L,6L,7L,2L,5L,7L,8L,0L,1L,2L,3L,9L,5L,1L,7L,4L,1L,0L,6L,0L,8L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195055Inst : IEnumerable<long>
{
public static readonly long[] Value=A195055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195055.Bytes);
public long this[int i]=>Value[i];

public static A195055Inst Instance=new A195055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195056
{
public static readonly long[] Value={ 1L,4L,0L,9L,9L,4L,3L,4L,8L,5L,8L,6L,9L,9L,0L,8L,3L,7L,4L,1L,1L,9L,2L,1L,2L,9L,9L,9L,9L,8L,2L,3L,0L,7L,3L,0L,5L,0L,4L,4L,8L,1L,4L,2L,0L,1L,0L,3L,4L,3L,9L,8L,6L,6L,0L,9L,1L,6L,1L,9L,2L,7L,6L,8L,0L,3L,1L,4L,3L,4L,9L,7L,4L,6L,3L,1L,3L,1L,5L,0L,3L,4L,7L,1L,4L,5L,3L,9L,0L,5L,7L,6L,7L,4L,0L,7L,8L,8L,9L,0L,2L,6L,0L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195056Inst : IEnumerable<long>
{
public static readonly long[] Value=A195056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195056.Bytes);
public long this[int i]=>Value[i];

public static A195056Inst Instance=new A195056Inst();

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