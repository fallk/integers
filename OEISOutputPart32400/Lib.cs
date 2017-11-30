using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A013917
{
public static readonly long[] Value={ 2L,3L,7L,13L,37L,43L,281L,311L,503L,541L,557L,593L,619L,673L,683L,733L,743L,839L,881L,929L,953L,1061L,1163L,1213L,1249L,1277L,1283L,1307L,1321L,1949L,2029L,2161L,2203L,2213L,2237L,2243L,2297L,2357L,2393L,2411L,2957L,3137L,3251L,3257L,3301L,3413L,3461L,3491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013917Inst : IEnumerable<long>
{
public static readonly long[] Value=A013917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013917.Bytes);
public long this[int i]=>Value[i];

public static A013917Inst Instance=new A013917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013916
{
public static readonly long[] Value={ 1L,2L,4L,6L,12L,14L,60L,64L,96L,100L,102L,108L,114L,122L,124L,130L,132L,146L,152L,158L,162L,178L,192L,198L,204L,206L,208L,214L,216L,296L,308L,326L,328L,330L,332L,334L,342L,350L,356L,358L,426L,446L,458L,460L,464L,480L,484L,488L,512L,530L,536L,548L,568L,620L,630L,676L,680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013916Inst : IEnumerable<long>
{
public static readonly long[] Value=A013916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013916.Bytes);
public long this[int i]=>Value[i];

public static A013916Inst Instance=new A013916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013915
{
public static readonly long[] Value={ 3L,3L,7L,10L,16L,24L,37L,57L,89L,140L,222L,354L,567L,911L,1467L,2366L,3820L,6172L,9977L,16133L,26093L,42208L,68282L,110470L,178731L,289179L,467887L,757042L,1224904L,1981920L,3206797L,5188689L,8395457L,13584116L,21979542L,35563626L,57543135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013915Inst : IEnumerable<long>
{
public static readonly long[] Value=A013915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013915.Bytes);
public long this[int i]=>Value[i];

public static A013915Inst Instance=new A013915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013914
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,8L,12L,16L,33L,62L,67L,186L,316L,280L,1040L,1963L,1702L,6830L,10751L,8679L,45838L,88255L,56292L,264838L,624778L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013914Inst : IEnumerable<long>
{
public static readonly long[] Value=A013914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013914.Bytes);
public long this[int i]=>Value[i];

public static A013914Inst Instance=new A013914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013913
{
public static readonly BigInteger[] Value={ 331776L,2641807540224L,BigInteger.Parse("21035720123168587776"),BigInteger.Parse("167499529910025153071284224"),BigInteger.Parse("1333735776850284124449081472843776"),BigInteger.Parse("10620036506406716776157242913621199028224"),BigInteger.Parse("84563357566790276763032290197830086290913099776"),BigInteger.Parse("673346220481905860719963226704206593022095630190772224") };
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
public class A013913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013913Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013913.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013913.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013913Inst Instance=new A013913Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013912
{
public static readonly BigInteger[] Value={ 13824L,110075314176L,876488338465357824L,BigInteger.Parse("6979147079584381377970176"),BigInteger.Parse("55572324035428505185378394701824"),BigInteger.Parse("442501521100279865673218454734216626176"),BigInteger.Parse("3523473231949594865126345424909586928788045824"),BigInteger.Parse("28056092520079410863331801112675274709253984591282176") };
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
public class A013912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013912Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013912.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013912.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013912Inst Instance=new A013912Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013911
{
public static readonly BigInteger[] Value={ 576L,4586471424L,36520347436056576L,BigInteger.Parse("290797794982682557415424"),BigInteger.Parse("2315513501476187716057433112576"),BigInteger.Parse("18437563379178327736384102280592359424"),BigInteger.Parse("146811384664566452713597726037899455366168576"),BigInteger.Parse("1169003855003308785972158379694803112885582691303424") };
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
public class A013911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013911Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013911.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013911.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013911Inst Instance=new A013911Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013910
{
public static readonly BigInteger[] Value={ 24L,191102976L,1521681143169024L,BigInteger.Parse("12116574790945106558976"),BigInteger.Parse("96479729228174488169059713024"),BigInteger.Parse("768231807465763655682670928358014976"),BigInteger.Parse("6117141027690268863066571918245810640257024") };
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
public class A013910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013910Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013910.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013910.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013910Inst Instance=new A013910Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013909
{
public static readonly BigInteger[] Value={ 279841L,1801152661463L,11592836324538749809UL,BigInteger.Parse("74615470927590710561908487"),BigInteger.Parse("480250763996501976790165756943041"),BigInteger.Parse("3091058643093537522799545838540043339063"),BigInteger.Parse("19895113660064588580108197261066338165074766609"),BigInteger.Parse("128051775540161094255459334683883498184411818540470887") };
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
public class A013909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013909Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013909.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013909.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013909Inst Instance=new A013909Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013908
{
public static readonly BigInteger[] Value={ 12167L,78310985281L,504036361936467383L,BigInteger.Parse("3244150909895248285300369"),BigInteger.Parse("20880467999847912034355032910567"),BigInteger.Parse("134393854047545109686936775588697536481"),BigInteger.Parse("865004941741938633917747707002884268046728983"),BigInteger.Parse("5567468501746134532846058029734065138452687762629169") };
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
public class A013908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013908Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013908.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013908.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013908Inst Instance=new A013908Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013907
{
public static readonly BigInteger[] Value={ 529L,3404825447L,21914624432020321L,BigInteger.Parse("141050039560662968926103"),BigInteger.Parse("907846434775996175406740561329"),BigInteger.Parse("5843211045545439551605946764725979847"),BigInteger.Parse("37608910510519071039902074217516707306379521"),BigInteger.Parse("242063847902005849254176436075394136454464685331703") };
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
public class A013907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013907Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013907.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013907.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013907Inst Instance=new A013907Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013906
{
public static readonly BigInteger[] Value={ 23L,148035889L,952809757913927L,BigInteger.Parse("6132610415680998648961"),BigInteger.Parse("39471584120695485887249589623"),BigInteger.Parse("254052654154149545721997685422868689"),BigInteger.Parse("1635170022196481349560959748587682926364327"),BigInteger.Parse("10524515126174167358877236351104092889324551536161"),BigInteger.Parse("67739389260745218861137988047774370539553852007909099223") };
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
public class A013906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013906Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013906.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013906.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013906Inst Instance=new A013906Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013905
{
public static readonly BigInteger[] Value={ 234256L,1207269217792L,6221821273427820544L,BigInteger.Parse("32064977213018365645815808"),BigInteger.Parse("165251092644282265779977014214656"),BigInteger.Parse("851643319086537701956194499721106030592"),BigInteger.Parse("4389056261830591470007906571986683114651910144"),BigInteger.Parse("22619580800770514778759787562400873673529752979243008") };
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
public class A013905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013905Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013905.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013905.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013905Inst Instance=new A013905Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013904
{
public static readonly BigInteger[] Value={ 10648L,54875873536L,282810057883082752L,BigInteger.Parse("1457498964228107529355264"),BigInteger.Parse("7511413302012830262726227918848"),BigInteger.Parse("38711059958478986452554295441868455936"),BigInteger.Parse("199502557355935975909450298726667414302359552"),BigInteger.Parse("1028162763671387035398172161927312439705897862692864") };
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
public class A013904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013904Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013904.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013904.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013904Inst Instance=new A013904Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013903
{
public static readonly BigInteger[] Value={ 484L,2494357888L,12855002631049216L,BigInteger.Parse("66249952919459433152512"),BigInteger.Parse("341427877364219557396646723584"),BigInteger.Parse("1759593634476317566025195247357657088"),BigInteger.Parse("9068298061633453450429559033030337013743616"),BigInteger.Parse("46734671075972137972644189178514201804813539213312") };
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
public class A013903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013903Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013903.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013903.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013903Inst Instance=new A013903Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013902
{
public static readonly BigInteger[] Value={ 22L,113379904L,584318301411328L,BigInteger.Parse("3011361496339065143296"),BigInteger.Parse("15519448971100888972574851072"),BigInteger.Parse("79981528839832616637508874879893504"),BigInteger.Parse("412195366437884247746798137865015318806528"),BigInteger.Parse("2124303230726006271483826780841554627491524509696"),BigInteger.Parse("10947877107572929152919737180202022857988400441953615872") };
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
public class A013902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013902Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013902.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013902.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013902Inst Instance=new A013902Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013869
{
public static readonly BigInteger[] Value={ 28561L,10604499373L,3937376385699289L,BigInteger.Parse("1461920290375446110677"),BigInteger.Parse("542800770374370512771595361"),BigInteger.Parse("201538126434611150798503956371773"),BigInteger.Parse("74829695578286078013428929473144712489"),BigInteger.Parse("27783742160348572763840067510872319734178277") };
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
public class A013869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013869Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013869.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013869.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013869Inst Instance=new A013869Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013868
{
public static readonly BigInteger[] Value={ 2197L,815730721L,302875106592253L,BigInteger.Parse("112455406951957393129"),BigInteger.Parse("41753905413413116367045797"),BigInteger.Parse("15502932802662396215269535105521"),BigInteger.Parse("5756130429098929077956071497934208653"),BigInteger.Parse("2137210935411428674141543654682486133398329") };
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
public class A013868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013868Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013868.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013868.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013868Inst Instance=new A013868Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013867
{
public static readonly BigInteger[] Value={ 169L,62748517L,23298085122481L,8650415919381337933L,BigInteger.Parse("3211838877954855105157369"),BigInteger.Parse("1192533292512492016559195008117"),BigInteger.Parse("442779263776840698304313192148785281"),BigInteger.Parse("164400841185494513395503358052498933338333"),BigInteger.Parse("61040881526285814362156628321386486455989674569") };
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
public class A013867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013867Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013867.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013867.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013867Inst Instance=new A013867Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013866
{
public static readonly BigInteger[] Value={ 13L,4826809L,1792160394037L,665416609183179841L,BigInteger.Parse("247064529073450392704413"),BigInteger.Parse("91733330193268616658399616009"),BigInteger.Parse("34059943367449284484947168626829637"),BigInteger.Parse("12646218552730347184269489080961456410641"),BigInteger.Parse("4695452425098908797088971409337422035076128813") };
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
public class A013866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013866Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013866.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013866.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013866Inst Instance=new A013866Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013865
{
public static readonly BigInteger[] Value={ 20736L,5159780352L,1283918464548864L,BigInteger.Parse("319479999370622926848"),BigInteger.Parse("79496847203390844133441536"),BigInteger.Parse("19781359483314150527412524285952"),BigInteger.Parse("4922235242952026704037113243122008064"),BigInteger.Parse("1224809639974238708818962962512535510581248") };
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
public class A013865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013865Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013865.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013865.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013865Inst Instance=new A013865Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013864
{
public static readonly BigInteger[] Value={ 1728L,429981696L,106993205379072L,BigInteger.Parse("26623333280885243904"),BigInteger.Parse("6624737266949237011120128"),BigInteger.Parse("1648446623609512543951043690496"),BigInteger.Parse("410186270246002225336426103593500672"),BigInteger.Parse("102067469997853225734913580209377959215104"),BigInteger.Parse("25397652694505813866070015990659936347412758528") };
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
public class A013864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013864Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013864.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013864.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013864Inst Instance=new A013864Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013863
{
public static readonly BigInteger[] Value={ 144L,35831808L,8916100448256L,2218611106740436992L,BigInteger.Parse("552061438912436417593344"),BigInteger.Parse("137370551967459378662586974208"),BigInteger.Parse("34182189187166852111368841966125056"),BigInteger.Parse("8505622499821102144576131684114829934592"),BigInteger.Parse("2116471057875484488839167999221661362284396544") };
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
public class A013863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013863Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013863.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013863.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013863Inst Instance=new A013863Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013862
{
public static readonly BigInteger[] Value={ 12L,2985984L,743008370688L,184884258895036416L,BigInteger.Parse("46005119909369701466112"),BigInteger.Parse("11447545997288281555215581184"),BigInteger.Parse("2848515765597237675947403497177088"),BigInteger.Parse("708801874985091845381344307009569161216"),BigInteger.Parse("176372588156290374069930666601805113523699712") };
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
public class A013862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013862Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013862.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013862.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013862Inst Instance=new A013862Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013861
{
public static readonly BigInteger[] Value={ 14641L,2357947691L,379749833583241L,BigInteger.Parse("61159090448414546291"),BigInteger.Parse("9849732675807611094711841"),BigInteger.Parse("1586309297171491574414436704891"),BigInteger.Parse("255476698618765889551019445759400441"),BigInteger.Parse("41144777789250865278081232758997200423491") };
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
public class A013861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013861Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013861.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013861.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013861Inst Instance=new A013861Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013860
{
public static readonly BigInteger[] Value={ 1331L,214358881L,34522712143931L,5559917313492231481L,BigInteger.Parse("895430243255237372246531"),BigInteger.Parse("144209936106499234037676064081"),BigInteger.Parse("23225154419887808141001767796309131"),BigInteger.Parse("3740434344477351388916475705363381856681"),BigInteger.Parse("602400691612421918536387328824478011400331731") };
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
public class A013860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013860Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013860.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013860.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013860Inst Instance=new A013860Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013859
{
public static readonly BigInteger[] Value={ 121L,19487171L,3138428376721L,505447028499293771L,BigInteger.Parse("81402749386839761113321"),BigInteger.Parse("13109994191499930367061460371"),BigInteger.Parse("2111377674535255285545615254209921"),BigInteger.Parse("340039485861577398992406882305761986971"),BigInteger.Parse("54763699237492901685126120802225273763666521") };
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
public class A013859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013859Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013859.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013859.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013859Inst Instance=new A013859Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013858
{
public static readonly BigInteger[] Value={ 11L,1771561L,285311670611L,45949729863572161L,BigInteger.Parse("7400249944258160101211"),BigInteger.Parse("1191817653772720942460132761"),BigInteger.Parse("191943424957750480504146841291811"),BigInteger.Parse("30912680532870672635673352936887453361"),BigInteger.Parse("4978518112499354698647829163838661251242411") };
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
public class A013858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013858Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013858.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013858.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013858Inst Instance=new A013858Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013857
{
public static readonly BigInteger[] Value={ 10000L,1000000000L,100000000000000L,10000000000000000000UL,BigInteger.Parse("1000000000000000000000000"),BigInteger.Parse("100000000000000000000000000000"),BigInteger.Parse("10000000000000000000000000000000000"),BigInteger.Parse("1000000000000000000000000000000000000000") };
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
public class A013857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013857Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013857.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013857.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013857Inst Instance=new A013857Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013856
{
public static readonly BigInteger[] Value={ 1000L,100000000L,10000000000000L,1000000000000000000L,BigInteger.Parse("100000000000000000000000"),BigInteger.Parse("10000000000000000000000000000"),BigInteger.Parse("1000000000000000000000000000000000"),BigInteger.Parse("100000000000000000000000000000000000000"),BigInteger.Parse("10000000000000000000000000000000000000000000") };
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
public class A013856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013856Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013856.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013856.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013856Inst Instance=new A013856Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013855
{
public static readonly BigInteger[] Value={ 100L,10000000L,1000000000000L,100000000000000000L,BigInteger.Parse("10000000000000000000000"),BigInteger.Parse("1000000000000000000000000000"),BigInteger.Parse("100000000000000000000000000000000"),BigInteger.Parse("10000000000000000000000000000000000000"),BigInteger.Parse("1000000000000000000000000000000000000000000") };
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
public class A013855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013855Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013855.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013855.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013855Inst Instance=new A013855Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013854
{
public static readonly BigInteger[] Value={ 10L,1000000L,100000000000L,10000000000000000L,BigInteger.Parse("1000000000000000000000"),BigInteger.Parse("100000000000000000000000000"),BigInteger.Parse("10000000000000000000000000000000"),BigInteger.Parse("1000000000000000000000000000000000000"),BigInteger.Parse("100000000000000000000000000000000000000000") };
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
public class A013854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013854Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013854.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013854.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013854Inst Instance=new A013854Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013837
{
public static readonly BigInteger[] Value={ 625L,1953125L,6103515625L,19073486328125L,59604644775390625L,BigInteger.Parse("186264514923095703125"),BigInteger.Parse("582076609134674072265625"),BigInteger.Parse("1818989403545856475830078125"),BigInteger.Parse("5684341886080801486968994140625"),BigInteger.Parse("17763568394002504646778106689453125") };
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
public class A013837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013837Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013837.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013837.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013837Inst Instance=new A013837Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013836
{
public static readonly BigInteger[] Value={ 125L,390625L,1220703125L,3814697265625L,11920928955078125L,BigInteger.Parse("37252902984619140625"),BigInteger.Parse("116415321826934814453125"),BigInteger.Parse("363797880709171295166015625"),BigInteger.Parse("1136868377216160297393798828125"),BigInteger.Parse("3552713678800500929355621337890625") };
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
public class A013836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013836Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013836.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013836.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013836Inst Instance=new A013836Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013835
{
public static readonly BigInteger[] Value={ 25L,78125L,244140625L,762939453125L,2384185791015625L,7450580596923828125L,BigInteger.Parse("23283064365386962890625"),BigInteger.Parse("72759576141834259033203125"),BigInteger.Parse("227373675443232059478759765625"),BigInteger.Parse("710542735760100185871124267578125"),BigInteger.Parse("2220446049250313080847263336181640625") };
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
public class A013835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013835Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013835.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013835.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013835Inst Instance=new A013835Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013834
{
public static readonly BigInteger[] Value={ 5L,15625L,48828125L,152587890625L,476837158203125L,1490116119384765625L,BigInteger.Parse("4656612873077392578125"),BigInteger.Parse("14551915228366851806640625"),BigInteger.Parse("45474735088646411895751953125"),BigInteger.Parse("142108547152020037174224853515625"),BigInteger.Parse("444089209850062616169452667236328125") };
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
public class A013834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013834Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013834.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013834.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013834Inst Instance=new A013834Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013833
{
public static readonly BigInteger[] Value={ 256L,262144L,268435456L,274877906944L,281474976710656L,288230376151711744L,BigInteger.Parse("295147905179352825856"),BigInteger.Parse("302231454903657293676544"),BigInteger.Parse("309485009821345068724781056"),BigInteger.Parse("316912650057057350374175801344"),BigInteger.Parse("324518553658426726783156020576256") };
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
public class A013833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013833Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013833.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013833.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013833Inst Instance=new A013833Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013832
{
public static readonly BigInteger[] Value={ 64L,65536L,67108864L,68719476736L,70368744177664L,72057594037927936L,BigInteger.Parse("73786976294838206464"),BigInteger.Parse("75557863725914323419136"),BigInteger.Parse("77371252455336267181195264"),BigInteger.Parse("79228162514264337593543950336"),BigInteger.Parse("81129638414606681695789005144064") };
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
public class A013832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013832Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013832.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013832.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013832Inst Instance=new A013832Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013831
{
public static readonly BigInteger[] Value={ 16L,16384L,16777216L,17179869184L,17592186044416L,18014398509481984L,BigInteger.Parse("18446744073709551616"),BigInteger.Parse("18889465931478580854784"),BigInteger.Parse("19342813113834066795298816"),BigInteger.Parse("19807040628566084398385987584"),BigInteger.Parse("20282409603651670423947251286016") };
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
public class A013831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013831Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013831.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013831.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013831Inst Instance=new A013831Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013830
{
public static readonly BigInteger[] Value={ 4L,4096L,4194304L,4294967296L,4398046511104L,4503599627370496L,4611686018427387904L,BigInteger.Parse("4722366482869645213696"),BigInteger.Parse("4835703278458516698824704"),BigInteger.Parse("4951760157141521099596496896"),BigInteger.Parse("5070602400912917605986812821504") };
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
public class A013830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013830Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013830.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013830.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013830Inst Instance=new A013830Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013829
{
public static readonly BigInteger[] Value={ 81L,19683L,4782969L,1162261467L,282429536481L,68630377364883L,16677181699666569L,4052555153018976267L,BigInteger.Parse("984770902183611232881"),BigInteger.Parse("239299329230617529590083"),BigInteger.Parse("58149737003040059690390169"),BigInteger.Parse("14130386091738734504764811067") };
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
public class A013829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013829Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013829.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013829.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013829Inst Instance=new A013829Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013828
{
public static readonly BigInteger[] Value={ 27L,6561L,1594323L,387420489L,94143178827L,22876792454961L,5559060566555523L,1350851717672992089L,BigInteger.Parse("328256967394537077627"),BigInteger.Parse("79766443076872509863361"),BigInteger.Parse("19383245667680019896796723"),BigInteger.Parse("4710128697246244834921603689") };
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
public class A013828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013828Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013828.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013828.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013828Inst Instance=new A013828Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013827
{
public static readonly BigInteger[] Value={ 9L,2187L,531441L,129140163L,31381059609L,7625597484987L,1853020188851841L,450283905890997363L,BigInteger.Parse("109418989131512359209"),BigInteger.Parse("26588814358957503287787"),BigInteger.Parse("6461081889226673298932241"),BigInteger.Parse("1570042899082081611640534563") };
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
public class A013827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013827Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013827.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013827.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013827Inst Instance=new A013827Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013826
{
public static readonly BigInteger[] Value={ 3L,729L,177147L,43046721L,10460353203L,2541865828329L,617673396283947L,150094635296999121L,BigInteger.Parse("36472996377170786403"),BigInteger.Parse("8862938119652501095929"),BigInteger.Parse("2153693963075557766310747"),BigInteger.Parse("523347633027360537213511521") };
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
public class A013826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013826Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013826.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013826.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013826Inst Instance=new A013826Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013825
{
public static readonly BigInteger[] Value={ 16L,512L,16384L,524288L,16777216L,536870912L,17179869184L,549755813888L,17592186044416L,562949953421312L,18014398509481984L,576460752303423488L,BigInteger.Parse("18446744073709551616"),BigInteger.Parse("590295810358705651712"),BigInteger.Parse("18889465931478580854784") };
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
public class A013825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013825Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013825.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013825.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013825Inst Instance=new A013825Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013824
{
public static readonly BigInteger[] Value={ 8L,256L,8192L,262144L,8388608L,268435456L,8589934592L,274877906944L,8796093022208L,281474976710656L,9007199254740992L,288230376151711744L,9223372036854775808UL,BigInteger.Parse("295147905179352825856"),BigInteger.Parse("9444732965739290427392") };
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
public class A013824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013824Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013824.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013824.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013824Inst Instance=new A013824Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013823
{
public static readonly BigInteger[] Value={ 4L,128L,4096L,131072L,4194304L,134217728L,4294967296L,137438953472L,4398046511104L,140737488355328L,4503599627370496L,144115188075855872L,4611686018427387904L,BigInteger.Parse("147573952589676412928"),BigInteger.Parse("4722366482869645213696") };
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
public class A013823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013823Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013823.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013823.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013823Inst Instance=new A013823Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013822
{
public static readonly BigInteger[] Value={ 2L,64L,2048L,65536L,2097152L,67108864L,2147483648L,68719476736L,2199023255552L,70368744177664L,2251799813685248L,72057594037927936L,2305843009213693952L,BigInteger.Parse("73786976294838206464"),BigInteger.Parse("2361183241434822606848") };
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
public class A013822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013822Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013822.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013822.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013822Inst Instance=new A013822Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013805
{
public static readonly BigInteger[] Value={ 4096L,268435456L,17592186044416L,1152921504606846976L,BigInteger.Parse("75557863725914323419136"),BigInteger.Parse("4951760157141521099596496896"),BigInteger.Parse("324518553658426726783156020576256"),BigInteger.Parse("21267647932558653966460912964485513216"),BigInteger.Parse("1393796574908163946345982392040522594123776") };
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
public class A013805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013805Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013805.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013805.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013805Inst Instance=new A013805Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013804
{
public static readonly BigInteger[] Value={ 16L,1048576L,68719476736L,4503599627370496L,BigInteger.Parse("295147905179352825856"),BigInteger.Parse("19342813113834066795298816"),BigInteger.Parse("1267650600228229401496703205376"),BigInteger.Parse("83076749736557242056487941267521536"),BigInteger.Parse("5444517870735015415413993718908291383296") };
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
public class A013804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013804Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013804.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013804.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013804Inst Instance=new A013804Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013803
{
public static readonly BigInteger[] Value={ 3375L,170859375L,8649755859375L,437893890380859375L,BigInteger.Parse("22168378200531005859375"),BigInteger.Parse("1122274146401882171630859375"),BigInteger.Parse("56815128661595284938812255859375"),BigInteger.Parse("2876265888493261300027370452880859375"),BigInteger.Parse("145610960604971353313885629177093505859375") };
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
public class A013803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013803Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013803.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013803.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013803Inst Instance=new A013803Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013802
{
public static readonly BigInteger[] Value={ 15L,759375L,38443359375L,1946195068359375L,BigInteger.Parse("98526125335693359375"),BigInteger.Parse("4987885095119476318359375"),BigInteger.Parse("252511682940423488616943359375"),BigInteger.Parse("12783403948858939111232757568359375"),BigInteger.Parse("647159824910983792506158351898193359375") };
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
public class A013802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013802Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013802.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013802.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013802Inst Instance=new A013802Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013801
{
public static readonly BigInteger[] Value={ 2744L,105413504L,4049565169664L,155568095557812224L,BigInteger.Parse("5976303958948914397184"),BigInteger.Parse("229585692886981495482220544"),BigInteger.Parse("8819763977946281130444984418304"),BigInteger.Parse("338820052976784335907174521413566464"),BigInteger.Parse("13016111155156147048210016414623569281024") };
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
public class A013801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013801Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013801.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013801.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013801Inst Instance=new A013801Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013800
{
public static readonly BigInteger[] Value={ 14L,537824L,20661046784L,793714773254144L,BigInteger.Parse("30491346729331195904"),BigInteger.Parse("1171355575953987221848064"),BigInteger.Parse("44998795805848373114515226624"),BigInteger.Parse("1728673739677471101567216945987584"),BigInteger.Parse("66408730383449729837806206197059026944") };
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
public class A013800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013800Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013800.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013800.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013800Inst Instance=new A013800Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013799
{
public static readonly BigInteger[] Value={ 2197L,62748517L,1792160394037L,51185893014090757L,BigInteger.Parse("1461920290375446110677"),BigInteger.Parse("41753905413413116367045797"),BigInteger.Parse("1192533292512492016559195008117"),BigInteger.Parse("34059943367449284484947168626829637"),BigInteger.Parse("972786042517719014174576083150881262357") };
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
public class A013799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013799Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013799.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013799.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013799Inst Instance=new A013799Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013798
{
public static readonly BigInteger[] Value={ 13L,371293L,10604499373L,302875106592253L,8650415919381337933L,BigInteger.Parse("247064529073450392704413"),BigInteger.Parse("7056410014866816666030739693"),BigInteger.Parse("201538126434611150798503956371773"),BigInteger.Parse("5756130429098929077956071497934208653") };
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
public class A013798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013798Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013798.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013798.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013798Inst Instance=new A013798Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013797
{
public static readonly BigInteger[] Value={ 1728L,35831808L,743008370688L,15407021574586368L,BigInteger.Parse("319479999370622926848"),BigInteger.Parse("6624737266949237011120128"),BigInteger.Parse("137370551967459378662586974208"),BigInteger.Parse("2848515765597237675947403497177088"),BigInteger.Parse("59066822915424320448445358917464096768") };
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
public class A013797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013797Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013797.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013797.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013797Inst Instance=new A013797Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013796
{
public static readonly BigInteger[] Value={ 12L,248832L,5159780352L,106993205379072L,2218611106740436992L,BigInteger.Parse("46005119909369701466112"),BigInteger.Parse("953962166440690129601298432"),BigInteger.Parse("19781359483314150527412524285952"),BigInteger.Parse("410186270246002225336426103593500672"),BigInteger.Parse("8505622499821102144576131684114829934592") };
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
public class A013796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013796Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013796.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013796.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013796Inst Instance=new A013796Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013795
{
public static readonly BigInteger[] Value={ 1331L,19487171L,285311670611L,4177248169415651L,BigInteger.Parse("61159090448414546291"),BigInteger.Parse("895430243255237372246531"),BigInteger.Parse("13109994191499930367061460371"),BigInteger.Parse("191943424957750480504146841291811"),BigInteger.Parse("2810243684806424785061213903353404851") };
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
public class A013795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013795Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013795.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013795.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013795Inst Instance=new A013795Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013794
{
public static readonly BigInteger[] Value={ 11L,161051L,2357947691L,34522712143931L,505447028499293771L,BigInteger.Parse("7400249944258160101211"),BigInteger.Parse("108347059433883722041830251"),BigInteger.Parse("1586309297171491574414436704891"),BigInteger.Parse("23225154419887808141001767796309131"),BigInteger.Parse("340039485861577398992406882305761986971") };
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
public class A013794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013794Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013794.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013794.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013794Inst Instance=new A013794Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013793
{
public static readonly BigInteger[] Value={ 1000L,10000000L,100000000000L,1000000000000000L,10000000000000000000UL,BigInteger.Parse("100000000000000000000000"),BigInteger.Parse("1000000000000000000000000000"),BigInteger.Parse("10000000000000000000000000000000"),BigInteger.Parse("100000000000000000000000000000000000") };
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
public class A013793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013793Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013793.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013793.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013793Inst Instance=new A013793Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013792
{
public static readonly BigInteger[] Value={ 10L,100000L,1000000000L,10000000000000L,100000000000000000L,BigInteger.Parse("1000000000000000000000"),BigInteger.Parse("10000000000000000000000000"),BigInteger.Parse("100000000000000000000000000000"),BigInteger.Parse("1000000000000000000000000000000000"),BigInteger.Parse("10000000000000000000000000000000000000") };
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
public class A013792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013792Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013792.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013792.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013792Inst Instance=new A013792Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013791
{
public static readonly BigInteger[] Value={ 729L,4782969L,31381059609L,205891132094649L,1350851717672992089L,BigInteger.Parse("8862938119652501095929"),BigInteger.Parse("58149737003040059690390169"),BigInteger.Parse("381520424476945831628649898809"),BigInteger.Parse("2503155504993241601315571986085849"),BigInteger.Parse("16423203268260658146231467800709255289") };
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
public class A013791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013791Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013791.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013791.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013791Inst Instance=new A013791Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013790
{
public static readonly BigInteger[] Value={ 9L,59049L,387420489L,2541865828329L,16677181699666569L,BigInteger.Parse("109418989131512359209"),BigInteger.Parse("717897987691852588770249"),BigInteger.Parse("4710128697246244834921603689"),BigInteger.Parse("30903154382632612361920641803529"),BigInteger.Parse("202755595904452569706561330872953769") };
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
public class A013790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013790Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013790.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013790.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013790Inst Instance=new A013790Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013789
{
public static readonly BigInteger[] Value={ 512L,2097152L,8589934592L,35184372088832L,144115188075855872L,BigInteger.Parse("590295810358705651712"),BigInteger.Parse("2417851639229258349412352"),BigInteger.Parse("9903520314283042199192993792"),BigInteger.Parse("40564819207303340847894502572032"),BigInteger.Parse("166153499473114484112975882535043072") };
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
public class A013789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013789Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013789.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013789.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013789Inst Instance=new A013789Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013788
{
public static readonly BigInteger[] Value={ 8L,32768L,134217728L,549755813888L,2251799813685248L,9223372036854775808UL,BigInteger.Parse("37778931862957161709568"),BigInteger.Parse("154742504910672534362390528"),BigInteger.Parse("633825300114114700748351602688"),BigInteger.Parse("2596148429267413814265248164610048"),BigInteger.Parse("10633823966279326983230456482242756608") };
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
public class A013788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013788Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013788.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013788.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013788Inst Instance=new A013788Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013787
{
public static readonly BigInteger[] Value={ 343L,823543L,1977326743L,4747561509943L,11398895185373143L,BigInteger.Parse("27368747340080916343"),BigInteger.Parse("65712362363534280139543"),BigInteger.Parse("157775382034845806615042743"),BigInteger.Parse("378818692265664781682717625943"),BigInteger.Parse("909543680129861140820205019889143"),BigInteger.Parse("2183814375991796599109312252753832343") };
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
public class A013787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013787Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013787.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013787.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013787Inst Instance=new A013787Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013786
{
public static readonly BigInteger[] Value={ 7L,16807L,40353607L,96889010407L,232630513987207L,558545864083284007L,BigInteger.Parse("1341068619663964900807"),BigInteger.Parse("3219905755813179726837607"),BigInteger.Parse("7730993719707444524137094407"),BigInteger.Parse("18562115921017574302453163671207"),BigInteger.Parse("44567640326363195900190045974568007") };
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
public class A013786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013786Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013786.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013786.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013786Inst Instance=new A013786Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013785
{
public static readonly BigInteger[] Value={ 216L,279936L,362797056L,470184984576L,609359740010496L,789730223053602816L,BigInteger.Parse("1023490369077469249536"),BigInteger.Parse("1326443518324400147398656"),BigInteger.Parse("1719070799748422591028658176"),BigInteger.Parse("2227915756473955677973140996096"),BigInteger.Parse("2887378820390246558653190730940416") };
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
public class A013785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013785Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013785.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013785.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013785Inst Instance=new A013785Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013784
{
public static readonly BigInteger[] Value={ 6L,7776L,10077696L,13060694016L,16926659444736L,21936950640377856L,BigInteger.Parse("28430288029929701376"),BigInteger.Parse("36845653286788892983296"),BigInteger.Parse("47751966659678405306351616"),BigInteger.Parse("61886548790943213277031694336"),BigInteger.Parse("80204967233062404407033075859456") };
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
public class A013784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013784Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013784.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013784.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013784Inst Instance=new A013784Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013783
{
public static readonly BigInteger[] Value={ 125L,78125L,48828125L,30517578125L,19073486328125L,11920928955078125L,7450580596923828125L,BigInteger.Parse("4656612873077392578125"),BigInteger.Parse("2910383045673370361328125"),BigInteger.Parse("1818989403545856475830078125"),BigInteger.Parse("1136868377216160297393798828125") };
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
public class A013783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013783Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013783.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013783.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013783Inst Instance=new A013783Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013782
{
public static readonly BigInteger[] Value={ 5L,3125L,1953125L,1220703125L,762939453125L,476837158203125L,298023223876953125L,BigInteger.Parse("186264514923095703125"),BigInteger.Parse("116415321826934814453125"),BigInteger.Parse("72759576141834259033203125"),BigInteger.Parse("45474735088646411895751953125") };
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
public class A013782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013782Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013782.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013782.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013782Inst Instance=new A013782Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013781
{
public static readonly BigInteger[] Value={ 64L,16384L,4194304L,1073741824L,274877906944L,70368744177664L,18014398509481984L,4611686018427387904L,BigInteger.Parse("1180591620717411303424"),BigInteger.Parse("302231454903657293676544"),BigInteger.Parse("77371252455336267181195264"),BigInteger.Parse("19807040628566084398385987584") };
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
public class A013781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013781Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013781.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013781.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013781Inst Instance=new A013781Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013780
{
public static readonly BigInteger[] Value={ 4L,1024L,262144L,67108864L,17179869184L,4398046511104L,1125899906842624L,288230376151711744L,BigInteger.Parse("73786976294838206464"),BigInteger.Parse("18889465931478580854784"),BigInteger.Parse("4835703278458516698824704"),BigInteger.Parse("1237940039285380274899124224") };
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
public class A013780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013780Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013780.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013780.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013780Inst Instance=new A013780Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013779
{
public static readonly BigInteger[] Value={ 27L,2187L,177147L,14348907L,1162261467L,94143178827L,7625597484987L,617673396283947L,50031545098999707L,4052555153018976267L,BigInteger.Parse("328256967394537077627"),BigInteger.Parse("26588814358957503287787"),BigInteger.Parse("2153693963075557766310747") };
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
public class A013779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013779Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013779.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013779.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013779Inst Instance=new A013779Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013778
{
public static readonly BigInteger[] Value={ 3L,243L,19683L,1594323L,129140163L,10460353203L,847288609443L,68630377364883L,5559060566555523L,450283905890997363L,BigInteger.Parse("36472996377170786403"),BigInteger.Parse("2954312706550833698643"),BigInteger.Parse("239299329230617529590083"),BigInteger.Parse("19383245667680019896796723") };
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
public class A013778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013778Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013778.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013778.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013778Inst Instance=new A013778Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013777
{
public static readonly ulong[] Value={ 8L,128L,2048L,32768L,524288L,8388608L,134217728L,2147483648L,34359738368L,549755813888L,8796093022208L,140737488355328L,2251799813685248L,36028797018963968L,576460752303423488L,9223372036854775808UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013777Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A013777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013777.Bytes);
public ulong this[int i]=>Value[i];

public static A013777Inst Instance=new A013777Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013776
{
public static readonly long[] Value={ 2L,32L,512L,8192L,131072L,2097152L,33554432L,536870912L,8589934592L,137438953472L,2199023255552L,35184372088832L,562949953421312L,9007199254740992L,144115188075855872L,2305843009213693952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013776Inst : IEnumerable<long>
{
public static readonly long[] Value=A013776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013776.Bytes);
public long this[int i]=>Value[i];

public static A013776Inst Instance=new A013776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013775
{
public static readonly BigInteger[] Value={ 576L,7962624L,110075314176L,1521681143169024L,BigInteger.Parse("21035720123168587776"),BigInteger.Parse("290797794982682557415424"),BigInteger.Parse("4019988717840603673710821376"),BigInteger.Parse("55572324035428505185378394701824") };
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
public class A013775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013775Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013775.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013775.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013775Inst Instance=new A013775Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013774
{
public static readonly BigInteger[] Value={ 24L,331776L,4586471424L,63403380965376L,876488338465357824L,BigInteger.Parse("12116574790945106558976"),BigInteger.Parse("167499529910025153071284224"),BigInteger.Parse("2315513501476187716057433112576"),BigInteger.Parse("32009658644406818986777955348250624") };
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
public class A013774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013774Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013774.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013774.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013774Inst Instance=new A013774Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013773
{
public static readonly BigInteger[] Value={ 529L,6436343L,78310985281L,952809757913927L,11592836324538749809UL,BigInteger.Parse("141050039560662968926103"),BigInteger.Parse("1716155831334586342923895201"),BigInteger.Parse("20880467999847912034355032910567"),BigInteger.Parse("254052654154149545721997685422868689") };
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
public class A013773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013773Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013773.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013773.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013773Inst Instance=new A013773Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013772
{
public static readonly BigInteger[] Value={ 23L,279841L,3404825447L,41426511213649L,504036361936467383L,BigInteger.Parse("6132610415680998648961"),BigInteger.Parse("74615470927590710561908487"),BigInteger.Parse("907846434775996175406740561329"),BigInteger.Parse("11045767571919545466173812409689943"),BigInteger.Parse("134393854047545109686936775588697536481") };
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
public class A013772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013772Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013772.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013772.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013772Inst Instance=new A013772Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013771
{
public static readonly BigInteger[] Value={ 484L,5153632L,54875873536L,584318301411328L,6221821273427820544L,BigInteger.Parse("66249952919459433152512"),BigInteger.Parse("705429498686404044207947776"),BigInteger.Parse("7511413302012830262726227918848"),BigInteger.Parse("79981528839832616637508874879893504"),BigInteger.Parse("851643319086537701956194499721106030592") };
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
public class A013771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013771Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013771.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013771.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013771Inst Instance=new A013771Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013770
{
public static readonly BigInteger[] Value={ 22L,234256L,2494357888L,26559922791424L,282810057883082752L,BigInteger.Parse("3011361496339065143296"),BigInteger.Parse("32064977213018365645815808"),BigInteger.Parse("341427877364219557396646723584"),BigInteger.Parse("3635524038174209847159494312722432"),BigInteger.Parse("38711059958478986452554295441868455936") };
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
public class A013770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013770Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013770.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013770.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013770Inst Instance=new A013770Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013769
{
public static readonly BigInteger[] Value={ 441L,4084101L,37822859361L,350277500542221L,3243919932521508681L,BigInteger.Parse("30041942495081691894741"),BigInteger.Parse("278218429446951548637196401"),BigInteger.Parse("2576580875108218291929075869661"),BigInteger.Parse("23861715484377209601555171628930521"),BigInteger.Parse("220983347100817338120002444455525554981") };
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
public class A013769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013769Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013769.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013769.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013769Inst Instance=new A013769Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013768
{
public static readonly BigInteger[] Value={ 21L,194481L,1801088541L,16679880978201L,154472377739119461L,BigInteger.Parse("1430568690241985328321"),BigInteger.Parse("13248496640331026125580781"),BigInteger.Parse("122694327386105632949003612841"),BigInteger.Parse("1136272165922724266740722458520501"),BigInteger.Parse("10523016528610349434285830688358359761") };
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
public class A013768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013768Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013768.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013768.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013768Inst Instance=new A013768Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013767
{
public static readonly BigInteger[] Value={ 400L,3200000L,25600000000L,204800000000000L,1638400000000000000L,BigInteger.Parse("13107200000000000000000"),BigInteger.Parse("104857600000000000000000000"),BigInteger.Parse("838860800000000000000000000000"),BigInteger.Parse("6710886400000000000000000000000000"),BigInteger.Parse("53687091200000000000000000000000000000") };
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
public class A013767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013767Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013767.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013767.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013767Inst Instance=new A013767Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013766
{
public static readonly BigInteger[] Value={ 20L,160000L,1280000000L,10240000000000L,81920000000000000L,BigInteger.Parse("655360000000000000000"),BigInteger.Parse("5242880000000000000000000"),BigInteger.Parse("41943040000000000000000000000"),BigInteger.Parse("335544320000000000000000000000000"),BigInteger.Parse("2684354560000000000000000000000000000") };
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
public class A013766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013766Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013766.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013766.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013766Inst Instance=new A013766Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013765
{
public static readonly BigInteger[] Value={ 361L,2476099L,16983563041L,116490258898219L,799006685782884121L,BigInteger.Parse("5480386857784802185939"),BigInteger.Parse("37589973457545958193355601"),BigInteger.Parse("257829627945307727248226067259"),BigInteger.Parse("1768453418076865701195582595329481") };
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
public class A013765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013765Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013765.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013765.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013765Inst Instance=new A013765Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013764
{
public static readonly BigInteger[] Value={ 19L,130321L,893871739L,6131066257801L,42052983462257059L,BigInteger.Parse("288441413567621167681"),BigInteger.Parse("1978419655660313589123979"),BigInteger.Parse("13569980418174090907801371961"),BigInteger.Parse("93076495688256089536609610280499") };
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
public class A013764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013764Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013764.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013764.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013764Inst Instance=new A013764Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013763
{
public static readonly BigInteger[] Value={ 324L,1889568L,11019960576L,64268410079232L,374813367582081024L,BigInteger.Parse("2185911559738696531968"),BigInteger.Parse("12748236216396078174437376"),BigInteger.Parse("74347713614021927913318776832"),BigInteger.Parse("433595865796975883590475106484224") };
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
public class A013763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013763Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013763.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013763.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013763Inst Instance=new A013763Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013762
{
public static readonly BigInteger[] Value={ 18L,104976L,612220032L,3570467226624L,20822964865671168L,BigInteger.Parse("121439531096594251776"),BigInteger.Parse("708235345355337676357632"),BigInteger.Parse("4130428534112329328517709824"),BigInteger.Parse("24088659210943104643915283693568") };
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
public class A013762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013762Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013762.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013762.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013762Inst Instance=new A013762Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013761
{
public static readonly BigInteger[] Value={ 289L,1419857L,6975757441L,34271896307633L,168377826559400929L,BigInteger.Parse("827240261886336764177"),BigInteger.Parse("4064231406647572522401601"),BigInteger.Parse("19967568900859523802559065713"),BigInteger.Parse("98100666009922840441972689847969"),BigInteger.Parse("481968572106750915091411825223071697") };
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
public class A013761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013761Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013761.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013761.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013761Inst Instance=new A013761Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013760
{
public static readonly BigInteger[] Value={ 17L,83521L,410338673L,2015993900449L,9904578032905937L,BigInteger.Parse("48661191875666868481"),BigInteger.Parse("239072435685151324847153"),BigInteger.Parse("1174562876521148458974062689") };
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
public class A013760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013760Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013760.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013760.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013760Inst Instance=new A013760Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013759
{
public static readonly BigInteger[] Value={ 256L,1048576L,4294967296L,17592186044416L,72057594037927936L,BigInteger.Parse("295147905179352825856"),BigInteger.Parse("1208925819614629174706176"),BigInteger.Parse("4951760157141521099596496896") };
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
public class A013759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013759Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013759.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013759.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013759Inst Instance=new A013759Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013758
{
public static readonly BigInteger[] Value={ 16L,65536L,268435456L,1099511627776L,4503599627370496L,BigInteger.Parse("18446744073709551616"),BigInteger.Parse("75557863725914323419136"),BigInteger.Parse("309485009821345068724781056"),BigInteger.Parse("1267650600228229401496703205376"),BigInteger.Parse("5192296858534827628530496329220096") };
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
public class A013758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013758Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013758.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013758.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013758Inst Instance=new A013758Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013677
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,9L,0L,8L,2L,1L,2L,7L,1L,6L,5L,5L,3L,9L,3L,8L,9L,2L,5L,6L,5L,6L,9L,5L,7L,7L,9L,5L,1L,0L,1L,3L,5L,3L,2L,5L,8L,5L,7L,1L,1L,4L,4L,8L,3L,8L,6L,3L,0L,2L,3L,5L,9L,3L,3L,0L,4L,6L,7L,6L,1L,8L,2L,3L,9L,4L,9L,7L,0L,5L,3L,4L,1L,3L,0L,9L,3L,1L,2L,6L,6L,4L,2L,2L,7L,1L,1L,8L,0L,7L,6L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013677Inst : IEnumerable<long>
{
public static readonly long[] Value=A013677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013677.Bytes);
public long this[int i]=>Value[i];

public static A013677Inst Instance=new A013677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013676
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,3L,8L,1L,7L,2L,9L,3L,2L,6L,4L,9L,9L,9L,8L,3L,9L,8L,5L,6L,4L,6L,1L,6L,4L,4L,6L,2L,1L,9L,3L,9L,7L,3L,0L,4L,5L,4L,6L,9L,7L,2L,1L,8L,9L,5L,3L,3L,3L,1L,1L,4L,3L,1L,7L,4L,4L,2L,9L,9L,8L,7L,6L,3L,0L,0L,3L,9L,5L,4L,2L,6L,5L,0L,0L,4L,5L,6L,3L,8L,0L,0L,1L,9L,6L,8L,6L,6L,8L,9L,8L,9L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013676Inst : IEnumerable<long>
{
public static readonly long[] Value=A013676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013676.Bytes);
public long this[int i]=>Value[i];

public static A013676Inst Instance=new A013676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013675
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,7L,6L,3L,7L,1L,9L,7L,6L,3L,7L,8L,9L,9L,7L,6L,2L,2L,7L,3L,6L,0L,0L,2L,9L,3L,5L,6L,3L,0L,2L,9L,2L,1L,3L,0L,8L,8L,2L,4L,9L,0L,9L,0L,2L,6L,2L,6L,7L,9L,0L,9L,5L,3L,7L,9L,8L,4L,3L,9L,7L,2L,9L,3L,5L,6L,4L,3L,2L,9L,0L,2L,8L,2L,4L,5L,9L,3L,4L,2L,0L,8L,1L,7L,3L,8L,6L,3L,6L,9L,1L,6L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013675Inst : IEnumerable<long>
{
public static readonly long[] Value=A013675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013675.Bytes);
public long this[int i]=>Value[i];

public static A013675Inst Instance=new A013675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013674
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,5L,2L,8L,2L,2L,5L,9L,4L,0L,8L,6L,5L,1L,8L,7L,1L,7L,3L,2L,5L,7L,1L,4L,8L,7L,6L,3L,6L,7L,2L,2L,0L,2L,3L,2L,3L,7L,3L,8L,8L,9L,9L,0L,4L,7L,1L,5L,3L,1L,1L,5L,3L,1L,0L,5L,2L,0L,3L,5L,8L,8L,7L,8L,7L,0L,8L,7L,0L,2L,7L,9L,5L,3L,1L,5L,1L,7L,8L,6L,2L,8L,5L,6L,0L,4L,8L,4L,6L,3L,2L,2L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013674Inst : IEnumerable<long>
{
public static readonly long[] Value=A013674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013674.Bytes);
public long this[int i]=>Value[i];

public static A013674Inst Instance=new A013674Inst();

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