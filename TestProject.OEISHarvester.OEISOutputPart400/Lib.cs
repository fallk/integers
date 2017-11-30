using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A288736
{
public static readonly long[] Value={ 0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288736Inst : IEnumerable<long>
{
public static readonly long[] Value=A288736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288736.Bytes);
public long this[int i]=>Value[i];

public static A288736Inst Instance=new A288736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288735
{
public static readonly long[] Value={ 1L,5L,7L,8L,10L,11L,15L,19L,21L,22L,24L,25L,27L,28L,30L,31L,35L,39L,41L,42L,44L,45L,49L,53L,55L,56L,58L,59L,61L,62L,64L,65L,67L,68L,70L,71L,75L,79L,81L,82L,84L,85L,89L,93L,95L,96L,98L,99L,101L,102L,104L,105L,109L,113L,115L,116L,118L,119L,123L,127L,129L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288735Inst : IEnumerable<long>
{
public static readonly long[] Value=A288735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288735.Bytes);
public long this[int i]=>Value[i];

public static A288735Inst Instance=new A288735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288734
{
public static readonly long[] Value={ 2L,3L,4L,6L,9L,12L,13L,14L,16L,17L,18L,20L,23L,26L,29L,32L,33L,34L,36L,37L,38L,40L,43L,46L,47L,48L,50L,51L,52L,54L,57L,60L,63L,66L,69L,72L,73L,74L,76L,77L,78L,80L,83L,86L,87L,88L,90L,91L,92L,94L,97L,100L,103L,106L,107L,108L,110L,111L,112L,114L,117L,120L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288734Inst : IEnumerable<long>
{
public static readonly long[] Value=A288734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288734.Bytes);
public long this[int i]=>Value[i];

public static A288734Inst Instance=new A288734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288733
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288733Inst : IEnumerable<long>
{
public static readonly long[] Value=A288733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288733.Bytes);
public long this[int i]=>Value[i];

public static A288733Inst Instance=new A288733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288732
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,14L,18L,22L,26L,34L,42L,50L,58L,74L,90L,106L,122L,154L,186L,218L,250L,314L,378L,442L,506L,634L,762L,890L,1018L,1274L,1530L,1786L,2042L,2554L,3066L,3578L,4090L,5114L,6138L,7162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288732Inst : IEnumerable<long>
{
public static readonly long[] Value=A288732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288732.Bytes);
public long this[int i]=>Value[i];

public static A288732Inst Instance=new A288732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288731
{
public static readonly long[] Value={ 3L,4L,6L,7L,13L,14L,16L,17L,19L,20L,22L,23L,29L,30L,32L,33L,39L,40L,42L,43L,45L,46L,48L,49L,51L,52L,54L,55L,61L,62L,64L,65L,71L,72L,74L,75L,77L,78L,80L,81L,87L,88L,90L,91L,97L,98L,100L,101L,103L,104L,106L,107L,109L,110L,112L,113L,115L,116L,118L,119L,125L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288731Inst : IEnumerable<long>
{
public static readonly long[] Value=A288731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288731.Bytes);
public long this[int i]=>Value[i];

public static A288731Inst Instance=new A288731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288730
{
public static readonly long[] Value={ 1L,2L,5L,8L,9L,10L,11L,12L,15L,18L,21L,24L,25L,26L,27L,28L,31L,34L,35L,36L,37L,38L,41L,44L,47L,50L,53L,56L,57L,58L,59L,60L,63L,66L,67L,68L,69L,70L,73L,76L,79L,82L,83L,84L,85L,86L,89L,92L,93L,94L,95L,96L,99L,102L,105L,108L,111L,114L,117L,120L,121L,122L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288730Inst : IEnumerable<long>
{
public static readonly long[] Value=A288730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288730.Bytes);
public long this[int i]=>Value[i];

public static A288730Inst Instance=new A288730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288729
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288729Inst : IEnumerable<long>
{
public static readonly long[] Value=A288729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288729.Bytes);
public long this[int i]=>Value[i];

public static A288729Inst Instance=new A288729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288728
{
public static readonly long[] Value={ 1L,1L,3L,3L,7L,8L,18L,19L,47L,43L,102L,116L,238L,240L,553L,554L,1185L,1259L,2578L,2607L,5873L,5526L,11834L,12601L,24692L,24390L,53735L,52534L,107445L,107330L,218727L,215607L,461367L,427778L,891039L,910294L,1804606L,1706828L,3695418L,3411513L,7136850L,6892950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288728Inst : IEnumerable<long>
{
public static readonly long[] Value=A288728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288728.Bytes);
public long this[int i]=>Value[i];

public static A288728Inst Instance=new A288728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288727
{
public static readonly BigInteger[] Value={ 1L,-1488L,1266840L,-811420480L,434731407660L,-205762405603104L,88869953694086720L,BigInteger.Parse("-35768448018942261120"),BigInteger.Parse("13610297613250180785870"),BigInteger.Parse("-4947238483283026511913200"),BigInteger.Parse("1731166476103096494953112096"),BigInteger.Parse("-586625688530872572480200739648") };
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
public class A288727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288727Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288727.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288727Inst Instance=new A288727Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288726
{
public static readonly long[] Value={ 0L,0L,0L,2L,5L,5L,10L,8L,15L,12L,12L,12L,23L,18L,31L,31L,31L,24L,41L,41L,60L,60L,60L,60L,83L,72L,72L,72L,72L,59L,88L,88L,119L,119L,119L,119L,119L,102L,139L,139L,139L,120L,161L,161L,204L,204L,204L,204L,251L,228L,228L,228L,228L,228L,281L,281L,281L,281L,281L,281L,340L,311L,372L,372L,372L,341L,341L,341L,408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288726Inst : IEnumerable<long>
{
public static readonly long[] Value=A288726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288726.Bytes);
public long this[int i]=>Value[i];

public static A288726Inst Instance=new A288726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288725
{
public static readonly long[] Value={ 3L,1L,2L,2L,3L,3L,1L,1L,1L,2L,2L,2L,3L,1L,2L,3L,3L,1L,1L,1L,2L,3L,1L,1L,2L,2L,3L,3L,3L,1L,1L,1L,2L,2L,2L,3L,1L,2L,3L,3L,1L,1L,2L,2L,3L,3L,3L,1L,2L,2L,3L,3L,3L,1L,1L,1L,2L,3L,1L,2L,2L,3L,3L,3L,1L,1L,1L,2L,3L,1L,1L,2L,2L,3L,3L,1L,1L,1L,2L,2L,2L,3L,3L,3L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288725Inst : IEnumerable<long>
{
public static readonly long[] Value=A288725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288725.Bytes);
public long this[int i]=>Value[i];

public static A288725Inst Instance=new A288725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288724
{
public static readonly long[] Value={ 2L,1L,2L,2L,1L,2L,1L,1L,2L,2L,1L,2L,2L,1L,1L,2L,1L,1L,2L,1L,2L,2L,1L,1L,2L,1L,1L,2L,2L,1L,2L,1L,1L,2L,1L,1L,2L,2L,1L,2L,2L,1L,2L,1L,1L,2L,1L,2L,2L,1L,1L,2L,1L,1L,2L,1L,2L,2L,1L,2L,2L,1L,1L,2L,1L,2L,2L,1L,2L,1L,1L,2L,1L,1L,2L,2L,1L,2L,2L,1L,2L,1L,1L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288724Inst : IEnumerable<long>
{
public static readonly long[] Value=A288724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288724.Bytes);
public long this[int i]=>Value[i];

public static A288724Inst Instance=new A288724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288723
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,1L,1L,1L,2L,3L,1L,1L,2L,2L,3L,3L,3L,1L,1L,1L,2L,2L,2L,3L,1L,2L,3L,3L,1L,1L,1L,2L,3L,3L,1L,1L,2L,2L,2L,3L,3L,3L,1L,2L,3L,3L,1L,1L,2L,2L,3L,3L,3L,1L,2L,3L,3L,1L,1L,2L,2L,3L,3L,3L,1L,1L,1L,2L,2L,2L,3L,1L,1L,2L,2L,2L,3L,1L,2L,2L,3L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288723Inst : IEnumerable<long>
{
public static readonly long[] Value=A288723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288723.Bytes);
public long this[int i]=>Value[i];

public static A288723Inst Instance=new A288723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288722
{
public static readonly BigInteger[] Value={ 1L,7L,47L,492L,10030L,415504L,34821705L,5873737591L,1986293769719L,1342287826603144L,1808263364071413240L,BigInteger.Parse("4847274244238104590520"),BigInteger.Parse("25819608749278516743821755"),BigInteger.Parse("272991106439478141199607596649"),BigInteger.Parse("5724287949499035173796596544768241"),BigInteger.Parse("237885203520333624684917852305536258876") };
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
public class A288722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288722Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288722.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288722Inst Instance=new A288722Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288721
{
public static readonly long[] Value={ 1L,7L,32L,296L,5744L,227080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288721Inst : IEnumerable<long>
{
public static readonly long[] Value=A288721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288721.Bytes);
public long this[int i]=>Value[i];

public static A288721Inst Instance=new A288721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288672
{
public static readonly long[] Value={ 2L,3L,6L,7L,10L,15L,16L,19L,20L,23L,28L,33L,42L,43L,46L,47L,50L,51L,54L,59L,60L,63L,64L,67L,72L,77L,86L,87L,90L,95L,104L,105L,108L,113L,122L,123L,130L,131L,138L,139L,142L,143L,146L,147L,150L,155L,156L,159L,160L,163L,168L,169L,172L,173L,176L,181L,186L,195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288672Inst : IEnumerable<long>
{
public static readonly long[] Value=A288672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288672.Bytes);
public long this[int i]=>Value[i];

public static A288672Inst Instance=new A288672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288671
{
public static readonly long[] Value={ 1L,4L,5L,8L,9L,11L,12L,13L,14L,17L,18L,21L,22L,24L,25L,26L,27L,29L,30L,31L,32L,34L,35L,36L,37L,38L,39L,40L,41L,44L,45L,48L,49L,52L,53L,55L,56L,57L,58L,61L,62L,65L,66L,68L,69L,70L,71L,73L,74L,75L,76L,78L,79L,80L,81L,82L,83L,84L,85L,88L,89L,91L,92L,93L,94L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288671Inst : IEnumerable<long>
{
public static readonly long[] Value=A288671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288671.Bytes);
public long this[int i]=>Value[i];

public static A288671Inst Instance=new A288671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288670
{
public static readonly long[] Value={ 0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288670Inst : IEnumerable<long>
{
public static readonly long[] Value=A288670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288670.Bytes);
public long this[int i]=>Value[i];

public static A288670Inst Instance=new A288670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288669
{
public static readonly long[] Value={ 45L,162L,243L,324L,405L,486L,567L,648L,729L,891L,2223L,4446L,4455L,4545L,4950L,5445L,6669L,7767L,8892L,8910L,10701L,18819L,19512L,21402L,22212L,26829L,32103L,37638L,39024L,42804L,43434L,44424L,53505L,53658L,56457L,56556L,58536L,64206L,66636L,70731L,74907L,75276L,77778L,78048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288669Inst : IEnumerable<long>
{
public static readonly long[] Value=A288669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288669.Bytes);
public long this[int i]=>Value[i];

public static A288669Inst Instance=new A288669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288668
{
public static readonly long[] Value={ 2L,4L,5L,8L,13L,18L,29L,44L,65L,102L,153L,232L,357L,538L,821L,1252L,1897L,2894L,4401L,6688L,10189L,15490L,23565L,35868L,54545L,82998L,126281L,192088L,292277L,444650L,676453L,1029204L,1565753L,2382110L,3624161L,5513616L,8388381L,12761938L,19415613L,29538700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288668Inst : IEnumerable<long>
{
public static readonly long[] Value=A288668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288668.Bytes);
public long this[int i]=>Value[i];

public static A288668Inst Instance=new A288668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288667
{
public static readonly long[] Value={ 6L,7L,14L,15L,18L,19L,22L,23L,26L,35L,36L,43L,44L,47L,48L,51L,52L,55L,60L,61L,64L,65L,68L,73L,74L,77L,78L,81L,86L,91L,100L,101L,108L,109L,116L,117L,120L,121L,124L,125L,128L,137L,138L,145L,146L,149L,150L,153L,154L,157L,162L,163L,166L,167L,170L,175L,176L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288667Inst : IEnumerable<long>
{
public static readonly long[] Value=A288667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288667.Bytes);
public long this[int i]=>Value[i];

public static A288667Inst Instance=new A288667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288666
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,9L,10L,11L,12L,13L,16L,17L,20L,21L,24L,25L,27L,28L,29L,30L,31L,32L,33L,34L,37L,38L,39L,40L,41L,42L,45L,46L,49L,50L,53L,54L,56L,57L,58L,59L,62L,63L,66L,67L,69L,70L,71L,72L,75L,76L,79L,80L,82L,83L,84L,85L,87L,88L,89L,90L,92L,93L,94L,95L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288666Inst : IEnumerable<long>
{
public static readonly long[] Value=A288666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288666.Bytes);
public long this[int i]=>Value[i];

public static A288666Inst Instance=new A288666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288665
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288665Inst : IEnumerable<long>
{
public static readonly long[] Value=A288665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288665.Bytes);
public long this[int i]=>Value[i];

public static A288665Inst Instance=new A288665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288664
{
public static readonly long[] Value={ 1L,1L,4L,3L,24L,7L,112L,15L,480L,31L,1984L,63L,8064L,127L,32512L,255L,130560L,511L,523264L,1023L,2095104L,2047L,8384512L,4095L,33546240L,8191L,134201344L,16383L,536838144L,32767L,2147418112L,65535L,8589803520L,131071L,34359476224L,262143L,137438429184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288664Inst : IEnumerable<long>
{
public static readonly long[] Value=A288664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288664.Bytes);
public long this[int i]=>Value[i];

public static A288664Inst Instance=new A288664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288663
{
public static readonly long[] Value={ 1L,2L,1L,12L,3L,56L,7L,240L,15L,992L,31L,4032L,63L,16256L,127L,65280L,255L,261632L,511L,1047552L,1023L,4192256L,2047L,16773120L,4095L,67100672L,8191L,268419072L,16383L,1073709056L,32767L,4294901760L,65535L,17179738112L,131071L,68719214592L,262143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288663Inst : IEnumerable<long>
{
public static readonly long[] Value=A288663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288663.Bytes);
public long this[int i]=>Value[i];

public static A288663Inst Instance=new A288663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288662
{
public static readonly BigInteger[] Value={ 1L,1L,100L,11L,11000L,111L,1110000L,1111L,111100000L,11111L,11111000000L,111111L,1111110000000L,1111111L,111111100000000L,11111111L,11111111000000000L,111111111L,1111111110000000000L,1111111111L,BigInteger.Parse("111111111100000000000"),11111111111L,BigInteger.Parse("11111111111000000000000") };
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
public class A288662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288662Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288662.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288662Inst Instance=new A288662Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288661
{
public static readonly BigInteger[] Value={ 1L,10L,1L,1100L,11L,111000L,111L,11110000L,1111L,1111100000L,11111L,111111000000L,111111L,11111110000000L,1111111L,1111111100000000L,11111111L,111111111000000000L,111111111L,11111111110000000000UL,1111111111L,BigInteger.Parse("1111111111100000000000"),11111111111L };
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
public class A288661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288661Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288661.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288661Inst Instance=new A288661Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288660
{
public static readonly long[] Value={ 3L,4L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,96L,97L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288660Inst : IEnumerable<long>
{
public static readonly long[] Value=A288660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288660.Bytes);
public long this[int i]=>Value[i];

public static A288660Inst Instance=new A288660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288659
{
public static readonly long[] Value={ 0L,1L,2L,5L,6L,7L,8L,9L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,100L,101L,102L,103L,104L,105L,106L,107L,108L,109L,110L,111L,112L,113L,114L,115L,116L,117L,118L,119L,120L,121L,122L,123L,124L,125L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288659Inst : IEnumerable<long>
{
public static readonly long[] Value=A288659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288659.Bytes);
public long this[int i]=>Value[i];

public static A288659Inst Instance=new A288659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288658
{
public static readonly long[] Value={ 4L,5L,6L,7L,8L,9L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288658Inst : IEnumerable<long>
{
public static readonly long[] Value=A288658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288658.Bytes);
public long this[int i]=>Value[i];

public static A288658Inst Instance=new A288658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288657
{
public static readonly long[] Value={ 0L,1L,2L,3L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,100L,101L,102L,103L,104L,105L,106L,107L,108L,109L,110L,111L,112L,113L,114L,115L,116L,117L,118L,119L,120L,121L,122L,123L,124L,125L,126L,127L,128L,129L,130L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288657Inst : IEnumerable<long>
{
public static readonly long[] Value=A288657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288657.Bytes);
public long this[int i]=>Value[i];

public static A288657Inst Instance=new A288657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288592
{
public static readonly BigInteger[] Value={ 1L,10L,1L,1100L,1L,111010L,11L,11110100L,101L,1111101010L,1101L,111111010010L,10011L,11111110100000L,110001L,1111111101000010L,1000001L,111111111010101010L,11000101L,11111111110100100100UL,100000111L,BigInteger.Parse("1111111111101010000000"),1101001111L };
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
public class A288592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288592Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288592.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288592Inst Instance=new A288592Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288591
{
public static readonly long[] Value={ 1L,3L,6L,7L,28L,63L,56L,223L,432L,127L,1248L,3967L,8128L,2047L,28544L,55807L,47872L,229375L,196096L,886783L,777216L,3653631L,2914304L,13033471L,12382208L,63438847L,62971904L,265256959L,264749056L,968359935L,811827200L,3891658751L,3237937152L,15527313407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288591Inst : IEnumerable<long>
{
public static readonly long[] Value=A288591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288591.Bytes);
public long this[int i]=>Value[i];

public static A288591Inst Instance=new A288591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288590
{
public static readonly long[] Value={ 1L,3L,3L,14L,7L,63L,14L,251L,27L,1016L,57L,4079L,127L,16376L,251L,65435L,442L,262139L,1018L,1048091L,1914L,4194171L,3866L,16776035L,7802L,67108751L,14366L,268431167L,31870L,1073740647L,58118L,4294946791L,130566L,17179867879L,237542L,68719387527L,517606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288590Inst : IEnumerable<long>
{
public static readonly long[] Value=A288590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288590.Bytes);
public long this[int i]=>Value[i];

public static A288590Inst Instance=new A288590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288589
{
public static readonly ulong[] Value={ 1L,11L,110L,111L,11100L,111111L,111000L,11011111L,110110000L,1111111L,10011100000L,111101111111L,1111111000000L,11111111111L,110111110000000L,1101100111111111L,1011101100000000L,110111111111111111L,101111111000000000L,11011000011111111111UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288589Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A288589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288589.Bytes);
public ulong this[int i]=>Value[i];

public static A288589Inst Instance=new A288589Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288588
{
public static readonly BigInteger[] Value={ 1L,11L,11L,1110L,111L,111111L,1110L,11111011L,11011L,1111111000L,111001L,111111101111L,1111111L,11111111111000L,11111011L,1111111110011011L,110111010L,111111111111111011L,1111111010L,11111111111000011011UL,11101111010L,BigInteger.Parse("1111111111111101111011"),111100011010L };
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
public class A288588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288588Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288588.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288588Inst Instance=new A288588Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288587
{
public static readonly long[] Value={ 1L,1L,6L,7L,20L,15L,88L,31L,368L,63L,1312L,895L,5312L,1791L,20608L,2047L,91904L,45055L,289280L,172031L,1551360L,770047L,4884480L,2392063L,19623936L,16449535L,67149824L,31326207L,294567936L,113508351L,1150320640L,911736831L,5744558080L,22020095L,24031920128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288587Inst : IEnumerable<long>
{
public static readonly long[] Value=A288587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288587.Bytes);
public long this[int i]=>Value[i];

public static A288587Inst Instance=new A288587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288586
{
public static readonly long[] Value={ 1L,2L,3L,14L,5L,60L,13L,248L,29L,1008L,37L,4076L,101L,16344L,133L,65504L,461L,262100L,689L,1048468L,1725L,4194164L,2217L,16776740L,7593L,67108220L,10241L,268434360L,28209L,1073737944L,33937L,4294961772L,117973L,17179855360L,176333L,68719459080L,428989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288586Inst : IEnumerable<long>
{
public static readonly long[] Value=A288586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288586.Bytes);
public long this[int i]=>Value[i];

public static A288586Inst Instance=new A288586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288585
{
public static readonly BigInteger[] Value={ 1L,1L,110L,111L,10100L,1111L,1011000L,11111L,101110000L,111111L,10100100000L,1101111111L,1010011000000L,11011111111L,101000010000000L,11111111111L,10110011100000000L,1010111111111111L,1000110101000000000L,101001111111111111L,BigInteger.Parse("101111010110000000000") };
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
public class A288585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288585Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288585.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288585Inst Instance=new A288585Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288584
{
public static readonly BigInteger[] Value={ 1L,10L,11L,1110L,101L,111100L,1101L,11111000L,11101L,1111110000L,100101L,111111101100L,1100101L,11111111011000L,10000101L,1111111111100000L,111001101L,111111111111010100L,1010110001L,11111111111110010100UL,11010111101L,BigInteger.Parse("1111111111111101110100"),100010101001L };
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
public class A288584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288584Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288584.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288584Inst Instance=new A288584Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288583
{
public static readonly long[] Value={ 1L,2L,3L,6L,11L,19L,28L,42L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288583Inst : IEnumerable<long>
{
public static readonly long[] Value=A288583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288583.Bytes);
public long this[int i]=>Value[i];

public static A288583Inst Instance=new A288583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288582
{
public static readonly BigInteger[] Value={ 1L,0L,1L,10L,1001L,1001010L,100101001001L,10010100100101001010UL,BigInteger.Parse("100101001001010010100100101001001") };
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
public class A288582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288582Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288582.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288582Inst Instance=new A288582Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288581
{
public static readonly BigInteger[] Value={ 1L,0L,1L,2L,9L,74L,2377L,608586L,4985538889L,10455432852752714L,BigInteger.Parse("179622968672387565806504265"),BigInteger.Parse("6471599478241175343734843735327078926076234"),BigInteger.Parse("4005726056166563547283223187979602658910620746504772987089147436550473") };
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
public class A288581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288581Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288581.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288581Inst Instance=new A288581Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288580
{
public static readonly long[] Value={ 1L,1L,-1L,1L,-1L,4L,1L,1L,-4L,-36L,1L,1L,-2L,9L,576L,1L,1L,-4L,-9L,64L,-14400L,1L,1L,2L,-3L,-8L,-225L,518400L,1L,1L,2L,-6L,-16L,40L,-2304L,-25401600L,1L,1L,2L,-9L,-4L,-15L,324L,11025L,1625702400L,1L,1L,2L,3L,-8L,-25L,144L,280L,147456L,-131681894400L,1L,1L,2L,3L,-12L,-5L,-24L,105L,-2240L,-893025L,13168189440000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288580Inst : IEnumerable<long>
{
public static readonly long[] Value=A288580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288580.Bytes);
public long this[int i]=>Value[i];

public static A288580Inst Instance=new A288580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288579
{
public static readonly long[] Value={ 1L,2L,5L,10L,19L,34L,60L,100L,165L,265L,418L,647L,990L,1490L,2220L,3268L,4765L,6880L,9855L,13995L,19736L,27632L,38441L,53142L,73054L,99861L,135815L,183791L,247565L,331965L,443271L,589460L,780846L,1030487L,1355104L,1775823L,2319522L,3019991L,3920002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288579Inst : IEnumerable<long>
{
public static readonly long[] Value=A288579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288579.Bytes);
public long this[int i]=>Value[i];

public static A288579Inst Instance=new A288579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288578
{
public static readonly long[] Value={ 1L,2L,5L,9L,18L,31L,55L,91L,151L,240L,381L,587L,900L,1352L,2018L,2966L,4332L,6250L,8962L,12725L,17962L,25147L,35015L,48414L,66603L,91071L,123945L,167786L,226154L,303375L,405337L,539249L,714740L,943659L,1241605L,1627812L,2127302L,2770966L,3598567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288578Inst : IEnumerable<long>
{
public static readonly long[] Value=A288578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288578.Bytes);
public long this[int i]=>Value[i];

public static A288578Inst Instance=new A288578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288577
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,3L,4L,5L,3L,4L,5L,3L,4L,5L,5L,6L,3L,4L,5L,5L,6L,3L,4L,5L,5L,6L,6L,6L,7L,8L,3L,4L,5L,5L,6L,6L,6L,7L,8L,3L,4L,5L,5L,6L,6L,6L,7L,8L,6L,7L,8L,6L,7L,8L,8L,9L,3L,4L,5L,5L,6L,6L,6L,7L,8L,6L,7L,8L,6L,7L,8L,8L,9L,3L,4L,5L,5L,6L,6L,6L,7L,8L,6L,7L,8L,6L,7L,8L,8L,9L,6L,7L,8L,8L,9L,6L,7L,8L,8L,9L,9L,9L,10L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288577Inst : IEnumerable<long>
{
public static readonly long[] Value=A288577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288577.Bytes);
public long this[int i]=>Value[i];

public static A288577Inst Instance=new A288577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288511
{
public static readonly long[] Value={ 2L,4L,5L,7L,9L,12L,17L,23L,33L,48L,70L,103L,152L,228L,343L,515L,779L,1180L,1787L,2715L,4124L,6264L,9526L,14483L,22025L,33504L,50957L,77519L,117929L,179396L,272930L,415215L,631680L,961032L,1462067L,2224347L,3384083L,5148432L,7832727L,11916547L,18129540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288511Inst : IEnumerable<long>
{
public static readonly long[] Value=A288511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288511.Bytes);
public long this[int i]=>Value[i];

public static A288511Inst Instance=new A288511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288510
{
public static readonly long[] Value={ 4L,7L,9L,11L,14L,16L,18L,21L,25L,29L,31L,33L,36L,40L,44L,46L,48L,51L,54L,57L,61L,64L,67L,71L,75L,79L,81L,83L,86L,89L,92L,96L,99L,102L,106L,110L,114L,116L,118L,121L,123L,125L,128L,130L,132L,135L,138L,141L,145L,147L,149L,152L,154L,156L,159L,162L,165L,169L,172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288510Inst : IEnumerable<long>
{
public static readonly long[] Value=A288510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288510.Bytes);
public long this[int i]=>Value[i];

public static A288510Inst Instance=new A288510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288509
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,8L,10L,12L,13L,15L,17L,19L,20L,22L,23L,24L,26L,27L,28L,30L,32L,34L,35L,37L,38L,39L,41L,42L,43L,45L,47L,49L,50L,52L,53L,55L,56L,58L,59L,60L,62L,63L,65L,66L,68L,69L,70L,72L,73L,74L,76L,77L,78L,80L,82L,84L,85L,87L,88L,90L,91L,93L,94L,95L,97L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288509Inst : IEnumerable<long>
{
public static readonly long[] Value=A288509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288509.Bytes);
public long this[int i]=>Value[i];

public static A288509Inst Instance=new A288509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288508
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288508Inst : IEnumerable<long>
{
public static readonly long[] Value=A288508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288508.Bytes);
public long this[int i]=>Value[i];

public static A288508Inst Instance=new A288508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288507
{
public static readonly long[] Value={ 24L,319L,738L,57360L,1077529L,116552943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288507Inst : IEnumerable<long>
{
public static readonly long[] Value=A288507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288507.Bytes);
public long this[int i]=>Value[i];

public static A288507Inst Instance=new A288507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288506
{
public static readonly long[] Value={ 1L,2L,2L,8L,12L,0L,120L,0L,496L,0L,1888L,256L,7616L,512L,31616L,3072L,124672L,12288L,464384L,118784L,2055168L,81920L,8222720L,327680L,32829440L,1441792L,130277376L,8126464L,520601600L,24117248L,2132246528L,30408704L,8529051648L,926941184L,32499433472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288506Inst : IEnumerable<long>
{
public static readonly long[] Value=A288506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288506.Bytes);
public long this[int i]=>Value[i];

public static A288506Inst Instance=new A288506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288505
{
public static readonly long[] Value={ 1L,1L,2L,1L,6L,0L,15L,0L,31L,0L,55L,8L,119L,16L,239L,48L,463L,48L,839L,184L,1887L,160L,3935L,160L,7775L,416L,15903L,992L,31775L,928L,62591L,2944L,128127L,2992L,246863L,15284L,508123L,32548L,1016059L,32516L,2065035L,25972L,4168327L,25720L,8362887L,9304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288505Inst : IEnumerable<long>
{
public static readonly long[] Value=A288505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288505.Bytes);
public long this[int i]=>Value[i];

public static A288505Inst Instance=new A288505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288504
{
public static readonly BigInteger[] Value={ 1L,10L,10L,1000L,1100L,0L,1111000L,0L,111110000L,0L,11101100000L,100000000L,1110111000000L,1000000000L,111101110000000L,110000000000L,11110011100000000L,11000000000000L,1110001011000000000L,11101000000000000L,BigInteger.Parse("111110101110000000000"),10100000000000000L };
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
public class A288504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288504Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288504.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288504Inst Instance=new A288504Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288503
{
public static readonly long[] Value={ 1L,1L,10L,1L,110L,0L,1111L,0L,11111L,0L,110111L,1000L,1110111L,10000L,11101111L,110000L,111001111L,110000L,1101000111L,10111000L,11101011111L,10100000L,111101011111L,10100000L,1111001011111L,110100000L,11111000011111L,1111100000L,111110000011111L,1110100000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288503Inst : IEnumerable<long>
{
public static readonly long[] Value=A288503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288503.Bytes);
public long this[int i]=>Value[i];

public static A288503Inst Instance=new A288503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288502
{
public static readonly long[] Value={ 263L,284L,362L,393L,482L,1262L,1284L,1293L,1382L,1393L,1482L,1493L,1631L,1823L,1841L,1932L,1934L,2162L,2173L,2184L,2193L,2194L,2195L,2346L,2375L,2593L,2597L,2612L,2621L,2625L,2638L,2658L,2674L,2713L,2735L,2813L,2814L,2831L,2841L,2843L,2845L,2847L,2849L,2859L,2895L,2914L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288502Inst : IEnumerable<long>
{
public static readonly long[] Value=A288502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288502.Bytes);
public long this[int i]=>Value[i];

public static A288502Inst Instance=new A288502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288501
{
public static readonly long[] Value={ 1L,3L,4L,7L,24L,15L,96L,63L,384L,255L,1536L,1023L,6656L,3071L,31232L,3071L,126464L,25599L,473088L,102399L,1892352L,507903L,7372800L,2097151L,29507584L,8093695L,122224640L,23986175L,489095168L,99745791L,1981677568L,331612159L,7926841344L,1326186495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288501Inst : IEnumerable<long>
{
public static readonly long[] Value=A288501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288501.Bytes);
public long this[int i]=>Value[i];

public static A288501Inst Instance=new A288501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288500
{
public static readonly long[] Value={ 1L,3L,1L,14L,3L,60L,3L,252L,3L,1020L,3L,4092L,11L,16372L,47L,65488L,239L,261912L,231L,1048344L,231L,4194168L,135L,16777208L,1159L,67107704L,1175L,268434280L,7319L,1073734632L,15415L,4294951880L,48183L,17179821000L,48183L,68719428552L,64567L,274877846472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288500Inst : IEnumerable<long>
{
public static readonly long[] Value=A288500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288500.Bytes);
public long this[int i]=>Value[i];

public static A288500Inst Instance=new A288500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288499
{
public static readonly BigInteger[] Value={ 1L,11L,100L,111L,11000L,1111L,1100000L,111111L,110000000L,11111111L,11000000000L,1111111111L,1101000000000L,101111111111L,111101000000000L,101111111111L,11110111000000000L,110001111111111L,1110011100000000000L,11000111111111111L,BigInteger.Parse("111001110000000000000") };
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
public class A288499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288499Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288499.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288499Inst Instance=new A288499Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288498
{
public static readonly BigInteger[] Value={ 1L,11L,1L,1110L,11L,111100L,11L,11111100L,11L,1111111100L,11L,111111111100L,1011L,11111111110100L,101111L,1111111111010000L,11101111L,111111111100011000L,11100111L,11111111111100011000UL,11100111L,BigInteger.Parse("1111111111111101111000"),10000111L,BigInteger.Parse("111111111111111111111000") };
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
public class A288498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288498Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288498.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288498Inst Instance=new A288498Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288497
{
public static readonly long[] Value={ 1L,2L,2L,4L,20L,24L,8L,208L,336L,416L,160L,3392L,5440L,6528L,3200L,50432L,95488L,125440L,10752L,807936L,1528832L,1091584L,1484800L,14372864L,21581824L,23764992L,27959296L,214777856L,375734272L,523337728L,27033600L,4240769024L,7590969344L,2116681728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288497Inst : IEnumerable<long>
{
public static readonly long[] Value=A288497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288497.Bytes);
public long this[int i]=>Value[i];

public static A288497Inst Instance=new A288497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288496
{
public static readonly long[] Value={ 1L,1L,2L,2L,5L,6L,8L,11L,21L,22L,40L,43L,85L,102L,152L,163L,349L,350L,672L,675L,1373L,1346L,2740L,2779L,5413L,5466L,10924L,11059L,21709L,25406L,40128L,41791L,89159L,86520L,175619L,174589L,349950L,352512L,696059L,714901L,1390446L,1425760L,2776731L,2861173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288496Inst : IEnumerable<long>
{
public static readonly long[] Value=A288496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288496.Bytes);
public long this[int i]=>Value[i];

public static A288496Inst Instance=new A288496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288303
{
public static readonly long[] Value={ 1L,2L,2L,4L,12L,24L,56L,112L,368L,416L,864L,1472L,3520L,7296L,15744L,18176L,63232L,127488L,202240L,416768L,1014784L,1140736L,2480128L,7761920L,11235328L,24092672L,52912128L,96321536L,211664896L,381583360L,1073053696L,2112815104L,8576368640L,3288203264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288303Inst : IEnumerable<long>
{
public static readonly long[] Value=A288303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288303.Bytes);
public long this[int i]=>Value[i];

public static A288303Inst Instance=new A288303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288302
{
public static readonly long[] Value={ 1L,1L,2L,2L,6L,6L,14L,14L,29L,22L,54L,58L,118L,78L,222L,226L,478L,318L,838L,934L,2014L,1442L,3538L,3694L,7594L,6106L,14118L,15322L,30502L,24410L,55294L,63422L,72191L,130828L,194364L,262143L,278296L,518104L,780284L,1022946L,1271782L,1808794L,3139518L,3676662L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288302Inst : IEnumerable<long>
{
public static readonly long[] Value=A288302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288302.Bytes);
public long this[int i]=>Value[i];

public static A288302Inst Instance=new A288302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288301
{
public static readonly ulong[] Value={ 1L,10L,10L,100L,1100L,11000L,111000L,1110000L,101110000L,110100000L,1101100000L,10111000000L,110111000000L,1110010000000L,11110110000000L,100011100000000L,1111011100000000L,11111001000000000L,110001011000000000L,1100101110000000000L,11110111110000000000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288301Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A288301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288301.Bytes);
public ulong this[int i]=>Value[i];

public static A288301Inst Instance=new A288301Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288300
{
public static readonly long[] Value={ 1L,1L,10L,10L,110L,110L,1110L,1110L,11101L,10110L,110110L,111010L,1110110L,1001110L,11011110L,11100010L,111011110L,100111110L,1101000110L,1110100110L,11111011110L,10110100010L,110111010010L,111001101110L,1110110101010L,1011111011010L,11011100100110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288300Inst : IEnumerable<long>
{
public static readonly long[] Value=A288300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288300.Bytes);
public long this[int i]=>Value[i];

public static A288300Inst Instance=new A288300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288299
{
public static readonly long[] Value={ 1L,1L,4L,7L,24L,15L,96L,127L,256L,511L,1024L,2047L,6656L,8191L,24576L,16383L,114688L,98303L,458752L,524287L,1048576L,2097151L,6291456L,4194303L,29360128L,25165823L,92274688L,117440511L,463470592L,234881023L,1946157056L,2013265919L,4731174912L,7985954815L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288299Inst : IEnumerable<long>
{
public static readonly long[] Value=A288299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288299.Bytes);
public long this[int i]=>Value[i];

public static A288299Inst Instance=new A288299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288298
{
public static readonly long[] Value={ 1L,2L,1L,14L,3L,60L,3L,254L,1L,1022L,1L,4094L,11L,16382L,3L,65532L,7L,262138L,7L,1048574L,1L,4194302L,3L,16777212L,7L,67108858L,13L,268435446L,187L,1073741804L,23L,4294967278L,177L,17179869038L,243L,68719476590L,241L,274877906862L,115L,1099511627758L,669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288298Inst : IEnumerable<long>
{
public static readonly long[] Value=A288298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288298.Bytes);
public long this[int i]=>Value[i];

public static A288298Inst Instance=new A288298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288297
{
public static readonly long[] Value={ 1L,1L,100L,111L,11000L,1111L,1100000L,1111111L,100000000L,111111111L,10000000000L,11111111111L,1101000000000L,1111111111111L,110000000000000L,11111111111111L,11100000000000000L,10111111111111111L,1110000000000000000L,1111111111111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288297Inst : IEnumerable<long>
{
public static readonly long[] Value=A288297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288297.Bytes);
public long this[int i]=>Value[i];

public static A288297Inst Instance=new A288297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288296
{
public static readonly BigInteger[] Value={ 1L,10L,1L,1110L,11L,111100L,11L,11111110L,1L,1111111110L,1L,111111111110L,1011L,11111111111110L,11L,1111111111111100L,111L,111111111111111010L,111L,11111111111111111110UL,1L,BigInteger.Parse("1111111111111111111110"),11L,BigInteger.Parse("111111111111111111111100"),111L,BigInteger.Parse("11111111111111111111111010") };
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
public class A288296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288296Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288296.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288296Inst Instance=new A288296Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288295
{
public static readonly long[] Value={ 1L,3L,6L,7L,24L,15L,120L,255L,96L,831L,960L,4095L,7680L,13311L,14720L,57343L,122368L,127999L,474112L,106495L,1892352L,933887L,6533120L,3735551L,29278208L,25427967L,83869696L,130547711L,528416768L,25165823L,2098823168L,4261412863L,1743650816L,17043816447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288295Inst : IEnumerable<long>
{
public static readonly long[] Value=A288295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288295.Bytes);
public long this[int i]=>Value[i];

public static A288295Inst Instance=new A288295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288294
{
public static readonly long[] Value={ 1L,3L,3L,14L,3L,60L,15L,255L,12L,1011L,30L,4095L,15L,16371L,206L,65531L,247L,261950L,487L,1048472L,231L,4194076L,1763L,16776988L,1787L,67108614L,8185L,268435006L,8159L,1073741728L,52319L,4294967231L,61388L,17179811775L,127939L,68719476734L,903L,274877906424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288294Inst : IEnumerable<long>
{
public static readonly long[] Value=A288294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288294.Bytes);
public long this[int i]=>Value[i];

public static A288294Inst Instance=new A288294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288293
{
public static readonly long[] Value={ 1L,11L,110L,111L,11000L,1111L,1111000L,11111111L,1100000L,1100111111L,1111000000L,111111111111L,1111000000000L,11001111111111L,11100110000000L,1101111111111111L,11101111000000000L,11111001111111111L,1110011110000000000L,11001111111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288293Inst : IEnumerable<long>
{
public static readonly long[] Value=A288293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288293.Bytes);
public long this[int i]=>Value[i];

public static A288293Inst Instance=new A288293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288292
{
public static readonly BigInteger[] Value={ 1L,11L,11L,1110L,11L,111100L,1111L,11111111L,1100L,1111110011L,11110L,111111111111L,1111L,11111111110011L,11001110L,1111111111111011L,11110111L,111111111100111110L,111100111L,11111111111110011000UL,11100111L,BigInteger.Parse("1111111111111100011100"),11011100011L };
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
public class A288292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288292Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288292.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288292Inst Instance=new A288292Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288290
{
public static readonly BigInteger[] Value={ BigInteger.Parse("28449551653853229900"),BigInteger.Parse("5131008990500486096250"),BigInteger.Parse("447964809766718459342400"),BigInteger.Parse("25606868770179512447281320"),BigInteger.Parse("1088463806617771584122226336"),BigInteger.Parse("36940703720927769833985462240"),BigInteger.Parse("1047632171592441142843472246400"),BigInteger.Parse("25624962301264473700614835484334"),BigInteger.Parse("553279524558089394499396612588296"),BigInteger.Parse("10733417717473916970871163704143300"),BigInteger.Parse("189705897479950023040270728219928512") };
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
public class A288290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288290Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288290.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288290Inst Instance=new A288290Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288289
{
public static readonly BigInteger[] Value={ 2682208751185413450L,BigInteger.Parse("447016944351510642564"),BigInteger.Parse("36188783145801243558900"),BigInteger.Parse("1924446945220467632598816"),BigInteger.Parse("76330117260895762678976496"),BigInteger.Parse("2424036981927621898592714592"),BigInteger.Parse("64495258714680679471831890624"),BigInteger.Parse("1483610943246601143976044602400"),BigInteger.Parse("30193909664655985735143003641892"),BigInteger.Parse("553279524558089394499396612588296"),BigInteger.Parse("9254922250232295721515866705613000"),BigInteger.Parse("142890407229849701818261896174135456") };
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
public class A288289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288289Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288289.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288289Inst Instance=new A288289Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288288
{
public static readonly BigInteger[] Value={ 233454817237201560L,BigInteger.Parse("35801820369640556595"),BigInteger.Parse("2677324515710001081372"),BigInteger.Parse("131989618396827099239715"),BigInteger.Parse("4869474711666664850333856"),BigInteger.Parse("144282707675416905279319800"),BigInteger.Parse("3591928999997575304490876960"),BigInteger.Parse("77515666515764938993111323048"),BigInteger.Parse("1483610943246601143976044602400"),BigInteger.Parse("25624962301264473700614835484334"),BigInteger.Parse("404881818003827869935873694190904"),BigInteger.Parse("5916336815178383154031082792690874") };
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
public class A288288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288288Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288288.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288288Inst Instance=new A288288Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288287
{
public static readonly BigInteger[] Value={ 18475997006212200L,2595050050431235488L,BigInteger.Parse("178505550201444784920"),BigInteger.Parse("8127109896970086044280"),BigInteger.Parse("277921666244135490925320"),BigInteger.Parse("7658941714130456546009472"),BigInteger.Parse("177889367903895880526289600"),BigInteger.Parse("3591928999997575304490876960"),BigInteger.Parse("64495258714680679471831890624"),BigInteger.Parse("1047632171592441142843472246400"),BigInteger.Parse("15602830991918991492377865030768"),BigInteger.Parse("215367527001361085125596104693328") };
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
public class A288287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288287Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288287.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288287Inst Instance=new A288287Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288235
{
public static readonly long[] Value={ 1L,3L,5L,9L,17L,30L,52L,91L,160L,281L,493L,865L,1518L,2664L,4675L,8204L,14397L,25265L,44337L,77805L,136534L,239592L,420441L,737798L,1294700L,2271961L,3986877L,6996242L,12277127L,21544115L,37805987L,66342603L,116419152L,204294349L,358499270L,629100742L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288235Inst : IEnumerable<long>
{
public static readonly long[] Value=A288235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288235.Bytes);
public long this[int i]=>Value[i];

public static A288235Inst Instance=new A288235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288234
{
public static readonly long[] Value={ 1L,3L,5L,9L,17L,30L,52L,91L,160L,281L,493L,865L,1518L,2664L,4675L,8204L,14398L,25271L,44356L,77853L,136647L,239844L,420976L,738898L,1296915L,2276349L,3995455L,7012834L,12308945L,21604693L,37920614L,66558359L,116823399L,205048721L,359902025L,631700929L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288234Inst : IEnumerable<long>
{
public static readonly long[] Value=A288234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288234.Bytes);
public long this[int i]=>Value[i];

public static A288234Inst Instance=new A288234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288233
{
public static readonly long[] Value={ 1L,3L,5L,9L,17L,30L,52L,91L,160L,281L,494L,871L,1537L,2711L,4782L,8437L,14885L,26258L,46319L,81706L,144126L,254229L,448442L,791021L,1395308L,2461230L,4341448L,7658035L,13508286L,23827758L,42030652L,74139404L,130777206L,230682689L,406909610L,717762700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288233Inst : IEnumerable<long>
{
public static readonly long[] Value=A288233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288233.Bytes);
public long this[int i]=>Value[i];

public static A288233Inst Instance=new A288233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288232
{
public static readonly long[] Value={ 1L,3L,5L,9L,17L,30L,52L,91L,160L,281L,494L,871L,1537L,2711L,4782L,8437L,14885L,26258L,46320L,81712L,144145L,254277L,448555L,791273L,1395843L,2462330L,4343663L,7662423L,13516866L,23844368L,42062554L,74200268L,130892661L,230900629L,407319256L,718529778L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288232Inst : IEnumerable<long>
{
public static readonly long[] Value=A288232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288232.Bytes);
public long this[int i]=>Value[i];

public static A288232Inst Instance=new A288232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288231
{
public static readonly long[] Value={ 1L,3L,5L,9L,18L,36L,71L,138L,268L,522L,1017L,1981L,3859L,7517L,14642L,28521L,55557L,108223L,210814L,410654L,799931L,1558224L,3035341L,5912689L,11517614L,22435718L,43703622L,85132404L,165833537L,323035186L,629255898L,1225758065L,2387713549L,4651142959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288231Inst : IEnumerable<long>
{
public static readonly long[] Value=A288231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288231.Bytes);
public long this[int i]=>Value[i];

public static A288231Inst Instance=new A288231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288230
{
public static readonly long[] Value={ 1L,3L,5L,9L,18L,36L,71L,138L,268L,522L,1017L,1980L,3853L,7498L,14594L,28406L,55287L,107604L,209428L,407608L,793325L,1544042L,3005154L,5848902L,11383662L,22155913L,43121842L,83927627L,163347533L,317921733L,618768013L,1204302235L,2343921860L,4561952576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288230Inst : IEnumerable<long>
{
public static readonly long[] Value=A288230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288230.Bytes);
public long this[int i]=>Value[i];

public static A288230Inst Instance=new A288230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288229
{
public static readonly long[] Value={ 1L,3L,5L,9L,18L,36L,72L,144L,287L,570L,1132L,2250L,4473L,8892L,17676L,35137L,69847L,138845L,276002L,548649L,1090629L,2168001L,4309649L,8566912L,17029689L,33852374L,67293256L,133768530L,265911039L,528589801L,1050754338L,2088736250L,4152082903L,8253695235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288229Inst : IEnumerable<long>
{
public static readonly long[] Value=A288229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288229.Bytes);
public long this[int i]=>Value[i];

public static A288229Inst Instance=new A288229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288228
{
public static readonly long[] Value={ 3L,4L,5L,6L,7L,9L,10L,11L,12L,14L,15L,16L,21L,22L,23L,24L,25L,26L,27L,28L,29L,31L,32L,33L,34L,35L,36L,37L,38L,40L,41L,42L,43L,44L,45L,46L,48L,49L,50L,51L,52L,53L,55L,56L,57L,58L,59L,61L,62L,63L,64L,66L,67L,68L,73L,74L,75L,76L,78L,79L,80L,81L,82L,83L,84L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288228Inst : IEnumerable<long>
{
public static readonly long[] Value=A288228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288228.Bytes);
public long this[int i]=>Value[i];

public static A288228Inst Instance=new A288228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288227
{
public static readonly long[] Value={ 1L,2L,8L,13L,17L,18L,19L,20L,30L,39L,47L,54L,60L,65L,69L,70L,71L,72L,77L,91L,104L,116L,127L,137L,146L,154L,161L,167L,172L,176L,177L,178L,180L,181L,182L,199L,217L,234L,250L,265L,279L,292L,304L,315L,325L,334L,342L,349L,355L,360L,364L,365L,366L,368L,369L,370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288227Inst : IEnumerable<long>
{
public static readonly long[] Value=A288227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288227.Bytes);
public long this[int i]=>Value[i];

public static A288227Inst Instance=new A288227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288226
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288226Inst : IEnumerable<long>
{
public static readonly long[] Value=A288226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288226.Bytes);
public long this[int i]=>Value[i];

public static A288226Inst Instance=new A288226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288225
{
public static readonly long[] Value={ 2L,4L,10L,12L,17L,21L,24L,26L,32L,35L,37L,41L,46L,48L,53L,57L,60L,62L,67L,69L,75L,79L,82L,84L,88L,93L,96L,98L,104L,106L,111L,115L,118L,120L,126L,129L,131L,135L,140L,143L,145L,151L,153L,158L,162L,165L,167L,171L,176L,180L,183L,185L,190L,192L,198L,200L,205L,209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288225Inst : IEnumerable<long>
{
public static readonly long[] Value=A288225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288225.Bytes);
public long this[int i]=>Value[i];

public static A288225Inst Instance=new A288225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288224
{
public static readonly long[] Value={ 1L,3L,5L,6L,7L,8L,9L,11L,13L,14L,15L,16L,18L,19L,20L,22L,23L,25L,27L,28L,29L,30L,31L,33L,34L,36L,38L,39L,40L,42L,43L,44L,45L,47L,49L,50L,51L,52L,54L,55L,56L,58L,59L,61L,63L,64L,65L,66L,68L,70L,71L,72L,73L,74L,76L,77L,78L,80L,81L,83L,85L,86L,87L,89L,90L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288224Inst : IEnumerable<long>
{
public static readonly long[] Value=A288224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288224.Bytes);
public long this[int i]=>Value[i];

public static A288224Inst Instance=new A288224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288223
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288223Inst : IEnumerable<long>
{
public static readonly long[] Value=A288223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288223.Bytes);
public long this[int i]=>Value[i];

public static A288223Inst Instance=new A288223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288222
{
public static readonly long[] Value={ 1L,6L,10L,13L,15L,20L,22L,28L,32L,35L,37L,41L,46L,49L,51L,57L,59L,64L,68L,71L,73L,78L,80L,86L,88L,93L,97L,100L,102L,108L,111L,113L,117L,122L,126L,129L,131L,135L,140L,143L,145L,151L,153L,158L,162L,165L,167L,171L,176L,180L,183L,185L,190L,192L,198L,201L,203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288222Inst : IEnumerable<long>
{
public static readonly long[] Value=A288222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288222.Bytes);
public long this[int i]=>Value[i];

public static A288222Inst Instance=new A288222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288221
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,8L,9L,11L,12L,14L,16L,17L,18L,19L,21L,23L,24L,25L,26L,27L,29L,30L,31L,33L,34L,36L,38L,39L,40L,42L,43L,44L,45L,47L,48L,50L,52L,53L,54L,55L,56L,58L,60L,61L,62L,63L,65L,66L,67L,69L,70L,72L,74L,75L,76L,77L,79L,81L,82L,83L,84L,85L,87L,89L,90L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288221Inst : IEnumerable<long>
{
public static readonly long[] Value=A288221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288221.Bytes);
public long this[int i]=>Value[i];

public static A288221Inst Instance=new A288221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288220
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288220Inst : IEnumerable<long>
{
public static readonly long[] Value=A288220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288220.Bytes);
public long this[int i]=>Value[i];

public static A288220Inst Instance=new A288220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288139
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,17L,16L,18L,19L,20L,21L,22L,23L,25L,24L,26L,27L,29L,28L,30L,34L,31L,33L,32L,35L,36L,37L,38L,39L,41L,40L,42L,43L,45L,44L,46L,50L,47L,49L,48L,51L,53L,52L,54L,58L,55L,57L,56L,60L,68L,61L,59L,69L,62L,66L,63L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288139Inst : IEnumerable<long>
{
public static readonly long[] Value=A288139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288139.Bytes);
public long this[int i]=>Value[i];

public static A288139Inst Instance=new A288139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288138
{
public static readonly long[] Value={ 1L,3L,6L,7L,28L,63L,56L,223L,496L,511L,1760L,3967L,4032L,14335L,31616L,32255L,114432L,253951L,257536L,915455L,2030592L,2064383L,7321600L,16244735L,16510976L,58589183L,129949696L,132087807L,468697088L,1039663103L,1056669696L,3749576703L,8317239296L,8453619711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288138Inst : IEnumerable<long>
{
public static readonly long[] Value=A288138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288138.Bytes);
public long this[int i]=>Value[i];

public static A288138Inst Instance=new A288138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288137
{
public static readonly long[] Value={ 1L,3L,3L,14L,7L,63L,14L,251L,31L,1022L,59L,4079L,126L,16379L,239L,65470L,507L,262127L,958L,1048315L,2031L,4194238L,3835L,16776175L,8126L,67108603L,15343L,268431294L,32507L,1073740783L,61374L,4294950651L,130031L,17179865022L,245499L,68719410159L,520126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288137Inst : IEnumerable<long>
{
public static readonly long[] Value=A288137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288137.Bytes);
public long this[int i]=>Value[i];

public static A288137Inst Instance=new A288137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288136
{
public static readonly ulong[] Value={ 1L,11L,110L,111L,11100L,111111L,111000L,11011111L,111110000L,111111111L,11011100000L,111101111111L,111111000000L,11011111111111L,111101110000000L,111110111111111L,11011111100000000L,111101111111111111L,111110111000000000L,11011111011111111111UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288136Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A288136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288136.Bytes);
public ulong this[int i]=>Value[i];

public static A288136Inst Instance=new A288136Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}