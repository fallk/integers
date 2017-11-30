using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A035136
{
public static readonly long[] Value={ 86L,429L,7396L,12L,648L,551L,3927L,471L,144L,5087L,861L,72L,1612L,1728L,131L,5070L,399L,9111L,1875L,151L,3760L,2004L,1595L,3436L,678L,446L,2039L,707L,5138L,2921L,287L,1439L,783L,563L,2973L,2613L,1788L,5686L,7023L,185L,662L,1042L,1855L,1906L,3682L,449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035136Inst : IEnumerable<long>
{
public static readonly long[] Value=A035136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035136.Bytes);
public long this[int i]=>Value[i];

public static A035136Inst Instance=new A035136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035137
{
public static readonly long[] Value={ 21L,32L,43L,54L,65L,76L,87L,98L,201L,1031L,1041L,1042L,1051L,1052L,1053L,1061L,1062L,1063L,1064L,1071L,1072L,1073L,1074L,1075L,1081L,1082L,1083L,1084L,1085L,1086L,1091L,1092L,1093L,1094L,1095L,1096L,1097L,1099L,1101L,1103L,1104L,1105L,1106L,1107L,1108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035137Inst : IEnumerable<long>
{
public static readonly long[] Value=A035137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035137.Bytes);
public long this[int i]=>Value[i];

public static A035137Inst Instance=new A035137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035138
{
public static readonly long[] Value={ 1L,594L,746L,986L,1000000009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035138Inst : IEnumerable<long>
{
public static readonly long[] Value=A035138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035138.Bytes);
public long this[int i]=>Value[i];

public static A035138Inst Instance=new A035138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035139
{
public static readonly long[] Value={ 1L,4L,6L,8L,9L,10L,14L,16L,18L,21L,27L,34L,38L,40L,44L,46L,48L,49L,54L,56L,57L,58L,60L,64L,66L,68L,69L,76L,78L,80L,81L,84L,86L,87L,88L,90L,96L,98L,99L,100L,106L,108L,111L,116L,118L,129L,134L,140L,144L,146L,148L,158L,160L,161L,166L,168L,174L,177L,180L,184L,188L,189L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035139Inst : IEnumerable<long>
{
public static readonly long[] Value=A035139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035139.Bytes);
public long this[int i]=>Value[i];

public static A035139Inst Instance=new A035139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035140
{
public static readonly long[] Value={ 25L,32L,121L,125L,128L,132L,135L,143L,175L,187L,243L,250L,256L,295L,312L,324L,341L,351L,375L,432L,451L,512L,625L,671L,679L,735L,781L,875L,928L,932L,1023L,1024L,1053L,1057L,1207L,1243L,1250L,1255L,1324L,1325L,1328L,1331L,1352L,1359L,1372L,1375L,1377L,1379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035140Inst : IEnumerable<long>
{
public static readonly long[] Value=A035140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035140.Bytes);
public long this[int i]=>Value[i];

public static A035140Inst Instance=new A035140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035141
{
public static readonly long[] Value={ 132L,312L,735L,1255L,1377L,1775L,1972L,3792L,4371L,4773L,5192L,6769L,7112L,7236L,7371L,7539L,9321L,11009L,11099L,11132L,11163L,11232L,11255L,11375L,11913L,12176L,12326L,12595L,12955L,13092L,13175L,13312L,13377L,13491L,13755L,14842L,15033L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035141Inst : IEnumerable<long>
{
public static readonly long[] Value=A035141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035141.Bytes);
public long this[int i]=>Value[i];

public static A035141Inst Instance=new A035141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035142
{
public static readonly long[] Value={ 0L,1L,2L,6L,20L,29L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035142Inst : IEnumerable<long>
{
public static readonly long[] Value=A035142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035142.Bytes);
public long this[int i]=>Value[i];

public static A035142Inst Instance=new A035142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035143
{
public static readonly long[] Value={ 1L,2L,2L,3L,0L,4L,2L,4L,3L,0L,0L,6L,0L,4L,0L,5L,2L,6L,0L,0L,4L,0L,0L,8L,1L,0L,4L,6L,0L,0L,0L,6L,0L,4L,0L,9L,2L,0L,0L,0L,0L,8L,0L,0L,0L,0L,1L,10L,3L,2L,4L,0L,2L,8L,0L,8L,0L,0L,2L,0L,2L,0L,6L,7L,0L,0L,0L,6L,0L,0L,2L,12L,0L,4L,2L,0L,0L,0L,2L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035143Inst : IEnumerable<long>
{
public static readonly long[] Value=A035143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035143.Bytes);
public long this[int i]=>Value[i];

public static A035143Inst Instance=new A035143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035144
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,0L,0L,1L,1L,2L,2L,0L,0L,0L,0L,1L,0L,1L,2L,2L,0L,2L,1L,0L,3L,0L,0L,0L,0L,0L,2L,1L,0L,0L,0L,1L,2L,2L,0L,2L,2L,0L,2L,2L,2L,1L,2L,0L,1L,3L,0L,0L,2L,0L,4L,0L,0L,0L,0L,0L,2L,2L,0L,1L,0L,0L,2L,0L,0L,0L,2L,1L,2L,2L,0L,2L,0L,0L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035144Inst : IEnumerable<long>
{
public static readonly long[] Value=A035144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035144.Bytes);
public long this[int i]=>Value[i];

public static A035144Inst Instance=new A035144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035145
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,0L,2L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,2L,0L,2L,0L,1L,0L,1L,2L,2L,0L,0L,0L,0L,0L,2L,1L,0L,0L,0L,0L,2L,0L,2L,0L,1L,0L,2L,1L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,0L,2L,1L,0L,0L,2L,0L,2L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035145Inst : IEnumerable<long>
{
public static readonly long[] Value=A035145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035145.Bytes);
public long this[int i]=>Value[i];

public static A035145Inst Instance=new A035145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035146
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,0L,1L,3L,2L,1L,2L,0L,0L,4L,1L,0L,3L,0L,2L,0L,1L,2L,2L,3L,0L,4L,0L,0L,4L,2L,1L,2L,0L,0L,3L,2L,0L,0L,2L,0L,0L,0L,1L,6L,2L,2L,2L,1L,3L,0L,0L,2L,4L,2L,0L,0L,0L,2L,4L,0L,2L,0L,1L,0L,2L,2L,0L,4L,0L,2L,3L,0L,2L,6L,0L,0L,0L,0L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035146Inst : IEnumerable<long>
{
public static readonly long[] Value=A035146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035146.Bytes);
public long this[int i]=>Value[i];

public static A035146Inst Instance=new A035146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035147
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,2L,0L,2L,0L,0L,1L,2L,0L,0L,0L,0L,0L,2L,0L,1L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,1L,0L,0L,0L,0L,2L,0L,1L,2L,0L,0L,2L,0L,1L,0L,0L,2L,2L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,1L,0L,0L,2L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035147Inst : IEnumerable<long>
{
public static readonly long[] Value=A035147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035147.Bytes);
public long this[int i]=>Value[i];

public static A035147Inst Instance=new A035147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035148
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,2L,1L,0L,1L,2L,1L,0L,0L,1L,0L,2L,1L,1L,2L,1L,1L,2L,0L,2L,1L,0L,2L,0L,1L,0L,0L,2L,0L,2L,1L,2L,0L,0L,2L,0L,1L,1L,1L,2L,2L,2L,1L,0L,1L,0L,2L,2L,0L,2L,2L,1L,1L,0L,0L,2L,2L,2L,0L,2L,1L,0L,0L,1L,0L,0L,2L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035148Inst : IEnumerable<long>
{
public static readonly long[] Value=A035148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035148.Bytes);
public long this[int i]=>Value[i];

public static A035148Inst Instance=new A035148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035149
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,2L,4L,3L,4L,2L,6L,0L,4L,4L,5L,0L,6L,2L,6L,4L,4L,0L,8L,3L,0L,4L,6L,0L,8L,0L,6L,4L,0L,4L,9L,2L,4L,0L,8L,1L,8L,0L,6L,6L,0L,2L,10L,3L,6L,0L,0L,0L,8L,4L,8L,4L,0L,0L,12L,2L,0L,6L,7L,0L,8L,2L,0L,0L,8L,2L,12L,2L,4L,6L,6L,4L,0L,2L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035149Inst : IEnumerable<long>
{
public static readonly long[] Value=A035149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035149.Bytes);
public long this[int i]=>Value[i];

public static A035149Inst Instance=new A035149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035150
{
public static readonly long[] Value={ 1L,-96L,4464L,-133760L,2897880L,-48264768L,641207744L,-6954435840L,62452035180L,-467536231520L,2916146241888L,-14993052561792L,61695767581248L,-187599812159040L,302907998183040L,676931170946304L,-7255673126427378L,28908305661771648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035150Inst : IEnumerable<long>
{
public static readonly long[] Value=A035150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035150.Bytes);
public long this[int i]=>Value[i];

public static A035150Inst Instance=new A035150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035151
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,2L,0L,4L,1L,4L,2L,3L,1L,0L,2L,5L,0L,2L,0L,6L,0L,4L,0L,4L,3L,2L,1L,0L,0L,4L,0L,6L,2L,0L,0L,3L,0L,0L,1L,8L,2L,0L,2L,6L,2L,0L,2L,5L,1L,6L,0L,3L,0L,2L,4L,0L,0L,0L,2L,6L,2L,0L,0L,7L,2L,4L,0L,0L,0L,0L,2L,4L,0L,0L,3L,0L,0L,2L,2L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035151Inst : IEnumerable<long>
{
public static readonly long[] Value=A035151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035151.Bytes);
public long this[int i]=>Value[i];

public static A035151Inst Instance=new A035151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035152
{
public static readonly long[] Value={ 1L,1L,2L,1L,0L,2L,2L,1L,3L,0L,0L,2L,2L,2L,0L,1L,2L,3L,1L,0L,4L,0L,2L,2L,1L,2L,4L,2L,2L,0L,0L,1L,0L,2L,0L,3L,2L,1L,4L,0L,0L,4L,0L,0L,0L,2L,2L,2L,3L,1L,4L,2L,2L,4L,0L,2L,2L,2L,2L,0L,0L,0L,6L,1L,0L,0L,2L,2L,4L,0L,0L,3L,2L,2L,2L,1L,0L,4L,0L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035152Inst : IEnumerable<long>
{
public static readonly long[] Value=A035152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035152.Bytes);
public long this[int i]=>Value[i];

public static A035152Inst Instance=new A035152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035153
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,2L,0L,0L,0L,2L,0L,1L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,1L,1L,0L,0L,0L,2L,0L,2L,0L,0L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,2L,0L,0L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035153Inst : IEnumerable<long>
{
public static readonly long[] Value=A035153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035153.Bytes);
public long this[int i]=>Value[i];

public static A035153Inst Instance=new A035153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035154
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,0L,1L,1L,2L,0L,1L,2L,0L,2L,1L,2L,1L,0L,2L,0L,0L,0L,1L,3L,2L,1L,0L,2L,2L,0L,1L,0L,2L,0L,1L,2L,0L,2L,2L,2L,0L,0L,0L,2L,0L,0L,1L,1L,3L,2L,2L,2L,1L,0L,0L,0L,2L,0L,2L,2L,0L,0L,1L,4L,0L,0L,2L,0L,0L,0L,1L,2L,2L,3L,0L,0L,2L,0L,2L,1L,2L,0L,0L,4L,0L,2L,0L,2L,2L,0L,0L,0L,0L,0L,1L,2L,1L,0L,3L,2L,2L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035154Inst : IEnumerable<long>
{
public static readonly long[] Value=A035154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035154.Bytes);
public long this[int i]=>Value[i];

public static A035154Inst Instance=new A035154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035155
{
public static readonly long[] Value={ 1L,0L,2L,1L,1L,0L,1L,0L,3L,0L,2L,2L,2L,0L,2L,1L,2L,0L,0L,1L,2L,0L,0L,0L,1L,0L,4L,1L,2L,0L,0L,0L,4L,0L,1L,3L,0L,0L,4L,0L,0L,0L,0L,2L,3L,0L,2L,2L,1L,0L,4L,2L,0L,0L,2L,0L,0L,0L,0L,2L,0L,0L,3L,1L,2L,0L,0L,2L,0L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035155Inst : IEnumerable<long>
{
public static readonly long[] Value=A035155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035155.Bytes);
public long this[int i]=>Value[i];

public static A035155Inst Instance=new A035155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035156
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,0L,2L,1L,1L,2L,0L,0L,0L,2L,0L,1L,1L,1L,2L,2L,0L,0L,2L,0L,3L,0L,0L,2L,2L,0L,2L,1L,0L,1L,4L,1L,2L,2L,0L,2L,0L,0L,2L,0L,2L,2L,0L,0L,3L,3L,0L,0L,0L,0L,0L,2L,0L,2L,2L,0L,2L,2L,2L,1L,0L,0L,2L,1L,0L,4L,2L,1L,0L,2L,0L,2L,0L,0L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035156Inst : IEnumerable<long>
{
public static readonly long[] Value=A035156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035156.Bytes);
public long this[int i]=>Value[i];

public static A035156Inst Instance=new A035156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035157
{
public static readonly long[] Value={ 1L,2L,1L,3L,0L,2L,2L,4L,1L,0L,1L,3L,0L,4L,0L,5L,2L,2L,2L,0L,2L,2L,2L,4L,1L,0L,1L,6L,2L,0L,0L,6L,1L,4L,0L,3L,2L,4L,0L,0L,2L,4L,2L,3L,0L,4L,2L,5L,3L,2L,2L,0L,0L,2L,0L,8L,2L,4L,2L,0L,0L,0L,2L,7L,0L,2L,0L,6L,2L,0L,2L,4L,0L,4L,1L,6L,2L,0L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035157Inst : IEnumerable<long>
{
public static readonly long[] Value=A035157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035157.Bytes);
public long this[int i]=>Value[i];

public static A035157Inst Instance=new A035157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035158
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,3L,5L,5L,5L,5L,7L,7L,10L,10L,10L,10L,13L,13L,16L,16L,16L,16L,19L,19L,19L,19L,19L,19L,22L,22L,26L,26L,26L,26L,26L,26L,29L,29L,29L,29L,33L,33L,37L,37L,37L,37L,40L,40L,40L,40L,40L,40L,44L,44L,44L,44L,44L,44L,49L,49L,53L,53L,53L,53L,53L,53L,57L,57L,57L,57L,61L,61L,65L,65L,65L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035158Inst : IEnumerable<long>
{
public static readonly long[] Value=A035158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035158.Bytes);
public long this[int i]=>Value[i];

public static A035158Inst Instance=new A035158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035159
{
public static readonly long[] Value={ 1L,2L,0L,3L,2L,0L,2L,4L,1L,4L,0L,0L,0L,4L,0L,5L,0L,2L,2L,6L,0L,0L,0L,0L,3L,0L,0L,6L,0L,0L,1L,6L,0L,0L,4L,3L,0L,4L,0L,8L,2L,0L,0L,0L,2L,0L,2L,0L,3L,6L,0L,0L,0L,0L,0L,8L,0L,0L,2L,0L,0L,2L,2L,7L,0L,0L,2L,0L,0L,8L,2L,4L,0L,0L,0L,6L,0L,0L,0L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035159Inst : IEnumerable<long>
{
public static readonly long[] Value=A035159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035159.Bytes);
public long this[int i]=>Value[i];

public static A035159Inst Instance=new A035159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035160
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,2L,1L,2L,0L,1L,1L,2L,1L,0L,1L,0L,2L,2L,1L,1L,2L,1L,0L,2L,1L,2L,1L,2L,2L,0L,1L,2L,0L,2L,1L,0L,0L,2L,2L,1L,2L,2L,1L,1L,1L,2L,2L,0L,1L,2L,0L,0L,2L,2L,1L,0L,2L,0L,1L,2L,2L,2L,2L,2L,0L,0L,1L,0L,2L,1L,0L,0L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035160Inst : IEnumerable<long>
{
public static readonly long[] Value=A035160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035160.Bytes);
public long this[int i]=>Value[i];

public static A035160Inst Instance=new A035160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035161
{
public static readonly long[] Value={ 1L,0L,2L,1L,2L,0L,0L,0L,3L,0L,2L,2L,2L,0L,4L,1L,0L,0L,2L,2L,0L,0L,0L,0L,3L,0L,4L,0L,1L,0L,2L,0L,4L,0L,0L,3L,0L,0L,4L,0L,0L,0L,2L,2L,6L,0L,2L,2L,1L,0L,0L,2L,2L,0L,4L,0L,4L,0L,0L,4L,0L,0L,0L,1L,4L,0L,0L,0L,0L,0L,0L,0L,0L,0L,6L,2L,0L,0L,2L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035161Inst : IEnumerable<long>
{
public static readonly long[] Value=A035161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035161.Bytes);
public long this[int i]=>Value[i];

public static A035161Inst Instance=new A035161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035162
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,2L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,2L,2L,0L,1L,0L,0L,1L,2L,0L,0L,1L,0L,0L,0L,1L,2L,0L,0L,0L,0L,0L,2L,2L,0L,2L,0L,0L,1L,1L,0L,0L,2L,0L,0L,1L,0L,2L,0L,0L,0L,0L,1L,1L,0L,0L,2L,0L,0L,0L,2L,1L,0L,2L,0L,0L,2L,0L,2L,0L,1L,0L,0L,0L,0L,2L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,0L,1L,2L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035162Inst : IEnumerable<long>
{
public static readonly long[] Value=A035162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035162.Bytes);
public long this[int i]=>Value[i];

public static A035162Inst Instance=new A035162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035163
{
public static readonly long[] Value={ 15L,91L,289L,319L,435L,561L,692L,703L,1016L,1105L,1369L,1495L,1729L,1885L,1891L,2105L,2465L,2701L,2755L,2821L,3367L,4371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035163Inst : IEnumerable<long>
{
public static readonly long[] Value=A035163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035163.Bytes);
public long this[int i]=>Value[i];

public static A035163Inst Instance=new A035163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035164
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,2L,1L,3L,2L,0L,2L,1L,2L,4L,1L,2L,3L,0L,2L,4L,0L,0L,2L,3L,1L,4L,2L,0L,4L,2L,1L,0L,2L,4L,3L,2L,0L,2L,2L,0L,4L,2L,0L,6L,0L,2L,2L,3L,3L,4L,1L,0L,4L,0L,2L,0L,0L,0L,4L,0L,2L,6L,1L,2L,0L,0L,2L,0L,4L,2L,3L,0L,2L,6L,0L,0L,2L,0L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035164Inst : IEnumerable<long>
{
public static readonly long[] Value=A035164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035164.Bytes);
public long this[int i]=>Value[i];

public static A035164Inst Instance=new A035164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035165
{
public static readonly long[] Value={ 1L,2L,0L,3L,1L,0L,0L,4L,1L,2L,0L,0L,2L,0L,0L,5L,2L,2L,0L,3L,0L,0L,0L,0L,1L,4L,0L,0L,2L,0L,0L,6L,0L,4L,0L,3L,2L,0L,0L,4L,2L,0L,0L,0L,1L,0L,0L,0L,1L,2L,0L,6L,2L,0L,0L,0L,0L,4L,0L,0L,2L,0L,0L,7L,2L,0L,0L,6L,0L,0L,0L,4L,2L,4L,0L,0L,0L,0L,0L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035165Inst : IEnumerable<long>
{
public static readonly long[] Value=A035165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035165.Bytes);
public long this[int i]=>Value[i];

public static A035165Inst Instance=new A035165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035166
{
public static readonly long[] Value={ 1L,10L,15L,20L,25L,42L,49L,50L,55L,66L,75L,78L,91L,100L,110L,121L,125L,136L,153L,156L,164L,169L,171L,182L,189L,190L,205L,250L,253L,272L,276L,289L,294L,342L,343L,354L,361L,375L,406L,413L,435L,465L,473L,496L,500L,506L,516L,529L,555L,592L,605L,625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035166Inst : IEnumerable<long>
{
public static readonly long[] Value=A035166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035166.Bytes);
public long this[int i]=>Value[i];

public static A035166Inst Instance=new A035166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035167
{
public static readonly long[] Value={ 1L,2L,2L,3L,0L,4L,0L,4L,3L,0L,0L,6L,2L,0L,0L,5L,0L,6L,0L,0L,0L,0L,1L,8L,1L,4L,4L,0L,2L,0L,2L,6L,0L,0L,0L,9L,0L,0L,4L,0L,2L,0L,0L,0L,0L,2L,2L,10L,1L,2L,0L,6L,0L,8L,0L,0L,0L,4L,2L,0L,0L,4L,0L,7L,0L,0L,0L,0L,2L,0L,2L,12L,2L,0L,2L,0L,0L,8L,0L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035167Inst : IEnumerable<long>
{
public static readonly long[] Value=A035167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035167.Bytes);
public long this[int i]=>Value[i];

public static A035167Inst Instance=new A035167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035168
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,2L,0L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,1L,2L,0L,0L,2L,0L,2L,1L,0L,0L,0L,1L,0L,2L,0L,0L,0L,0L,2L,1L,0L,2L,2L,0L,1L,1L,0L,2L,0L,0L,0L,0L,0L,2L,0L,0L,2L,2L,0L,1L,0L,0L,0L,0L,0L,0L,2L,1L,0L,0L,0L,2L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035168Inst : IEnumerable<long>
{
public static readonly long[] Value=A035168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035168.Bytes);
public long this[int i]=>Value[i];

public static A035168Inst Instance=new A035168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035169
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,0L,1L,0L,1L,0L,2L,1L,0L,0L,2L,1L,2L,0L,2L,2L,1L,0L,2L,0L,3L,0L,1L,1L,0L,0L,2L,0L,2L,0L,2L,1L,2L,0L,0L,0L,2L,0L,0L,2L,2L,0L,0L,1L,1L,0L,2L,0L,0L,0L,4L,0L,2L,0L,0L,2L,0L,0L,1L,1L,0L,0L,0L,2L,2L,0L,2L,0L,0L,0L,3L,2L,2L,0L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035169Inst : IEnumerable<long>
{
public static readonly long[] Value=A035169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035169.Bytes);
public long this[int i]=>Value[i];

public static A035169Inst Instance=new A035169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035170
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,2L,1L,3L,1L,0L,2L,0L,2L,2L,1L,0L,3L,0L,1L,4L,0L,2L,2L,1L,0L,4L,2L,2L,2L,0L,1L,0L,0L,2L,3L,0L,0L,0L,1L,2L,4L,2L,0L,3L,2L,2L,2L,3L,1L,0L,0L,0L,4L,0L,2L,0L,2L,0L,2L,2L,0L,6L,1L,0L,0L,2L,0L,4L,2L,0L,3L,0L,0L,2L,0L,0L,0L,0L,1L,5L,2L,2L,4L,0L,2L,4L,0L,2L,3L,0L,2L,0L,2L,0L,2L,0L,3L,0L,1L,2L,0L,2L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035170Inst : IEnumerable<long>
{
public static readonly long[] Value=A035170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035170.Bytes);
public long this[int i]=>Value[i];

public static A035170Inst Instance=new A035170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035171
{
public static readonly long[] Value={ 1L,0L,0L,1L,2L,0L,2L,0L,1L,0L,2L,0L,0L,0L,0L,1L,2L,0L,1L,2L,0L,0L,2L,0L,3L,0L,0L,2L,0L,0L,0L,0L,0L,0L,4L,1L,0L,0L,0L,0L,0L,0L,2L,2L,2L,0L,2L,0L,3L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,2L,0L,2L,1L,0L,0L,0L,2L,0L,0L,0L,0L,2L,0L,0L,1L,4L,0L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035171Inst : IEnumerable<long>
{
public static readonly long[] Value=A035171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035171.Bytes);
public long this[int i]=>Value[i];

public static A035171Inst Instance=new A035171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035172
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,2L,1L,0L,0L,0L,1L,2L,1L,2L,0L,0L,2L,0L,1L,1L,0L,1L,0L,0L,0L,0L,1L,2L,2L,0L,1L,0L,2L,0L,0L,2L,0L,2L,2L,0L,0L,0L,1L,1L,1L,2L,0L,0L,1L,0L,0L,2L,0L,2L,0L,0L,0L,0L,1L,0L,2L,2L,2L,0L,0L,0L,1L,2L,0L,1L,2L,0L,0L,0L,0L,1L,2L,2L,0L,0L,2L,0L,2L,2L,0L,0L,0L,0L,0L,0L,1L,2L,1L,2L,1L,0L,2L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035172Inst : IEnumerable<long>
{
public static readonly long[] Value=A035172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035172.Bytes);
public long this[int i]=>Value[i];

public static A035172Inst Instance=new A035172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035173
{
public static readonly long[] Value={ 1L,2L,2L,3L,0L,4L,2L,4L,3L,0L,2L,6L,2L,4L,0L,5L,1L,6L,0L,0L,4L,4L,2L,8L,1L,4L,4L,6L,0L,0L,2L,6L,4L,2L,0L,9L,0L,0L,4L,0L,0L,8L,0L,6L,0L,4L,0L,10L,3L,2L,2L,6L,2L,8L,0L,8L,0L,0L,0L,0L,0L,4L,6L,7L,0L,8L,0L,3L,4L,0L,2L,12L,0L,0L,2L,0L,4L,8L,2L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035173Inst : IEnumerable<long>
{
public static readonly long[] Value=A035173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035173.Bytes);
public long this[int i]=>Value[i];

public static A035173Inst Instance=new A035173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035174
{
public static readonly BigInteger[] Value={ 1L,-24L,-1472L,84480L,987136L,-196706304L,2699296768L,338071388160L,-13641873096704L,-364965248630784L,36697722069188608L,-133296500464680960L,BigInteger.Parse("-71957818786545926144"),BigInteger.Parse("1999978883828768833536"),BigInteger.Parse("99370119662955604738048") };
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
public class A035174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035174Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A035174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035174.Bytes);
public BigInteger this[int i]=>Value[i];

public static A035174Inst Instance=new A035174Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035175
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,2L,0L,4L,1L,2L,0L,3L,0L,0L,1L,5L,2L,2L,2L,3L,0L,0L,2L,4L,1L,0L,1L,0L,0L,2L,2L,6L,0L,4L,0L,3L,0L,4L,0L,4L,0L,0L,0L,0L,1L,4L,2L,5L,1L,2L,2L,0L,2L,2L,0L,0L,2L,0L,0L,3L,2L,4L,0L,7L,0L,0L,0L,6L,2L,0L,0L,4L,0L,0L,1L,6L,0L,0L,2L,5L,1L,0L,2L,0L,2L,0L,0L,0L,0L,2L,0L,6L,2L,4L,2L,6L,0L,2L,0L,3L,0L,4L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035175Inst : IEnumerable<long>
{
public static readonly long[] Value=A035175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035175.Bytes);
public long this[int i]=>Value[i];

public static A035175Inst Instance=new A035175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035176
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,1L,1L,3L,2L,0L,2L,2L,1L,4L,1L,0L,3L,2L,2L,2L,0L,2L,2L,3L,2L,4L,1L,0L,4L,0L,1L,0L,0L,2L,3L,0L,2L,4L,2L,0L,2L,0L,0L,6L,2L,0L,2L,1L,3L,0L,2L,0L,4L,0L,1L,4L,0L,2L,4L,2L,0L,3L,1L,4L,0L,0L,0L,4L,2L,2L,3L,0L,0L,6L,2L,0L,4L,2L,2L,5L,0L,2L,2L,0L,0L,0L,0L,0L,6L,2L,2L,0L,0L,4L,2L,0L,1L,0L,3L,2L,0L,0L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035176Inst : IEnumerable<long>
{
public static readonly long[] Value=A035176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035176.Bytes);
public long this[int i]=>Value[i];

public static A035176Inst Instance=new A035176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035177
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,2L,0L,1L,0L,2L,0L,1L,0L,0L,1L,2L,0L,2L,0L,0L,0L,0L,0L,1L,0L,0L,2L,2L,0L,2L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,2L,0L,3L,0L,0L,1L,2L,0L,0L,0L,0L,0L,2L,0L,2L,0L,2L,1L,0L,0L,2L,2L,0L,0L,2L,0L,0L,0L,0L,2L,4L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035177Inst : IEnumerable<long>
{
public static readonly long[] Value=A035177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035177.Bytes);
public long this[int i]=>Value[i];

public static A035177Inst Instance=new A035177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035178
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,2L,1L,1L,0L,0L,1L,2L,2L,0L,1L,0L,1L,2L,0L,2L,0L,0L,1L,1L,2L,1L,2L,0L,0L,2L,1L,0L,0L,0L,1L,2L,2L,2L,0L,0L,2L,2L,0L,0L,0L,0L,1L,3L,1L,0L,2L,0L,1L,0L,2L,2L,0L,0L,0L,2L,2L,2L,1L,0L,0L,2L,0L,0L,0L,0L,1L,2L,2L,1L,2L,0L,2L,2L,0L,1L,0L,0L,2L,0L,2L,0L,0L,0L,0L,4L,0L,2L,0L,0L,1L,2L,3L,0L,1L,0L,0L,2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035178Inst : IEnumerable<long>
{
public static readonly long[] Value=A035178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035178.Bytes);
public long this[int i]=>Value[i];

public static A035178Inst Instance=new A035178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035179
{
public static readonly long[] Value={ 1L,0L,2L,1L,2L,0L,0L,0L,3L,0L,1L,2L,0L,0L,4L,1L,0L,0L,0L,2L,0L,0L,2L,0L,3L,0L,4L,0L,0L,0L,2L,0L,2L,0L,0L,3L,2L,0L,0L,0L,0L,0L,0L,1L,6L,0L,2L,2L,1L,0L,0L,0L,2L,0L,2L,0L,0L,0L,2L,4L,0L,0L,0L,1L,0L,0L,2L,0L,4L,0L,2L,0L,0L,0L,6L,0L,0L,0L,0L,2L,5L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035179Inst : IEnumerable<long>
{
public static readonly long[] Value=A035179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035179.Bytes);
public long this[int i]=>Value[i];

public static A035179Inst Instance=new A035179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035180
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,2L,1L,1L,1L,2L,0L,2L,2L,0L,1L,0L,1L,2L,1L,0L,2L,2L,0L,1L,2L,0L,2L,0L,0L,0L,1L,0L,0L,2L,1L,2L,2L,0L,1L,2L,0L,0L,2L,1L,2L,2L,0L,3L,1L,0L,2L,2L,0L,2L,2L,0L,0L,2L,0L,0L,0L,2L,1L,2L,0L,0L,0L,0L,2L,0L,1L,0L,2L,0L,2L,4L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035180Inst : IEnumerable<long>
{
public static readonly long[] Value=A035180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035180.Bytes);
public long this[int i]=>Value[i];

public static A035180Inst Instance=new A035180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035197
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,2L,2L,4L,1L,2L,2L,3L,0L,4L,1L,5L,2L,2L,0L,3L,2L,4L,0L,4L,1L,0L,1L,6L,0L,2L,0L,6L,2L,4L,2L,3L,0L,0L,0L,4L,0L,4L,2L,6L,1L,0L,0L,5L,3L,2L,2L,0L,2L,2L,2L,8L,0L,0L,2L,3L,2L,0L,2L,7L,0L,4L,2L,6L,0L,4L,2L,4L,0L,0L,1L,0L,4L,0L,0L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035197Inst : IEnumerable<long>
{
public static readonly long[] Value=A035197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035197.Bytes);
public long this[int i]=>Value[i];

public static A035197Inst Instance=new A035197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035198
{
public static readonly long[] Value={ 1L,9L,17L,25L,41L,73L,81L,89L,97L,113L,121L,137L,153L,169L,193L,225L,233L,241L,257L,281L,289L,313L,337L,353L,361L,369L,401L,409L,425L,433L,449L,457L,521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035198Inst : IEnumerable<long>
{
public static readonly long[] Value=A035198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035198.Bytes);
public long this[int i]=>Value[i];

public static A035198Inst Instance=new A035198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035199
{
public static readonly long[] Value={ 1L,2L,0L,3L,0L,0L,0L,4L,1L,0L,0L,0L,2L,0L,0L,5L,1L,2L,2L,0L,0L,0L,0L,0L,1L,4L,0L,0L,0L,0L,0L,6L,0L,2L,0L,3L,0L,4L,0L,0L,0L,0L,2L,0L,0L,0L,2L,0L,1L,2L,0L,6L,2L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,7L,0L,0L,2L,3L,0L,0L,0L,4L,0L,0L,0L,6L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035199Inst : IEnumerable<long>
{
public static readonly long[] Value=A035199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035199.Bytes);
public long this[int i]=>Value[i];

public static A035199Inst Instance=new A035199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035200
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,2L,1L,1L,0L,0L,1L,0L,2L,0L,1L,2L,1L,0L,0L,2L,0L,2L,1L,1L,0L,1L,2L,0L,0L,2L,1L,0L,2L,0L,1L,0L,0L,0L,0L,2L,2L,0L,0L,0L,2L,2L,1L,3L,1L,2L,0L,0L,1L,0L,2L,0L,0L,0L,0L,0L,2L,2L,1L,0L,0L,0L,2L,2L,0L,2L,1L,2L,0L,1L,0L,0L,0L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035200Inst : IEnumerable<long>
{
public static readonly long[] Value=A035200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035200.Bytes);
public long this[int i]=>Value[i];

public static A035200Inst Instance=new A035200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035201
{
public static readonly long[] Value={ 1L,0L,2L,1L,2L,0L,0L,0L,3L,0L,0L,2L,0L,0L,4L,1L,2L,0L,1L,2L,0L,0L,0L,0L,3L,0L,4L,0L,0L,0L,2L,0L,0L,0L,0L,3L,0L,0L,0L,0L,0L,0L,0L,0L,6L,0L,0L,2L,1L,0L,4L,0L,0L,0L,0L,0L,2L,0L,2L,4L,2L,0L,0L,1L,0L,0L,2L,2L,0L,0L,2L,0L,2L,0L,6L,1L,0L,0L,2L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035201Inst : IEnumerable<long>
{
public static readonly long[] Value=A035201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035201.Bytes);
public long this[int i]=>Value[i];

public static A035201Inst Instance=new A035201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035202
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,2L,0L,0L,0L,0L,1L,0L,1L,2L,1L,0L,2L,0L,0L,1L,0L,0L,0L,2L,0L,2L,1L,0L,0L,0L,1L,0L,2L,0L,1L,2L,0L,0L,2L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,2L,0L,0L,2L,2L,0L,2L,2L,0L,1L,0L,0L,0L,0L,0L,0L,2L,1L,0L,0L,0L,2L,0L,0L,2L,1L,1L,2L,0L,0L,0L,0L,0L,2L,2L,1L,0L,0L,0L,0L,2L,0L,0L,1L,2L,1L,2L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035202Inst : IEnumerable<long>
{
public static readonly long[] Value=A035202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035202.Bytes);
public long this[int i]=>Value[i];

public static A035202Inst Instance=new A035202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035203
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,0L,1L,0L,1L,0L,0L,1L,0L,0L,2L,1L,2L,0L,0L,2L,1L,0L,0L,0L,3L,0L,1L,1L,0L,0L,0L,0L,0L,0L,2L,1L,2L,0L,0L,0L,2L,0L,2L,0L,2L,0L,2L,1L,1L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,2L,0L,0L,1L,1L,0L,0L,2L,2L,0L,0L,0L,0L,0L,0L,3L,0L,0L,0L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035203Inst : IEnumerable<long>
{
public static readonly long[] Value=A035203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035203.Bytes);
public long this[int i]=>Value[i];

public static A035203Inst Instance=new A035203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035204
{
public static readonly long[] Value={ 1L,1L,2L,1L,0L,2L,2L,1L,3L,0L,1L,2L,2L,2L,0L,1L,0L,3L,0L,0L,4L,1L,0L,2L,1L,2L,4L,2L,2L,0L,0L,1L,2L,0L,0L,3L,0L,0L,4L,0L,0L,4L,0L,1L,0L,0L,0L,2L,3L,1L,0L,2L,0L,4L,0L,2L,0L,2L,2L,0L,2L,0L,6L,1L,0L,2L,2L,0L,0L,0L,0L,3L,0L,0L,2L,0L,2L,4L,2L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035204Inst : IEnumerable<long>
{
public static readonly long[] Value=A035204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035204.Bytes);
public long this[int i]=>Value[i];

public static A035204Inst Instance=new A035204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035205
{
public static readonly long[] Value={ 1L,2L,0L,3L,0L,0L,2L,4L,1L,0L,2L,0L,2L,4L,0L,5L,0L,2L,2L,0L,0L,4L,1L,0L,1L,4L,0L,6L,2L,0L,0L,6L,0L,0L,0L,3L,0L,4L,0L,0L,2L,0L,2L,6L,0L,2L,0L,0L,3L,2L,0L,6L,0L,0L,0L,8L,0L,4L,0L,0L,0L,0L,2L,7L,0L,0L,2L,0L,0L,0L,0L,4L,2L,0L,0L,6L,4L,0L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035205Inst : IEnumerable<long>
{
public static readonly long[] Value=A035205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035205.Bytes);
public long this[int i]=>Value[i];

public static A035205Inst Instance=new A035205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035206
{
public static readonly long[] Value={ 1L,2L,1L,3L,6L,1L,4L,12L,6L,12L,1L,5L,20L,20L,30L,30L,20L,1L,6L,30L,30L,15L,60L,120L,20L,60L,90L,30L,1L,7L,42L,42L,42L,105L,210L,105L,105L,140L,420L,140L,105L,210L,42L,1L,8L,56L,56L,56L,28L,168L,336L,336L,168L,168L,280L,840L,420L,840L,70L,280L,1120L,560L,168L,420L,56L,1L,9L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035206Inst : IEnumerable<long>
{
public static readonly long[] Value=A035206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035206.Bytes);
public long this[int i]=>Value[i];

public static A035206Inst Instance=new A035206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035207
{
public static readonly long[] Value={ 1L,2L,2L,3L,1L,4L,2L,4L,3L,2L,2L,6L,2L,4L,2L,5L,2L,6L,2L,3L,4L,4L,2L,8L,1L,4L,4L,6L,2L,4L,2L,6L,4L,4L,2L,9L,2L,4L,4L,4L,2L,8L,2L,6L,3L,4L,2L,10L,3L,2L,4L,6L,2L,8L,2L,8L,4L,4L,2L,6L,2L,4L,6L,7L,2L,8L,2L,6L,4L,4L,2L,12L,2L,4L,2L,6L,4L,8L,2L,5L,5L,4L,2L,12L,2L,4L,4L,8L,2L,6L,4L,6L,4L,4L,2L,12L,2L,6L,6L,3L,2L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035207Inst : IEnumerable<long>
{
public static readonly long[] Value=A035207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035207.Bytes);
public long this[int i]=>Value[i];

public static A035207Inst Instance=new A035207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035208
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,0L,0L,1L,1L,2L,2L,0L,1L,0L,0L,1L,2L,1L,2L,2L,0L,2L,2L,0L,3L,1L,0L,0L,0L,0L,0L,1L,0L,2L,0L,1L,2L,2L,0L,2L,0L,0L,0L,2L,2L,2L,0L,0L,1L,3L,0L,1L,0L,0L,4L,0L,0L,0L,2L,0L,0L,0L,0L,1L,2L,0L,2L,2L,0L,0L,0L,1L,0L,2L,0L,2L,0L,0L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035208Inst : IEnumerable<long>
{
public static readonly long[] Value=A035208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035208.Bytes);
public long this[int i]=>Value[i];

public static A035208Inst Instance=new A035208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035209
{
public static readonly long[] Value={ 1L,599L,691L,829L,1151L,2209L,2347L,2393L,3037L,3313L,3359L,4463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035209Inst : IEnumerable<long>
{
public static readonly long[] Value=A035209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035209.Bytes);
public long this[int i]=>Value[i];

public static A035209Inst Instance=new A035209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035210
{
public static readonly long[] Value={ 1L,1L,2L,1L,0L,2L,1L,1L,3L,0L,0L,2L,0L,1L,0L,1L,0L,3L,2L,0L,2L,0L,0L,2L,1L,0L,4L,1L,2L,0L,2L,1L,0L,0L,0L,3L,2L,2L,0L,0L,0L,2L,0L,0L,0L,0L,2L,2L,1L,1L,0L,0L,2L,4L,0L,1L,4L,2L,2L,0L,0L,2L,3L,1L,0L,0L,0L,0L,0L,0L,0L,3L,0L,2L,2L,2L,0L,0L,0L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035210Inst : IEnumerable<long>
{
public static readonly long[] Value=A035210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035210.Bytes);
public long this[int i]=>Value[i];

public static A035210Inst Instance=new A035210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035211
{
public static readonly long[] Value={ 1L,0L,0L,1L,2L,0L,2L,0L,1L,0L,0L,0L,2L,0L,0L,1L,0L,0L,0L,2L,0L,0L,2L,0L,3L,0L,0L,2L,1L,0L,0L,0L,0L,0L,4L,1L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,3L,0L,0L,2L,2L,0L,0L,0L,0L,0L,2L,0L,0L,0L,2L,1L,4L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035211Inst : IEnumerable<long>
{
public static readonly long[] Value=A035211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035211.Bytes);
public long this[int i]=>Value[i];

public static A035211Inst Instance=new A035211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035212
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,0L,1L,2L,2L,1L,1L,2L,1L,2L,1L,2L,0L,0L,1L,1L,2L,1L,2L,2L,1L,0L,1L,0L,2L,2L,1L,2L,2L,2L,1L,0L,2L,0L,0L,1L,0L,0L,1L,3L,1L,2L,2L,0L,1L,0L,2L,2L,2L,0L,1L,0L,0L,2L,1L,2L,0L,0L,2L,0L,2L,2L,1L,0L,2L,1L,2L,0L,2L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035212Inst : IEnumerable<long>
{
public static readonly long[] Value=A035212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035212.Bytes);
public long this[int i]=>Value[i];

public static A035212Inst Instance=new A035212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035261
{
public static readonly long[] Value={ 1L,2L,4L,7L,8L,9L,11L,13L,14L,16L,18L,19L,22L,23L,25L,26L,28L,29L,32L,36L,38L,41L,43L,44L,46L,49L,50L,52L,56L,58L,63L,64L,67L,72L,73L,76L,77L,79L,81L,82L,83L,86L,88L,91L,92L,98L,99L,100L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035261Inst : IEnumerable<long>
{
public static readonly long[] Value=A035261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035261.Bytes);
public long this[int i]=>Value[i];

public static A035261Inst Instance=new A035261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035262
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,9L,10L,11L,13L,16L,17L,18L,19L,20L,22L,23L,25L,26L,32L,34L,36L,37L,38L,40L,44L,45L,46L,49L,50L,52L,55L,59L,64L,65L,67L,68L,72L,74L,76L,79L,80L,81L,83L,85L,88L,90L,92L,95L,98L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035262Inst : IEnumerable<long>
{
public static readonly long[] Value=A035262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035262.Bytes);
public long this[int i]=>Value[i];

public static A035262Inst Instance=new A035262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035263
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035263Inst : IEnumerable<long>
{
public static readonly long[] Value=A035263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035263.Bytes);
public long this[int i]=>Value[i];

public static A035263Inst Instance=new A035263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035264
{
public static readonly long[] Value={ 1L,4L,5L,7L,9L,13L,16L,20L,23L,25L,28L,29L,35L,36L,45L,49L,52L,53L,59L,63L,64L,65L,67L,71L,80L,81L,83L,91L,92L,100L,103L,107L,109L,112L,115L,116L,117L,121L,125L,139L,140L,144L,145L,149L,151L,161L,167L,169L,173L,175L,179L,180L,181L,196L,197L,199L,203L,207L,208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035264Inst : IEnumerable<long>
{
public static readonly long[] Value=A035264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035264.Bytes);
public long this[int i]=>Value[i];

public static A035264Inst Instance=new A035264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035265
{
public static readonly BigInteger[] Value={ 1L,12L,264L,8448L,354816L,18450432L,1143926784L,82362728448L,6753743732736L,621344423411712L,63377131187994624L,7098238693055397888L,BigInteger.Parse("865985120552758542336"),BigInteger.Parse("114310035912964127588352") };
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
public class A035265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035265Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A035265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035265.Bytes);
public BigInteger this[int i]=>Value[i];

public static A035265Inst Instance=new A035265Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035266
{
public static readonly long[] Value={ 1L,4L,5L,7L,9L,13L,16L,17L,19L,20L,23L,25L,28L,29L,31L,35L,36L,43L,45L,49L,52L,59L,63L,64L,65L,67L,68L,73L,76L,80L,81L,85L,91L,92L,95L,97L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035266Inst : IEnumerable<long>
{
public static readonly long[] Value=A035266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035266.Bytes);
public long this[int i]=>Value[i];

public static A035266Inst Instance=new A035266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035267
{
public static readonly long[] Value={ 1L,3L,4L,7L,9L,11L,12L,16L,21L,25L,27L,28L,33L,36L,37L,41L,44L,47L,48L,49L,53L,63L,64L,67L,71L,73L,75L,77L,81L,83L,84L,99L,100L,101L,107L,108L,111L,112L,121L,123L,127L,132L,137L,139L,141L,144L,147L,148L,149L,151L,157L,159L,164L,169L,173L,175L,176L,181L,188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035267Inst : IEnumerable<long>
{
public static readonly long[] Value=A035267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035267.Bytes);
public long this[int i]=>Value[i];

public static A035267Inst Instance=new A035267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035268
{
public static readonly long[] Value={ 1L,2L,4L,8L,9L,11L,13L,16L,17L,18L,19L,22L,25L,26L,29L,31L,32L,34L,36L,37L,38L,43L,44L,49L,50L,52L,53L,58L,62L,64L,68L,71L,72L,73L,74L,76L,79L,81L,83L,86L,88L,98L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035268Inst : IEnumerable<long>
{
public static readonly long[] Value=A035268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035268.Bytes);
public long this[int i]=>Value[i];

public static A035268Inst Instance=new A035268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035269
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,9L,10L,16L,18L,20L,23L,25L,31L,32L,36L,37L,40L,41L,43L,45L,46L,49L,50L,59L,61L,62L,64L,72L,73L,74L,80L,81L,82L,83L,86L,90L,92L,98L,100L,103L,107L,113L,115L,118L,121L,122L,124L,125L,127L,128L,131L,139L,144L,146L,148L,155L,160L,162L,163L,164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035269Inst : IEnumerable<long>
{
public static readonly long[] Value=A035269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035269.Bytes);
public long this[int i]=>Value[i];

public static A035269Inst Instance=new A035269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035270
{
public static readonly long[] Value={ 1L,3L,4L,7L,9L,12L,13L,16L,17L,19L,21L,25L,27L,28L,36L,39L,41L,43L,48L,49L,51L,52L,53L,57L,63L,64L,68L,71L,75L,76L,81L,84L,91L,97L,100L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035270Inst : IEnumerable<long>
{
public static readonly long[] Value=A035270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035270.Bytes);
public long this[int i]=>Value[i];

public static A035270Inst Instance=new A035270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035271
{
public static readonly long[] Value={ 1L,2L,4L,8L,9L,11L,16L,17L,18L,19L,22L,23L,25L,31L,32L,34L,36L,37L,38L,43L,44L,46L,47L,49L,50L,53L,61L,62L,64L,67L,68L,72L,74L,76L,81L,86L,88L,89L,92L,94L,97L,98L,99L,100L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035271Inst : IEnumerable<long>
{
public static readonly long[] Value=A035271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035271.Bytes);
public long this[int i]=>Value[i];

public static A035271Inst Instance=new A035271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035272
{
public static readonly BigInteger[] Value={ 1L,13L,299L,9867L,424281L,22486893L,1416674259L,103417220907L,8583629335281L,798277528181133L,82222585402656699L,9291152150500206987UL,BigInteger.Parse("1142811714511525459401"),BigInteger.Parse("151993958030032886100333") };
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
public class A035272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035272Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A035272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035272.Bytes);
public BigInteger this[int i]=>Value[i];

public static A035272Inst Instance=new A035272Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035273
{
public static readonly BigInteger[] Value={ 1L,14L,336L,11424L,502656L,27143424L,1737179136L,128551256064L,10798305509376L,1015040717881344L,105564234659659776L,12034322751201214464UL,BigInteger.Parse("1492256021148950593536"),BigInteger.Parse("199962306833959379533824") };
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
public class A035273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035273Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A035273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035273.Bytes);
public BigInteger this[int i]=>Value[i];

public static A035273Inst Instance=new A035273Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035274
{
public static readonly BigInteger[] Value={ 1L,15L,375L,13125L,590625L,32484375L,2111484375L,158361328125L,13460712890625L,1278767724609375L,134270611083984375L,15441120274658203125UL,BigInteger.Parse("1930140034332275390625"),BigInteger.Parse("260568904634857177734375") };
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
public class A035274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035274Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A035274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035274.Bytes);
public BigInteger this[int i]=>Value[i];

public static A035274Inst Instance=new A035274Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035275
{
public static readonly BigInteger[] Value={ 1L,16L,416L,14976L,688896L,38578176L,2546159616L,193508130816L,16641699250176L,1597603128016896L,169345931569790976L,BigInteger.Parse("19644128062095753216"),BigInteger.Parse("2475160135824064905216"),BigInteger.Parse("336621778472072827109376") };
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
public class A035275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035275Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A035275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035275.Bytes);
public BigInteger this[int i]=>Value[i];

public static A035275Inst Instance=new A035275Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035276
{
public static readonly BigInteger[] Value={ 1L,17L,459L,16983L,798201L,45497457L,3048329619L,234721380663L,20420760117681L,1980813731415057L,211947069261411099L,BigInteger.Parse("24797807103585098583"),BigInteger.Parse("3149321502155307520041"),BigInteger.Parse("431457045795277130245617") };
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
public class A035276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035276Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A035276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035276.Bytes);
public BigInteger this[int i]=>Value[i];

public static A035276Inst Instance=new A035276Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035373
{
public static readonly long[] Value={ 0L,1L,0L,2L,0L,2L,1L,3L,2L,3L,3L,5L,4L,7L,5L,10L,7L,13L,10L,16L,15L,20L,20L,26L,26L,34L,33L,45L,42L,56L,55L,70L,71L,86L,91L,109L,113L,136L,140L,170L,174L,209L,217L,255L,270L,311L,331L,381L,404L,465L,491L,565L,597L,681L,726L,820L,878L,985L,1056L,1185L,1265L,1419L,1515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035373Inst : IEnumerable<long>
{
public static readonly long[] Value=A035373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035373.Bytes);
public long this[int i]=>Value[i];

public static A035373Inst Instance=new A035373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035374
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,1L,1L,2L,2L,1L,2L,4L,3L,3L,4L,6L,6L,7L,7L,9L,11L,12L,12L,16L,17L,20L,23L,25L,27L,33L,36L,41L,44L,50L,57L,66L,69L,77L,88L,100L,107L,120L,131L,149L,165L,180L,196L,222L,242L,268L,293L,323L,353L,394L,428L,470L,513L,565L,617L,680L,734L,805L,882L,966L,1046L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035374Inst : IEnumerable<long>
{
public static readonly long[] Value=A035374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035374.Bytes);
public long this[int i]=>Value[i];

public static A035374Inst Instance=new A035374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035375
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,3L,3L,3L,3L,3L,5L,7L,8L,8L,8L,8L,11L,15L,17L,18L,18L,18L,23L,30L,35L,37L,38L,38L,45L,57L,66L,71L,73L,74L,85L,104L,121L,131L,136L,138L,154L,184L,212L,231L,241L,246L,270L,316L,363L,396L,416L,426L,461L,530L,604L,661L,696L,716L,768L,870L,986L,1079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035375Inst : IEnumerable<long>
{
public static readonly long[] Value=A035375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035375.Bytes);
public long this[int i]=>Value[i];

public static A035375Inst Instance=new A035375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035376
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,2L,0L,3L,0L,3L,0L,5L,0L,7L,0L,8L,0L,11L,0L,15L,0L,17L,0L,23L,0L,30L,0L,35L,0L,44L,0L,57L,0L,66L,0L,82L,0L,103L,0L,121L,0L,146L,0L,181L,0L,211L,0L,253L,0L,308L,0L,360L,0L,425L,0L,513L,0L,596L,0L,700L,0L,834L,0L,969L,0L,1127L,0L,1333L,0L,1541L,0L,1786L,0L,2093L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035376Inst : IEnumerable<long>
{
public static readonly long[] Value=A035376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035376.Bytes);
public long this[int i]=>Value[i];

public static A035376Inst Instance=new A035376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035377
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,2L,0L,0L,3L,0L,0L,5L,0L,0L,7L,0L,0L,11L,0L,0L,15L,0L,0L,22L,0L,0L,30L,0L,0L,42L,0L,0L,56L,0L,0L,77L,0L,0L,101L,0L,0L,135L,0L,0L,176L,0L,0L,231L,0L,0L,297L,0L,0L,385L,0L,0L,490L,0L,0L,627L,0L,0L,792L,0L,0L,1002L,0L,0L,1255L,0L,0L,1575L,0L,0L,1958L,0L,0L,2436L,0L,0L,3010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035377Inst : IEnumerable<long>
{
public static readonly long[] Value=A035377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035377.Bytes);
public long this[int i]=>Value[i];

public static A035377Inst Instance=new A035377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035378
{
public static readonly BigInteger[] Value={ 3L,11L,72L,635L,7085L,95911L,1528541L,28044762L,582314535L,13500314080L,345696545788L,9690223054222L,295132850278639L,9705001713289680L,342693270841135600L,12932930349605422101UL,BigInteger.Parse("519485442041267214922") };
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
public class A035378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035378Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A035378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035378.Bytes);
public BigInteger this[int i]=>Value[i];

public static A035378Inst Instance=new A035378Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035379
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,2L,2L,0L,0L,1L,2L,4L,3L,0L,1L,2L,5L,7L,5L,1L,2L,5L,9L,12L,8L,2L,5L,10L,17L,20L,13L,5L,10L,19L,29L,32L,20L,10L,20L,34L,49L,50L,32L,20L,36L,59L,78L,77L,50L,37L,64L,97L,124L,117L,79L,66L,107L,157L,190L,176L,123L,112L,177L,247L,290L,262L,191L,187L,282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035379Inst : IEnumerable<long>
{
public static readonly long[] Value=A035379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035379.Bytes);
public long this[int i]=>Value[i];

public static A035379Inst Instance=new A035379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035380
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,4L,5L,7L,8L,10L,11L,13L,15L,19L,22L,27L,30L,35L,39L,46L,53L,62L,70L,80L,89L,102L,115L,133L,149L,169L,187L,211L,235L,266L,297L,333L,368L,410L,454L,508L,563L,628L,691L,765L,841L,932L,1027L,1136L,1247L,1372L,1502L,1653L,1812L,1993L,2179L,2388L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035380Inst : IEnumerable<long>
{
public static readonly long[] Value=A035380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035380.Bytes);
public long this[int i]=>Value[i];

public static A035380Inst Instance=new A035380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035381
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,4L,4L,6L,7L,7L,9L,11L,12L,15L,18L,19L,23L,27L,29L,35L,41L,44L,51L,59L,64L,74L,86L,93L,106L,121L,131L,148L,169L,184L,206L,233L,253L,282L,318L,346L,384L,430L,467L,516L,576L,626L,689L,766L,831L,911L,1010L,1096L,1199L,1324L,1435L,1565L,1723L,1867L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035381Inst : IEnumerable<long>
{
public static readonly long[] Value=A035381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035381.Bytes);
public long this[int i]=>Value[i];

public static A035381Inst Instance=new A035381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035382
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,3L,4L,4L,5L,6L,7L,8L,10L,11L,13L,15L,17L,19L,23L,26L,29L,33L,38L,42L,48L,54L,61L,68L,77L,85L,96L,107L,119L,132L,148L,163L,181L,201L,223L,245L,272L,299L,330L,363L,400L,438L,483L,529L,580L,635L,697L,760L,832L,908L,992L,1081L,1180L,1283L,1399L,1521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035382Inst : IEnumerable<long>
{
public static readonly long[] Value=A035382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035382.Bytes);
public long this[int i]=>Value[i];

public static A035382Inst Instance=new A035382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035383
{
public static readonly long[] Value={ 1L,25L,36L,625L,5776L,141376L,390625L,87909376L,8212890625L,11963109376L,793212890625L,8355712890625L,50543227109376L,166168212890625L,7588043387109376L,45322418212890625L,619541169787109376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035383Inst : IEnumerable<long>
{
public static readonly long[] Value=A035383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035383.Bytes);
public long this[int i]=>Value[i];

public static A035383Inst Instance=new A035383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035384
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,2L,1L,3L,3L,3L,4L,5L,4L,7L,7L,8L,10L,12L,11L,16L,16L,18L,22L,25L,25L,33L,34L,38L,45L,50L,52L,65L,67L,75L,87L,95L,101L,121L,126L,141L,160L,174L,187L,218L,229L,254L,285L,308L,333L,380L,401L,443L,492L,530L,574L,646L,683L,752L,828L,890L,964L,1072L,1137L,1246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035384Inst : IEnumerable<long>
{
public static readonly long[] Value=A035384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035384.Bytes);
public long this[int i]=>Value[i];

public static A035384Inst Instance=new A035384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035385
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,0L,2L,0L,4L,0L,5L,0L,7L,0L,9L,0L,13L,0L,16L,0L,22L,0L,27L,0L,36L,0L,44L,0L,57L,0L,70L,0L,89L,0L,108L,0L,135L,0L,163L,0L,202L,0L,243L,0L,297L,0L,355L,0L,431L,0L,513L,0L,617L,0L,731L,0L,874L,0L,1031L,0L,1225L,0L,1439L,0L,1701L,0L,1991L,0L,2341L,0L,2731L,0L,3197L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035385Inst : IEnumerable<long>
{
public static readonly long[] Value=A035385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035385.Bytes);
public long this[int i]=>Value[i];

public static A035385Inst Instance=new A035385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035386
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,1L,2L,1L,3L,2L,3L,3L,4L,4L,6L,5L,7L,7L,9L,9L,12L,11L,15L,15L,18L,19L,23L,23L,29L,29L,35L,37L,43L,45L,53L,55L,64L,68L,78L,82L,95L,99L,114L,121L,136L,145L,164L,173L,196L,208L,232L,248L,276L,294L,328L,349L,386L,413L,456L,486L,537L,572L,629L,673L,737L,787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035386Inst : IEnumerable<long>
{
public static readonly long[] Value=A035386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035386.Bytes);
public long this[int i]=>Value[i];

public static A035386Inst Instance=new A035386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035387
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,1L,1L,1L,2L,2L,1L,3L,3L,2L,4L,5L,3L,6L,7L,6L,8L,10L,8L,12L,14L,12L,16L,20L,17L,23L,27L,25L,30L,37L,34L,42L,49L,47L,55L,67L,63L,74L,87L,86L,97L,115L,113L,129L,149L,150L,166L,195L,195L,217L,249L,255L,278L,321L,327L,359L,407L,421L,456L,520L,535L,581L,654L,682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035387Inst : IEnumerable<long>
{
public static readonly long[] Value=A035387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035387.Bytes);
public long this[int i]=>Value[i];

public static A035387Inst Instance=new A035387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035388
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,0L,1L,2L,1L,2L,2L,1L,3L,4L,2L,4L,5L,3L,7L,7L,5L,9L,9L,8L,13L,13L,11L,17L,18L,16L,24L,24L,22L,32L,32L,31L,43L,42L,42L,56L,56L,57L,74L,74L,75L,96L,96L,100L,125L,124L,130L,160L,161L,171L,205L,205L,219L,261L,264L,282L,330L,334L,359L,418L,424L,456L,524L,533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035388Inst : IEnumerable<long>
{
public static readonly long[] Value=A035388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035388.Bytes);
public long this[int i]=>Value[i];

public static A035388Inst Instance=new A035388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035437
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,2L,0L,0L,2L,1L,0L,3L,2L,0L,3L,3L,1L,4L,4L,3L,4L,5L,5L,6L,6L,8L,8L,7L,10L,13L,9L,13L,17L,13L,15L,23L,19L,19L,28L,28L,24L,34L,37L,34L,40L,48L,46L,50L,58L,63L,64L,71L,80L,85L,85L,100L,110L,108L,120L,142L,137L,146L,174L,178L,179L,212L,224L,226L,252L,280L,285L,307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035437Inst : IEnumerable<long>
{
public static readonly long[] Value=A035437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035437.Bytes);
public long this[int i]=>Value[i];

public static A035437Inst Instance=new A035437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035438
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,2L,1L,1L,2L,3L,2L,2L,3L,4L,3L,4L,5L,6L,5L,6L,7L,8L,8L,10L,10L,11L,12L,14L,15L,17L,18L,20L,20L,24L,26L,28L,29L,34L,36L,38L,41L,48L,50L,53L,57L,65L,67L,73L,80L,88L,91L,99L,108L,118L,123L,135L,145L,156L,165L,181L,192L,207L,221L,240L,253L,273L,292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035438Inst : IEnumerable<long>
{
public static readonly long[] Value=A035438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035438.Bytes);
public long this[int i]=>Value[i];

public static A035438Inst Instance=new A035438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035439
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,2L,1L,1L,1L,2L,2L,3L,2L,3L,2L,4L,3L,6L,4L,6L,4L,7L,6L,9L,8L,10L,9L,11L,11L,15L,14L,17L,16L,20L,18L,24L,23L,29L,27L,32L,31L,38L,38L,45L,45L,52L,51L,60L,60L,71L,71L,82L,81L,94L,94L,108L,111L,126L,128L,143L,146L,164L,169L,190L,195L,218L,221L,246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035439Inst : IEnumerable<long>
{
public static readonly long[] Value=A035439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035439.Bytes);
public long this[int i]=>Value[i];

public static A035439Inst Instance=new A035439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035440
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,2L,1L,0L,1L,1L,2L,3L,2L,2L,1L,2L,3L,5L,5L,4L,3L,3L,5L,8L,8L,8L,6L,6L,8L,12L,13L,14L,13L,12L,13L,17L,20L,23L,23L,22L,21L,26L,30L,36L,38L,38L,37L,40L,45L,53L,59L,62L,61L,65L,67L,78L,88L,96L,100L,102L,104L,114L,128L,144L,152L,160L,160L,170L,186L,208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035440Inst : IEnumerable<long>
{
public static readonly long[] Value=A035440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035440.Bytes);
public long this[int i]=>Value[i];

public static A035440Inst Instance=new A035440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035441
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,3L,3L,3L,3L,3L,3L,3L,5L,7L,8L,8L,8L,8L,8L,8L,11L,15L,17L,18L,18L,18L,18L,18L,23L,30L,35L,37L,38L,38L,38L,38L,45L,57L,66L,71L,73L,74L,74L,74L,85L,104L,121L,131L,136L,138L,139L,139L,154L,184L,212L,231L,241L,246L,248L,249L,271L,316L,363L,396L,416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035441Inst : IEnumerable<long>
{
public static readonly long[] Value=A035441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035441.Bytes);
public long this[int i]=>Value[i];

public static A035441Inst Instance=new A035441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035442
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,1L,0L,2L,0L,3L,0L,3L,0L,3L,0L,5L,0L,7L,0L,8L,0L,8L,0L,11L,0L,15L,0L,17L,0L,18L,0L,23L,0L,30L,0L,35L,0L,37L,0L,45L,0L,57L,0L,66L,0L,71L,0L,84L,0L,104L,0L,121L,0L,131L,0L,151L,0L,183L,0L,212L,0L,231L,0L,263L,0L,313L,0L,362L,0L,396L,0L,446L,0L,523L,0L,601L,0L,660L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035442Inst : IEnumerable<long>
{
public static readonly long[] Value=A035442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035442.Bytes);
public long this[int i]=>Value[i];

public static A035442Inst Instance=new A035442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A035443
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,2L,1L,0L,2L,1L,2L,2L,1L,4L,2L,1L,5L,2L,4L,5L,2L,8L,5L,2L,10L,5L,7L,11L,5L,14L,11L,5L,19L,11L,12L,21L,11L,24L,22L,11L,33L,22L,22L,38L,22L,41L,40L,22L,58L,41L,37L,68L,41L,67L,73L,41L,95L,75L,63L,114L,76L,108L,124L,76L,155L,129L,106L,188L,131L,173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A035443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A035443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A035443Inst : IEnumerable<long>
{
public static readonly long[] Value=A035443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A035443.Bytes);
public long this[int i]=>Value[i];

public static A035443Inst Instance=new A035443Inst();

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