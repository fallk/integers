using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A273062
{
public static readonly long[] Value={ 1L,3L,3L,6L,7L,7L,7L,12L,13L,13L,13L,18L,19L,19L,22L,23L,24L,25L,25L,25L,30L,31L,32L,33L,33L,36L,37L,37L,37L,42L,43L,43L,46L,47L,48L,49L,49L,52L,53L,54L,55L,55L,55L,60L,61L,62L,63L,63L,66L,67L,67L,67L,72L,73L,74L,75L,75L,78L,79L,79L,82L,83L,84L,85L,85L,88L,89L,90L,91L,92L,93L,93L,96L,97L,97L,97L,102L,103L,103L,103L,108L,109L,109L,112L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273062Inst : IEnumerable<long>
{
public static readonly long[] Value=A273062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273062.Bytes);
public long this[int i]=>Value[i];

public static A273062Inst Instance=new A273062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273063
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,8L,44L,53L,79L,89L,95L,120L,224L,259L,290L,488L,725L,821L,1815L,3096L,3100L,3404L,5909L,8054L,11879L,17298L,25588L,41516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273063Inst : IEnumerable<long>
{
public static readonly long[] Value=A273063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273063.Bytes);
public long this[int i]=>Value[i];

public static A273063Inst Instance=new A273063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273064
{
public static readonly long[] Value={ 1L,2L,3L,7L,10L,13L,13L,13L,31L,37L,37L,37L,61L,61L,61L,83L,83L,83L,127L,127L,127L,127L,127L,179L,179L,179L,179L,179L,193L,193L,193L,193L,193L,193L,193L,193L,277L,277L,277L,277L,277L,277L,383L,383L,383L,383L,383L,479L,479L,479L,479L,479L,479L,479L,541L,541L,541L,541L,541L,541L,541L,541L,541L,641L,641L,641L,641L,641L,641L,641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273064Inst : IEnumerable<long>
{
public static readonly long[] Value=A273064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273064.Bytes);
public long this[int i]=>Value[i];

public static A273064Inst Instance=new A273064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273065
{
public static readonly long[] Value={ 5L,6L,5L,1L,9L,7L,7L,1L,7L,3L,8L,3L,6L,3L,9L,3L,9L,6L,4L,3L,7L,5L,2L,8L,0L,1L,3L,2L,4L,7L,0L,3L,0L,8L,1L,6L,0L,9L,8L,4L,8L,3L,9L,7L,6L,7L,5L,9L,5L,5L,3L,8L,2L,7L,5L,5L,5L,4L,8L,3L,8L,1L,0L,9L,4L,8L,4L,1L,1L,2L,0L,3L,3L,0L,1L,5L,7L,2L,3L,9L,4L,7L,1L,3L,3L,3L,5L,8L,7L,7L,7L,3L,9L,7L,0L,1L,1L,2L,3L,8L,4L,1L,1L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273065Inst : IEnumerable<long>
{
public static readonly long[] Value=A273065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273065.Bytes);
public long this[int i]=>Value[i];

public static A273065Inst Instance=new A273065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273066
{
public static readonly long[] Value={ 1L,7L,6L,9L,2L,9L,2L,3L,5L,4L,2L,3L,8L,6L,3L,1L,4L,1L,5L,2L,4L,0L,4L,0L,9L,4L,6L,4L,3L,3L,5L,0L,3L,3L,4L,9L,2L,6L,7L,0L,5L,5L,3L,0L,4L,5L,8L,9L,8L,8L,5L,7L,0L,0L,4L,2L,3L,3L,1L,0L,6L,1L,3L,0L,4L,0L,2L,6L,7L,3L,8L,1L,7L,3L,5L,0L,6L,6L,8L,3L,2L,9L,0L,6L,8L,7L,4L,1L,2L,2L,1L,4L,9L,4L,4L,5L,4L,8L,1L,8L,1L,2L,7L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273066Inst : IEnumerable<long>
{
public static readonly long[] Value=A273066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273066.Bytes);
public long this[int i]=>Value[i];

public static A273066Inst Instance=new A273066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273067
{
public static readonly long[] Value={ 6L,3L,8L,8L,9L,6L,9L,1L,9L,4L,7L,1L,3L,5L,2L,6L,2L,2L,3L,6L,5L,3L,5L,3L,4L,3L,7L,8L,4L,0L,9L,7L,1L,8L,6L,0L,4L,7L,3L,5L,8L,5L,0L,9L,2L,3L,7L,9L,7L,4L,9L,3L,4L,9L,1L,2L,2L,1L,3L,8L,5L,0L,8L,5L,0L,5L,8L,5L,1L,4L,1L,0L,7L,4L,7L,5L,2L,3L,5L,3L,9L,6L,4L,2L,0L,6L,9L,4L,6L,6L,0L,1L,5L,0L,5L,2L,5L,7L,0L,4L,4L,4L,7L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273067Inst : IEnumerable<long>
{
public static readonly long[] Value=A273067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273067.Bytes);
public long this[int i]=>Value[i];

public static A273067Inst Instance=new A273067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273068
{
public static readonly long[] Value={ 1L,2L,4L,8L,8L,24L,24L,38L,47L,62L,62L,83L,83L,83L,83L,83L,83L,134L,134L,134L,134L,134L,134L,134L,134L,134L,134L,134L,134L,227L,227L,227L,227L,227L,227L,227L,227L,227L,227L,227L,227L,227L,227L,227L,439L,439L,439L,439L,439L,439L,587L,587L,607L,607L,607L,681L,681L,681L,681L,1069L,1069L,1097L,1097L,1097L,1097L,1097L,1097L,1174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273068Inst : IEnumerable<long>
{
public static readonly long[] Value=A273068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273068.Bytes);
public long this[int i]=>Value[i];

public static A273068Inst Instance=new A273068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273069
{
public static readonly long[] Value={ 1L,8L,20L,41L,57L,96L,116L,189L,197L,273L,272L,457L,457L,581L,549L,805L,708L,929L,921L,1161L,1173L,1353L,1317L,1780L,1649L,1857L,1937L,2324L,2105L,2592L,2569L,3000L,2860L,3333L,3073L,3772L,3756L,3945L,4105L,4549L,4628L,4909L,5048L,5381L,5708L,5769L,6080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273069Inst : IEnumerable<long>
{
public static readonly long[] Value=A273069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273069.Bytes);
public long this[int i]=>Value[i];

public static A273069Inst Instance=new A273069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273070
{
public static readonly long[] Value={ 1L,8L,41L,189L,805L,3000L,11484L,45736L,181841L,715333L,2818337L,11125965L,44110241L,175573869L,700425137L,2797189233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273070Inst : IEnumerable<long>
{
public static readonly long[] Value=A273070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273070.Bytes);
public long this[int i]=>Value[i];

public static A273070Inst Instance=new A273070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273071
{
public static readonly long[] Value={ 1L,9L,29L,70L,127L,223L,339L,528L,725L,998L,1270L,1727L,2184L,2765L,3314L,4119L,4827L,5756L,6677L,7838L,9011L,10364L,11681L,13461L,15110L,16967L,18904L,21228L,23333L,25925L,28494L,31494L,34354L,37687L,40760L,44532L,48288L,52233L,56338L,60887L,65515L,70424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273071Inst : IEnumerable<long>
{
public static readonly long[] Value=A273071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273071.Bytes);
public long this[int i]=>Value[i];

public static A273071Inst Instance=new A273071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273072
{
public static readonly long[] Value={ 7L,12L,21L,16L,39L,20L,73L,8L,76L,-1L,185L,0L,124L,-32L,256L,-97L,221L,-8L,240L,12L,180L,-36L,463L,-131L,208L,80L,387L,-219L,487L,-23L,431L,-140L,473L,-260L,699L,-16L,189L,160L,444L,79L,281L,139L,333L,327L,61L,311L,413L,31L,629L,-225L,632L,361L,255L,-131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273072Inst : IEnumerable<long>
{
public static readonly long[] Value=A273072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273072.Bytes);
public long this[int i]=>Value[i];

public static A273072Inst Instance=new A273072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273073
{
public static readonly long[] Value={ 1L,4L,17L,29L,49L,81L,133L,125L,176L,249L,301L,337L,401L,485L,585L,609L,709L,785L,897L,993L,1141L,1297L,1437L,1509L,1685L,1725L,1897L,1909L,2201L,2429L,2645L,2521L,2792L,2929L,3261L,3188L,3493L,3701L,4121L,4109L,4377L,4493L,5001L,5065L,5165L,5589L,5916L,5793L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273073Inst : IEnumerable<long>
{
public static readonly long[] Value=A273073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273073.Bytes);
public long this[int i]=>Value[i];

public static A273073Inst Instance=new A273073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273074
{
public static readonly long[] Value={ 1L,4L,29L,125L,609L,2521L,10825L,43209L,175472L,706016L,2824641L,11298237L,45208657L,180846288L,723569004L,2894179373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273074Inst : IEnumerable<long>
{
public static readonly long[] Value=A273074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273074.Bytes);
public long this[int i]=>Value[i];

public static A273074Inst Instance=new A273074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273075
{
public static readonly long[] Value={ 1L,5L,22L,51L,100L,181L,314L,439L,615L,864L,1165L,1502L,1903L,2388L,2973L,3582L,4291L,5076L,5973L,6966L,8107L,9404L,10841L,12350L,14035L,15760L,17657L,19566L,21767L,24196L,26841L,29362L,32154L,35083L,38344L,41532L,45025L,48726L,52847L,56956L,61333L,65826L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273075Inst : IEnumerable<long>
{
public static readonly long[] Value=A273075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273075.Bytes);
public long this[int i]=>Value[i];

public static A273075Inst Instance=new A273075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273076
{
public static readonly long[] Value={ 3L,13L,12L,20L,32L,52L,-8L,51L,73L,52L,36L,64L,84L,100L,24L,100L,76L,112L,96L,148L,156L,140L,72L,176L,40L,172L,12L,292L,228L,216L,-124L,271L,137L,332L,-73L,305L,208L,420L,-12L,268L,116L,508L,64L,100L,424L,327L,-123L,735L,109L,279L,65L,271L,557L,535L,-175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273076Inst : IEnumerable<long>
{
public static readonly long[] Value=A273076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273076.Bytes);
public long this[int i]=>Value[i];

public static A273076Inst Instance=new A273076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273077
{
public static readonly long[] Value={ 1L,5L,13L,29L,57L,73L,121L,141L,209L,241L,297L,329L,469L,501L,613L,633L,781L,837L,905L,1029L,1177L,1257L,1485L,1441L,1673L,1825L,1905L,2109L,2293L,2413L,2593L,2769L,3001L,3021L,3377L,3401L,3813L,3729L,4157L,4325L,4561L,4689L,4881L,5229L,5509L,5561L,6021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273077Inst : IEnumerable<long>
{
public static readonly long[] Value=A273077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273077.Bytes);
public long this[int i]=>Value[i];

public static A273077Inst Instance=new A273077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273078
{
public static readonly long[] Value={ 1L,5L,29L,141L,633L,2769L,11197L,44277L,175897L,695685L,2759673L,10987473L,43792977L,174845693L,698730301L,2793842913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273078Inst : IEnumerable<long>
{
public static readonly long[] Value=A273078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273078.Bytes);
public long this[int i]=>Value[i];

public static A273078Inst Instance=new A273078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273079
{
public static readonly long[] Value={ 1L,6L,19L,48L,105L,178L,299L,440L,649L,890L,1187L,1516L,1985L,2486L,3099L,3732L,4513L,5350L,6255L,7284L,8461L,9718L,11203L,12644L,14317L,16142L,18047L,20156L,22449L,24862L,27455L,30224L,33225L,36246L,39623L,43024L,46837L,50566L,54723L,59048L,63609L,68298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273079Inst : IEnumerable<long>
{
public static readonly long[] Value=A273079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273079.Bytes);
public long this[int i]=>Value[i];

public static A273079Inst Instance=new A273079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273080
{
public static readonly long[] Value={ 4L,8L,16L,28L,16L,48L,20L,68L,32L,56L,32L,140L,32L,112L,20L,148L,56L,68L,124L,148L,80L,228L,-44L,232L,152L,80L,204L,184L,120L,180L,176L,232L,20L,356L,24L,412L,-84L,428L,168L,236L,128L,192L,348L,280L,52L,460L,300L,204L,160L,388L,228L,420L,8L,516L,248L,456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273080Inst : IEnumerable<long>
{
public static readonly long[] Value=A273080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273080.Bytes);
public long this[int i]=>Value[i];

public static A273080Inst Instance=new A273080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273081
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,6L,1L,3L,9L,9L,0L,3L,5L,1L,4L,0L,6L,9L,4L,0L,2L,1L,5L,0L,2L,0L,7L,0L,3L,8L,9L,3L,9L,9L,5L,7L,3L,8L,8L,7L,5L,0L,8L,3L,9L,1L,2L,4L,2L,3L,7L,5L,2L,8L,9L,3L,7L,2L,7L,9L,9L,8L,6L,3L,1L,3L,9L,1L,4L,4L,3L,7L,0L,4L,5L,5L,1L,8L,7L,4L,5L,3L,4L,8L,5L,1L,2L,8L,5L,4L,2L,4L,9L,3L,0L,0L,7L,1L,2L,0L,4L,7L,3L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273081Inst : IEnumerable<long>
{
public static readonly long[] Value=A273081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273081.Bytes);
public long this[int i]=>Value[i];

public static A273081Inst Instance=new A273081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273082
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,6L,9L,7L,4L,6L,8L,4L,7L,1L,2L,4L,1L,7L,9L,9L,1L,2L,7L,9L,3L,5L,7L,4L,5L,5L,7L,2L,2L,7L,7L,3L,3L,8L,6L,0L,8L,4L,8L,1L,1L,8L,1L,9L,3L,4L,3L,9L,5L,9L,6L,7L,0L,2L,4L,3L,4L,2L,3L,6L,2L,3L,8L,8L,2L,3L,7L,0L,8L,1L,9L,5L,5L,9L,4L,5L,4L,9L,6L,1L,9L,2L,5L,3L,0L,0L,9L,2L,4L,6L,2L,9L,9L,5L,1L,4L,6L,7L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273082Inst : IEnumerable<long>
{
public static readonly long[] Value=A273082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273082.Bytes);
public long this[int i]=>Value[i];

public static A273082Inst Instance=new A273082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273083
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,3L,0L,1L,4L,0L,3L,4L,5L,5L,0L,7L,8L,0L,1L,2L,9L,2L,2L,1L,5L,0L,6L,5L,4L,9L,0L,3L,9L,0L,8L,0L,8L,0L,2L,2L,3L,6L,1L,7L,8L,9L,5L,4L,9L,4L,8L,6L,6L,7L,3L,4L,7L,7L,7L,4L,3L,7L,4L,8L,7L,6L,2L,8L,2L,1L,3L,3L,1L,0L,3L,1L,5L,1L,3L,9L,6L,2L,7L,4L,2L,8L,0L,5L,8L,1L,4L,3L,4L,4L,2L,8L,4L,2L,9L,8L,5L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273083Inst : IEnumerable<long>
{
public static readonly long[] Value=A273083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273083.Bytes);
public long this[int i]=>Value[i];

public static A273083Inst Instance=new A273083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273084
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,1L,3L,0L,2L,4L,8L,2L,4L,2L,7L,2L,1L,5L,9L,8L,0L,1L,4L,5L,6L,4L,2L,4L,3L,3L,0L,2L,3L,0L,9L,0L,6L,7L,4L,5L,7L,3L,2L,5L,4L,1L,4L,6L,0L,4L,1L,5L,7L,5L,1L,1L,4L,8L,0L,1L,1L,9L,0L,4L,5L,9L,3L,4L,8L,2L,3L,9L,1L,1L,1L,3L,6L,1L,2L,5L,1L,7L,1L,1L,8L,6L,0L,8L,8L,8L,1L,0L,9L,2L,6L,4L,0L,4L,4L,6L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273084Inst : IEnumerable<long>
{
public static readonly long[] Value=A273084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273084.Bytes);
public long this[int i]=>Value[i];

public static A273084Inst Instance=new A273084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273085
{
public static readonly BigInteger[] Value={ 3L,5L,5L,5L,23L,29L,37L,41L,67L,113L,113L,113L,197L,617L,881L,10193L,103867L,521497L,938071L,1106356357L,1546157677L,100343116693L,518914006417L,1145565031404704513L,BigInteger.Parse("135178919999357237393881"),BigInteger.Parse("620712448371732926474772025689944913040651041015217889164158638163856301549281") };
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
public class A273085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273085Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A273085.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A273085.Bytes);
public BigInteger this[int i]=>Value[i];

public static A273085Inst Instance=new A273085Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273086
{
public static readonly long[] Value={ 1L,0L,0L,0L,9L,0L,9L,9L,2L,1L,8L,8L,7L,2L,5L,6L,7L,6L,2L,9L,1L,9L,2L,8L,6L,0L,0L,4L,1L,2L,1L,5L,6L,6L,6L,7L,1L,8L,0L,4L,5L,8L,8L,1L,4L,6L,7L,3L,0L,3L,0L,1L,3L,3L,0L,8L,5L,9L,2L,4L,1L,7L,9L,6L,8L,1L,3L,9L,5L,8L,5L,4L,2L,0L,8L,7L,9L,5L,0L,0L,5L,6L,3L,3L,2L,7L,5L,4L,2L,2L,0L,2L,2L,1L,8L,2L,9L,1L,1L,4L,7L,4L,2L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273086Inst : IEnumerable<long>
{
public static readonly long[] Value=A273086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273086.Bytes);
public long this[int i]=>Value[i];

public static A273086Inst Instance=new A273086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273087
{
public static readonly long[] Value={ 1L,0L,2L,3L,5L,2L,3L,9L,9L,9L,3L,4L,1L,0L,0L,5L,8L,6L,3L,4L,9L,7L,7L,9L,8L,6L,5L,6L,7L,2L,4L,9L,7L,1L,8L,5L,2L,5L,6L,4L,9L,1L,4L,6L,0L,7L,9L,4L,8L,7L,8L,4L,7L,4L,1L,8L,7L,2L,1L,5L,1L,9L,8L,5L,8L,7L,4L,1L,3L,4L,7L,9L,7L,7L,6L,7L,8L,4L,6L,0L,3L,1L,1L,1L,3L,0L,2L,2L,8L,5L,7L,7L,4L,6L,8L,7L,6L,0L,1L,9L,3L,3L,5L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273087Inst : IEnumerable<long>
{
public static readonly long[] Value=A273087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273087.Bytes);
public long this[int i]=>Value[i];

public static A273087Inst Instance=new A273087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273088
{
public static readonly long[] Value={ 24L,36L,48L,54L,66L,78L,84L,90L,96L,114L,126L,132L,156L,162L,168L,174L,210L,222L,234L,252L,258L,264L,276L,294L,306L,318L,330L,336L,354L,360L,366L,372L,378L,384L,390L,396L,402L,408L,438L,444L,450L,456L,468L,480L,486L,492L,498L,504L,510L,540L,546L,558L,564L,576L,588L,594L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273088Inst : IEnumerable<long>
{
public static readonly long[] Value=A273088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273088.Bytes);
public long this[int i]=>Value[i];

public static A273088Inst Instance=new A273088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273089
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,3L,0L,0L,5L,6L,0L,0L,586L,882L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273089Inst : IEnumerable<long>
{
public static readonly long[] Value=A273089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273089.Bytes);
public long this[int i]=>Value[i];

public static A273089Inst Instance=new A273089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273090
{
public static readonly long[] Value={ 2L,62L,2L,116L,1532L,2L,200L,6402L,50830L,2L,318L,19884L,446930L,1855110L,2L,476L,51128L,2460462L,34121322L,71292624L,2L,682L,115188L,10106370L,332112068L,2741227176L,2833906726L,2L,946L,235180L,33905948L,2177193500L,47162138964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273090Inst : IEnumerable<long>
{
public static readonly long[] Value=A273090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273090.Bytes);
public long this[int i]=>Value[i];

public static A273090Inst Instance=new A273090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273091
{
public static readonly long[] Value={ 6L,45L,2475L,2175L,5775L,5075L,13475L,15925L,2975L,2730L,510L,468L,396L,348L,924L,812L,2156L,2548L,476L,28L,210L,1575L,225L,12375L,10875L,28875L,25375L,67375L,79625L,14875L,13650L,2550L,2340L,1980L,1740L,4620L,4060L,10780L,12740L,2380L,2184L,408L,152L,92L,380L,230L,950L,575L,2375L,9625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273091Inst : IEnumerable<long>
{
public static readonly long[] Value=A273091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273091.Bytes);
public long this[int i]=>Value[i];

public static A273091Inst Instance=new A273091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273092
{
public static readonly long[] Value={ 0L,1L,3L,7L,51L,13L,36L,721L,552L,115L,3201L,7402L,5904L,1918L,38361L,76723L,53556L,170131L,341262L,782425L,5758401L,1517902L,3034914L,7068838L,51277761L,13445533L,36880176L,727712431L,554534862L,119078635L,3281473701L,7463847412L,5927694924L,1954399858L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273092Inst : IEnumerable<long>
{
public static readonly long[] Value=A273092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273092.Bytes);
public long this[int i]=>Value[i];

public static A273092Inst Instance=new A273092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273093
{
public static readonly long[] Value={ 1L,7L,4L,2L,1L,9L,7L,8L,3L,0L,3L,4L,7L,2L,4L,7L,0L,0L,5L,5L,8L,5L,7L,4L,0L,7L,2L,1L,8L,0L,5L,3L,4L,6L,9L,1L,6L,5L,1L,1L,0L,5L,7L,5L,1L,8L,7L,0L,3L,1L,3L,5L,5L,7L,2L,3L,3L,2L,6L,3L,7L,0L,5L,1L,6L,4L,6L,0L,0L,7L,3L,6L,0L,3L,1L,0L,6L,7L,9L,3L,2L,6L,2L,5L,3L,6L,5L,9L,3L,0L,3L,5L,9L,1L,0L,6L,6L,0L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273093Inst : IEnumerable<long>
{
public static readonly long[] Value=A273093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273093.Bytes);
public long this[int i]=>Value[i];

public static A273093Inst Instance=new A273093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273094
{
public static readonly long[] Value={ 203457869L,206893558L,507083396L,506815954L,102668478970L,895233580L,26475394180L,887692930L,10708845258L,13306408052L,155503137452L,963213572L,803503960576L,40349550036L,203264657940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273094Inst : IEnumerable<long>
{
public static readonly long[] Value=A273094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273094.Bytes);
public long this[int i]=>Value[i];

public static A273094Inst Instance=new A273094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273095
{
public static readonly BigInteger[] Value={ 1L,1L,3L,9L,34L,131L,544L,2321L,10219L,45858L,209422L,969115L,4536240L,21435168L,102120900L,489966937L,2365411849L,11481936107L,56005441585L,274365808690L,1349355995822L,6659759051278L,32975144338094L,163753271207603L,815384381782875L,4070152108372400L,20363490114853946L,102097178305283104L,512896449689275282L,2581316849641991364L,13013547947445475296UL,BigInteger.Parse("65712064033864711137"),BigInteger.Parse("332312118095745844303"),BigInteger.Parse("1682904769274022037513") };
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
public class A273095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273095Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A273095.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A273095.Bytes);
public BigInteger this[int i]=>Value[i];

public static A273095Inst Instance=new A273095Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273096
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,1L,3L,3L,4L,6L,18L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273096Inst : IEnumerable<long>
{
public static readonly long[] Value=A273096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273096.Bytes);
public long this[int i]=>Value[i];

public static A273096Inst Instance=new A273096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273097
{
public static readonly long[] Value={ 1L,2L,4L,5L,13L,25L,27L,32L,37L,38L,40L,45L,57L,80L,91L,151L,214L,441L,644L,764L,797L,2329L,2931L,4324L,21794L,22396L,24041L,1222L,46420L,51489L,55165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273097Inst : IEnumerable<long>
{
public static readonly long[] Value=A273097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273097.Bytes);
public long this[int i]=>Value[i];

public static A273097Inst Instance=new A273097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273098
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,6L,4L,8L,13L,11L,13L,8L,17L,20L,12L,16L,23L,19L,35L,28L,41L,23L,41L,20L,37L,53L,47L,29L,61L,31L,76L,32L,63L,67L,61L,37L,101L,73L,131L,41L,101L,43L,67L,108L,83L,47L,119L,70L,137L,61L,118L,53L,127L,113L,137L,128L,167L,59L,179L,61L,173L,202L,206L,64L,239L,67L,334L,278L,213L,71L,179L,73L,185L,386L,269L,218L,277L,79L,197L,283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273098Inst : IEnumerable<long>
{
public static readonly long[] Value=A273098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273098.Bytes);
public long this[int i]=>Value[i];

public static A273098Inst Instance=new A273098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273099
{
public static readonly long[] Value={ 12L,90L,675L,37125L,32625L,86625L,76125L,202125L,177625L,471625L,557375L,104125L,95550L,17850L,16380L,3060L,2808L,2376L,2088L,5544L,4872L,12936L,11368L,30184L,35672L,6664L,392L,2940L,22050L,165375L,23625L,3375L,185625L,163125L,433125L,380625L,1010625L,888125L,2358125L,2786875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273099Inst : IEnumerable<long>
{
public static readonly long[] Value=A273099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273099.Bytes);
public long this[int i]=>Value[i];

public static A273099Inst Instance=new A273099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273100
{
public static readonly long[] Value={ 1L,1L,0L,3L,8L,3L,9L,6L,5L,3L,6L,1L,7L,6L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273100Inst : IEnumerable<long>
{
public static readonly long[] Value=A273100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273100.Bytes);
public long this[int i]=>Value[i];

public static A273100Inst Instance=new A273100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273101
{
public static readonly long[] Value={ 7714800L,8126820L,8341260L,8646060L,9200880L,9422970L,13224270L,13597920L,14012460L,14124630L,15305700L,17008680L,17563920L,18830940L,22603740L,22812150L,24576240L,25197300L,26147040L,26196900L,26932950L,27225240L,30305580L,31214640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273101Inst : IEnumerable<long>
{
public static readonly long[] Value=A273101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273101.Bytes);
public long this[int i]=>Value[i];

public static A273101Inst Instance=new A273101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273102
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,3L,2L,1L,2L,4L,1L,2L,1L,1L,5L,4L,1L,2L,3L,6L,1L,1L,3L,0L,2L,2L,1L,7L,6L,1L,2L,4L,8L,1L,2L,4L,1L,2L,1L,1L,3L,9L,2L,6L,4L,1L,2L,5L,10L,1L,3L,5L,2L,2L,0L,1L,11L,10L,1L,2L,3L,4L,6L,12L,1L,1L,1L,2L,6L,0L,0L,1L,4L,0L,1L,3L,1L,2L,1L,1L,13L,12L,1L,2L,7L,14L,1L,5L,7L,4L,2L,-2L,1L,3L,5L,15L,2L,2L,10L,0L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273102Inst : IEnumerable<long>
{
public static readonly long[] Value=A273102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273102.Bytes);
public long this[int i]=>Value[i];

public static A273102Inst Instance=new A273102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273103
{
public static readonly long[] Value={ 1L,4L,6L,11L,10L,21L,14L,26L,25L,31L,22L,52L,26L,41L,54L,57L,34L,86L,38L,66L,72L,61L,46L,103L,71L,71L,90L,102L,58L,205L,62L,120L,108L,91L,134L,157L,74L,101L,126L,75L,82L,329L,86L,174L,218L,121L,94L,110L,141L,158L,162L,210L,106L,373L,202L,269L,180L,151L,118L,-437L,122L,161L,250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273103Inst : IEnumerable<long>
{
public static readonly long[] Value=A273103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273103.Bytes);
public long this[int i]=>Value[i];

public static A273103Inst Instance=new A273103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273104
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,3L,2L,1L,2L,4L,1L,2L,1L,1L,5L,4L,1L,2L,3L,6L,1L,1L,3L,0L,2L,2L,1L,7L,6L,1L,2L,4L,8L,1L,2L,4L,1L,2L,1L,1L,3L,9L,2L,6L,4L,1L,2L,5L,10L,1L,3L,5L,2L,2L,0L,1L,11L,10L,1L,2L,3L,4L,6L,12L,1L,1L,1L,2L,6L,0L,0L,1L,4L,0L,1L,3L,1L,2L,1L,1L,13L,12L,1L,2L,7L,14L,1L,5L,7L,4L,2L,2L,1L,3L,5L,15L,2L,2L,10L,0L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273104Inst : IEnumerable<long>
{
public static readonly long[] Value=A273104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273104.Bytes);
public long this[int i]=>Value[i];

public static A273104Inst Instance=new A273104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273105
{
public static readonly long[] Value={ 0L,2L,2L,6L,3L,9L,8L,14L,5L,15L,10L,20L,15L,25L,20L,30L,9L,27L,14L,32L,19L,37L,24L,42L,29L,47L,34L,52L,39L,57L,44L,62L,17L,51L,22L,56L,27L,61L,32L,66L,37L,71L,42L,76L,47L,81L,52L,86L,57L,91L,62L,96L,67L,101L,72L,106L,77L,111L,82L,116L,87L,121L,92L,126L,33L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273105Inst : IEnumerable<long>
{
public static readonly long[] Value=A273105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273105.Bytes);
public long this[int i]=>Value[i];

public static A273105Inst Instance=new A273105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273106
{
public static readonly long[] Value={ 0L,2L,3L,5L,6L,8L,9L,10L,14L,15L,17L,19L,20L,22L,24L,25L,27L,29L,30L,32L,33L,34L,37L,38L,39L,42L,43L,44L,47L,48L,51L,52L,53L,56L,57L,58L,61L,62L,63L,65L,66L,67L,68L,70L,71L,72L,73L,75L,76L,77L,78L,80L,81L,82L,83L,85L,86L,87L,88L,90L,91L,92L,93L,95L,96L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273106Inst : IEnumerable<long>
{
public static readonly long[] Value=A273106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273106.Bytes);
public long this[int i]=>Value[i];

public static A273106Inst Instance=new A273106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273107
{
public static readonly long[] Value={ 0L,1L,2L,1L,0L,1L,1L,1L,1L,1L,3L,4L,2L,3L,2L,1L,2L,3L,3L,1L,2L,3L,1L,1L,1L,1L,4L,3L,3L,4L,1L,1L,5L,3L,2L,3L,3L,5L,2L,1L,2L,1L,3L,3L,3L,3L,2L,4L,5L,5L,2L,4L,5L,6L,1L,3L,7L,3L,5L,4L,2L,6L,4L,1L,5L,4L,5L,4L,7L,7L,4L,3L,5L,4L,5L,6L,2L,10L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273107Inst : IEnumerable<long>
{
public static readonly long[] Value=A273107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273107.Bytes);
public long this[int i]=>Value[i];

public static A273107Inst Instance=new A273107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273108
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,3L,1L,2L,3L,5L,3L,1L,3L,4L,1L,1L,5L,4L,3L,3L,3L,4L,1L,3L,5L,9L,4L,1L,6L,5L,3L,2L,5L,7L,6L,3L,3L,7L,1L,5L,9L,5L,3L,3L,6L,5L,1L,1L,6L,10L,6L,3L,6L,9L,3L,4L,4L,5L,8L,1L,6L,8L,2L,1L,10L,10L,2L,5L,6L,6L,2L,4L,6L,11L,7L,3L,6L,5L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273108Inst : IEnumerable<long>
{
public static readonly long[] Value=A273108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273108.Bytes);
public long this[int i]=>Value[i];

public static A273108Inst Instance=new A273108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273109
{
public static readonly long[] Value={ 1L,2L,4L,8L,12L,16L,32L,64L,128L,256L,512L,1024L,2048L,4096L,8192L,16384L,32768L,65536L,131072L,262144L,524288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273109Inst : IEnumerable<long>
{
public static readonly long[] Value=A273109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273109.Bytes);
public long this[int i]=>Value[i];

public static A273109Inst Instance=new A273109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273110
{
public static readonly long[] Value={ 1L,2L,2L,1L,2L,3L,1L,2L,3L,3L,3L,2L,2L,2L,2L,1L,5L,6L,2L,2L,2L,3L,1L,3L,3L,4L,6L,1L,4L,4L,1L,2L,6L,5L,3L,3L,2L,5L,1L,3L,6L,5L,4L,3L,4L,3L,1L,2L,4L,7L,7L,2L,4L,8L,1L,2L,6L,3L,4L,2L,4L,5L,4L,1L,7L,8L,4L,5L,4L,4L,1L,6L,5L,7L,5L,2L,4L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273110Inst : IEnumerable<long>
{
public static readonly long[] Value=A273110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273110.Bytes);
public long this[int i]=>Value[i];

public static A273110Inst Instance=new A273110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273111
{
public static readonly long[] Value={ 1L,8L,20L,41L,61L,93L,129L,180L,208L,268L,321L,413L,433L,592L,592L,773L,797L,885L,1028L,1085L,1233L,1349L,1504L,1661L,1692L,1941L,2052L,2300L,2349L,2549L,2745L,3004L,2952L,3409L,3405L,3729L,3817L,4281L,4237L,4712L,4801L,5049L,5252L,5621L,5756L,6044L,6412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273111Inst : IEnumerable<long>
{
public static readonly long[] Value=A273111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273111.Bytes);
public long this[int i]=>Value[i];

public static A273111Inst Instance=new A273111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273112
{
public static readonly long[] Value={ 1L,8L,41L,180L,773L,3004L,12008L,48944L,192448L,775968L,3100457L,12383769L,49500941L,198083389L,792197180L,3168915349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273112Inst : IEnumerable<long>
{
public static readonly long[] Value=A273112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273112.Bytes);
public long this[int i]=>Value[i];

public static A273112Inst Instance=new A273112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273113
{
public static readonly long[] Value={ 1L,9L,29L,70L,131L,224L,353L,533L,741L,1009L,1330L,1743L,2176L,2768L,3360L,4133L,4930L,5815L,6843L,7928L,9161L,10510L,12014L,13675L,15367L,17308L,19360L,21660L,24009L,26558L,29303L,32307L,35259L,38668L,42073L,45802L,49619L,53900L,58137L,62849L,67650L,72699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273113Inst : IEnumerable<long>
{
public static readonly long[] Value=A273113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273113.Bytes);
public long this[int i]=>Value[i];

public static A273113Inst Instance=new A273113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273114
{
public static readonly long[] Value={ 7L,12L,21L,20L,32L,36L,51L,28L,60L,53L,92L,20L,159L,0L,181L,24L,88L,143L,57L,148L,116L,155L,157L,31L,249L,111L,248L,49L,200L,196L,259L,-52L,457L,-4L,324L,88L,464L,-44L,475L,89L,248L,203L,369L,135L,288L,368L,277L,196L,172L,452L,451L,-32L,648L,-3L,616L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273114Inst : IEnumerable<long>
{
public static readonly long[] Value=A273114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273114.Bytes);
public long this[int i]=>Value[i];

public static A273114Inst Instance=new A273114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273115
{
public static readonly long[] Value={ 1L,5L,9L,17L,17L,37L,49L,41L,57L,77L,97L,113L,141L,149L,225L,189L,249L,249L,361L,257L,349L,409L,437L,529L,525L,537L,637L,681L,685L,833L,853L,977L,1073L,957L,1133L,1077L,1133L,1253L,1193L,1393L,1405L,1469L,1537L,1721L,1793L,1953L,1949L,2205L,1985L,2225L,2365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273115Inst : IEnumerable<long>
{
public static readonly long[] Value=A273115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273115.Bytes);
public long this[int i]=>Value[i];

public static A273115Inst Instance=new A273115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273116
{
public static readonly long[] Value={ 1L,5L,17L,41L,189L,977L,4013L,14577L,60617L,241005L,964021L,3841653L,15349713L,61414133L,245738437L,982690957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273116Inst : IEnumerable<long>
{
public static readonly long[] Value=A273116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273116.Bytes);
public long this[int i]=>Value[i];

public static A273116Inst Instance=new A273116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273117
{
public static readonly long[] Value={ 1L,6L,15L,32L,49L,86L,135L,176L,233L,310L,407L,520L,661L,810L,1035L,1224L,1473L,1722L,2083L,2340L,2689L,3098L,3535L,4064L,4589L,5126L,5763L,6444L,7129L,7962L,8815L,9792L,10865L,11822L,12955L,14032L,15165L,16418L,17611L,19004L,20409L,21878L,23415L,25136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273117Inst : IEnumerable<long>
{
public static readonly long[] Value=A273117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273117.Bytes);
public long this[int i]=>Value[i];

public static A273117Inst Instance=new A273117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273118
{
public static readonly long[] Value={ 4L,4L,8L,0L,20L,12L,-8L,16L,20L,20L,16L,28L,8L,76L,-36L,60L,0L,112L,-104L,92L,60L,28L,92L,-4L,12L,100L,44L,4L,148L,20L,124L,96L,-116L,176L,-56L,56L,120L,-60L,200L,12L,64L,68L,184L,72L,160L,-4L,256L,-220L,240L,140L,-32L,40L,320L,-124L,268L,-4L,52L,228L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273118Inst : IEnumerable<long>
{
public static readonly long[] Value=A273118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273118.Bytes);
public long this[int i]=>Value[i];

public static A273118Inst Instance=new A273118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273119
{
public static readonly long[] Value={ 1L,4L,17L,25L,60L,65L,137L,136L,224L,221L,345L,328L,476L,469L,641L,664L,796L,849L,1001L,1068L,1220L,1285L,1493L,1524L,1736L,1797L,2045L,2096L,2336L,2429L,2661L,2824L,3048L,3193L,3356L,3636L,3925L,3953L,4408L,4396L,4865L,4837L,5316L,5352L,5769L,5865L,6288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273119Inst : IEnumerable<long>
{
public static readonly long[] Value=A273119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273119.Bytes);
public long this[int i]=>Value[i];

public static A273119Inst Instance=new A273119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273120
{
public static readonly long[] Value={ 1L,4L,25L,136L,664L,2824L,11668L,47364L,191084L,768413L,3084521L,12382973L,49700585L,199608265L,801170741L,3207852473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273120Inst : IEnumerable<long>
{
public static readonly long[] Value=A273120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273120.Bytes);
public long this[int i]=>Value[i];

public static A273120Inst Instance=new A273120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273121
{
public static readonly long[] Value={ 1L,5L,22L,47L,107L,172L,309L,445L,669L,890L,1235L,1563L,2039L,2508L,3149L,3813L,4609L,5458L,6459L,7527L,8747L,10032L,11525L,13049L,14785L,16582L,18627L,20723L,23059L,25488L,28149L,30973L,34021L,37214L,40570L,44206L,48131L,52084L,56492L,60888L,65753L,70590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273121Inst : IEnumerable<long>
{
public static readonly long[] Value=A273121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273121.Bytes);
public long this[int i]=>Value[i];

public static A273121Inst Instance=new A273121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273122
{
public static readonly long[] Value={ 3L,13L,8L,35L,5L,72L,-1L,88L,-3L,124L,-17L,148L,-7L,172L,23L,132L,53L,152L,67L,152L,65L,208L,31L,212L,61L,248L,51L,240L,93L,232L,163L,224L,145L,163L,280L,289L,28L,455L,-12L,469L,-28L,479L,36L,417L,96L,423L,208L,269L,260L,363L,168L,561L,16L,655L,72L,397L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273122Inst : IEnumerable<long>
{
public static readonly long[] Value=A273122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273122.Bytes);
public long this[int i]=>Value[i];

public static A273122Inst Instance=new A273122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273123
{
public static readonly long[] Value={ 85L,130L,340L,520L,1360L,2080L,5440L,8320L,21760L,33280L,87040L,133120L,348160L,532480L,1392640L,2129920L,5570560L,8519680L,22282240L,34078720L,89128960L,136314880L,356515840L,545259520L,1426063360L,2181038080L,5704253440L,8724152320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273123Inst : IEnumerable<long>
{
public static readonly long[] Value=A273123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273123.Bytes);
public long this[int i]=>Value[i];

public static A273123Inst Instance=new A273123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273124
{
public static readonly long[] Value={ 6L,24L,28L,30L,48L,80L,84L,90L,96L,108L,120L,126L,132L,140L,150L,156L,160L,168L,192L,198L,200L,204L,210L,216L,220L,228L,240L,252L,260L,264L,270L,276L,300L,312L,320L,330L,336L,348L,372L,378L,384L,390L,396L,400L,408L,420L,432L,440L,444L,448L,450L,456L,462L,480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273124Inst : IEnumerable<long>
{
public static readonly long[] Value=A273124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273124.Bytes);
public long this[int i]=>Value[i];

public static A273124Inst Instance=new A273124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273125
{
public static readonly long[] Value={ 117L,667L,737L,917L,997L,1003L,1083L,1237L,1283L,1503L,1577L,1723L,2077L,2357L,2403L,2637L,2963L,3117L,3197L,3243L,3803L,4583L,4737L,4923L,5717L,5997L,6043L,6197L,6277L,6283L,6517L,6717L,6827L,7163L,7397L,7663L,7723L,7817L,8017L,8563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273125Inst : IEnumerable<long>
{
public static readonly long[] Value=A273125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273125.Bytes);
public long this[int i]=>Value[i];

public static A273125Inst Instance=new A273125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273126
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,4L,1L,2L,2L,4L,2L,5L,4L,6L,1L,2L,2L,4L,2L,5L,4L,6L,2L,7L,5L,5L,4L,5L,6L,8L,1L,2L,2L,4L,2L,5L,4L,6L,2L,7L,5L,5L,4L,5L,6L,8L,2L,9L,7L,6L,5L,6L,5L,6L,4L,8L,5L,7L,6L,6L,8L,10L,1L,2L,2L,4L,2L,5L,4L,6L,2L,7L,5L,5L,4L,5L,6L,8L,2L,9L,7L,6L,5L,6L,5L,6L,4L,8L,5L,7L,6L,6L,8L,10L,2L,11L,9L,7L,7L,8L,6L,9L,5L,7L,6L,8L,5L,7L,6L,9L,4L,9L,8L,11L,5L,6L,7L,7L,6L,7L,6L,8L,8L,9L,10L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273126Inst : IEnumerable<long>
{
public static readonly long[] Value=A273126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273126.Bytes);
public long this[int i]=>Value[i];

public static A273126Inst Instance=new A273126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273127
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,2L,2L,0L,2L,0L,0L,0L,1L,1L,0L,2L,0L,2L,1L,1L,1L,0L,0L,5L,0L,5L,2L,3L,2L,1L,1L,0L,0L,1L,0L,1L,2L,0L,1L,2L,0L,3L,6L,1L,0L,3L,5L,1L,3L,7L,0L,1L,2L,0L,1L,0L,0L,1L,3L,5L,1L,0L,1L,0L,0L,1L,5L,0L,2L,1L,1L,1L,3L,0L,1L,1L,3L,0L,5L,0L,0L,0L,3L,2L,0L,2L,1L,0L,0L,0L,7L,2L,2L,0L,3L,0L,1L,4L,1L,2L,2L,0L,0L,3L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,2L,2L,4L,1L,0L,0L,3L,0L,0L,4L,0L,2L,0L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273127Inst : IEnumerable<long>
{
public static readonly long[] Value=A273127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273127.Bytes);
public long this[int i]=>Value[i];

public static A273127Inst Instance=new A273127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273128
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,3L,0L,3L,0L,2L,0L,0L,2L,5L,0L,1L,2L,0L,1L,2L,4L,3L,0L,0L,1L,2L,0L,0L,1L,7L,3L,2L,3L,0L,1L,0L,0L,0L,0L,3L,2L,3L,1L,3L,2L,0L,0L,0L,0L,2L,2L,0L,0L,0L,1L,0L,1L,2L,1L,0L,3L,4L,0L,0L,0L,3L,0L,0L,0L,1L,1L,1L,2L,2L,0L,3L,0L,0L,1L,0L,2L,1L,3L,0L,0L,2L,0L,1L,1L,2L,0L,1L,1L,1L,8L,1L,3L,2L,3L,2L,1L,2L,3L,0L,1L,1L,1L,2L,5L,0L,0L,2L,6L,2L,3L,1L,0L,2L,0L,2L,1L,3L,1L,1L,0L,0L,5L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273128Inst : IEnumerable<long>
{
public static readonly long[] Value=A273128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273128.Bytes);
public long this[int i]=>Value[i];

public static A273128Inst Instance=new A273128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273129
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273129Inst : IEnumerable<long>
{
public static readonly long[] Value=A273129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273129.Bytes);
public long this[int i]=>Value[i];

public static A273129Inst Instance=new A273129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273130
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,11L,13L,16L,17L,19L,21L,23L,25L,27L,29L,31L,32L,33L,37L,39L,41L,43L,47L,49L,51L,53L,55L,57L,59L,61L,64L,65L,67L,69L,71L,73L,79L,81L,83L,85L,87L,89L,93L,95L,97L,101L,103L,107L,109L,111L,113L,115L,119L,121L,123L,125L,127L,128L,129L,131L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273130Inst : IEnumerable<long>
{
public static readonly long[] Value=A273130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273130.Bytes);
public long this[int i]=>Value[i];

public static A273130Inst Instance=new A273130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273131
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,14L,16L,24L,32L,64L,128L,152L,256L,512L,1024L,2048L,4096L,8192L,16384L,32768L,65536L,131072L,262144L,524288L,1048576L,2097152L,4194304L,8388608L,16777216L,33554432L,67108864L,134217728L,268435456L,536870912L,1073741824L,2147483648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273131Inst : IEnumerable<long>
{
public static readonly long[] Value=A273131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273131.Bytes);
public long this[int i]=>Value[i];

public static A273131Inst Instance=new A273131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273132
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,3L,1L,1L,2L,1L,2L,4L,1L,4L,5L,1L,1L,2L,0L,1L,3L,2L,2L,3L,6L,1L,6L,7L,1L,1L,2L,1L,2L,4L,1L,2L,4L,8L,1L,2L,3L,4L,6L,9L,1L,1L,2L,2L,3L,5L,0L,2L,5L,10L,1L,10L,11L,1L,1L,2L,0L,1L,3L,0L,0L,1L,4L,1L,1L,1L,2L,6L,1L,2L,3L,4L,6L,12L,1L,12L,13L,1L,1L,2L,4L,5L,7L,2L,2L,7L,14L,1L,2L,3L,0L,2L,5L,8L,8L,10L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273132Inst : IEnumerable<long>
{
public static readonly long[] Value=A273132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273132.Bytes);
public long this[int i]=>Value[i];

public static A273132Inst Instance=new A273132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273133
{
public static readonly long[] Value={ 0L,1L,1L,3L,1L,4L,1L,7L,5L,10L,1L,11L,1L,16L,7L,15L,1L,6L,1L,31L,13L,28L,1L,36L,9L,34L,19L,31L,1L,-20L,1L,31L,25L,46L,7L,47L,1L,52L,31L,106L,1L,-62L,1L,31L,21L,64L,1L,151L,13L,66L,43L,31L,1L,-34L,19L,8L,49L,82L,1L,727L,1L,88L,71L,63L,25L,-6L,1L,31L,61L,148L,1L,12L,1L,106L,11L,31L,13L,22L,1L,439L,65L,118L,1L,1541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273133Inst : IEnumerable<long>
{
public static readonly long[] Value=A273133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273133.Bytes);
public long this[int i]=>Value[i];

public static A273133Inst Instance=new A273133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273134
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,2L,4L,2L,1L,1L,2L,1L,1L,3L,2L,3L,3L,1L,1L,2L,1L,3L,3L,1L,3L,3L,3L,1L,1L,2L,5L,3L,2L,3L,1L,2L,2L,3L,2L,2L,4L,2L,4L,3L,1L,3L,4L,2L,4L,3L,1L,3L,1L,2L,5L,4L,3L,2L,3L,1L,4L,5L,2L,3L,5L,3L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273134Inst : IEnumerable<long>
{
public static readonly long[] Value=A273134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273134.Bytes);
public long this[int i]=>Value[i];

public static A273134Inst Instance=new A273134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273135
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,3L,2L,1L,2L,1L,4L,2L,1L,1L,5L,4L,1L,2L,1L,3L,1L,0L,6L,3L,2L,2L,1L,7L,6L,1L,2L,1L,4L,2L,1L,8L,4L,2L,1L,1L,3L,2L,9L,6L,4L,1L,2L,1L,5L,3L,2L,10L,5L,2L,0L,1L,11L,10L,1L,2L,1L,3L,1L,0L,4L,1L,0L,0L,6L,2L,1L,1L,1L,12L,6L,4L,3L,2L,1L,1L,13L,12L,1L,2L,1L,7L,5L,4L,14L,7L,2L,-2L,1L,3L,2L,5L,2L,0L,15L,10L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273135Inst : IEnumerable<long>
{
public static readonly long[] Value=A273135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273135.Bytes);
public long this[int i]=>Value[i];

public static A273135Inst Instance=new A273135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273136
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,3L,1L,1L,1L,2L,2L,4L,1L,4L,5L,1L,1L,0L,2L,2L,1L,2L,3L,3L,6L,1L,6L,7L,1L,1L,1L,1L,2L,2L,2L,4L,4L,8L,1L,2L,4L,3L,6L,9L,1L,1L,2L,0L,2L,3L,2L,5L,5L,10L,1L,10L,11L,1L,1L,0L,0L,1L,1L,2L,1L,0L,1L,2L,3L,1L,1L,3L,4L,2L,4L,6L,6L,12L,1L,12L,13L,1L,1L,4L,-2L,2L,5L,2L,7L,7L,14L,1L,2L,0L,8L,3L,2L,8L,5L,10L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273136Inst : IEnumerable<long>
{
public static readonly long[] Value=A273136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273136.Bytes);
public long this[int i]=>Value[i];

public static A273136Inst Instance=new A273136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273137
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,3L,1L,1L,1L,2L,2L,4L,1L,4L,5L,1L,1L,0L,2L,2L,1L,2L,3L,3L,6L,1L,6L,7L,1L,1L,1L,1L,2L,2L,2L,4L,4L,8L,1L,2L,4L,3L,6L,9L,1L,1L,2L,0L,2L,3L,2L,5L,5L,10L,1L,10L,11L,1L,1L,0L,0L,1L,1L,2L,1L,0L,1L,2L,3L,1L,1L,3L,4L,2L,4L,6L,6L,12L,1L,12L,13L,1L,1L,4L,2L,2L,5L,2L,7L,7L,14L,1L,2L,0L,8L,3L,2L,8L,5L,10L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273137Inst : IEnumerable<long>
{
public static readonly long[] Value=A273137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273137.Bytes);
public long this[int i]=>Value[i];

public static A273137Inst Instance=new A273137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273138
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,1L,5L,2L,3L,1L,1L,2L,1L,2L,3L,2L,3L,1L,3L,1L,3L,2L,4L,1L,2L,1L,2L,2L,1L,2L,3L,2L,3L,2L,1L,3L,2L,1L,2L,1L,3L,4L,3L,4L,3L,2L,1L,6L,5L,4L,2L,1L,2L,3L,5L,2L,3L,1L,3L,1L,6L,1L,3L,1L,6L,5L,1L,1L,5L,4L,3L,2L,1L,2L,3L,2L,1L,2L,5L,6L,10L,8L,7L,4L,3L,2L,1L,6L,5L,4L,3L,5L,4L,4L,2L,7L,5L,4L,2L,2L,4L,2L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273138Inst : IEnumerable<long>
{
public static readonly long[] Value=A273138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273138.Bytes);
public long this[int i]=>Value[i];

public static A273138Inst Instance=new A273138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273139
{
public static readonly long[] Value={ 1L,2L,3L,5L,9L,10L,17L,20L,26L,28L,36L,44L,45L,54L,64L,65L,76L,78L,103L,105L,134L,135L,168L,171L,189L,190L,230L,252L,253L,275L,298L,299L,323L,324L,325L,376L,377L,378L,405L,406L,463L,493L,494L,627L,628L,629L,630L,736L,737L,738L,740L,741L,779L,859L,899L,902L,944L,946L,1033L,1035L,1171L,1176L,1223L,1225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273139Inst : IEnumerable<long>
{
public static readonly long[] Value=A273139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273139.Bytes);
public long this[int i]=>Value[i];

public static A273139Inst Instance=new A273139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273140
{
public static readonly long[] Value={ 1L,3L,6L,11L,17L,25L,34L,46L,59L,74L,90L,109L,129L,151L,174L,201L,229L,259L,290L,323L,358L,394L,434L,475L,518L,562L,609L,657L,707L,758L,814L,871L,930L,990L,1052L,1116L,1181L,1249L,1318L,1389L,1462L,1536L,1615L,1695L,1777L,1860L,1946L,2033L,2122L,2212L,2305L,2400L,2496L,2594L,2694L,2795L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273140Inst : IEnumerable<long>
{
public static readonly long[] Value=A273140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273140.Bytes);
public long this[int i]=>Value[i];

public static A273140Inst Instance=new A273140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273141
{
public static readonly long[] Value={ 1L,5L,33L,169L,765L,3073L,12125L,48825L,195329L,783421L,3128065L,12516113L,50042885L,200169857L,800593533L,3202109089L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273141Inst : IEnumerable<long>
{
public static readonly long[] Value=A273141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273141.Bytes);
public long this[int i]=>Value[i];

public static A273141Inst Instance=new A273141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273142
{
public static readonly long[] Value={ 1L,6L,19L,52L,101L,194L,291L,460L,645L,906L,1187L,1584L,1965L,2550L,3099L,3864L,4577L,5518L,6431L,7580L,8653L,10130L,11539L,13264L,15049L,16934L,18887L,21240L,23501L,26182L,28759L,31832L,34833L,38198L,41591L,45404L,49113L,53426L,57695L,62488L,67249L,72402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273142Inst : IEnumerable<long>
{
public static readonly long[] Value=A273142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273142.Bytes);
public long this[int i]=>Value[i];

public static A273142Inst Instance=new A273142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273143
{
public static readonly long[] Value={ 4L,8L,20L,16L,44L,4L,72L,16L,76L,20L,116L,-16L,204L,-36L,216L,-52L,228L,-28L,236L,-76L,404L,-68L,316L,60L,100L,68L,400L,-92L,420L,-104L,496L,-72L,364L,28L,420L,-104L,604L,-44L,524L,-32L,392L,32L,636L,-260L,780L,-92L,492L,80L,416L,92L,696L,-96L,820L,-180L,888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273143Inst : IEnumerable<long>
{
public static readonly long[] Value=A273143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273143.Bytes);
public long this[int i]=>Value[i];

public static A273143Inst Instance=new A273143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273144
{
public static readonly long[] Value={ 1L,8L,20L,41L,57L,104L,116L,193L,193L,312L,292L,457L,409L,632L,548L,833L,705L,1064L,884L,1321L,1081L,1608L,1300L,1921L,1537L,2264L,1796L,2633L,2073L,3032L,2372L,3457L,2689L,3912L,3028L,4393L,3385L,4904L,3764L,5441L,4161L,6008L,4580L,6601L,5017L,7224L,5476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273144Inst : IEnumerable<long>
{
public static readonly long[] Value=A273144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273144.Bytes);
public long this[int i]=>Value[i];

public static A273144Inst Instance=new A273144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273145
{
public static readonly long[] Value={ 1L,8L,41L,193L,833L,3457L,14081L,56833L,228353L,915457L,3665921L,14671873L,58703873L,234848257L,939458561L,3757965313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273145Inst : IEnumerable<long>
{
public static readonly long[] Value=A273145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273145.Bytes);
public long this[int i]=>Value[i];

public static A273145Inst Instance=new A273145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273146
{
public static readonly long[] Value={ 1L,9L,29L,70L,127L,231L,347L,540L,733L,1045L,1337L,1794L,2203L,2835L,3383L,4216L,4921L,5985L,6869L,8190L,9271L,10879L,12179L,14100L,15637L,17901L,19697L,22330L,24403L,27435L,29807L,33264L,35953L,39865L,42893L,47286L,50671L,55575L,59339L,64780L,68941L,74949L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273146Inst : IEnumerable<long>
{
public static readonly long[] Value=A273146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273146.Bytes);
public long this[int i]=>Value[i];

public static A273146Inst Instance=new A273146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273147
{
public static readonly long[] Value={ 7L,12L,21L,16L,47L,12L,77L,0L,119L,-20L,165L,-48L,223L,-84L,285L,-128L,359L,-180L,437L,-240L,527L,-308L,621L,-384L,727L,-468L,837L,-560L,959L,-660L,1085L,-768L,1223L,-884L,1365L,-1008L,1519L,-1140L,1677L,-1280L,1847L,-1428L,2021L,-1584L,2207L,-1748L,2397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273147Inst : IEnumerable<long>
{
public static readonly long[] Value=A273147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273147.Bytes);
public long this[int i]=>Value[i];

public static A273147Inst Instance=new A273147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273148
{
public static readonly long[] Value={ 0L,1L,4L,2L,164L,19L,3L,5L,16L,14L,12L,10L,8L,6L,8228L,28L,51L,26L,158L,24L,7L,9L,11L,13L,15L,17L,46L,90L,44L,88L,42L,86L,40L,84L,38L,82L,36L,80L,34L,78L,32L,147L,1975L,18L,22L,20L,255L,73L,1971L,71L,714L,69L,424L,67L,250L,65L,421L,63L,137L,61L,246L,59L,707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273148Inst : IEnumerable<long>
{
public static readonly long[] Value=A273148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273148.Bytes);
public long this[int i]=>Value[i];

public static A273148Inst Instance=new A273148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273149
{
public static readonly long[] Value={ 1L,2L,3L,4L,2L,3L,4L,1L,3L,4L,1L,2L,4L,1L,2L,3L,2L,3L,4L,1L,3L,4L,1L,2L,4L,1L,2L,3L,1L,2L,3L,4L,3L,4L,1L,2L,4L,1L,2L,3L,1L,2L,3L,4L,2L,3L,4L,1L,4L,1L,2L,3L,1L,2L,3L,4L,2L,3L,4L,1L,3L,4L,1L,2L,2L,3L,4L,1L,3L,4L,1L,2L,4L,1L,2L,3L,1L,2L,3L,4L,3L,4L,1L,2L,4L,1L,2L,3L,1L,2L,3L,4L,2L,3L,4L,1L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273149Inst : IEnumerable<long>
{
public static readonly long[] Value=A273149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273149.Bytes);
public long this[int i]=>Value[i];

public static A273149Inst Instance=new A273149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273150
{
public static readonly long[] Value={ 1L,5L,9L,21L,17L,53L,41L,85L,33L,101L,105L,181L,81L,245L,169L,341L,65L,197L,201L,341L,209L,629L,361L,789L,161L,485L,489L,821L,337L,1013L,681L,1365L,129L,389L,393L,661L,401L,1205L,681L,1493L,417L,1253L,1257L,2101L,721L,2165L,1577L,3029L,321L,965L,969L,1621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273150Inst : IEnumerable<long>
{
public static readonly long[] Value=A273150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273150.Bytes);
public long this[int i]=>Value[i];

public static A273150Inst Instance=new A273150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273151
{
public static readonly long[] Value={ 1L,6L,15L,36L,53L,106L,147L,232L,265L,366L,471L,652L,733L,978L,1147L,1488L,1553L,1750L,1951L,2292L,2501L,3130L,3491L,4280L,4441L,4926L,5415L,6236L,6573L,7586L,8267L,9632L,9761L,10150L,10543L,11204L,11605L,12810L,13491L,14984L,15401L,16654L,17911L,20012L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273151Inst : IEnumerable<long>
{
public static readonly long[] Value=A273151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273151.Bytes);
public long this[int i]=>Value[i];

public static A273151Inst Instance=new A273151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273152
{
public static readonly long[] Value={ 4L,4L,12L,-4L,36L,-12L,44L,-52L,68L,4L,76L,-100L,164L,-76L,172L,-276L,132L,4L,140L,-132L,420L,-268L,428L,-628L,324L,4L,332L,-484L,676L,-332L,684L,-1236L,260L,4L,268L,-260L,804L,-524L,812L,-1076L,836L,4L,844L,-1380L,1444L,-588L,1452L,-2708L,644L,4L,652L,-644L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273152Inst : IEnumerable<long>
{
public static readonly long[] Value=A273152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273152.Bytes);
public long this[int i]=>Value[i];

public static A273152Inst Instance=new A273152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273153
{
public static readonly long[] Value={ 0L,1L,1L,5L,3L,27L,29L,121L,31L,503L,507L,2037L,1021L,8179L,8185L,32753L,4095L,131055L,131063L,524269L,262139L,2097131L,2097141L,8388585L,2097149L,33554407L,33554419L,134217701L,67108857L,536870883L,536870897L,2147483617L,134217727L,8589934559L,8589934575L,34359738333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273153Inst : IEnumerable<long>
{
public static readonly long[] Value=A273153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273153.Bytes);
public long this[int i]=>Value[i];

public static A273153Inst Instance=new A273153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273154
{
public static readonly long[] Value={ 1L,2L,4L,8L,14L,26L,48L,88L,160L,292L,532L,972L,1768L,3220L,5866L,10686L,19454L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273154Inst : IEnumerable<long>
{
public static readonly long[] Value=A273154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273154.Bytes);
public long this[int i]=>Value[i];

public static A273154Inst Instance=new A273154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273155
{
public static readonly long[] Value={ 1L,3L,0L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273155Inst : IEnumerable<long>
{
public static readonly long[] Value=A273155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273155.Bytes);
public long this[int i]=>Value[i];

public static A273155Inst Instance=new A273155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273156
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,5L,5L,10L,8L,8L,16L,24L,24L,13L,13L,26L,39L,39L,65L,65L,130L,21L,21L,42L,63L,63L,105L,105L,210L,168L,168L,336L,504L,504L,34L,34L,68L,102L,102L,170L,170L,340L,272L,272L,544L,816L,816L,442L,442L,884L,1326L,1326L,2210L,2210L,4420L,55L,55L,110L,165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273156Inst : IEnumerable<long>
{
public static readonly long[] Value=A273156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273156.Bytes);
public long this[int i]=>Value[i];

public static A273156Inst Instance=new A273156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273157
{
public static readonly long[] Value={ 6L,10L,12L,14L,15L,18L,20L,22L,24L,26L,28L,30L,34L,35L,36L,38L,40L,42L,44L,45L,46L,48L,50L,52L,54L,56L,58L,60L,62L,63L,66L,68L,70L,72L,74L,75L,76L,77L,78L,80L,82L,84L,86L,88L,90L,91L,92L,94L,96L,98L,99L,100L,102L,104L,105L,106L,108L,110L,112L,114L,116L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273157Inst : IEnumerable<long>
{
public static readonly long[] Value=A273157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273157.Bytes);
public long this[int i]=>Value[i];

public static A273157Inst Instance=new A273157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273158
{
public static readonly long[] Value={ 5L,6L,12L,8L,8L,14L,14L,9L,21L,9L,14L,17L,16L,17L,19L,11L,16L,25L,16L,11L,32L,17L,16L,20L,11L,18L,33L,20L,17L,21L,17L,12L,33L,18L,20L,29L,17L,18L,35L,12L,17L,37L,17L,20L,31L,18L,17L,23L,26L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273158Inst : IEnumerable<long>
{
public static readonly long[] Value=A273158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273158.Bytes);
public long this[int i]=>Value[i];

public static A273158Inst Instance=new A273158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273159
{
public static readonly long[] Value={ 0L,7L,16L,25L,34L,43L,52L,59L,61L,68L,70L,77L,86L,95L,106L,115L,124L,133L,142L,149L,151L,158L,160L,167L,176L,185L,194L,205L,214L,223L,232L,239L,241L,248L,250L,257L,266L,275L,284L,293L,304L,313L,322L,329L,331L,338L,340L,347L,356L,365L,374L,383L,392L,399L,403L,412L,419L,421L,428L,430L,437L,446L,455L,464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273159Inst : IEnumerable<long>
{
public static readonly long[] Value=A273159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273159.Bytes);
public long this[int i]=>Value[i];

public static A273159Inst Instance=new A273159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273160
{
public static readonly long[] Value={ 0L,1L,3L,5L,10L,13L,30L,39L,84L,143L,290L,424L,1120L,1697L,3521L,6633L,14012L,22721L,53529L,88607L,189749L,356024L,730697L,1256272L,2889484L,5006918L,10399649L,19706342L,40954970L,72663140L,160499071L,286286349L,597385864L,1134282375L,2340807724L,4251969339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273160Inst : IEnumerable<long>
{
public static readonly long[] Value=A273160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273160.Bytes);
public long this[int i]=>Value[i];

public static A273160Inst Instance=new A273160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273161
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,7L,13L,19L,34L,61L,108L,174L,384L,641L,1166L,2337L,4458L,7828L,16421L,29346L,57231L,114126L,215915L,396491L,839324L,1549146L,2983185L,5978656L,11628952L,21812113L,45099914L,84842925L,166417181L,332267593L,647614074L,1234586894L,2538571022L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273161Inst : IEnumerable<long>
{
public static readonly long[] Value=A273161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273161.Bytes);
public long this[int i]=>Value[i];

public static A273161Inst Instance=new A273161Inst();

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